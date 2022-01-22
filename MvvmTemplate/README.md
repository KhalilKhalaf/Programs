# MvvmTemplate
C# WPF MVVM Template

Just an empty MVVM project:

1.	New Project -> Visual C# -> WPF App (.Net FrameWork)
2.	Go To Nuget -> Browse Caliburn.Micro and install (v3.1.0)
3.	Delete MainWindow from Solution Explorer
4.	Remove “StartupUri=”MainWindow.xaml” from App.xaml (Caliburn will handle startups – not WPF)
5.	Add bootstrapper Resources under App.xaml and create its class (This will be the startup):

    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary>
                    <local:Bootstrapper x:Key="Bootstrapper"/>
                </ResourceDictionary>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>

6.	Add Folders Models, Views and ViewModel under Solution Explorer
7.	Add your ViewModel Class that you set as startup in OnStartup() in step 6
8.	Add a view (as a Window type) under Views folder
9.	Resolve errors by including all files in the bootstrapper startup class and build
See more here: https://www.youtube.com/watch?v=laPFq3Fhs8k

# To use this Template:
1. Download as .zip
2. Renaming Solution/Project locally to your desired project name
3. Create a new remote repository with your desired name
4. Do these in cmd:

echo "# NewNameHere" >> README.md

git init

git add README.md

git commit -m "first commit"

git remote add origin https://github.com/KhalilKhalaf/NewNameHere.git

git push -u origin master
