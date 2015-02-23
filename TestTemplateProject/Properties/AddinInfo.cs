using System;
using Mono.Addins;
using Mono.Addins.Description;

[assembly:Addin (
	"TestTemplateProject", 
	Namespace = "TestTemplateProject",
	Version = "1.0"
)]

[assembly:AddinName ("TestTemplateProject")]
[assembly:AddinCategory ("TestTemplateProject")]
[assembly:AddinDescription ("TestTemplateProject")]
[assembly:AddinAuthor ("john")]

[assembly:AddinDependency ("::MonoDevelop.Core", MonoDevelop.BuildInfo.Version)]
[assembly:AddinDependency ("::MonoDevelop.Ide", MonoDevelop.BuildInfo.Version)]


