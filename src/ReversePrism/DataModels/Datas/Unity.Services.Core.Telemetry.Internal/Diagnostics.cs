using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Handler                                  0001866CEA40 ModelClassType DiagnosticsHandler DiagnosticsHandler DiagnosticsHandler Pointer
    // 018 <PackageTags>k__BackingField             IDictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    public partial class Diagnostics : DataModel
    {
        public DiagnosticsHandler?                      Handler                                 { get; set; }

        public static Diagnostics? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Diagnostics() { Pointer= p0 };

            value.Handler                                   = GetObject<DiagnosticsHandler>(new IntPtr(p + 0x010), ReversePrism.DataModels.DiagnosticsHandler.FromPointer); // 0245A6642158 0x10 Handler                     ( 0001866CEA40 ModelClassType DiagnosticsHandler DiagnosticsHandler DiagnosticsHandler Pointer )

            return value;
        }
    }
}
