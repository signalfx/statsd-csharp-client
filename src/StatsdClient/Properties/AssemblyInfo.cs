﻿using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("StatsdClient")]
[assembly: AssemblyDescription("Statsd Client")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("SignalFx")]
[assembly: AssemblyProduct("StatsdClient")]
[assembly: AssemblyCopyright("Copyright ©  2016")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("ecebfa48-5557-4fe6-84a6-c0b1e3ece14c")]

// Set in appveyor.yml (combo of that & the current build number on there).
[assembly: AssemblyVersion("0.0.0.1")]

// Used to get $version$ for nuget (otherwise you end up with 4 parts to the version): http://stackoverflow.com/questions/28194498/nuget-pack-does-not-honor-number-of-digits-on-assembly-version
[assembly: AssemblyInformationalVersionAttribute("0.0.0.1")]

[assembly: AssemblyFileVersion("1.0.0")]
