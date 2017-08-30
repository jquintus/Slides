#### Cake

![logo](img/cake-build-logo.png)


---

#### make for C&#35;

Like *make*, you can define the build processas a series of dependent tasks.  To run the Cake script, you specify which task to run and Cake will run it, ensuring any dependent tasks are run first.

Unlike make, the Cake script is written in C#.

--- 

#### What About The Build Server?

Cake scripts can be run locally and on the build server. This allows for:

* Consitency across local and server environments
* Easier testing of build scripts
* Easier creation of new scripts - it's just C#
* ...

---
#### What About The Build Server? (cont.)

* ...
* Simplified build server configuration (just run the cake script)
* Better history tracking since the script is checked in and managed by source control
* Testing of changes to the build in isolation on a branch

--- 

#### What Can You Do With It?

1. Clean the directory
1. Restore packages (NuGet/Npm/etc.)
1. Update the build number
1. Build a solution (or project)
1. Run unit tests
1. Sign the build
1. Package the build (Wix/NuGet/Npm/etc.)
1. Publish artifacts to the build server (or locally)
1. Publish NuGet packages 
1. Publish a website
1. Anything you can do in C#

--- 

#### Installing

1. Download the [cake bootstrapper](https://raw.githubusercontent.com/cake-build/resources/master/build.ps1) in the root folder of your project
2. Create a simple cake script and save it as `build.cake` in the same directory
3. Running the cake script the first time will automatically download any additional tools you'll need

---

#### Running 

Running your Cake script is as easy running the powershell bootstrapper

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

Hello world

```csharp
Task("Hello_World")
    .Does(() =>
{
    Information("Hello World");
});
```

---

#### Running The Entry Point Task

```csharp
var target = Argument("target", "Default");

//...

RunTarget(target);
```

---
#### Task Dependencies

Running `Build` will run both `Clean` and `Restore`

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
---

#### It's just C&#35;

You can call methods from your tasks

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

```
powershell ./build.ps1 -ScriptArgs '-config="Debug"'
```

```csharp
var config = Argument("config", "Release");
```

---

#### Links

* [Official Site](http://cakebuild.net/)
* [Addins](https://cakebuild.net/addins/)
* [Cake on GitHub](https://github.com/cake-build/cake)
