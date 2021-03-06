#define MyAppName "RolePlay Notes"
#define MyAppVersion "0.8.1.0"
#define MyAppPublisher "EnergyCube"
#define MyAppURL "https://energycube.fr"
#define MyAppExeName "RolePlayNotes.exe"

; Set your server ip / domain
#define ServerIpOrDomain ""

; Define whether your server supports SSL (HTTPS)
; This is highly recommended, it will secure all communications.
; including user authentication and data sent/transmitted.
; MUST be true or false
#define SupportSSL ""

[Setup]
; (You need to generate a new GUID, click Tools | Generate GUID inside the IDE.)
; Must look like this : AppId={{X-X-X-X-X}
AppId={
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={localappdata}\Programs\{#MyAppName}
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
LicenseFile=../LICENSE
OutputDir=/
OutputBaseFilename=setup
Compression=lzma2/max
PrivilegesRequired=lowest
UsePreviousAppDir=yes
SolidCompression=yes
SetupIconFile=../client/related/RPN_Sharp.ico  
UninstallDisplayIcon={uninstallexe}
WizardSmallImageFile=../client/related/RPN_Sharp.bmp
; Min Windows XP SP2 (Note SP 2 for x86_64, SP 3 for x86)
MinVersion=0,5.1sp2

[INI] 
Filename: "{app}\config.ini"; Section: "Login"; Key: "server"; String: "{#ServerIpOrDomain}"
Filename: "{app}\config.ini"; Section: "Login"; Key: "ssl"; String: "{#SupportSSL}"

[UninstallDelete]
Type: files; Name: "{app}\config.ini"; 
       
[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}";
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "../client/RolePlay Notes/bin/Release/RolePlayNotes.exe"; DestDir: "{app}"; Flags: ignoreversion
; Uncomment this if you want to include a pre-defined config (with a pre-defined theme color for ex.)
; Source: ../client/RolePlay Notes/bin/Release/config.ini"; DestDir: "{app}"; Flags: ignoreversion
Source: "../client/RolePlay Notes/bin/Release/FlatUI.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "../client/RolePlay Notes/bin/Release/Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "../client/RolePlay Notes/bin/Release/RolePlayNotes.exe"; DestDir: "{app}"; Flags: ignoreversion
; Uncomment this if you want to provide the icon in the program folder
; Source: "../client/related/RPN_Sharp.ico"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
[Code]
function IsDotNetDetected(version: string; service: cardinal): boolean;
// Indicates whether the specified version and service pack of the .NET Framework is installed.
//
// version -- Specify one of these strings for the required .NET Framework version:
//    'v1.1'          .NET Framework 1.1
//    'v2.0'          .NET Framework 2.0
//    'v3.0'          .NET Framework 3.0
//    'v3.5'          .NET Framework 3.5
//    'v4\Client'     .NET Framework 4.0 Client Profile
//    'v4\Full'       .NET Framework 4.0 Full Installation
//    'v4.5'          .NET Framework 4.5
//    'v4.5.1'        .NET Framework 4.5.1
//    'v4.5.2'        .NET Framework 4.5.2
//    'v4.6'          .NET Framework 4.6
//    'v4.6.1'        .NET Framework 4.6.1
//    'v4.6.2'        .NET Framework 4.6.2
//    'v4.7'          .NET Framework 4.7
//    'v4.7.1'        .NET Framework 4.7.1
//    'v4.7.2'        .NET Framework 4.7.2
//    'v4.8'          .NET Framework 4.8
//
// service -- Specify any non-negative integer for the required service pack level:
//    0               No service packs required
//    1, 2, etc.      Service pack 1, 2, etc. required
var
    key, versionKey: string;
    install, release, serviceCount, versionRelease: cardinal;
    success: boolean;
begin
    versionKey := version;
    versionRelease := 0;

    // .NET 1.1 and 2.0 embed release number in version key
    if version = 'v1.1' then begin
        versionKey := 'v1.1.4322';
    end else if version = 'v2.0' then begin
        versionKey := 'v2.0.50727';
    end

    // .NET 4.5 and newer install as update to .NET 4.0 Full
    else if Pos('v4.', version) = 1 then begin
        versionKey := 'v4\Full';
        case version of
          'v4.5':   versionRelease := 378389;
          'v4.5.1': versionRelease := 378675; // 378758 on Windows 8 and older
          'v4.5.2': versionRelease := 379893;
          'v4.6':   versionRelease := 393295; // 393297 on Windows 8.1 and older
          'v4.6.1': versionRelease := 394254; // 394271 before Win10 November Update
          'v4.6.2': versionRelease := 394802; // 394806 before Win10 Anniversary Update
          'v4.7':   versionRelease := 460798; // 460805 before Win10 Creators Update
          'v4.7.1': versionRelease := 461308; // 461310 before Win10 Fall Creators Update
          'v4.7.2': versionRelease := 461808; // 461814 before Win10 April 2018 Update
          'v4.8':   versionRelease := 528040; // 528049 before Win10 May 2019 Update
        end;
    end;

    // installation key group for all .NET versions
    key := 'SOFTWARE\Microsoft\NET Framework Setup\NDP\' + versionKey;

    // .NET 3.0 uses value InstallSuccess in subkey Setup
    if Pos('v3.0', version) = 1 then begin
        success := RegQueryDWordValue(HKLM, key + '\Setup', 'InstallSuccess', install);
    end else begin
        success := RegQueryDWordValue(HKLM, key, 'Install', install);
    end;

    // .NET 4.0 and newer use value Servicing instead of SP
    if Pos('v4', version) = 1 then begin
        success := success and RegQueryDWordValue(HKLM, key, 'Servicing', serviceCount);
    end else begin
        success := success and RegQueryDWordValue(HKLM, key, 'SP', serviceCount);
    end;

    // .NET 4.5 and newer use additional value Release
    if versionRelease > 0 then begin
        success := success and RegQueryDWordValue(HKLM, key, 'Release', release);
        success := success and (release >= versionRelease);
    end;

    result := success and (install = 1) and (serviceCount >= service);
end;


function InitializeSetup(): Boolean;
begin
    if not IsDotNetDetected('v4.0', 0) then begin
        MsgBox('{#MyAppName} requires Microsoft .NET Framework >= 4.0 !'#13#13
            'Please use Windows Update to install this version,'#13
            'Or download and install it manually from dotnet.microsoft.com,'#13
            'and then re-run the {#MyAppName} setup program.', mbInformation, MB_OK);
    end;
    result := true;
end;
