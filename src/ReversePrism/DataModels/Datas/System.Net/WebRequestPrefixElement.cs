using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Prefix                                   ModelPrimitiveType string string string String
    // 018 Creator                                  ModelClassType IWebRequestCreate IWebRequestCreate IWebRequestCreate Pointer
    // 020 CreatorType                              ModelClassType Type Type Type Pointer
    public partial class WebRequestPrefixElement : DataModel
    {
        public string                                   Prefix                                  { get; set; }
        public IWebRequestCreate?                       Creator                                 { get; set; }
        public Type?                                    CreatorType                             { get; set; }

        public static WebRequestPrefixElement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebRequestPrefixElement() { Pointer= p0 };

            value.Prefix                                    = GetString(new IntPtr(p + 0x010)); // 0x10 Prefix                      ( ModelPrimitiveType string string string String )
            value.Creator                                   = GetObject<IWebRequestCreate>(new IntPtr(p + 0x018), ReversePrism.DataModels.IWebRequestCreate.FromPointer); // 0x18 Creator                     ( ModelClassType IWebRequestCreate IWebRequestCreate IWebRequestCreate Pointer )
            value.CreatorType                               = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0x20 CreatorType                 ( ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
