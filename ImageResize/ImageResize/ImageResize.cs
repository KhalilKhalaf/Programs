using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace ImageResize
{
    public partial class ImageResize : Form
    {
        string mInputFolder = null;
        string mOutputFolder = null;
        string[] mAllInputFiles;
        Image<Bgr, Byte> mCurImage;
        string mCurImagePath;
        int mCurImageIndex = -1;
        string mTempDirectoryPath = string.Empty;

        const int cDesiredHeight = 1200;
        const int cDesiredWidth = 1800;
        const double cReductionScale = 0.9;

        DataTable mCommunicationTable;
        bool mAutoMode = false;

        public ImageResize()
        {
            InitializeComponent();
        }

        private void ImageResize_Load( object sender, EventArgs e )
        {
            BrowseInputBtn.Enabled = true;
            BrowseOutputBtn.Enabled = false;
            StartBtn.Enabled = false;
            IgnoreBtn.Enabled = false;
            SubmitBtn.Enabled = false;

            mCurImageIndex = 0;

            mCommunicationTable = new DataTable();
            mCommunicationTable.Columns.Add( "Desc", typeof( string ) );
            mCommunicationTable.Columns.Add( "Size", typeof( int ) );
            mCommunicationTable.Columns.Add( "Height", typeof( int ) );
            mCommunicationTable.Columns.Add( "Width", typeof( int ) );
            mCommunicationTable.Columns.Add( "Path", typeof( string ) );

            OldDataGridView.DataSource = mCommunicationTable;
            OldDataGridView.Columns[0].Width = 50;
            OldDataGridView.Columns[1].Width = 100;
            OldDataGridView.Columns[2].Width = 50;
            OldDataGridView.Columns[3].Width = 50;
            OldDataGridView.Columns[4].Width = 1000;
        }

        private void BrowseInputBtn_Click( object sender, EventArgs e )
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;

            if ( folderBrowserDialog1.ShowDialog() == DialogResult.OK )
            {
                mInputFolder = folderBrowserDialog1.SelectedPath;
                // Maybe check mInputFolder validity

                BrowseOutputBtn.Enabled = true;
                BrowseInputBtn.Enabled = false;
            }

        }

        private void BrowseOutputBtn_Click( object sender, EventArgs e )
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;

            if ( folderBrowserDialog1.ShowDialog() == DialogResult.OK )
            {
                mOutputFolder = folderBrowserDialog1.SelectedPath;

                // maybe validate mOutputFolder here

                if ( mInputFolder != null )
                {
                    mCurImageIndex = 0;
                    StartBtn.Enabled = true;
                    BrowseOutputBtn.Enabled = false;

                }
            }
        }

        private void StartBtn_Click( object sender, EventArgs e )
        {
            if( mCurImageIndex == -1 )
            {
                return;
            }

            mCurImageIndex = 0;
            BrowseInputBtn.Enabled = false;
            BrowseOutputBtn.Enabled = false;
            SubmitBtn.Enabled = true;
            IgnoreBtn.Enabled = true;
            StartBtn.Enabled = false;

            mAllInputFiles = Directory.GetFiles( mInputFolder );

            if(mAllInputFiles.Length == 0)
            {
                MessageBox.Show("No Files Found.");
                StartBtn.Enabled = true;
                mCurImageIndex = 0;
                return;
            }

            ProcessNextImage();
        }
        
        private void SetTemporaryDirectory()
        {
            if(mTempDirectoryPath == string.Empty)
            {
                // https://stackoverflow.com/questions/278439/creating-a-temporary-directory-in-windows
                var uniqueTempDir = Path.GetFullPath(Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString()));
                Directory.CreateDirectory(uniqueTempDir + "\\");
                mTempDirectoryPath = uniqueTempDir;

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = mTempDirectoryPath,
                    FileName = "explorer.exe"
                };

                Process.Start(startInfo);
            }

        }

        private void ProcessNextImage()
        {

            int lNewHeight, lNewWidth;

            if ( mCurImageIndex == mAllInputFiles.Length )
            {
                BrowseInputBtn.Enabled = true;
                BrowseOutputBtn.Enabled = false;
                StartBtn.Enabled = false;
                IgnoreBtn.Enabled = false;
                SubmitBtn.Enabled = false;
                return;
            }

            mCurImage = new Image<Bgr, byte>( mAllInputFiles[mCurImageIndex] );
            mCurImagePath = mAllInputFiles[mCurImageIndex];

            if ( mCurImage.Height > mCurImage.Width )
            {
                lNewHeight = ( int )( mCurImage.Height * cReductionScale );
                lNewWidth = ( int )( mCurImage.Width * cReductionScale );

                while ( lNewHeight > cDesiredHeight )
                {
                    lNewHeight = ( int )( lNewHeight * cReductionScale );
                    lNewWidth = ( int )( lNewWidth * cReductionScale );
                }
            }
            else
            {
                lNewHeight = ( int )( mCurImage.Height * cReductionScale );
                lNewWidth = ( int )( mCurImage.Width * cReductionScale );

                while ( lNewWidth > cDesiredWidth )
                {
                    lNewWidth = ( int )( lNewWidth * cReductionScale );
                    lNewHeight = ( int )( lNewHeight * cReductionScale );
                }
            }

            OldImageBox.Image = mCurImage;
            mCommunicationTable.Clear();

            FileInfo fi = new FileInfo( mCurImagePath );
            mCommunicationTable.Rows.Add( "Old:", fi.Length / 1024, mCurImage.Height, mCurImage.Width, mCurImagePath );

            mCurImage = mCurImage.Resize( lNewWidth, lNewHeight, Emgu.CV.CvEnum.Inter.Cubic );
            NewImageBox.Image = mCurImage;
            
            SetTemporaryDirectory();
            string lCurImageNewPath = mTempDirectoryPath + "\\" + Path.GetFileName( mCurImagePath );
            mCurImage.Save( lCurImageNewPath );
            
            fi = new FileInfo( lCurImageNewPath );
            mCommunicationTable.Rows.Add( "New:", fi.Length / 1024, mCurImage.Height, mCurImage.Width, lCurImageNewPath );
            mCommunicationTable.Rows.Add( "Num: ", mCurImageIndex + 1 / mAllInputFiles.Length);
            
            OldDataGridView.DataSource = mCommunicationTable;

            if(mAutoMode)
            {
                ProcessPhysicalFile();
                mCurImageIndex++;
                ProcessNextImage();
            }
        }

        private void ProcessPhysicalFile()
        {
            // move from temp directory to output
            string lCurImageNewPath = mOutputFolder + "\\" + Path.GetFileName( mCurImagePath );
            string mSourcePath = mTempDirectoryPath + "\\" + Path.GetFileName(mCurImagePath);
            string mDestinationPath = lCurImageNewPath;

            if ( File.Exists(mDestinationPath) )
            {
                File.Delete( mDestinationPath );
            }
            File.Move( mSourcePath, mDestinationPath );

            // move from input directory to sufolder "done"
            mSourcePath = mCurImagePath;
            mDestinationPath = mInputFolder + "\\Done\\";

            if ( Directory.Exists(mDestinationPath) )
            {
                if(File.Exists(mDestinationPath + "\\" + Path.GetFileName(mCurImagePath)))
                {
                    File.Delete(mDestinationPath + "\\" + Path.GetFileName(mCurImagePath));
                }
            }
            else
            {
                Directory.CreateDirectory(mDestinationPath);
            }
            

            File.Move(mSourcePath, mDestinationPath + "\\" + Path.GetFileName(mCurImagePath) );
        }

        private void SubmitBtn_Click( object sender, EventArgs e )
        {
            ProcessPhysicalFile();
            mCurImageIndex++;
            ProcessNextImage();
        }
        
        private void IgnoreBtn_Click( object sender, EventArgs e )
        {
            mCurImageIndex++;
            ProcessNextImage();
        }

        private void AutoModeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            mAutoMode = !mAutoMode;
        }
    }
}
