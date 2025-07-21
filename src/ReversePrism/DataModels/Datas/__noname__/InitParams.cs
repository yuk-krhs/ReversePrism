using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LightCookieManager                       ModelClassType LightCookieManager LightCookieManager LightCookieManager Pointer
    // 018 ForwardPlus                              ModelPrimitiveType bool bool bool Bool
    public partial class InitParams : DataModel
    {
        public LightCookieManager?                      LightCookieManager                      { get; set; }
        public bool                                     ForwardPlus                             { get; set; }

        public static InitParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InitParams() { Pointer= p0 };

            value.LightCookieManager                        = GetObject<LightCookieManager>(new IntPtr(p + 0x010), ReversePrism.DataModels.LightCookieManager.FromPointer); // 0x10 LightCookieManager          ( ModelClassType LightCookieManager LightCookieManager LightCookieManager Pointer )
            value.ForwardPlus                               = GetBool(new IntPtr(p + 0x018)); // 0x18 ForwardPlus                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
