using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 BackupPrefsKey                           string IL2CPP_TYPE_STRING
    // 010 Host                                     ModelPrimitiveType string string string String
    // 018 Port                                     ModelPrimitiveType int int int Int32
    // 01C UseCredentials                           ModelPrimitiveType bool bool bool Bool
    // 01D UseEncryption                            ModelPrimitiveType bool bool bool Bool
    // 01E UseTrace                                 ModelPrimitiveType bool bool bool Bool
    // 020 RequestTimeOutMs                         ModelPrimitiveType int int int Int32
    public partial class LoginServerData : DataModel
    {
        public string                                   Host                                    { get; set; }
        public int                                      Port                                    { get; set; }
        public bool                                     UseCredentials                          { get; set; }
        public bool                                     UseEncryption                           { get; set; }
        public bool                                     UseTrace                                { get; set; }
        public int                                      RequestTimeOutMs                        { get; set; }

        public static LoginServerData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoginServerData() { Pointer= p0 };

            value.Host                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Host                        ( ModelPrimitiveType string string string String )
            value.Port                                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 Port                        ( ModelPrimitiveType int int int Int32 )
            value.UseCredentials                            = GetBool(new IntPtr(p + 0x01C)); // 0x1C UseCredentials              ( ModelPrimitiveType bool bool bool Bool )
            value.UseEncryption                             = GetBool(new IntPtr(p + 0x01D)); // 0x1D UseEncryption               ( ModelPrimitiveType bool bool bool Bool )
            value.UseTrace                                  = GetBool(new IntPtr(p + 0x01E)); // 0x1E UseTrace                    ( ModelPrimitiveType bool bool bool Bool )
            value.RequestTimeOutMs                          = GetInt32(new IntPtr(p + 0x020)); // 0x20 RequestTimeOutMs            ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
