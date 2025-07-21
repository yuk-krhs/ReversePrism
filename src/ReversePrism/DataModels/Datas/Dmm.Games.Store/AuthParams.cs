using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ClientId                                 ModelPrimitiveType string string string String
    // 018 ClientSecret                             ModelPrimitiveType string string string String
    // 020 SecretKey                                ModelPrimitiveType string string string String
    // 028 RedirectUri                              ModelPrimitiveType string string string String
    // 030 ConnectionTimeoutMillis                  ModelPrimitiveType int int int Int32
    // 034 ReadTimeoutMillis                        ModelPrimitiveType int int int Int32
    public partial class AuthParams : DataModel
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
            var value   = new AuthParams() { Pointer= p0 };

            value.ClientId                                  = GetString(new IntPtr(p + 0x010)); // 0x10 ClientId                    ( ModelPrimitiveType string string string String )
            value.ClientSecret                              = GetString(new IntPtr(p + 0x018)); // 0x18 ClientSecret                ( ModelPrimitiveType string string string String )
            value.SecretKey                                 = GetString(new IntPtr(p + 0x020)); // 0x20 SecretKey                   ( ModelPrimitiveType string string string String )
            value.RedirectUri                               = GetString(new IntPtr(p + 0x028)); // 0x28 RedirectUri                 ( ModelPrimitiveType string string string String )
            value.ConnectionTimeoutMillis                   = GetInt32(new IntPtr(p + 0x030)); // 0x30 ConnectionTimeoutMillis     ( ModelPrimitiveType int int int Int32 )
            value.ReadTimeoutMillis                         = GetInt32(new IntPtr(p + 0x034)); // 0x34 ReadTimeoutMillis           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
