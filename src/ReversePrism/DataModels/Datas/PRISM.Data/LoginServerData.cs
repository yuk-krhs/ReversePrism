using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 BackupPrefsKey                           string IL2CPP_TYPE_STRING
    // 010 Host                                     000186671910 ModelPrimitiveType string string string String
    // 018 Port                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C UseCredentials                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01D UseEncryption                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01E UseTrace                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 020 RequestTimeOutMs                         0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LoginServerData
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
            var value   = new LoginServerData();

            value.Host                                      = GetString(new IntPtr(p + 0x010)); // 0270D594E3F0 0x10 Host                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Port                                      = GetInt32(new IntPtr(p + 0x018)); // 0270D594E410 0x18 Port                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UseCredentials                            = GetBool(new IntPtr(p + 0x01C)); // 0270D594E430 0x1C UseCredentials              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UseEncryption                             = GetBool(new IntPtr(p + 0x01D)); // 0270D594E450 0x1D UseEncryption               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UseTrace                                  = GetBool(new IntPtr(p + 0x01E)); // 0270D594E470 0x1E UseTrace                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RequestTimeOutMs                          = GetInt32(new IntPtr(p + 0x020)); // 0270D594E490 0x20 RequestTimeOutMs            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
