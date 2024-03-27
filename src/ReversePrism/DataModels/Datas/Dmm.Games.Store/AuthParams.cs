using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ClientId                                 0001866722E0 ModelPrimitiveType string string string String
    // 018 ClientSecret                             0001866722E0 ModelPrimitiveType string string string String
    // 020 SecretKey                                0001866722E0 ModelPrimitiveType string string string String
    // 028 RedirectUri                              0001866722E0 ModelPrimitiveType string string string String
    // 030 ConnectionTimeoutMillis                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 ReadTimeoutMillis                        0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class AuthParams
    {
        public string                                   ClientId                                { get; set; }
        public string                                   ClientSecret                            { get; set; }
        public string                                   SecretKey                               { get; set; }
        public string                                   RedirectUri                             { get; set; }
        public int                                      ConnectionTimeoutMillis                 { get; set; }
        public int                                      ReadTimeoutMillis                       { get; set; }

        public static AuthParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuthParams();

            value.ClientId                                  = GetString(new IntPtr(p + 0x010)); // 0270DB484628 0x10 ClientId                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ClientSecret                              = GetString(new IntPtr(p + 0x018)); // 0270DB484648 0x18 ClientSecret                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.SecretKey                                 = GetString(new IntPtr(p + 0x020)); // 0270DB484668 0x20 SecretKey                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.RedirectUri                               = GetString(new IntPtr(p + 0x028)); // 0270DB484688 0x28 RedirectUri                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ConnectionTimeoutMillis                   = GetInt32(new IntPtr(p + 0x030)); // 0270DB4846A8 0x30 ConnectionTimeoutMillis     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ReadTimeoutMillis                         = GetInt32(new IntPtr(p + 0x034)); // 0270DB4846C8 0x34 ReadTimeoutMillis           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
