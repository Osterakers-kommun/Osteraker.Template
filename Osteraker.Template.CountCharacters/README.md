## Building

### Clone a copy of the repository

`git clone link`

### Build the project

`dotnet build`

### Run tests

Run the tests

`dotnet test`

### Create a NuGet package

`dotnet pack --configuration Release`

This command generates a .nupkg file in task/bin/Release. Upload this file to Administration/Tasks in Frends to make the task available for use.

### StyleCop.Analyzers Version
This project uses StyleCop.Analyzers 1.2.0-beta.556, as recommended by the author, to get the latest fixes and improvements not available in the last stable release.
