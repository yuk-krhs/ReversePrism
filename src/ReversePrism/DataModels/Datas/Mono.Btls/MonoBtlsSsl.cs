using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Bio                                      00018663E6E0 ModelClassType MonoBtlsBio MonoBtlsBio MonoBtlsBio Pointer
    // 028 PrintErrorsFunc                          00018673F830 ModelClassType PrintErrorsCallbackFunc PrintErrorsCallbackFunc PrintErrorsCallbackFunc Pointer
    // 030 printErrorsFuncPtr                       <int> IL2CPP_TYPE_I
    public partial class MonoBtlsSsl
    {
        public MonoBtlsBio?                             Bio                                     { get; set; }
        public PrintErrorsCallbackFunc?                 PrintErrorsFunc                         { get; set; }

        public static MonoBtlsSsl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoBtlsSsl();

            value.Bio                                       = GetObject<MonoBtlsBio>(new IntPtr(p + 0x020), ReversePrism.DataModels.MonoBtlsBio.FromPointer); // 0270D79430A8 0x20 Bio                         ( 00018663E6E0 ModelClassType MonoBtlsBio MonoBtlsBio MonoBtlsBio Pointer )
            value.PrintErrorsFunc                           = GetObject<PrintErrorsCallbackFunc>(new IntPtr(p + 0x028), ReversePrism.DataModels.PrintErrorsCallbackFunc.FromPointer); // 0270D79430C8 0x28 PrintErrorsFunc             ( 00018673F830 ModelClassType PrintErrorsCallbackFunc PrintErrorsCallbackFunc PrintErrorsCallbackFunc Pointer )

            return value;
        }
    }
}
