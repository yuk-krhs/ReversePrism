using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UserId                                   0001866722E0 ModelPrimitiveType string string string String
    // 018 ConsumerKey                              0001866722E0 ModelPrimitiveType string string string String
    // 020 ConsumerSecret                           0001866722E0 ModelPrimitiveType string string string String
    // 028 Token                                    0001866722E0 ModelPrimitiveType string string string String
    // 030 TokenSecret                              0001866722E0 ModelPrimitiveType string string string String
    public partial class OAuthModel
    {
        public string                                   UserId                                  { get; set; }
        public string                                   ConsumerKey                             { get; set; }
        public string                                   ConsumerSecret                          { get; set; }
        public string                                   Token                                   { get; set; }
        public string                                   TokenSecret                             { get; set; }

        public static OAuthModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OAuthModel();

            value.UserId                                    = GetString(new IntPtr(p + 0x010)); // 0270DB4A0850 0x10 UserId                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ConsumerKey                               = GetString(new IntPtr(p + 0x018)); // 0270DB4A0870 0x18 ConsumerKey                 ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ConsumerSecret                            = GetString(new IntPtr(p + 0x020)); // 0270DB4A0890 0x20 ConsumerSecret              ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Token                                     = GetString(new IntPtr(p + 0x028)); // 0270DB4A08B0 0x28 Token                       ( 0001866722E0 ModelPrimitiveType string string string String )
            value.TokenSecret                               = GetString(new IntPtr(p + 0x030)); // 0270DB4A08D0 0x30 TokenSecret                 ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
