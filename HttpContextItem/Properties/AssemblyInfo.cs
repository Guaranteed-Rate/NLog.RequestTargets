using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("HttpContextItem")]
[assembly: AssemblyDescription("An NLog layout renderer that allows items in the current HTTP context to be added to a log layout.  " + 
                               "Example: ${http-context-item:X-RequestId} will log the contents of HttpContext.Current.Items[\"X-Request-Id\"]")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Guaranteed Rate")]
[assembly: AssemblyProduct("HttpContextItem")]
[assembly: AssemblyCopyright("Copyright © HP 2015")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("dbc5d816-2af5-4490-96a4-63b095f37041")]

[assembly: AssemblyVersion("1.0.0")]
[assembly: AssemblyFileVersion("1.0.0")]
