using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 platformUserAccountHandle                Nullable`1<InputUserAccountHandle> IL2CPP_TYPE_GENERICINST
    // 028 PlatformUserAccountName                  0001866722E0 ModelPrimitiveType string string string String
    // 030 PlatformUserAccountId                    0001866722E0 ModelPrimitiveType string string string String
    // 038 DeviceCount                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 03C DeviceStartIndex                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 040 Actions                                  000186581A90 ModelClassType IInputActionCollection IInputActionCollection IInputActionCollection Pointer
    // 048 controlScheme                            Nullable`1<InputControlScheme> IL2CPP_TYPE_GENERICINST
    // 068 ControlSchemeMatch                       0001866FA540 ModelEnumType MatchResult MatchResult MatchResult Int32
    // 0B8 LostDeviceCount                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 0BC LostDeviceStartIndex                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 0C0 Flags                                    00018663E590 ModelEnumType UserFlags UserFlags UserFlags Int32
    public partial class UserData
    {
        public string                                   PlatformUserAccountName                 { get; set; }
        public string                                   PlatformUserAccountId                   { get; set; }
        public int                                      DeviceCount                             { get; set; }
        public int                                      DeviceStartIndex                        { get; set; }
        public IInputActionCollection?                  Actions                                 { get; set; }
        public MatchResult                              ControlSchemeMatch                      { get; set; }
        public int                                      LostDeviceCount                         { get; set; }
        public int                                      LostDeviceStartIndex                    { get; set; }
        public UserFlags                                Flags                                   { get; set; }

        public static UserData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UserData();

            value.PlatformUserAccountName                   = GetString(new IntPtr(p + 0x028)); // 0270D7787468 0x28 PlatformUserAccountName     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.PlatformUserAccountId                     = GetString(new IntPtr(p + 0x030)); // 0270D7787488 0x30 PlatformUserAccountId       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.DeviceCount                               = GetInt32(new IntPtr(p + 0x038)); // 0270D77874A8 0x38 DeviceCount                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.DeviceStartIndex                          = GetInt32(new IntPtr(p + 0x03C)); // 0270D77874C8 0x3C DeviceStartIndex            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Actions                                   = GetObject<IInputActionCollection>(new IntPtr(p + 0x040), ReversePrism.DataModels.IInputActionCollection.FromPointer); // 0270D77874E8 0x40 Actions                     ( 000186581A90 ModelClassType IInputActionCollection IInputActionCollection IInputActionCollection Pointer )
            value.ControlSchemeMatch                        = (MatchResult)GetInt32(new IntPtr(p + 0x068)); // 0270D7787528 0x68 ControlSchemeMatch          ( 0001866FA540 ModelEnumType MatchResult MatchResult MatchResult Int32 )
            value.LostDeviceCount                           = GetInt32(new IntPtr(p + 0x0B8)); // 0270D7787548 0xB8 LostDeviceCount             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LostDeviceStartIndex                      = GetInt32(new IntPtr(p + 0x0BC)); // 0270D7787568 0xBC LostDeviceStartIndex        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Flags                                     = (UserFlags)GetInt32(new IntPtr(p + 0x0C0)); // 0270D7787588 0xC0 Flags                       ( 00018663E590 ModelEnumType UserFlags UserFlags UserFlags Int32 )

            return value;
        }
    }
}
