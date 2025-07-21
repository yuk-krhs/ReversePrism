using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Binder                                   ModelClassType CallSiteBinder CallSiteBinder CallSiteBinder Pointer
    // 018 Match                                    ModelPrimitiveType bool bool bool Bool
    public partial class CallSite : DataModel
    {
        public CallSiteBinder?                          Binder                                  { get; set; }
        public bool                                     Match                                   { get; set; }

        public static CallSite? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallSite() { Pointer= p0 };

            value.Binder                                    = GetObject<CallSiteBinder>(new IntPtr(p + 0x010), ReversePrism.DataModels.CallSiteBinder.FromPointer); // 0x10 Binder                      ( ModelClassType CallSiteBinder CallSiteBinder CallSiteBinder Pointer )
            value.Match                                     = GetBool(new IntPtr(p + 0x018)); // 0x18 Match                       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
