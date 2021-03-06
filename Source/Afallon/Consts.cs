// ReSharper disable InconsistentNaming

static class Consts
{
    public const string Version = "4.0.0.0";
    public const string Company = "The GreenBox Development";
    public const string Product = "The GreenBox Development Presentation Framework Implementation";
    public const string Copyright = "� The GreenBox Development and Various Contributors";

#if NET_2_1
    // Versions of .NET Framework for Silverlight 4.0
	public const string FxVersion = "2.0.5.0";
	public const string VsVersion = "9.0.0.0"; // unused, but needed for compilation
	public const string FxFileVersion = "4.0.50524.0";
	public const string VsFileVersion = "9.0.50727.42"; // unused, but needed for compilation
#elif NET_4_5
    public const string FxVersion = "4.0.0.0";
    public const string FxFileVersion = "4.0.30319.17020";

    public const string VsVersion = "0.0.0.0"; // Useless ?
    public const string VsFileVersion = "11.0.0.0";
#elif NET_4_0
	public const string FxVersion = "4.0.0.0";
	public const string FxFileVersion = "4.0.30319.1";

	public const string VsVersion = "0.0.0.0"; // Useless ?
	public const string VsFileVersion = "10.0.0.0";
#elif NET_3_5
    // Versions of .NET Framework 3.5 RTM
	public const string FxVersion = "3.5.0.0";
	public const string FxFileVersion = "3.5.21022.8";

	public const string VsVersion = "0.0.0.0"; // Useless ?
#elif NET_3_0
	public const string FxVersion = "3.0.0.0";
	public const string VsVersion = "8.0.0.0";
	public const string FxFileVersion = "3.0.4506.648";
	public const string VsFileVersion = "6.0.6001.17014";
#elif NET_2_0
    // Versions of .NET Framework 2.0 RTM
	public const string FxVersion = "2.0.0.0";
	public const string VsVersion = "8.0.0.0";
	public const string FxFileVersion = "2.0.50727.1433";
	public const string VsFileVersion = "8.0.50727.1433";
#elif NET_1_1
#error Profile NET_1_1 is not supported.
#elif NET_1_0
#error Profile NET_1_0 is not supported.
#else
#error No profile symbols defined.
#endif

#if MOBILE
	const string PublicKeyToken = "7cec85d7bea7798e";
#else
    private const string PublicKeyToken = "b77a5c561934e089";
#endif

    //
    // Use these assembly name constants to make code more maintainable.
    //

    public const string AssemblyI18N =
        "I18N, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=0738eb9f132ed756";

    public const string AssemblyMicrosoft_VisualStudio =
        "Microsoft.VisualStudio, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

    public const string AssemblyMicrosoft_VisualStudio_Web =
        "Microsoft.VisualStudio.Web, Version=" + VsVersion + ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

    public const string AssemblyMicrosoft_VSDesigner =
        "Microsoft.VSDesigner, Version=" + VsVersion + ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

    public const string AssemblyMono_Http =
        "Mono.Http, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=0738eb9f132ed756";

    public const string AssemblyMono_Posix =
        "Mono.Posix, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=0738eb9f132ed756";

    public const string AssemblyMono_Security =
        "Mono.Security, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=0738eb9f132ed756";

    public const string AssemblyMono_Messaging_RabbitMQ =
        "Mono.Messaging.RabbitMQ, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=0738eb9f132ed756";

    public const string AssemblyCorlib =
        "mscorlib, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=" + PublicKeyToken;

    public const string AssemblySystem =
        "System, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b77a5c561934e089";

    public const string AssemblySystem_Data =
        "System.Data, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b77a5c561934e089";

    public const string AssemblySystem_Design =
        "System.Design, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

    public const string AssemblySystem_DirectoryServices =
        "System.DirectoryServices, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

    public const string AssemblySystem_Drawing =
        "System.Drawing, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

    public const string AssemblySystem_Drawing_Design =
        "System.Drawing.Design, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

    public const string AssemblySystem_Messaging =
        "System.Messaging, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

    public const string AssemblySystem_Security =
        "System.Security, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

    public const string AssemblySystem_ServiceProcess =
        "System.ServiceProcess, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

    public const string AssemblySystem_Web =
        "System.Web, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

    public const string AssemblySystem_Windows_Forms =
        "System.Windows.Forms, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b77a5c561934e089";

#if NET_4_0
	public const string AssemblySystem_2_0 = "System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
	public const string AssemblySystemCore_3_5 = "System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
	public const string AssemblySystem_Core = "System.Core, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b77a5c561934e089";
	public const string WindowsBase_3_0 = "WindowsBase, Version=3.0.0.0, PublicKeyToken=31bf3856ad364e35";
	public const string AssemblyWindowsBase = "WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";
	public const string AssemblyPresentationCore_3_5 = "PresentationCore, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";
	public const string AssemblyPresentationFramework_3_5 = "PresentationFramework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";
#elif NET_2_1
	public const string AssemblySystem_Core = "System.Core, Version=" + FxVersion + ", Culture=neutral, PublicKeyToken=b77a5c561934e089";
#elif NET_2_0
	public const string AssemblySystem_Core = "System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
#endif
}
