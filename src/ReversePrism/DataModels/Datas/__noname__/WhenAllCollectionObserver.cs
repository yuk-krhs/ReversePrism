using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Parent                                   000186711BA0 ModelClassType WhenAll_ WhenAll_ WhenAll_ Pointer
    // 018 IsCompleted                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class WhenAllCollectionObserver : DataModel
    {
        public WhenAll_?                                Parent                                  { get; set; }
        public bool                                     IsCompleted                             { get; set; }

        public static WhenAllCollectionObserver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WhenAllCollectionObserver() { Pointer= p0 };

            value.Parent                                    = GetObject<WhenAll_>(new IntPtr(p + 0x010), ReversePrism.DataModels.WhenAll_.FromPointer); // 024669815168 0x10 Parent                      ( 000186711BA0 ModelClassType WhenAll_ WhenAll_ WhenAll_ Pointer )
            value.IsCompleted                               = GetBool(new IntPtr(p + 0x018)); // 024669815188 0x18 IsCompleted                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
