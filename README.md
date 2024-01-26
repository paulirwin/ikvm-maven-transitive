1. Run `dotnet pack` in ProjectC
2. Run `dotnet add package ProjectC --version 2.0.0 --source ../ProjectC/bin/Release` in Project B
3. Run `dotnet pack` in Project B
4. Run `dotnet add package ProjectB --version 2.0.0 --source ../ProjectB/bin/Release` in Project A
5. Run `dotnet pack` in Project A
6. Run `dotnet add package ProjectA --version 2.0.0 --source ../ProjectA/bin/Release` in ConsoleApp
7. Run `dotnet build` in ConsoleApp
8. Note version of org.apache.commons.lang3.dll in ConsoleApp's bin folder is 3.11.0, while it is 3.12.0 in ProjectA, ProjectB, and ProjectC