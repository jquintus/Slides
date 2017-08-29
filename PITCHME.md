#### Cake

![logo](img/cake-build-logo.png)


---

#### What is Cake?

**make for C#**

Like *make*, you can define the build processas a series of dependent tasks.  To run the Cake script, you specify which task to run and Cake will run it, ensuring any dependent tasks are run first.

Unlike make, the Cake script is written in C#.

--- 

#### Tasks

The main building block of Cake are tasks.  Below is a simple task named `Hello_World` that prints out a friendly message.

```csharp
Task("Hello_World")
    .Does(() =>
{
    Information("Hello World");
});
```

---

#### Task Dependencies

Running `Build` will  run both the `Clean` and `Restore`

```csharp
Task("Build")
    .IsDependentOn("Clean")
    .IsDependentOn("Restore")
    .Does(() =>
{
    DotNetCoreMSBuild(slnFile, buildSettings));
});
Task("Clean")
    .Does(() => {
    DotNetCoreClean(slnFile);
});
Task("Restore")
    .Does(() =>{
    DotNetCoreRestore(slnFile);
});
```
---

#### Arguments

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

#### Links

<br/>
<br/>

* [Official Site](http://cakebuild.net/)
* [Addins](https://cakebuild.net/addins/)
* [Cake on GitHub](https://github.com/cake-build/cake)