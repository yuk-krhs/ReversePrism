using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Prefix                                   0001866722E0 ModelPrimitiveType string string string String
    // 018 Creator                                  00018669B990 ModelClassType IWebRequestCreate IWebRequestCreate IWebRequestCreate Pointer
    // 020 CreatorType                              000186692A80 ModelClassType Type Type Type Pointer
    public partial class WebRequestPrefixElement
    {
        public string                                   Prefix                                  { get; set; }
        public IWebRequestCreate?                       Creator                                 { get; set; }
        public Type?                                    CreatorType                             { get; set; }

        public static WebRequestPrefixElement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebRequestPrefixElement();

            value.Prefix                                    = GetString(new IntPtr(p + 0x010)); // 0270D7A2CB98 0x10 Prefix                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Creator                                   = GetObject<IWebRequestCreate>(new IntPtr(p + 0x018), ReversePrism.DataModels.IWebRequestCreate.FromPointer); // 0270D7A2CBB8 0x18 Creator                     ( 00018669B990 ModelClassType IWebRequestCreate IWebRequestCreate IWebRequestCreate Pointer )
            value.CreatorType                               = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0270D7A2CBD8 0x20 CreatorType                 ( 000186692A80 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
