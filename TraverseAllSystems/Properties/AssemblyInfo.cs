using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle( "TraverseAllSystems" )]
[assembly: AssemblyDescription("Revit add-In for MEP system traversal")]
[assembly: AssemblyConfiguration( "" )]
[assembly: AssemblyCompany( "Autodesk Inc." )]
[assembly: AssemblyProduct( "TraverseAllSystems Revit C# .NET Add-In" )]
[assembly: AssemblyCopyright("Copyright 2016-2022 (C) Jeremy Tammik, Autodesk Inc.")]
[assembly: AssemblyTrademark( "" )]
[assembly: AssemblyCulture( "" )]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible( false )]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid( "321044f7-b0b2-4b1c-af18-e71a19252be0" )]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
//
// History:
//
// 2016-06-21 2017.0.0.0 initial implementation based on TraverseSystem SDK sample
// 2016-06-21 2017.0.0.1 added desired system predicate, first successful test
// 2016-06-22 2017.0.0.2 implemented visited element dictionary to prevent infinite recursion loop
// 2016-06-22 2017.0.0.3 implemented DumpToJson
// 2016-06-22 2017.0.0.4 implemented shared parameter creation
// 2016-06-22 2017.0.0.5 implemented shared parameter value population
// 2016-06-22 2017.0.0.5 tested and verified graph structure json is written out
// 2016-06-22 2017.0.0.6 renamed json text field to name
// 2016-06-23 2017.0.0.7 implemented storage of top-down system graph in json
// 2016-06-23 2017.0.0.8 automatically create shared parameter if needed, eliminated separate command
// 2016-06-23 2017.0.0.8 wrap json strings in double quotes and validated json output
// 2016-06-23 2017.0.0.9 cleaned up for publication
// 2016-06-23 2017.0.0.10 implemented jstree test file and verified proper tree population
// 2016-06-23 2017.0.0.11 implemented test page, gh-pages, test link, separate test treedata.json, master and gh-pages syncing
// 2016-06-24 2017.0.0.12 added json sample data from rme_advanced_sample_model
// 2016-06-24 2017.0.0.13 removed duplicate root id -1
// 2016-06-24 2017.0.0.14 store entire json graph for all systems on project info instead of separate subgraph on each individual system
// 2016-06-24 2017.0.0.15 before pull request #1 by @ChengZY
// 2016-06-24 2017.0.0.16 integrated pull request #1 by @ChengZY
// 2016-06-25 2017.0.0.17 implemented Options.NodeLabelTag to switch more easily between 'text' and 'name' for node label
// 2016-06-26 2017.0.0.17 split graph into three domain-specific subgraphs
// 2016-06-26 2017.0.0.17 sort each domain specific graph and display full element description
// 2016-06-27 2017.0.0.18 use hash code to generate unique jstree ids for top-level project, mechanical, electrical and piping nodes 
//
[assembly: AssemblyVersion("2017.0.0.19")]
[assembly: AssemblyFileVersion("2017.0.0.19")]
