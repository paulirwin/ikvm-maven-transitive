1. Run `dotnet pack` in PackageC
2. Run `dotnet add package PackageC --version 2.0.0 --source ../PackageC/bin/Release` in Package B
3. Run `dotnet pack` in Package B
4. Run `dotnet add package PackageB --version 2.0.0 --source ../PackageB/bin/Release` in Package A
5. Run `dotnet pack` in Package A
6. Run `dotnet add package PackageA --version 2.0.0 --source ../PackageA/bin/Release` in ConsoleApp
7. Run `dotnet build` in ConsoleApp
8. Note version of org.apache.commons.lang3.dll in ConsoleApp's bin folder is 3.11.0, while it is 3.12.0 in PackageA, PackageB, and PackageC.

- PackageC depends on commons-configuration2 2.9.0, which has a compile dependency on commons-lang3 3.12.0.
- PackageB depends on PackageC.
- PackageA depends on PackageB and velocity-engine-core 2.3, which has a compile dependency on commons-lang3 3.11.0.
- ConsoleApp depends on PackageA.
