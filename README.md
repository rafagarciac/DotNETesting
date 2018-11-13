# .NETesting
HotelBookingRepositoryClean refactored, including Unit Tests, Functional Test using SpecFlow &amp; Gherkin. 
Architectural Design Improved:

## Architectural Design
### Functional Section

---
***Hotel Booking*** <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|| <br>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;||====== **Business Logic** <br>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;||====== **Data** <br>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;||====== **Booking** <br>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;||====== **Customer** <br>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;||====== **Room** <br>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;||====== **DateManager** <br>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;||====== **Models** <br>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;||====== **HotelBookingStartupProject** <br>
### Testing Section

---
***Hotel Booking*** <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;|| <br>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;||====== **Integration Tests** <br>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;||====== **Controller Tests** <br>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;||====== **Unit Tests** <br>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;||====== **BookingManagerTest** <br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;||====== **Fakes** <br>
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;||====== **Functional Tests (Specs)** <br>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;||====== **CreateBookingTest** <br>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;||====== **FindAvailableRoomTest** <br>

## Report **TODO**
---
### TDD & Cyclomatic complexity
### DD-path Graphs
- Program graphs 
- Node coverage
- Edge coverage
- Loop coverage
- Multiple condition coverage
### Unit, Functional & Integration Testing Explanation
- DateManager Class

## Technologies Used
---
- [NUnit](https://github.com/nunit/nunit) - Unit Testing
- [NUnit3TestAdapter]() - In order, to show up the SpecFlow Test in the Test Explorer in VS2017. <br> 
    * **See this topic for more information:** [Tests not discovered in Visual Studio Test Explorer Window](https://github.com/techtalk/SpecFlow/issues/358)
- [xUnit](https://github.com/xunit/xunit) xUnit.net is a free, open source, community-focused unit testing tool for the .NET Framework.
- [Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json) Json.NET is a popular high-performance JSON framework for .NET
- [SpecRun.SpecFlow](https://specflow.org/documentation/NuGet-Integration/) - Installs SpecFlow and SpecRun
- [SpecFlow.Runner](https://specflow.org/plus/runner/) SpecFlow builds on existing unit testing frameworks like NUnit and MsTest.
- [Gherkin](https://docs.cucumber.io/gherkin/reference/) uses a set of special keywords to give structure and meaning to executable specifications.


# TREE **TODO** - This tree has to looks like as the Architectural Design  
```
└───HotelBooking_Clean
    ├───HotelBooking.BusinessLogic
    │   ├───bin
    │   │   └───Debug
    │   │       └───netstandard2.0
    │   └───obj
    │       └───Debug
    │           └───netstandard2.0
    ├───HotelBooking.ControllerTests
    │   ├───bin
    │   │   └───Debug
    │   │       └───netcoreapp2.1
    │   └───obj
    │       └───Debug
    │           └───netcoreapp2.1
    ├───HotelBooking.Data
    │   ├───bin
    │   │   └───Debug
    │   │       └───netcoreapp2.1
    │   ├───obj
    │   │   └───Debug
    │   │       └───netcoreapp2.1
    │   └───Repositories
    ├───HotelBooking.IntegrationTests
    │   ├───bin
    │   │   └───Debug
    │   │       └───netcoreapp2.1
    │   └───obj
    │       └───Debug
    │           └───netcoreapp2.1
    ├───HotelBooking.Models
    │   ├───bin
    │   │   └───Debug
    │   │       └───netstandard2.0
    │   └───obj
    │       └───Debug
    │           └───netstandard2.0
    ├───HotelBooking.Specs
    │   ├───bin
    │   │   ├───Debug
    │   │   │   └───SpecFlowPlusRunner
    │   │   └───Release
    │   ├───Fakes
    │   ├───obj
    │   │   └───Debug
    │   │       └───TempPE
    │   └───Properties
    ├───HotelBooking.UnitTests
    │   ├───bin
    │   │   └───Debug
    │   │       └───netcoreapp2.1
    │   ├───Fakes
    │   └───obj
    │       └───Debug
    │           └───netcoreapp2.1
    ├───HotelBookingStartupProject
    │   ├───bin
    │   │   └───Debug
    │   │       └───netcoreapp2.1
    │   ├───Controllers
    │   ├───Models
    │   ├───obj
    │   │   └───Debug
    │   │       └───netcoreapp2.1
    │   ├───Properties
    │   ├───Views
    │   │   ├───Bookings
    │   │   ├───Customers
    │   │   ├───Home
    │   │   ├───Rooms
    │   │   └───Shared
    │   └───wwwroot
    │       ├───css
    │       ├───images
    │       ├───js
    │       └───lib
    │           ├───bootstrap
    │           │   └───dist
    │           │       ├───css
    │           │       ├───fonts
    │           │       └───js
    │           ├───jquery
    │           │   └───dist
    │           ├───jquery-validation
    │           │   └───dist
    │           └───jquery-validation-unobtrusive
    ├───packages
    │   ├───MSTest.TestAdapter.1.3.2
    │   │   └───build
    │   │       ├───net45
    │   │       ├───netcoreapp1.0
    │   │       ├───uap10.0
    │   │       └───_common
    │   │           ├───cs
    │   │           ├───de
    │   │           ├───es
    │   │           ├───fr
    │   │           ├───it
    │   │           ├───ja
    │   │           ├───ko
    │   │           ├───pl
    │   │           ├───pt
    │   │           ├───ru
    │   │           ├───tr
    │   │           ├───zh-Hans
    │   │           └───zh-Hant
    │   ├───MSTest.TestFramework.1.3.2
    │   │   └───lib
    │   │       ├───net45
    │   │       │   ├───cs
    │   │       │   ├───de
    │   │       │   ├───es
    │   │       │   ├───fr
    │   │       │   ├───it
    │   │       │   ├───ja
    │   │       │   ├───ko
    │   │       │   ├───pl
    │   │       │   ├───pt
    │   │       │   ├───ru
    │   │       │   ├───tr
    │   │       │   ├───zh-Hans
    │   │       │   └───zh-Hant
    │   │       ├───netstandard1.0
    │   │       │   ├───cs
    │   │       │   ├───de
    │   │       │   ├───es
    │   │       │   ├───fr
    │   │       │   ├───it
    │   │       │   ├───ja
    │   │       │   ├───ko
    │   │       │   ├───pl
    │   │       │   ├───pt
    │   │       │   ├───ru
    │   │       │   ├───tr
    │   │       │   ├───zh-Hans
    │   │       │   └───zh-Hant
    │   │       └───uap10.0
    │   │           ├───cs
    │   │           ├───de
    │   │           ├───es
    │   │           ├───fr
    │   │           ├───it
    │   │           ├───ja
    │   │           ├───ko
    │   │           ├───pl
    │   │           ├───pt
    │   │           ├───ru
    │   │           ├───tr
    │   │           ├───zh-Hans
    │   │           └───zh-Hant
    │   ├───Newtonsoft.Json.10.0.3
    │   │   ├───lib
    │   │   │   ├───net20
    │   │   │   ├───net35
    │   │   │   ├───net40
    │   │   │   ├───net45
    │   │   │   ├───netstandard1.0
    │   │   │   ├───netstandard1.3
    │   │   │   ├───portable-net40+sl5+win8+wp8+wpa81
    │   │   │   └───portable-net45+win8+wp8+wpa81
    │   │   └───tools
    │   ├───NUnit.3.11.0
    │   │   ├───build
    │   │   └───lib
    │   │       ├───net20
    │   │       ├───net35
    │   │       ├───net40
    │   │       ├───net45
    │   │       ├───netstandard1.4
    │   │       └───netstandard2.0
    │   ├───NUnit3TestAdapter.3.11.0
    │   │   └───build
    │   │       ├───net35
    │   │       └───netcoreapp1.0
    │   ├───SpecFlow.2.4.0
    │   │   ├───build
    │   │   ├───content
    │   │   ├───lib
    │   │   │   └───net45
    │   │   └───tools
    │   │       └───Licenses
    │   ├───SpecFlow.xUnit.2.4.0
    │   │   ├───build
    │   │   ├───content
    │   │   ├───lib
    │   │   └───tools
    │   ├───SpecRun.Runner.1.8.5
    │   │   ├───build
    │   │   ├───docs
    │   │   ├───templates
    │   │   └───tools
    │   │       └───server
    │   ├───SpecRun.SpecFlow.1.8.5
    │   ├───SpecRun.SpecFlow.2-4-0.1.8.5
    │   │   ├───build
    │   │   ├───content
    │   │   └───lib
    │   │       └───net45
    │   ├───System.ValueTuple.4.3.0
    │   │   └───lib
    │   │       ├───netstandard1.0
    │   │       └───portable-net40+sl4+win8+wp8
    │   ├───xunit.2.0.0
    │   ├───xunit.abstractions.2.0.0
    │   │   └───lib
    │   │       ├───net35
    │   │       └───portable-net45+win+wpa81+wp80+monotouch+monoandroid+Xamarin.iOS
    │   ├───xunit.assert.2.0.0
    │   │   └───lib
    │   │       └───portable-net45+win+wpa81+wp80+monotouch+monoandroid+Xamarin.iOS
    │   ├───xunit.core.2.0.0
    │   │   └───build
    │   │       ├───monoandroid
    │   │       ├───monotouch
    │   │       ├───portable-net45+win+wpa81+wp80+monotouch+monoandroid+Xamarin.iOS
    │   │       ├───portable-win81+wpa81
    │   │       ├───win8
    │   │       ├───wp8
    │   │       ├───Xamarin.iOS
    │   │       └───_Desktop
    │   └───xunit.extensibility.core.2.0.0
    │       └───lib
    │           └───portable-net45+win+wpa81+wp80+monotouch+monoandroid+Xamarin.iOS
    └───TestResults

D:\EASV - Software Engineer\Testing\Projects\.NETesting>tree /F
Listado de rutas de carpetas
El número de serie del volumen es AE80-58C0
D:.
│   LICENSE
│   README.md
│
└───HotelBooking_Clean
    │   .DS_Store
    │   .gitignore
    │   HotelBookingStartupProject.sln
    │   README.md
    │
    ├───HotelBooking.BusinessLogic
    │   │   BookingManager.cs
    │   │   HotelBooking.BusinessLogic.csproj
    │   │   IBookingManager.cs
    │   │
    │   ├───bin
    │   │   └───Debug
    │   │       └───netstandard2.0
    │   │               HotelBooking.BusinessLogic.deps.json
    │   │               HotelBooking.BusinessLogic.dll
    │   │               HotelBooking.BusinessLogic.pdb
    │   │               HotelBooking.Models.dll
    │   │               HotelBooking.Models.pdb
    │   │               nunit.engine.api.dll
    │   │               nunit.engine.dll
    │   │               NUnit3.TestAdapter.dll
    │   │               NUnit3.TestAdapter.pdb
    │   │
    │   └───obj
    │       │   HotelBooking.BusinessLogic.csproj.nuget.cache
    │       │   HotelBooking.BusinessLogic.csproj.nuget.g.props
    │       │   HotelBooking.BusinessLogic.csproj.nuget.g.targets
    │       │   project.assets.json
    │       │
    │       └───Debug
    │           └───netstandard2.0
    │                   HotelBooking.BusinessLogic.AssemblyInfo.cs
    │                   HotelBooking.BusinessLogic.AssemblyInfoInputs.cache
    │                   HotelBooking.BusinessLogic.assets.cache
    │                   HotelBooking.BusinessLogic.csproj.CopyComplete
    │                   HotelBooking.BusinessLogic.csproj.CoreCompileInputs.cache
    │                   HotelBooking.BusinessLogic.csproj.FileListAbsolute.txt
    │                   HotelBooking.BusinessLogic.csprojAssemblyReference.cache
    │                   HotelBooking.BusinessLogic.dll
    │                   HotelBooking.BusinessLogic.pdb
    │
    ├───HotelBooking.ControllerTests
    │   │   BookingControllerTests.cs
    │   │   CustomerControllerTests.cs
    │   │   HotelBooking.ControllerTests.csproj
    │   │   RoomControllerTests.cs
    │   │
    │   ├───bin
    │   │   └───Debug
    │   │       └───netcoreapp2.1
    │   │               HotelBooking.BusinessLogic.dll
    │   │               HotelBooking.BusinessLogic.pdb
    │   │               HotelBooking.ControllerTests.deps.json
    │   │               HotelBooking.ControllerTests.dll
    │   │               HotelBooking.ControllerTests.pdb
    │   │               HotelBooking.ControllerTests.runtimeconfig.dev.json
    │   │               HotelBooking.ControllerTests.runtimeconfig.json
    │   │               HotelBooking.Data.dll
    │   │               HotelBooking.Data.pdb
    │   │               HotelBooking.Models.dll
    │   │               HotelBooking.Models.pdb
    │   │               HotelBookingStartupProject.dll
    │   │               HotelBookingStartupProject.pdb
    │   │               nunit.engine.api.dll
    │   │               nunit.engine.dll
    │   │               nunit.engine.netstandard.dll
    │   │               NUnit3.TestAdapter.dll
    │   │               NUnit3.TestAdapter.pdb
    │   │               xunit.runner.reporters.netcoreapp10.dll
    │   │               xunit.runner.utility.netcoreapp10.dll
    │   │               xunit.runner.visualstudio.dotnetcore.testadapter.dll
    │   │
    │   └───obj
    │       │   HotelBooking.ControllerTests.csproj.nuget.cache
    │       │   HotelBooking.ControllerTests.csproj.nuget.g.props
    │       │   HotelBooking.ControllerTests.csproj.nuget.g.targets
    │       │   project.assets.json
    │       │
    │       └───Debug
    │           └───netcoreapp2.1
    │                   HotelBooking.ControllerTests.AssemblyInfo.cs
    │                   HotelBooking.ControllerTests.AssemblyInfoInputs.cache
    │                   HotelBooking.ControllerTests.assets.cache
    │                   HotelBooking.ControllerTests.csproj.CopyComplete
    │                   HotelBooking.ControllerTests.csproj.CoreCompileInputs.cache
    │                   HotelBooking.ControllerTests.csproj.FileListAbsolute.txt
    │                   HotelBooking.ControllerTests.csprojAssemblyReference.cache
    │                   HotelBooking.ControllerTests.dll
    │                   HotelBooking.ControllerTests.pdb
    │                   HotelBooking.ControllerTests.Program.cs
    │                   TemporaryGeneratedFile_036C0B5B-1481-4323-8D20-8F5ADCB23D92.cs
    │                   TemporaryGeneratedFile_5937a670-0e60-4077-877b-f7221da3dda1.cs
    │                   TemporaryGeneratedFile_E7A71F73-0F8D-4B9B-B56E-8E70B10BC5D3.cs
    │
    ├───HotelBooking.Data
    │   │   DbInitializer.cs
    │   │   HotelBooking.Data.csproj
    │   │   HotelBookingContext.cs
    │   │
    │   ├───bin
    │   │   └───Debug
    │   │       └───netcoreapp2.1
    │   │               HotelBooking.Data.deps.json
    │   │               HotelBooking.Data.dll
    │   │               HotelBooking.Data.pdb
    │   │               HotelBooking.Models.dll
    │   │               HotelBooking.Models.pdb
    │   │               nunit.engine.api.dll
    │   │               nunit.engine.dll
    │   │               nunit.engine.netstandard.dll
    │   │               NUnit3.TestAdapter.dll
    │   │               NUnit3.TestAdapter.pdb
    │   │
    │   ├───obj
    │   │   │   HotelBooking.Data.csproj.nuget.cache
    │   │   │   HotelBooking.Data.csproj.nuget.g.props
    │   │   │   HotelBooking.Data.csproj.nuget.g.targets
    │   │   │   project.assets.json
    │   │   │
    │   │   └───Debug
    │   │       └───netcoreapp2.1
    │   │               HotelBooking.Data.AssemblyInfo.cs
    │   │               HotelBooking.Data.AssemblyInfoInputs.cache
    │   │               HotelBooking.Data.assets.cache
    │   │               HotelBooking.Data.csproj.CopyComplete
    │   │               HotelBooking.Data.csproj.CoreCompileInputs.cache
    │   │               HotelBooking.Data.csproj.FileListAbsolute.txt
    │   │               HotelBooking.Data.csprojAssemblyReference.cache
    │   │               HotelBooking.Data.dll
    │   │               HotelBooking.Data.pdb
    │   │               TemporaryGeneratedFile_036C0B5B-1481-4323-8D20-8F5ADCB23D92.cs
    │   │               TemporaryGeneratedFile_5937a670-0e60-4077-877b-f7221da3dda1.cs
    │   │               TemporaryGeneratedFile_E7A71F73-0F8D-4B9B-B56E-8E70B10BC5D3.cs
    │   │
    │   └───Repositories
    │           BookingRepository.cs
    │           CustomerRepository.cs
    │           RoomRepository.cs
    │
    ├───HotelBooking.IntegrationTests
    │   │   BookingManagerTests.cs
    │   │   HotelBooking.IntegrationTests.csproj
    │   │
    │   ├───bin
    │   │   └───Debug
    │   │       └───netcoreapp2.1
    │   │               HotelBooking.BusinessLogic.dll
    │   │               HotelBooking.BusinessLogic.pdb
    │   │               HotelBooking.Data.dll
    │   │               HotelBooking.Data.pdb
    │   │               HotelBooking.IntegrationTests.deps.json
    │   │               HotelBooking.IntegrationTests.dll
    │   │               HotelBooking.IntegrationTests.pdb
    │   │               HotelBooking.IntegrationTests.runtimeconfig.dev.json
    │   │               HotelBooking.IntegrationTests.runtimeconfig.json
    │   │               HotelBooking.Models.dll
    │   │               HotelBooking.Models.pdb
    │   │               nunit.engine.api.dll
    │   │               nunit.engine.dll
    │   │               nunit.engine.netstandard.dll
    │   │               NUnit3.TestAdapter.dll
    │   │               NUnit3.TestAdapter.pdb
    │   │               xunit.runner.reporters.netcoreapp10.dll
    │   │               xunit.runner.utility.netcoreapp10.dll
    │   │               xunit.runner.visualstudio.dotnetcore.testadapter.dll
    │   │
    │   └───obj
    │       │   HotelBooking.IntegrationTests.csproj.nuget.cache
    │       │   HotelBooking.IntegrationTests.csproj.nuget.g.props
    │       │   HotelBooking.IntegrationTests.csproj.nuget.g.targets
    │       │   project.assets.json
    │       │
    │       └───Debug
    │           └───netcoreapp2.1
    │                   HotelBooking.IntegrationTests.AssemblyInfo.cs
    │                   HotelBooking.IntegrationTests.AssemblyInfoInputs.cache
    │                   HotelBooking.IntegrationTests.assets.cache
    │                   HotelBooking.IntegrationTests.csproj.CopyComplete
    │                   HotelBooking.IntegrationTests.csproj.CoreCompileInputs.cache
    │                   HotelBooking.IntegrationTests.csproj.FileListAbsolute.txt
    │                   HotelBooking.IntegrationTests.csprojAssemblyReference.cache
    │                   HotelBooking.IntegrationTests.dll
    │                   HotelBooking.IntegrationTests.pdb
    │                   HotelBooking.IntegrationTests.Program.cs
    │                   TemporaryGeneratedFile_036C0B5B-1481-4323-8D20-8F5ADCB23D92.cs
    │                   TemporaryGeneratedFile_5937a670-0e60-4077-877b-f7221da3dda1.cs
    │                   TemporaryGeneratedFile_E7A71F73-0F8D-4B9B-B56E-8E70B10BC5D3.cs
    │
    ├───HotelBooking.Models
    │   │   Booking.cs
    │   │   Customer.cs
    │   │   DataManager.cs
    │   │   HotelBooking.Models.csproj
    │   │   IRepository.cs
    │   │   Room.cs
    │   │
    │   ├───bin
    │   │   └───Debug
    │   │       └───netstandard2.0
    │   │               HotelBooking.Models.deps.json
    │   │               HotelBooking.Models.dll
    │   │               HotelBooking.Models.pdb
    │   │               nunit.engine.api.dll
    │   │               nunit.engine.dll
    │   │               NUnit3.TestAdapter.dll
    │   │               NUnit3.TestAdapter.pdb
    │   │
    │   └───obj
    │       │   HotelBooking.Models.csproj.nuget.cache
    │       │   HotelBooking.Models.csproj.nuget.g.props
    │       │   HotelBooking.Models.csproj.nuget.g.targets
    │       │   project.assets.json
    │       │
    │       └───Debug
    │           └───netstandard2.0
    │                   HotelBooking.Models.AssemblyInfo.cs
    │                   HotelBooking.Models.AssemblyInfoInputs.cache
    │                   HotelBooking.Models.assets.cache
    │                   HotelBooking.Models.csproj.CoreCompileInputs.cache
    │                   HotelBooking.Models.csproj.FileListAbsolute.txt
    │                   HotelBooking.Models.csprojAssemblyReference.cache
    │                   HotelBooking.Models.dll
    │                   HotelBooking.Models.pdb
    │
    ├───HotelBooking.Specs
    │   │   App.config
    │   │   CreateBooking.feature
    │   │   CreateBooking.feature.cs
    │   │   CreateBookingSteps.cs
    │   │   Default.srprofile
    │   │   FindAvailableRoom.feature
    │   │   FindAvailableRoom.feature.cs
    │   │   FindAvailableRoomSteps.cs
    │   │   HotelBooking.Specs.csproj
    │   │   packages.config
    │   │   runtests.cmd
    │   │   SpecRunTestProfile.xsd
    │   │   SpecRunTestProfile_2011_09.xsd
    │   │
    │   ├───bin
    │   │   ├───Debug
    │   │   │   │   Default.srprofile
    │   │   │   │   Gherkin.dll
    │   │   │   │   HotelBooking.BusinessLogic.dll
    │   │   │   │   HotelBooking.BusinessLogic.pdb
    │   │   │   │   HotelBooking.Models.dll
    │   │   │   │   HotelBooking.Models.pdb
    │   │   │   │   HotelBooking.Specs.dll
    │   │   │   │   HotelBooking.Specs.dll.config
    │   │   │   │   HotelBooking.Specs.pdb
    │   │   │   │   Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter.dll
    │   │   │   │   Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.dll
    │   │   │   │   Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.Interface.dll
    │   │   │   │   Microsoft.VisualStudio.TestPlatform.TestFramework.dll
    │   │   │   │   Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.dll
    │   │   │   │   Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │   │   │   Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │   │   │   Microsoft.Win32.Primitives.dll
    │   │   │   │   netstandard.dll
    │   │   │   │   Newtonsoft.Json.dll
    │   │   │   │   Newtonsoft.Json.xml
    │   │   │   │   nunit.engine.api.dll
    │   │   │   │   nunit.engine.dll
    │   │   │   │   NUnit3.TestAdapter.dll
    │   │   │   │   NUnit3.TestAdapter.pdb
    │   │   │   │   SpecRun.SpecFlowPlugin.dll
    │   │   │   │   System.AppContext.dll
    │   │   │   │   System.Collections.Concurrent.dll
    │   │   │   │   System.Collections.dll
    │   │   │   │   System.Collections.NonGeneric.dll
    │   │   │   │   System.Collections.Specialized.dll
    │   │   │   │   System.ComponentModel.dll
    │   │   │   │   System.ComponentModel.EventBasedAsync.dll
    │   │   │   │   System.ComponentModel.Primitives.dll
    │   │   │   │   System.ComponentModel.TypeConverter.dll
    │   │   │   │   System.Console.dll
    │   │   │   │   System.Data.Common.dll
    │   │   │   │   System.Diagnostics.Contracts.dll
    │   │   │   │   System.Diagnostics.Debug.dll
    │   │   │   │   System.Diagnostics.FileVersionInfo.dll
    │   │   │   │   System.Diagnostics.Process.dll
    │   │   │   │   System.Diagnostics.StackTrace.dll
    │   │   │   │   System.Diagnostics.TextWriterTraceListener.dll
    │   │   │   │   System.Diagnostics.Tools.dll
    │   │   │   │   System.Diagnostics.TraceSource.dll
    │   │   │   │   System.Diagnostics.Tracing.dll
    │   │   │   │   System.Drawing.Primitives.dll
    │   │   │   │   System.Dynamic.Runtime.dll
    │   │   │   │   System.Globalization.Calendars.dll
    │   │   │   │   System.Globalization.dll
    │   │   │   │   System.Globalization.Extensions.dll
    │   │   │   │   System.IO.Compression.dll
    │   │   │   │   System.IO.Compression.ZipFile.dll
    │   │   │   │   System.IO.dll
    │   │   │   │   System.IO.FileSystem.dll
    │   │   │   │   System.IO.FileSystem.DriveInfo.dll
    │   │   │   │   System.IO.FileSystem.Primitives.dll
    │   │   │   │   System.IO.FileSystem.Watcher.dll
    │   │   │   │   System.IO.IsolatedStorage.dll
    │   │   │   │   System.IO.MemoryMappedFiles.dll
    │   │   │   │   System.IO.Pipes.dll
    │   │   │   │   System.IO.UnmanagedMemoryStream.dll
    │   │   │   │   System.Linq.dll
    │   │   │   │   System.Linq.Expressions.dll
    │   │   │   │   System.Linq.Parallel.dll
    │   │   │   │   System.Linq.Queryable.dll
    │   │   │   │   System.Net.Http.dll
    │   │   │   │   System.Net.NameResolution.dll
    │   │   │   │   System.Net.NetworkInformation.dll
    │   │   │   │   System.Net.Ping.dll
    │   │   │   │   System.Net.Primitives.dll
    │   │   │   │   System.Net.Requests.dll
    │   │   │   │   System.Net.Security.dll
    │   │   │   │   System.Net.Sockets.dll
    │   │   │   │   System.Net.WebHeaderCollection.dll
    │   │   │   │   System.Net.WebSockets.Client.dll
    │   │   │   │   System.Net.WebSockets.dll
    │   │   │   │   System.ObjectModel.dll
    │   │   │   │   System.Reflection.dll
    │   │   │   │   System.Reflection.Extensions.dll
    │   │   │   │   System.Reflection.Primitives.dll
    │   │   │   │   System.Resources.Reader.dll
    │   │   │   │   System.Resources.ResourceManager.dll
    │   │   │   │   System.Resources.Writer.dll
    │   │   │   │   System.Runtime.CompilerServices.VisualC.dll
    │   │   │   │   System.Runtime.dll
    │   │   │   │   System.Runtime.Extensions.dll
    │   │   │   │   System.Runtime.Handles.dll
    │   │   │   │   System.Runtime.InteropServices.dll
    │   │   │   │   System.Runtime.InteropServices.RuntimeInformation.dll
    │   │   │   │   System.Runtime.Numerics.dll
    │   │   │   │   System.Runtime.Serialization.Formatters.dll
    │   │   │   │   System.Runtime.Serialization.Json.dll
    │   │   │   │   System.Runtime.Serialization.Primitives.dll
    │   │   │   │   System.Runtime.Serialization.Xml.dll
    │   │   │   │   System.Security.Claims.dll
    │   │   │   │   System.Security.Cryptography.Algorithms.dll
    │   │   │   │   System.Security.Cryptography.Csp.dll
    │   │   │   │   System.Security.Cryptography.Encoding.dll
    │   │   │   │   System.Security.Cryptography.Primitives.dll
    │   │   │   │   System.Security.Cryptography.X509Certificates.dll
    │   │   │   │   System.Security.Principal.dll
    │   │   │   │   System.Security.SecureString.dll
    │   │   │   │   System.Text.Encoding.dll
    │   │   │   │   System.Text.Encoding.Extensions.dll
    │   │   │   │   System.Text.RegularExpressions.dll
    │   │   │   │   System.Threading.dll
    │   │   │   │   System.Threading.Overlapped.dll
    │   │   │   │   System.Threading.Tasks.dll
    │   │   │   │   System.Threading.Tasks.Parallel.dll
    │   │   │   │   System.Threading.Thread.dll
    │   │   │   │   System.Threading.ThreadPool.dll
    │   │   │   │   System.Threading.Timer.dll
    │   │   │   │   System.ValueTuple.dll
    │   │   │   │   System.Xml.ReaderWriter.dll
    │   │   │   │   System.Xml.XDocument.dll
    │   │   │   │   System.Xml.XmlDocument.dll
    │   │   │   │   System.Xml.XmlSerializer.dll
    │   │   │   │   System.Xml.XPath.dll
    │   │   │   │   System.Xml.XPath.XDocument.dll
    │   │   │   │   TechTalk.SpecFlow.dll
    │   │   │   │   TechTalk.SpecRun.Common.dll
    │   │   │   │   TechTalk.SpecRun.dll
    │   │   │   │   TechTalk.SpecRun.Framework.dll
    │   │   │   │   TechTalk.SpecRun.Framework.Executor.dll
    │   │   │   │   TechTalk.SpecRun.Framework.Interfaces.dll
    │   │   │   │   TechTalk.SpecRun.Framework.Utils.dll
    │   │   │   │   TechTalk.SpecRun.VisualStudio.TestAdapter.dll
    │   │   │   │   TechTalk.SpecRun.VisualStudio.TestAdapter.dll.config
    │   │   │   │   xunit.abstractions.dll
    │   │   │   │   xunit.abstractions.xml
    │   │   │   │   xunit.assert.dll
    │   │   │   │   xunit.assert.pdb
    │   │   │   │   xunit.assert.xml
    │   │   │   │   xunit.core.dll
    │   │   │   │   xunit.core.pdb
    │   │   │   │   xunit.core.xml
    │   │   │   │   xunit.execution.desktop.dll
    │   │   │   │
    │   │   │   └───SpecFlowPlusRunner
    │   │   │           FSharp.Core.dll
    │   │   │           Gherkin.dll
    │   │   │           Microsoft.Data.Services.Client.dll
    │   │   │           Microsoft.Web.Publishing.Tasks.dll
    │   │   │           NConsoler.dll
    │   │   │           Newtonsoft.Json.dll
    │   │   │           RazorEngine.dll
    │   │   │           RestSharp.dll
    │   │   │           SpecRun.exe
    │   │   │           SpecRun.exe.config
    │   │   │           SpecRunTestProfile.xsd
    │   │   │           SpecRunTestProfile_2011_09.xsd
    │   │   │           System.Web.Razor.dll
    │   │   │           TechTalk.SpecRun.Common.dll
    │   │   │           TechTalk.SpecRun.dll
    │   │   │           TechTalk.SpecRun.Framework.dll
    │   │   │           TechTalk.SpecRun.Framework.dll.config
    │   │   │           TechTalk.SpecRun.Framework.Executor.anycpu.clr20.exe
    │   │   │           TechTalk.SpecRun.Framework.Executor.anycpu.clr20.exe.config
    │   │   │           TechTalk.SpecRun.Framework.Executor.anycpu.clr40.exe
    │   │   │           TechTalk.SpecRun.Framework.Executor.anycpu.clr40.exe.config
    │   │   │           TechTalk.SpecRun.Framework.Executor.dll
    │   │   │           TechTalk.SpecRun.Framework.Executor.dll.config
    │   │   │           TechTalk.SpecRun.Framework.Executor.x86.clr20.exe
    │   │   │           TechTalk.SpecRun.Framework.Executor.x86.clr20.exe.config
    │   │   │           TechTalk.SpecRun.Framework.Executor.x86.clr40.exe
    │   │   │           TechTalk.SpecRun.Framework.Executor.x86.clr40.exe.config
    │   │   │           TechTalk.SpecRun.Framework.Interfaces.dll
    │   │   │           TechTalk.SpecRun.Framework.Utils.dll
    │   │   │           TechTalk.SpecRun.Server.CommandClient.dll
    │   │   │           TechTalk.SpecRun.Server.Commands.dll
    │   │   │           TechTalk.SpecRun.Server.ReadModelClient.dll
    │   │   │           TechTalk.SpecRun.VisualStudio.TestAdapter.dll
    │   │   │           TechTalk.SpecRun.VisualStudio.TestAdapter.dll.config
    │   │   │
    │   │   └───Release
    │   ├───Fakes
    │   │       FakeBookingRepository.cs
    │   │       FakeRoomRepository.cs
    │   │
    │   ├───obj
    │   │   └───Debug
    │   │       │   DesignTimeResolveAssemblyReferencesInput.cache
    │   │       │   HotelBooking.Specs.csproj.CopyComplete
    │   │       │   HotelBooking.Specs.csproj.CoreCompileInputs.cache
    │   │       │   HotelBooking.Specs.csproj.FileListAbsolute.txt
    │   │       │   HotelBooking.Specs.csprojAssemblyReference.cache
    │   │       │   HotelBooking.Specs.dll
    │   │       │   HotelBooking.Specs.pdb
    │   │       │   TemporaryGeneratedFile_036C0B5B-1481-4323-8D20-8F5ADCB23D92.cs
    │   │       │   TemporaryGeneratedFile_5937a670-0e60-4077-877b-f7221da3dda1.cs
    │   │       │   TemporaryGeneratedFile_E7A71F73-0F8D-4B9B-B56E-8E70B10BC5D3.cs
    │   │       │
    │   │       └───TempPE
    │   │               CreateBooking.feature.cs.dll
    │   │               FindAvailableRoom.feature.cs.dll
    │   │
    │   └───Properties
    │           AssemblyInfo.cs
    │
    ├───HotelBooking.UnitTests
    │   │   BookingManagerTests.cs
    │   │   HotelBooking.UnitTests.csproj
    │   │
    │   ├───bin
    │   │   └───Debug
    │   │       └───netcoreapp2.1
    │   │               HotelBooking.BusinessLogic.dll
    │   │               HotelBooking.BusinessLogic.pdb
    │   │               HotelBooking.Data.dll
    │   │               HotelBooking.Data.pdb
    │   │               HotelBooking.Models.dll
    │   │               HotelBooking.Models.pdb
    │   │               HotelBooking.UnitTests.deps.json
    │   │               HotelBooking.UnitTests.dll
    │   │               HotelBooking.UnitTests.pdb
    │   │               HotelBooking.UnitTests.runtimeconfig.dev.json
    │   │               HotelBooking.UnitTests.runtimeconfig.json
    │   │               HotelBookingStartupProject.dll
    │   │               HotelBookingStartupProject.pdb
    │   │               nunit.engine.api.dll
    │   │               nunit.engine.dll
    │   │               nunit.engine.netstandard.dll
    │   │               NUnit3.TestAdapter.dll
    │   │               NUnit3.TestAdapter.pdb
    │   │               xunit.runner.reporters.netcoreapp10.dll
    │   │               xunit.runner.utility.netcoreapp10.dll
    │   │               xunit.runner.visualstudio.dotnetcore.testadapter.dll
    │   │
    │   ├───Fakes
    │   │       FakeBookingRepository.cs
    │   │       FakeRoomRepository.cs
    │   │
    │   └───obj
    │       │   HotelBooking.UnitTests.csproj.nuget.cache
    │       │   HotelBooking.UnitTests.csproj.nuget.g.props
    │       │   HotelBooking.UnitTests.csproj.nuget.g.targets
    │       │   project.assets.json
    │       │
    │       └───Debug
    │           └───netcoreapp2.1
    │                   HotelBooking.UnitTests.AssemblyInfo.cs
    │                   HotelBooking.UnitTests.AssemblyInfoInputs.cache
    │                   HotelBooking.UnitTests.assets.cache
    │                   HotelBooking.UnitTests.csproj.CopyComplete
    │                   HotelBooking.UnitTests.csproj.CoreCompileInputs.cache
    │                   HotelBooking.UnitTests.csproj.FileListAbsolute.txt
    │                   HotelBooking.UnitTests.csprojAssemblyReference.cache
    │                   HotelBooking.UnitTests.dll
    │                   HotelBooking.UnitTests.pdb
    │                   HotelBooking.UnitTests.Program.cs
    │                   TemporaryGeneratedFile_036C0B5B-1481-4323-8D20-8F5ADCB23D92.cs
    │                   TemporaryGeneratedFile_5937a670-0e60-4077-877b-f7221da3dda1.cs
    │                   TemporaryGeneratedFile_E7A71F73-0F8D-4B9B-B56E-8E70B10BC5D3.cs
    │
    ├───HotelBookingStartupProject
    │   │   .bowerrc
    │   │   appsettings.Development.json
    │   │   appsettings.json
    │   │   bower.json
    │   │   bundleconfig.json
    │   │   HotelBookingStartupProject.csproj
    │   │   HotelBookingStartupProject.csproj.user
    │   │   Program.cs
    │   │   Startup.cs
    │   │
    │   ├───bin
    │   │   └───Debug
    │   │       └───netcoreapp2.1
    │   │               HotelBooking.BusinessLogic.dll
    │   │               HotelBooking.BusinessLogic.pdb
    │   │               HotelBooking.Data.dll
    │   │               HotelBooking.Data.pdb
    │   │               HotelBooking.Models.dll
    │   │               HotelBooking.Models.pdb
    │   │               HotelBookingStartupProject.deps.json
    │   │               HotelBookingStartupProject.dll
    │   │               HotelBookingStartupProject.pdb
    │   │               HotelBookingStartupProject.runtimeconfig.dev.json
    │   │               HotelBookingStartupProject.runtimeconfig.json
    │   │               nunit.engine.api.dll
    │   │               nunit.engine.dll
    │   │               nunit.engine.netstandard.dll
    │   │               NUnit3.TestAdapter.dll
    │   │               NUnit3.TestAdapter.pdb
    │   │
    │   ├───Controllers
    │   │       BookingsController.cs
    │   │       CustomersController.cs
    │   │       RoomsController.cs
    │   │
    │   ├───Models
    │   │       BookingViewModel.cs
    │   │       ErrorViewModel.cs
    │   │       IBookingViewModel.cs
    │   │
    │   ├───obj
    │   │   │   HotelBookingStartupProject.csproj.nuget.cache
    │   │   │   HotelBookingStartupProject.csproj.nuget.g.props
    │   │   │   HotelBookingStartupProject.csproj.nuget.g.targets
    │   │   │   project.assets.json
    │   │   │
    │   │   └───Debug
    │   │       └───netcoreapp2.1
    │   │               HotelBookingStartupProject.AssemblyInfo.cs
    │   │               HotelBookingStartupProject.AssemblyInfoInputs.cache
    │   │               HotelBookingStartupProject.assets.cache
    │   │               HotelBookingStartupProject.csproj.CopyComplete
    │   │               HotelBookingStartupProject.csproj.CoreCompileInputs.cache
    │   │               HotelBookingStartupProject.csproj.FileListAbsolute.txt
    │   │               HotelBookingStartupProject.csprojAssemblyReference.cache
    │   │               HotelBookingStartupProject.dll
    │   │               HotelBookingStartupProject.pdb
    │   │               TemporaryGeneratedFile_036C0B5B-1481-4323-8D20-8F5ADCB23D92.cs
    │   │               TemporaryGeneratedFile_5937a670-0e60-4077-877b-f7221da3dda1.cs
    │   │               TemporaryGeneratedFile_E7A71F73-0F8D-4B9B-B56E-8E70B10BC5D3.cs
    │   │
    │   ├───Properties
    │   │       launchSettings.json
    │   │
    │   ├───Views
    │   │   │   _ViewImports.cshtml
    │   │   │   _ViewStart.cshtml
    │   │   │
    │   │   ├───Bookings
    │   │   │       Create.cshtml
    │   │   │       Delete.cshtml
    │   │   │       Details.cshtml
    │   │   │       Edit.cshtml
    │   │   │       Index.cshtml
    │   │   │
    │   │   ├───Customers
    │   │   │       Create.cshtml
    │   │   │       Delete.cshtml
    │   │   │       Details.cshtml
    │   │   │       Edit.cshtml
    │   │   │       Index.cshtml
    │   │   │
    │   │   ├───Home
    │   │   │       About.cshtml
    │   │   │       Contact.cshtml
    │   │   │       Index.cshtml
    │   │   │
    │   │   ├───Rooms
    │   │   │       Create.cshtml
    │   │   │       Delete.cshtml
    │   │   │       Details.cshtml
    │   │   │       Edit.cshtml
    │   │   │       Index.cshtml
    │   │   │
    │   │   └───Shared
    │   │           Error.cshtml
    │   │           _Layout.cshtml
    │   │           _ValidationScriptsPartial.cshtml
    │   │
    │   └───wwwroot
    │       │   favicon.ico
    │       │
    │       ├───css
    │       │       site.css
    │       │       site.min.css
    │       │
    │       ├───images
    │       │       banner1.svg
    │       │       banner2.svg
    │       │       banner3.svg
    │       │       banner4.svg
    │       │
    │       ├───js
    │       │       site.js
    │       │       site.min.js
    │       │
    │       └───lib
    │           ├───bootstrap
    │           │   │   .bower.json
    │           │   │   LICENSE
    │           │   │
    │           │   └───dist
    │           │       ├───css
    │           │       │       bootstrap-theme.css
    │           │       │       bootstrap-theme.css.map
    │           │       │       bootstrap-theme.min.css
    │           │       │       bootstrap-theme.min.css.map
    │           │       │       bootstrap.css
    │           │       │       bootstrap.css.map
    │           │       │       bootstrap.min.css
    │           │       │       bootstrap.min.css.map
    │           │       │
    │           │       ├───fonts
    │           │       │       glyphicons-halflings-regular.eot
    │           │       │       glyphicons-halflings-regular.svg
    │           │       │       glyphicons-halflings-regular.ttf
    │           │       │       glyphicons-halflings-regular.woff
    │           │       │       glyphicons-halflings-regular.woff2
    │           │       │
    │           │       └───js
    │           │               bootstrap.js
    │           │               bootstrap.min.js
    │           │               npm.js
    │           │
    │           ├───jquery
    │           │   │   .bower.json
    │           │   │   LICENSE.txt
    │           │   │
    │           │   └───dist
    │           │           jquery.js
    │           │           jquery.min.js
    │           │           jquery.min.map
    │           │
    │           ├───jquery-validation
    │           │   │   .bower.json
    │           │   │   LICENSE.md
    │           │   │
    │           │   └───dist
    │           │           additional-methods.js
    │           │           additional-methods.min.js
    │           │           jquery.validate.js
    │           │           jquery.validate.min.js
    │           │
    │           └───jquery-validation-unobtrusive
    │                   .bower.json
    │                   jquery.validate.unobtrusive.js
    │                   jquery.validate.unobtrusive.min.js
    │
    ├───packages
    │   ├───MSTest.TestAdapter.1.3.2
    │   │   │   .signature.p7s
    │   │   │   MSTest.TestAdapter.1.3.2.nupkg
    │   │   │
    │   │   └───build
    │   │       ├───net45
    │   │       │       MSTest.TestAdapter.props
    │   │       │       MSTest.TestAdapter.targets
    │   │       │
    │   │       ├───netcoreapp1.0
    │   │       │       Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.dll
    │   │       │       MSTest.TestAdapter.props
    │   │       │
    │   │       ├───uap10.0
    │   │       │       Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.dll
    │   │       │       MSTest.TestAdapter.props
    │   │       │       MSTest.TestAdapter.targets
    │   │       │
    │   │       └───_common
    │   │           │   Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter.dll
    │   │           │   Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.dll
    │   │           │   Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.Interface.dll
    │   │           │   Microsoft.VisualStudio.TestPlatform.TestFramework.dll
    │   │           │
    │   │           ├───cs
    │   │           │       Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter.resources.dll
    │   │           │       Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.resources.dll
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.resources.dll
    │   │           │
    │   │           ├───de
    │   │           │       Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter.resources.dll
    │   │           │       Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.resources.dll
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.resources.dll
    │   │           │
    │   │           ├───es
    │   │           │       Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter.resources.dll
    │   │           │       Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.resources.dll
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.resources.dll
    │   │           │
    │   │           ├───fr
    │   │           │       Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter.resources.dll
    │   │           │       Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.resources.dll
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.resources.dll
    │   │           │
    │   │           ├───it
    │   │           │       Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter.resources.dll
    │   │           │       Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.resources.dll
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.resources.dll
    │   │           │
    │   │           ├───ja
    │   │           │       Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter.resources.dll
    │   │           │       Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.resources.dll
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.resources.dll
    │   │           │
    │   │           ├───ko
    │   │           │       Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter.resources.dll
    │   │           │       Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.resources.dll
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.resources.dll
    │   │           │
    │   │           ├───pl
    │   │           │       Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter.resources.dll
    │   │           │       Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.resources.dll
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.resources.dll
    │   │           │
    │   │           ├───pt
    │   │           │       Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter.resources.dll
    │   │           │       Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.resources.dll
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.resources.dll
    │   │           │
    │   │           ├───ru
    │   │           │       Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter.resources.dll
    │   │           │       Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.resources.dll
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.resources.dll
    │   │           │
    │   │           ├───tr
    │   │           │       Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter.resources.dll
    │   │           │       Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.resources.dll
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.resources.dll
    │   │           │
    │   │           ├───zh-Hans
    │   │           │       Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter.resources.dll
    │   │           │       Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.resources.dll
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.resources.dll
    │   │           │
    │   │           └───zh-Hant
    │   │                   Microsoft.VisualStudio.TestPlatform.MSTest.TestAdapter.resources.dll
    │   │                   Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.resources.dll
    │   │                   Microsoft.VisualStudio.TestPlatform.TestFramework.resources.dll
    │   │
    │   ├───MSTest.TestFramework.1.3.2
    │   │   │   .signature.p7s
    │   │   │   MSTest.TestFramework.1.3.2.nupkg
    │   │   │
    │   │   └───lib
    │   │       ├───net45
    │   │       │   │   Microsoft.VisualStudio.TestPlatform.TestFramework.dll
    │   │       │   │   Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.dll
    │   │       │   │   Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.XML
    │   │       │   │   Microsoft.VisualStudio.TestPlatform.TestFramework.XML
    │   │       │   │
    │   │       │   ├───cs
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │   │
    │   │       │   ├───de
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │   │
    │   │       │   ├───es
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │   │
    │   │       │   ├───fr
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │   │
    │   │       │   ├───it
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │   │
    │   │       │   ├───ja
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │   │
    │   │       │   ├───ko
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │   │
    │   │       │   ├───pl
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │   │
    │   │       │   ├───pt
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │   │
    │   │       │   ├───ru
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │   │
    │   │       │   ├───tr
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │   │
    │   │       │   ├───zh-Hans
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │   │
    │   │       │   └───zh-Hant
    │   │       │           Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │           Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │
    │   │       ├───netstandard1.0
    │   │       │   │   Microsoft.VisualStudio.TestPlatform.TestFramework.dll
    │   │       │   │   Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.dll
    │   │       │   │   Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.XML
    │   │       │   │   Microsoft.VisualStudio.TestPlatform.TestFramework.XML
    │   │       │   │
    │   │       │   ├───cs
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │   │
    │   │       │   ├───de
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │   │
    │   │       │   ├───es
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │   │
    │   │       │   ├───fr
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │   │
    │   │       │   ├───it
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │   │
    │   │       │   ├───ja
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │   │
    │   │       │   ├───ko
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │   │
    │   │       │   ├───pl
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │   │
    │   │       │   ├───pt
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │   │
    │   │       │   ├───ru
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │   │
    │   │       │   ├───tr
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │   │
    │   │       │   ├───zh-Hans
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │   │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │   │
    │   │       │   └───zh-Hant
    │   │       │           Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │       │           Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │       │
    │   │       └───uap10.0
    │   │           │   Microsoft.VisualStudio.TestPlatform.TestFramework.dll
    │   │           │   Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.dll
    │   │           │   Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.XML
    │   │           │   Microsoft.VisualStudio.TestPlatform.TestFramework.XML
    │   │           │
    │   │           ├───cs
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │           │
    │   │           ├───de
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │           │
    │   │           ├───es
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │           │
    │   │           ├───fr
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │           │
    │   │           ├───it
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │           │
    │   │           ├───ja
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │           │
    │   │           ├───ko
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │           │
    │   │           ├───pl
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │           │
    │   │           ├───pt
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │           │
    │   │           ├───ru
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │           │
    │   │           ├───tr
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │           │
    │   │           ├───zh-Hans
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │           │       Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │           │
    │   │           └───zh-Hant
    │   │                   Microsoft.VisualStudio.TestPlatform.TestFramework.Extensions.xml
    │   │                   Microsoft.VisualStudio.TestPlatform.TestFramework.xml
    │   │
    │   ├───Newtonsoft.Json.10.0.3
    │   │   │   LICENSE.md
    │   │   │   Newtonsoft.Json.10.0.3.nupkg
    │   │   │
    │   │   ├───lib
    │   │   │   ├───net20
    │   │   │   │       Newtonsoft.Json.dll
    │   │   │   │       Newtonsoft.Json.xml
    │   │   │   │
    │   │   │   ├───net35
    │   │   │   │       Newtonsoft.Json.dll
    │   │   │   │       Newtonsoft.Json.xml
    │   │   │   │
    │   │   │   ├───net40
    │   │   │   │       Newtonsoft.Json.dll
    │   │   │   │       Newtonsoft.Json.xml
    │   │   │   │
    │   │   │   ├───net45
    │   │   │   │       Newtonsoft.Json.dll
    │   │   │   │       Newtonsoft.Json.xml
    │   │   │   │
    │   │   │   ├───netstandard1.0
    │   │   │   │       Newtonsoft.Json.dll
    │   │   │   │       Newtonsoft.Json.xml
    │   │   │   │
    │   │   │   ├───netstandard1.3
    │   │   │   │       Newtonsoft.Json.dll
    │   │   │   │       Newtonsoft.Json.xml
    │   │   │   │
    │   │   │   ├───portable-net40+sl5+win8+wp8+wpa81
    │   │   │   │       Newtonsoft.Json.dll
    │   │   │   │       Newtonsoft.Json.xml
    │   │   │   │
    │   │   │   └───portable-net45+win8+wp8+wpa81
    │   │   │           Newtonsoft.Json.dll
    │   │   │           Newtonsoft.Json.xml
    │   │   │
    │   │   └───tools
    │   │           install.ps1
    │   │
    │   ├───NUnit.3.11.0
    │   │   │   .signature.p7s
    │   │   │   CHANGES.md
    │   │   │   LICENSE.txt
    │   │   │   NOTICES.txt
    │   │   │   NUnit.3.11.0.nupkg
    │   │   │
    │   │   ├───build
    │   │   │       NUnit.props
    │   │   │
    │   │   └───lib
    │   │       ├───net20
    │   │       │       nunit.framework.dll
    │   │       │       nunit.framework.pdb
    │   │       │       nunit.framework.xml
    │   │       │       NUnit.System.Linq.dll
    │   │       │
    │   │       ├───net35
    │   │       │       nunit.framework.dll
    │   │       │       nunit.framework.pdb
    │   │       │       nunit.framework.xml
    │   │       │
    │   │       ├───net40
    │   │       │       nunit.framework.dll
    │   │       │       nunit.framework.pdb
    │   │       │       nunit.framework.xml
    │   │       │
    │   │       ├───net45
    │   │       │       nunit.framework.dll
    │   │       │       nunit.framework.pdb
    │   │       │       nunit.framework.xml
    │   │       │
    │   │       ├───netstandard1.4
    │   │       │       nunit.framework.dll
    │   │       │       nunit.framework.pdb
    │   │       │       nunit.framework.xml
    │   │       │
    │   │       └───netstandard2.0
    │   │               nunit.framework.dll
    │   │               nunit.framework.pdb
    │   │               nunit.framework.xml
    │   │
    │   ├───NUnit3TestAdapter.3.11.0
    │   │   │   .signature.p7s
    │   │   │   LICENSE.txt
    │   │   │   NUnit3TestAdapter.3.11.0.nupkg
    │   │   │
    │   │   └───build
    │   │       ├───net35
    │   │       │       nunit.engine.api.dll
    │   │       │       nunit.engine.dll
    │   │       │       NUnit3.TestAdapter.dll
    │   │       │       NUnit3.TestAdapter.pdb
    │   │       │       NUnit3TestAdapter.props
    │   │       │
    │   │       └───netcoreapp1.0
    │   │               nunit.engine.netstandard.dll
    │   │               NUnit3.TestAdapter.dll
    │   │               NUnit3.TestAdapter.pdb
    │   │               NUnit3TestAdapter.props
    │   │
    │   ├───SpecFlow.2.4.0
    │   │   │   .signature.p7s
    │   │   │   changelog.txt
    │   │   │   LICENSE.txt
    │   │   │   SpecFlow.2.4.0.nupkg
    │   │   │
    │   │   ├───build
    │   │   │       SpecFlow.targets
    │   │   │
    │   │   ├───content
    │   │   │       App.config.transform
    │   │   │
    │   │   ├───lib
    │   │   │   └───net45
    │   │   │           TechTalk.SpecFlow.dll
    │   │   │
    │   │   └───tools
    │   │       │   app.config
    │   │       │   CommandLine.dll
    │   │       │   Gherkin.dll
    │   │       │   Newtonsoft.Json.dll
    │   │       │   plugincompability.config
    │   │       │   specflow.exe
    │   │       │   specflow.exe.config
    │   │       │   System.ValueTuple.dll
    │   │       │   TechTalk.SpecFlow.dll
    │   │       │   TechTalk.SpecFlow.Generator.dll
    │   │       │   TechTalk.SpecFlow.Parser.dll
    │   │       │   TechTalk.SpecFlow.props
    │   │       │   TechTalk.SpecFlow.Reporting.dll
    │   │       │   TechTalk.SpecFlow.targets
    │   │       │   TechTalk.SpecFlow.tasks
    │   │       │   TechTalk.SpecFlow.Utils.dll
    │   │       │
    │   │       └───Licenses
    │   │               BoDi-LICENSE-Apache2.txt
    │   │               Gherkin-LICENSE-MIT.txt
    │   │               Newtonsoft.Json-LICENSE-MIT.md
    │   │               System.ValueTuple-LICENSE-MIT.txt
    │   │
    │   ├───SpecFlow.xUnit.2.4.0
    │   │   │   .signature.p7s
    │   │   │   SpecFlow.xUnit.2.4.0.nupkg
    │   │   │
    │   │   ├───build
    │   │   │       _._
    │   │   │
    │   │   ├───content
    │   │   │       App.config.transform
    │   │   │
    │   │   ├───lib
    │   │   │       _._
    │   │   │
    │   │   └───tools
    │   │           _._
    │   │
    │   ├───SpecRun.Runner.1.8.5
    │   │   │   .signature.p7s
    │   │   │   readme.txt
    │   │   │   SpecRun.Runner.1.8.5.nupkg
    │   │   │
    │   │   ├───build
    │   │   │       SpecRun.Runner.props
    │   │   │
    │   │   ├───docs
    │   │   │       readme.txt
    │   │   │       Sample.runsettings
    │   │   │
    │   │   ├───templates
    │   │   │       CucumberJson.cshtml
    │   │   │       ReportTemplate.cshtml
    │   │   │       ReportTemplate_Features.cshtml
    │   │   │       ReportTemplate_Json.cshtml
    │   │   │       ReportTemplate_Xml.cshtml
    │   │   │       SpecRunTestProfile.xsd
    │   │   │       SpecRunTestProfile_2011_09.xsd
    │   │   │
    │   │   └───tools
    │   │       │   FSharp.Core.dll
    │   │       │   Gherkin.dll
    │   │       │   Microsoft.Data.Services.Client.dll
    │   │       │   Microsoft.Web.Publishing.Tasks.dll
    │   │       │   NConsoler.dll
    │   │       │   Newtonsoft.Json.dll
    │   │       │   RazorEngine.dll
    │   │       │   RestSharp.dll
    │   │       │   SpecRun.exe
    │   │       │   SpecRun.exe.config
    │   │       │   SpecRunTestProfile.xsd
    │   │       │   SpecRunTestProfile_2011_09.xsd
    │   │       │   System.Web.Razor.dll
    │   │       │   TechTalk.SpecRun.Common.dll
    │   │       │   TechTalk.SpecRun.dll
    │   │       │   TechTalk.SpecRun.Framework.dll
    │   │       │   TechTalk.SpecRun.Framework.dll.config
    │   │       │   TechTalk.SpecRun.Framework.Executor.anycpu.clr20.exe
    │   │       │   TechTalk.SpecRun.Framework.Executor.anycpu.clr20.exe.config
    │   │       │   TechTalk.SpecRun.Framework.Executor.anycpu.clr40.exe
    │   │       │   TechTalk.SpecRun.Framework.Executor.anycpu.clr40.exe.config
    │   │       │   TechTalk.SpecRun.Framework.Executor.dll
    │   │       │   TechTalk.SpecRun.Framework.Executor.dll.config
    │   │       │   TechTalk.SpecRun.Framework.Executor.x86.clr20.exe
    │   │       │   TechTalk.SpecRun.Framework.Executor.x86.clr20.exe.config
    │   │       │   TechTalk.SpecRun.Framework.Executor.x86.clr40.exe
    │   │       │   TechTalk.SpecRun.Framework.Executor.x86.clr40.exe.config
    │   │       │   TechTalk.SpecRun.Framework.Interfaces.dll
    │   │       │   TechTalk.SpecRun.Framework.Utils.dll
    │   │       │   TechTalk.SpecRun.Server.CommandClient.dll
    │   │       │   TechTalk.SpecRun.Server.Commands.dll
    │   │       │   TechTalk.SpecRun.Server.ReadModelClient.dll
    │   │       │   TechTalk.SpecRun.VisualStudio.TestAdapter.dll
    │   │       │   TechTalk.SpecRun.VisualStudio.TestAdapter.dll.config
    │   │       │
    │   │       └───server
    │   │               Castle.Core.dll
    │   │               Castle.Windsor.dll
    │   │               EntityFramework.dll
    │   │               Microsoft.ApplicationServer.Common.dll
    │   │               Microsoft.ApplicationServer.Http.dll
    │   │               Microsoft.ApplicationServer.HttpEnhancements.dll
    │   │               Microsoft.ApplicationServer.Serialization.dll
    │   │               Microsoft.ApplicationServer.ServiceModel.dll
    │   │               Microsoft.Net.Http.dll
    │   │               Microsoft.QueryComposition.dll
    │   │               Microsoft.Runtime.Serialization.Json.dll
    │   │               Microsoft.ServiceModel.Web.jQuery.dll
    │   │               NConsoler.dll
    │   │               Ncqrs.CommandService.Contracts.dll
    │   │               Ncqrs.CommandService.dll
    │   │               Ncqrs.Config.Windsor.dll
    │   │               Ncqrs.dll
    │   │               Ncqrs.EventBus.dll
    │   │               Ncqrs.Eventing.Sourcing.Snapshotting.DynamicSnapshot.dll
    │   │               Newtonsoft.Json.dll
    │   │               NLog.dll
    │   │               SpecRun.Server.exe
    │   │               SpecRun.Server.exe.config
    │   │               TechTalk.SpecRun.Common.dll
    │   │               TechTalk.SpecRun.Server.Commands.dll
    │   │               TechTalk.SpecRun.Server.Model.dll
    │   │               TechTalk.SpecRun.Server.Model.dll.config
    │   │               TechTalk.SpecRun.Server.Service.exe
    │   │               TechTalk.SpecRun.Server.Service.exe.config
    │   │
    │   ├───SpecRun.SpecFlow.1.8.5
    │   │       .signature.p7s
    │   │       SpecRun.SpecFlow.1.8.5.nupkg
    │   │
    │   ├───SpecRun.SpecFlow.2-4-0.1.8.5
    │   │   │   .signature.p7s
    │   │   │   readme.txt
    │   │   │   SpecRun.SpecFlow.2-4-0.1.8.5.nupkg
    │   │   │
    │   │   ├───build
    │   │   │       SpecRun.SpecFlow.2-4-0.targets
    │   │   │
    │   │   ├───content
    │   │   │       App.config.transform
    │   │   │       Default.srprofile.pp
    │   │   │       runtests.cmd.pp
    │   │   │       SpecRunTestProfile.xsd
    │   │   │       SpecRunTestProfile_2011_09.xsd
    │   │   │
    │   │   └───lib
    │   │       └───net45
    │   │               SpecRun.SpecFlowPlugin.dll
    │   │               TechTalk.SpecRun.Common.dll
    │   │               TechTalk.SpecRun.dll
    │   │
    │   ├───System.ValueTuple.4.3.0
    │   │   │   .signature.p7s
    │   │   │   dotnet_library_license.txt
    │   │   │   System.ValueTuple.4.3.0.nupkg
    │   │   │   ThirdPartyNotices.txt
    │   │   │
    │   │   └───lib
    │   │       ├───netstandard1.0
    │   │       │       .xml
    │   │       │       System.ValueTuple.dll
    │   │       │
    │   │       └───portable-net40+sl4+win8+wp8
    │   │               .xml
    │   │               System.ValueTuple.dll
    │   │
    │   ├───xunit.2.0.0
    │   │       .signature.p7s
    │   │       xunit.2.0.0.nupkg
    │   │
    │   ├───xunit.abstractions.2.0.0
    │   │   │   .signature.p7s
    │   │   │   xunit.abstractions.2.0.0.nupkg
    │   │   │
    │   │   └───lib
    │   │       ├───net35
    │   │       │       xunit.abstractions.dll
    │   │       │       xunit.abstractions.xml
    │   │       │
    │   │       └───portable-net45+win+wpa81+wp80+monotouch+monoandroid+Xamarin.iOS
    │   │               xunit.abstractions.dll
    │   │               xunit.abstractions.xml
    │   │
    │   ├───xunit.assert.2.0.0
    │   │   │   .signature.p7s
    │   │   │   xunit.assert.2.0.0.nupkg
    │   │   │
    │   │   └───lib
    │   │       └───portable-net45+win+wpa81+wp80+monotouch+monoandroid+Xamarin.iOS
    │   │               xunit.assert.dll
    │   │               xunit.assert.pdb
    │   │               xunit.assert.xml
    │   │
    │   ├───xunit.core.2.0.0
    │   │   │   .signature.p7s
    │   │   │   xunit.core.2.0.0.nupkg
    │   │   │
    │   │   └───build
    │   │       ├───monoandroid
    │   │       │       xunit.core.props
    │   │       │       xunit.execution.MonoAndroid.dll
    │   │       │
    │   │       ├───monotouch
    │   │       │       xunit.core.props
    │   │       │       xunit.execution.MonoTouch.dll
    │   │       │
    │   │       ├───portable-net45+win+wpa81+wp80+monotouch+monoandroid+Xamarin.iOS
    │   │       │       xunit.core.props
    │   │       │
    │   │       ├───portable-win81+wpa81
    │   │       │       xunit.core.props
    │   │       │       xunit.core.targets
    │   │       │       xunit.execution.universal.dll
    │   │       │       xunit.execution.universal.pri
    │   │       │
    │   │       ├───win8
    │   │       │       xunit.core.props
    │   │       │       xunit.core.targets
    │   │       │       xunit.execution.win8.dll
    │   │       │
    │   │       ├───wp8
    │   │       │       xunit.core.props
    │   │       │       xunit.core.targets
    │   │       │       xunit.execution.wp8.dll
    │   │       │
    │   │       ├───Xamarin.iOS
    │   │       │       xunit.core.props
    │   │       │       xunit.execution.iOS-Universal.dll
    │   │       │
    │   │       └───_Desktop
    │   │               xunit.execution.desktop.dll
    │   │
    │   └───xunit.extensibility.core.2.0.0
    │       │   .signature.p7s
    │       │   xunit.extensibility.core.2.0.0.nupkg
    │       │
    │       └───lib
    │           └───portable-net45+win+wpa81+wp80+monotouch+monoandroid+Xamarin.iOS
    │                   xunit.core.dll
    │                   xunit.core.dll.tdnet
    │                   xunit.core.pdb
    │                   xunit.core.xml
    │                   xunit.runner.tdnet.dll
    │                   xunit.runner.utility.desktop.dll
    │
    └───TestResults
            HotelBooking.Specs_HotelBooking.Specs_2018-11-06T141144.html
            HotelBooking.Specs_HotelBooking.Specs_2018-11-06T141144.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-06T141204.html
            HotelBooking.Specs_HotelBooking.Specs_2018-11-06T141204.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-06T141308.html
            HotelBooking.Specs_HotelBooking.Specs_2018-11-06T141308.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-06T141428.html
            HotelBooking.Specs_HotelBooking.Specs_2018-11-06T141428.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-06T141524.html
            HotelBooking.Specs_HotelBooking.Specs_2018-11-06T141524.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-06T141604.html
            HotelBooking.Specs_HotelBooking.Specs_2018-11-06T141604.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-06T175554.html
            HotelBooking.Specs_HotelBooking.Specs_2018-11-06T175554.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-06T175640.html
            HotelBooking.Specs_HotelBooking.Specs_2018-11-06T175640.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-06T175715.html
            HotelBooking.Specs_HotelBooking.Specs_2018-11-06T175715.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T144836.html
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T144836.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T144859.html
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T144859.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T145215.html
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T145215.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T145249.html
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T145249.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T145330.html
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T145330.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T145440.html
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T145440.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T145547.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T145649.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T145920.html
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T145920.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T145947.html
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T145947.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T150057.html
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T150057.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T150121.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T150233.html
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T150233.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T150338.html
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T150338.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T150355.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T150501.html
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T150501.log
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T150655.html
            HotelBooking.Specs_HotelBooking.Specs_2018-11-13T150655.log
```
