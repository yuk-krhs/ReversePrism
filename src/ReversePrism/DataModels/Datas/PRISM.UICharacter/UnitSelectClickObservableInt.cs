using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 StatusLabelBlinkValue                    0001865A8B80 ModelClassType FloatReactiveProperty FloatReactiveProperty FloatReactiveProperty Pointer
    // 058 TapNotAvailable                          000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class UnitSelectClickObservableInt : DataModel
    {
        public FloatReactiveProperty?                   StatusLabelBlinkValue                   { get; set; }
        public bool                                     TapNotAvailable                         { get; set; }

        public static UnitSelectClickObservableInt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnitSelectClickObservableInt() { Pointer= p0 };

            value.StatusLabelBlinkValue                     = GetObject<FloatReactiveProperty>(new IntPtr(p + 0x050), ReversePrism.DataModels.FloatReactiveProperty.FromPointer); // 024665E20AD8 0x50 StatusLabelBlinkValue       ( 0001865A8B80 ModelClassType FloatReactiveProperty FloatReactiveProperty FloatReactiveProperty Pointer )
            value.TapNotAvailable                           = GetBool(new IntPtr(p + 0x058)); // 024665E20AF8 0x58 TapNotAvailable             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
