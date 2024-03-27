using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public enum RuntimePlatform
    {
        OSXEditor,
        OSXPlayer,
        WindowsPlayer,
        OSXWebPlayer,
        OSXDashboardPlayer,
        WindowsWebPlayer,
        WindowsEditor,
        IPhonePlayer,
        XBOX360,
        PS3,
        Android,
        NaCl,
        FlashPlayer,
        LinuxPlayer,
        LinuxEditor,
        WebGLPlayer,
        MetroPlayerX86,
        WSAPlayerX86,
        MetroPlayerX64,
        WSAPlayerX64,
        MetroPlayerARM,
        WSAPlayerARM,
        WP8Player,
        BlackBerryPlayer,
        TizenPlayer,
        PSP2,
        PS4,
        PSM,
        XboxOne,
        SamsungTVPlayer,
        WiiU,
        tvOS,
        Switch,
        Lumin,
        Stadia,
        CloudRendering,
        GameCoreScarlett,
        GameCoreXboxSeries,
        GameCoreXboxOne,
        PS5,
        EmbeddedLinuxArm64,
        EmbeddedLinuxArm32,
        EmbeddedLinuxX64,
        EmbeddedLinuxX86,
        LinuxServer,
        WindowsServer,
        OSXServer,
        QNXArm32,
        QNXArm64,
        QNXX64,
        QNXX86,
        VisionOS,
    }
}
