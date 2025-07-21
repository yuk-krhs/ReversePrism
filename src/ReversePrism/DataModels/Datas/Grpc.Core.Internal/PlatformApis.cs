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
    // 010 ClrVersion                               ModelPrimitiveType string string string String
    // 018 UnityApplicationPlatform                 ModelPrimitiveType string string string String
    // 020 IsXamarin                                ModelPrimitiveType bool bool bool Bool
    // 021 IsXamarinIOS                             ModelPrimitiveType bool bool bool Bool
    // 022 IsXamarinAndroid                         ModelPrimitiveType bool bool bool Bool
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

            value.ClrVersion                                = GetString(new IntPtr(p + 0x010)); // 0x10 ClrVersion                  ( ModelPrimitiveType string string string String )
            value.UnityApplicationPlatform                  = GetString(new IntPtr(p + 0x018)); // 0x18 UnityApplicationPlatform    ( ModelPrimitiveType string string string String )
            value.IsXamarin                                 = GetBool(new IntPtr(p + 0x020)); // 0x20 IsXamarin                   ( ModelPrimitiveType bool bool bool Bool )
            value.IsXamarinIOS                              = GetBool(new IntPtr(p + 0x021)); // 0x21 IsXamarinIOS                ( ModelPrimitiveType bool bool bool Bool )
            value.IsXamarinAndroid                          = GetBool(new IntPtr(p + 0x022)); // 0x22 IsXamarinAndroid            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
