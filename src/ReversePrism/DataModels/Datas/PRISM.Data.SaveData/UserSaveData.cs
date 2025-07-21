using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UserId                                   ModelPrimitiveType string string string String
    // 018 UserSecret                               ModelPrimitiveType string string string String
    // 020 UserName                                 ModelPrimitiveType string string string String
    // 028 LicenseLastUpdate                        ModelPrimitiveType long long long Int64
    // 030 ServerData                               ModelClassType LoginServerData LoginServerData LoginServerData Pointer
    // 038 TutorialFinished                         ModelPrimitiveType bool bool bool Bool
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

            value.UserId                                    = GetString(new IntPtr(p + 0x010)); // 0x10 UserId                      ( ModelPrimitiveType string string string String )
            value.UserSecret                                = GetString(new IntPtr(p + 0x018)); // 0x18 UserSecret                  ( ModelPrimitiveType string string string String )
            value.UserName                                  = GetString(new IntPtr(p + 0x020)); // 0x20 UserName                    ( ModelPrimitiveType string string string String )
            value.LicenseLastUpdate                         = GetInt64(new IntPtr(p + 0x028)); // 0x28 LicenseLastUpdate           ( ModelPrimitiveType long long long Int64 )
            value.ServerData                                = GetObject<LoginServerData>(new IntPtr(p + 0x030), ReversePrism.DataModels.LoginServerData.FromPointer); // 0x30 ServerData                  ( ModelClassType LoginServerData LoginServerData LoginServerData Pointer )
            value.TutorialFinished                          = GetBool(new IntPtr(p + 0x038)); // 0x38 TutorialFinished            ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
