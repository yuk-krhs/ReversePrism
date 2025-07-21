using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UserId                                   ModelPrimitiveType string string string String
    // 018 ConsumerKey                              ModelPrimitiveType string string string String
    // 020 ConsumerSecret                           ModelPrimitiveType string string string String
    // 028 Token                                    ModelPrimitiveType string string string String
    // 030 TokenSecret                              ModelPrimitiveType string string string String
    public partial class OAuthModel : DataModel
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
            var value   = new OAuthModel() { Pointer= p0 };

            value.UserId                                    = GetString(new IntPtr(p + 0x010)); // 0x10 UserId                      ( ModelPrimitiveType string string string String )
            value.ConsumerKey                               = GetString(new IntPtr(p + 0x018)); // 0x18 ConsumerKey                 ( ModelPrimitiveType string string string String )
            value.ConsumerSecret                            = GetString(new IntPtr(p + 0x020)); // 0x20 ConsumerSecret              ( ModelPrimitiveType string string string String )
            value.Token                                     = GetString(new IntPtr(p + 0x028)); // 0x28 Token                       ( ModelPrimitiveType string string string String )
            value.TokenSecret                               = GetString(new IntPtr(p + 0x030)); // 0x30 TokenSecret                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
