// *****************************************************************************
// Addins
// *****************************************************************************
#addin nuget:?package=Cake.Git
#load  nuget:?package=Cake.Recipes

// *****************************************************************************
// Configuration
// *****************************************************************************
// Arguments
var config = Argument("config", "Release");
var buildNumber = EnvironmentVariable("BUILD_NUMBER");
var versionSuffix = Argument<string>("versionSuffix", null);
var artifactsDir = @"./artifacts/";

// Helper Methods
string FindSolutionFile()
{
    var slnFiles = GetFiles("*.sln");
    var slnFile = slnFiles.First();
    Information("Building solution file {0}", slnFile);
    return slnFile.ToString();
}

// TASKS
Task("Hello_World")
    .WithCriteria(DateTime.UtcNow.DayOfWeek == DayOfWeek.Monday)
    .Does(() =>
{
    Information("Hello World");
});

Task("Restore-NuGet-Packages")
    .Does(() =>
{
    DotNetCoreRestore(slnFile);
});

Task("Clean")
    .IsDependentOn("Restore-NuGet-Packages")
    .Does(() => 
{
    DotNetCoreClean(slnFile);
});

Task("Build")
    .IsDependentOn("Clean")
    .Does(() =>
{
    DotNetCoreMSBuild(slnFile, buildSettings);
});

Task("Test")
    .IsDependentOn("Build")
    .WithCriteria(HasTestProjects)
    .Does(() =>
{
    var projectFiles = GetFiles("./Tests/**/*Tests.csproj");
    foreach(var testProject in projectFiles)
    {
        DotNetCoreTest(testProject.FullPath);
    }
});

Task("Pack")
    .IsDependentOn("Test")
    .Does(() =>
{
    DotNetCorePack(slnFile, packSettings);
});

Task("Publish")
    .IsDependentOn("Pack")
    .WithCriteria(BuildSystem.IsRunningOnTeamCity)
    .Does(() =>
{
    BuildSystem.TeamCity.PublishArtifacts(artifactsDir);
});

// *****************************************************************************
// Entry Point Tasks
// *****************************************************************************
Task("Default")
    .IsDependentOn("Information")
    .IsDependentOn("CoreNuPack")
    .IsDependentOn("Publish");