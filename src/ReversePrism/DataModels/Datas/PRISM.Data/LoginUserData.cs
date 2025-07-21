using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 BackupPrefsKey                           string IL2CPP_TYPE_STRING
    // 020 UserId                                   ModelPrimitiveType string string string String
    // 028 UserSecret                               ModelPrimitiveType string string string String
    // 030 LoginToken                               ModelPrimitiveType string string string String
    // 038 TutorialFinished                         ModelPrimitiveType bool bool bool Bool
    // 040 SearchUserId                             ModelPrimitiveType string string string String
    // 048 UserName                                 ModelPrimitiveType string string string String
    // 050 DisplayName                              ModelPrimitiveType string string string String
    // 058 LicenseLastUpdate                        ModelPrimitiveType long long long Int64
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

            value.UserId                                    = GetString(new IntPtr(p + 0x020)); // 0x20 UserId                      ( ModelPrimitiveType string string string String )
            value.UserSecret                                = GetString(new IntPtr(p + 0x028)); // 0x28 UserSecret                  ( ModelPrimitiveType string string string String )
            value.LoginToken                                = GetString(new IntPtr(p + 0x030)); // 0x30 LoginToken                  ( ModelPrimitiveType string string string String )
            value.TutorialFinished                          = GetBool(new IntPtr(p + 0x038)); // 0x38 TutorialFinished            ( ModelPrimitiveType bool bool bool Bool )
            value.SearchUserId                              = GetString(new IntPtr(p + 0x040)); // 0x40 SearchUserId                ( ModelPrimitiveType string string string String )
            value.UserName                                  = GetString(new IntPtr(p + 0x048)); // 0x48 UserName                    ( ModelPrimitiveType string string string String )
            value.DisplayName                               = GetString(new IntPtr(p + 0x050)); // 0x50 DisplayName                 ( ModelPrimitiveType string string string String )
            value.LicenseLastUpdate                         = GetInt64(new IntPtr(p + 0x058)); // 0x58 LicenseLastUpdate           ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
