#### Cake

![logo](img/cake-build-logo.png)


---

#### make for C&#35;

<br/>

Like *make*, you can define the build processas a series of dependent tasks.  To run the Cake script, you specify which task to run and Cake will run it, ensuring any dependent tasks are run first.

<br/>

Unlike make, the Cake script is written in C#.

--- 

#### What About The Build Server?

Cake scripts can be run locally and on the build server. This allows for:

<br/>

* Consitency across local and server environments
* Easier testing of build scripts
* Easier creation of new scripts - it's just C#
* ...

---
#### What About The Build Server? (cont.)

<br/>

* ...
* Share scripts across projects
* Simplified build server configuration (just run the cake script)
* Better history tracking since the script is checked in and managed by source control
* Testing of changes to the build in isolation on a branch

--- 

#### What Can You Do With It?

<br/>

* Clean the directory
* Restore packages (NuGet/Npm/etc.)
* Update the build number
* Build a solution (or project)
* Run unit tests

--- 

#### What Can You Do With It? (cont.)

<br/>

* Sign the build
* Package the build (Wix/NuGet/Npm/etc.)
* Publish artifacts to the build server (or locally)
* Publish NuGet packages 
* Publish a website
* Anything you can do in C#

--- 

#### Installing

<br/>

1. Download the [cake bootstrapper](https://raw.githubusercontent.com/cake-build/resources/master/build.ps1) in the root folder of your project
2. Create a simple cake script and save it as `build.cake` in the same directory
3. Running the cake script the first time will automatically download any additional tools you'll need

---

#### Running 

Running your Cake script is as easy running the powershell bootstrapper

<br/>

```
> powershell ./cake.ps1
Preparing to run build script...
Running build script...
Analyzing build script...
Processing build script...
Installing addins...
Compiling build script...
...
```

---

#### Tasks

<br/>

```csharp
Task("Hello_World")
    .Does(() =>
{
    Information("Hello World");
});
```

---

#### Running The Entry Point Task

<br/>

```csharp
var target = Argument("target", "Default");

//...

RunTarget(target);
```

---
#### Task Dependencies

```csharp
Task("Build")
    .IsDependentOn("Clean")
    .IsDependentOn("Restore")
    .Does(() =>
{
    DotNetCoreMSBuild(slnFile, buildSettings));
});
Task("Clean").Does(() => {
    DotNetCoreClean(slnFile);
});
Task("Restore").Does(() =>{
    DotNetCoreRestore(slnFile);
});
```

Running `Build` will run both `Clean` and `Restore`

---

#### Conditional Tasks

<br/>

```csharp
Task("Publish")
    .WithCriteria(BuildSystem.IsRunningOnTeamCity)
    .Does(() =>
{
    BuildSystem.TeamCity.PublishArtifacts(artifactsDir);
});
```

---

#### It's just C&#35;

You can call methods from your tasks

<br/>

```csharp
Task("Build")
    .Does(() =>
{
    var slnFile = FindSlnFile();
    DotNetCoreMSBuild(slnFile));
});

string FindSolutionFile()
{
    var slnFile = GetFiles("*.sln").FirstOrDefault();
    return slnFile.ToString();
}
```

---

#### Arguments

You can pass in optional [arguments](https://cakebuild.net/docs/fundamentals/args-and-environment-vars) from the command line

<br/>

```
powershell ./build.ps1 -ScriptArgs '-config="Debug"'
```

```csharp
var config = Argument("config", "Release");
```

---

#### Addins

Addins allow you to leverage 3rd party libaries

<br/>

* Git
* KeePass
* Azure/AWS
* Entity Framework
* Semantic Versioning
* Docker
* Slack

---

#### Addins (cont.)

<br/>

```
#addin nuget:?package=Cake.Foo
#addin nuget:?package=Cake.Foo&version=1.2.3
#addin nuget:?package=Cake.Foo&prerelease
#addin nuget:https://myget.org/f/Cake/?package=Cake.Foo&prerelease
```

---

#### Scripts

You can reference external Cake scripts with `#load`

<br/>

```
#load "scripts/utilities.cake"
#load "local:?path=scripts/utilities.cake"
#load "nuget:?package=utilities.cake"
```

---

#### Debugging Cake

Debugging Cake is possible from within 

[Visual Studio Code](https://code.visualstudio.com/)

<br/>

* Breakpoints
* Variable inspection

---

#### Setting Up Debugging Cake

<br/>

* Download the [Cake extension for Visual Studio Code](https://marketplace.visualstudio.com/items?itemName=cake-build.cake-vscode)
* Follow the steps in the [set up blog](https://cakebuild.net/blog/2016/09/debug-cake-vscode) or [set up video](https://www.youtube.com/watch?time_continue=486&v=zzZuysl3xSg) 
* Press `<F5>`

---
#### Useful Links Links

<br/>

* [Official Cake Site](http://cakebuild.net/)
* [Cake Addins](https://cakebuild.net/addins/)
* [Cake on GitHub](https://github.com/cake-build/cake)
* [Visual Studio Code](https://code.visualstudio.com/)
* [Cake extension for Visual Studio Code](https://marketplace.visualstudio.com/items?itemName=cake-build.cake-vscode)
