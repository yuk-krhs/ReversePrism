using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Binder                                   00018652E700 ModelClassType CallSiteBinder CallSiteBinder CallSiteBinder Pointer
    // 018 Match                                    000186595210 ModelPrimitiveType bool bool bool Bool
    public partial class CallSite
    {
        public CallSiteBinder?                          Binder                                  { get; set; }
        public bool                                     Match                                   { get; set; }

        public static CallSite? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallSite();

            value.Binder                                    = GetObject<CallSiteBinder>(new IntPtr(p + 0x010), ReversePrism.DataModels.CallSiteBinder.FromPointer); // 0270D875F608 0x10 Binder                      ( 00018652E700 ModelClassType CallSiteBinder CallSiteBinder CallSiteBinder Pointer )
            value.Match                                     = GetBool(new IntPtr(p + 0x018)); // 0270D875F628 0x18 Match                       ( 000186595210 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
