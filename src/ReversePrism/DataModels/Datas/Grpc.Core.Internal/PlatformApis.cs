using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 UnityEngineAssemblyName                  string IL2CPP_TYPE_STRING
    // 000 UnityEngineApplicationClassName          string IL2CPP_TYPE_STRING
    // 000 UnityIPhonePlayer                        string IL2CPP_TYPE_STRING
    // 000 XamarinAndroidObjectClassName            string IL2CPP_TYPE_STRING
    // 000 XamarinIOSObjectClassName                string IL2CPP_TYPE_STRING
    // 000 isLinux                                  bool IL2CPP_TYPE_BOOLEAN
    // 001 isMacOSX                                 bool IL2CPP_TYPE_BOOLEAN
    // 002 isWindows                                bool IL2CPP_TYPE_BOOLEAN
    // 003 isMono                                   bool IL2CPP_TYPE_BOOLEAN
    // 004 isNet5OrHigher                           bool IL2CPP_TYPE_BOOLEAN
    // 005 isNetCore                                bool IL2CPP_TYPE_BOOLEAN
    // 008 frameworkDescription                     string IL2CPP_TYPE_STRING
    // 010 ClrVersion                               0001866738F0 ModelPrimitiveType string string string String
    // 018 UnityApplicationPlatform                 0001866738F0 ModelPrimitiveType string string string String
    // 020 IsXamarin                                000186596D40 ModelPrimitiveType bool bool bool Bool
    // 021 IsXamarinIOS                             000186596D40 ModelPrimitiveType bool bool bool Bool
    // 022 IsXamarinAndroid                         000186596D40 ModelPrimitiveType bool bool bool Bool
    public partial class PlatformApis : DataModel
    {
        public string                                   ClrVersion                              { get; set; }
        public string                                   UnityApplicationPlatform                { get; set; }
        public bool                                     IsXamarin                               { get; set; }
        public bool                                     IsXamarinIOS                            { get; set; }
        public bool                                     IsXamarinAndroid                        { get; set; }

        public static PlatformApis? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlatformApis() { Pointer= p0 };

            value.ClrVersion                                = GetString(new IntPtr(p + 0x010)); // 0245A40C6510 0x10 ClrVersion                  ( 0001866738F0 ModelPrimitiveType string string string String )
            value.UnityApplicationPlatform                  = GetString(new IntPtr(p + 0x018)); // 0245A40C6530 0x18 UnityApplicationPlatform    ( 0001866738F0 ModelPrimitiveType string string string String )
            value.IsXamarin                                 = GetBool(new IntPtr(p + 0x020)); // 0245A40C6550 0x20 IsXamarin                   ( 000186596D40 ModelPrimitiveType bool bool bool Bool )
            value.IsXamarinIOS                              = GetBool(new IntPtr(p + 0x021)); // 0245A40C6570 0x21 IsXamarinIOS                ( 000186596D40 ModelPrimitiveType bool bool bool Bool )
            value.IsXamarinAndroid                          = GetBool(new IntPtr(p + 0x022)); // 0245A40C6590 0x22 IsXamarinAndroid            ( 000186596D40 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
