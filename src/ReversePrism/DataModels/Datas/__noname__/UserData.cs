using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 platformUserAccountHandle                Nullable`1<InputUserAccountHandle> IL2CPP_TYPE_GENERICINST
    // 028 PlatformUserAccountName                  ModelPrimitiveType string string string String
    // 030 PlatformUserAccountId                    ModelPrimitiveType string string string String
    // 038 DeviceCount                              ModelPrimitiveType int int int Int32
    // 03C DeviceStartIndex                         ModelPrimitiveType int int int Int32
    // 040 Actions                                  ModelClassType IInputActionCollection IInputActionCollection IInputActionCollection Pointer
    // 048 controlScheme                            Nullable`1<InputControlScheme> IL2CPP_TYPE_GENERICINST
    // 068 ControlSchemeMatch                       ModelEnumType MatchResult MatchResult MatchResult Int32
    // 0B8 LostDeviceCount                          ModelPrimitiveType int int int Int32
    // 0BC LostDeviceStartIndex                     ModelPrimitiveType int int int Int32
    // 0C0 Flags                                    ModelEnumType UserFlags UserFlags UserFlags Int32
    public partial class UserData : DataModel
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
            var value   = new UserData() { Pointer= p0 };

            value.PlatformUserAccountName                   = GetString(new IntPtr(p + 0x028)); // 0x28 PlatformUserAccountName     ( ModelPrimitiveType string string string String )
            value.PlatformUserAccountId                     = GetString(new IntPtr(p + 0x030)); // 0x30 PlatformUserAccountId       ( ModelPrimitiveType string string string String )
            value.DeviceCount                               = GetInt32(new IntPtr(p + 0x038)); // 0x38 DeviceCount                 ( ModelPrimitiveType int int int Int32 )
            value.DeviceStartIndex                          = GetInt32(new IntPtr(p + 0x03C)); // 0x3C DeviceStartIndex            ( ModelPrimitiveType int int int Int32 )
            value.Actions                                   = GetObject<IInputActionCollection>(new IntPtr(p + 0x040), ReversePrism.DataModels.IInputActionCollection.FromPointer); // 0x40 Actions                     ( ModelClassType IInputActionCollection IInputActionCollection IInputActionCollection Pointer )
            value.ControlSchemeMatch                        = (MatchResult)GetInt32(new IntPtr(p + 0x068)); // 0x68 ControlSchemeMatch          ( ModelEnumType MatchResult MatchResult MatchResult Int32 )
            value.LostDeviceCount                           = GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 LostDeviceCount             ( ModelPrimitiveType int int int Int32 )
            value.LostDeviceStartIndex                      = GetInt32(new IntPtr(p + 0x0BC)); // 0xBC LostDeviceStartIndex        ( ModelPrimitiveType int int int Int32 )
            value.Flags                                     = (UserFlags)GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 Flags                       ( ModelEnumType UserFlags UserFlags UserFlags Int32 )

            return value;
        }
    }
}
