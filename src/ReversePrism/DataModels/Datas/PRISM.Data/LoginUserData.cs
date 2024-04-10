using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 BackupPrefsKey                           string IL2CPP_TYPE_STRING
    // 020 UserId                                   000186671910 ModelPrimitiveType string string string String
    // 028 UserSecret                               000186671910 ModelPrimitiveType string string string String
    // 030 LoginToken                               000186671910 ModelPrimitiveType string string string String
    // 038 TutorialFinished                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 SearchUserId                             000186671910 ModelPrimitiveType string string string String
    // 048 UserName                                 000186671910 ModelPrimitiveType string string string String
    // 050 DisplayName                              000186671910 ModelPrimitiveType string string string String
    // 058 LicenseLastUpdate                        0001865F7700 ModelPrimitiveType long long long Int64
    public partial class LoginUserData : DataModel
    {
        public string                                   UserId                                  { get; set; }
        public string                                   UserSecret                              { get; set; }
        public string                                   LoginToken                              { get; set; }
        public bool                                     TutorialFinished                        { get; set; }
        public string                                   SearchUserId                            { get; set; }
        public string                                   UserName                                { get; set; }
        public string                                   DisplayName                             { get; set; }
        public long                                     LicenseLastUpdate                       { get; set; }

        public static LoginUserData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoginUserData() { Pointer= p0 };

            value.UserId                                    = GetString(new IntPtr(p + 0x020)); // 0245A3A7EBB8 0x20 UserId                      ( 000186671910 ModelPrimitiveType string string string String )
            value.UserSecret                                = GetString(new IntPtr(p + 0x028)); // 0245A3A7EBD8 0x28 UserSecret                  ( 000186671910 ModelPrimitiveType string string string String )
            value.LoginToken                                = GetString(new IntPtr(p + 0x030)); // 0245A3A7EBF8 0x30 LoginToken                  ( 000186671910 ModelPrimitiveType string string string String )
            value.TutorialFinished                          = GetBool(new IntPtr(p + 0x038)); // 0245A3A7EC18 0x38 TutorialFinished            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SearchUserId                              = GetString(new IntPtr(p + 0x040)); // 0245A3A7EC38 0x40 SearchUserId                ( 000186671910 ModelPrimitiveType string string string String )
            value.UserName                                  = GetString(new IntPtr(p + 0x048)); // 0245A3A7EC58 0x48 UserName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x050)); // 0245A3A7EC78 0x50 DisplayName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.LicenseLastUpdate                         = GetInt64(new IntPtr(p + 0x058)); // 0245A3A7EC98 0x58 LicenseLastUpdate           ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
