using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Threading;
using Task = System.Threading.Tasks.Task;
using Microsoft.SqlServer.Management.SqlStudio.Explorer;
using Microsoft.SqlServer.Management.UI.VSIntegration.ObjectExplorer;
using Microsoft.SqlServer.Management.Smo.RegSvrEnum;

namespace SSMSConnect
{
    /// <summary>
    /// This is the class that implements the package exposed by this assembly.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The minimum requirement for a class to be considered a valid package for Visual Studio
    /// is to implement the IVsPackage interface and register itself with the shell.
    /// This package uses the helper classes defined inside the Managed Package Framework (MPF)
    /// to do it: it derives from the Package class that provides the implementation of the
    /// IVsPackage interface and uses the registration attributes defined in the framework to
    /// register itself and its components with the shell. These attributes tell the pkgdef creation
    /// utility what data to put into .pkgdef file.
    /// </para>
    /// <para>
    /// To get loaded into VS, the package must be referred by &lt;Asset Type="Microsoft.VisualStudio.VsPackage" ...&gt; in .vsixmanifest file.
    /// </para>
    /// </remarks>
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [Guid(SSMSConnectPackage.PackageGuidString)]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "pkgdef, VS and vsixmanifest are valid VS terms")]
    [ProvideAutoLoad(VSConstants.UICONTEXT.ShellInitialized_string)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    public sealed class SSMSConnectPackage : AsyncPackage
    {
        /// <summary>
        /// SSMSConnectPackage GUID string.
        /// </summary>
        public const string PackageGuidString = "6a80d5ac-6bb4-434f-b0b2-75c25d61a50e";

        #region Package Members

        public Settings settings = new Settings();

        /// <summary>
        /// Initialization of the package; this method is called right after the package is sited, so this is the place
        /// where you can put all the initialization code that rely on services provided by VisualStudio.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token to monitor for initialization cancellation, which can occur when VS is shutting down.</param>
        /// <param name="progress">A provider for progress updates.</param>
        /// <returns>A task representing the async work of package initialization, or an already completed task if there is none. Do not return null from this method.</returns>
        protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            // When initialized asynchronously, the current thread may be a background thread at this point.
            // Do any initialization that requires the UI thread after switching to the UI thread.
            await this.JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);
            await SSMSConnect.InitializeAsync(this);

            ObjectExplorerService objectExplorerService = null;

            objectExplorerService = (ObjectExplorerService)ServiceProvider.GlobalProvider.GetService(typeof(IObjectExplorerService));

            string currentUserDomain = Environment.UserDomainName;

            settings.Load(ref settings);

            if (settings.connectAtStartup)
            {
                foreach (ServerSettings server in settings.servers)
                {
                    if (((server.userDomain == "") || (server.userDomain == null) || (server.userDomain == currentUserDomain))
                        && (server.serverIsEnabled))
                    {
                        UIConnectionInfo connInfo = new UIConnectionInfo
                        {
                            ServerName = server.serverPath,
                            AuthenticationType = 3,
                            OtherParams = "TrustServerCertificate=True",
                            ServerType = new Guid("8c91a03d-f9b4-46c0-a305-b5dcc79ff907")
                        };

                        objectExplorerService.ConnectToServer(connInfo);
                    }
                }
            }
        }

        #endregion
    }
}
