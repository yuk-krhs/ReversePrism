using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UserId                                   0001866722E0 ModelPrimitiveType string string string String
    // 018 UserSecret                               0001866722E0 ModelPrimitiveType string string string String
    // 020 UserName                                 0001866722E0 ModelPrimitiveType string string string String
    // 028 LicenseLastUpdate                        0001865F7E40 ModelPrimitiveType long long long Int64
    // 030 ServerData                               0001865BBFC0 ModelClassType LoginServerData LoginServerData LoginServerData Pointer
    // 038 TutorialFinished                         000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class UserSaveData : DataModel
    {
        public string                                   UserId                                  { get; set; }
        public string                                   UserSecret                              { get; set; }
        public string                                   UserName                                { get; set; }
        public long                                     LicenseLastUpdate                       { get; set; }
        public LoginServerData?                         ServerData                              { get; set; }
        public bool                                     TutorialFinished                        { get; set; }

        public static UserSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UserSaveData() { Pointer= p0 };

            value.UserId                                    = GetString(new IntPtr(p + 0x010)); // 0246659C0548 0x10 UserId                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.UserSecret                                = GetString(new IntPtr(p + 0x018)); // 0246659C0568 0x18 UserSecret                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.UserName                                  = GetString(new IntPtr(p + 0x020)); // 0246659C0588 0x20 UserName                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.LicenseLastUpdate                         = GetInt64(new IntPtr(p + 0x028)); // 0246659C05A8 0x28 LicenseLastUpdate           ( 0001865F7E40 ModelPrimitiveType long long long Int64 )
            value.ServerData                                = GetObject<LoginServerData>(new IntPtr(p + 0x030), ReversePrism.DataModels.LoginServerData.FromPointer); // 0246659C05C8 0x30 ServerData                  ( 0001865BBFC0 ModelClassType LoginServerData LoginServerData LoginServerData Pointer )
            value.TutorialFinished                          = GetBool(new IntPtr(p + 0x038)); // 0246659C05E8 0x38 TutorialFinished            ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
