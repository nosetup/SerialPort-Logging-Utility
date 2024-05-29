using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("SerialPort Logging")]
[assembly: AssemblyDescription(
#if DEBUG
                                "***** DEBUG BUILD *****\r\n" + //Give notice this is a debug build on about page
#endif
                                "Serial Port Logging\r\n" +
                                "Hex logging utility with automated scripting.\r\n" +
                                " \r\n \r\n \r\n \r\n" +
                                "Download at: \r\n" +
                                "NoSetup : https://github.com/nosetup"
                                )]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("SerialPort Terminal")]
[assembly: AssemblyCopyright("Copyright ©  2024")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM componenets.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("BF9233E8-4E7F-44E1-9CD3-220ACAF1A3C0")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
[assembly: AssemblyVersion("1.2.1.*")]
[assembly: AssemblyFileVersion("1.0.0.0")]
