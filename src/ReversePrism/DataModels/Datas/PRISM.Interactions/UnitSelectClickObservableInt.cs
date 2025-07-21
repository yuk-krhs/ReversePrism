using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 StatusLabelBlinkValue                    ModelClassType FloatReactiveProperty FloatReactiveProperty FloatReactiveProperty Pointer
    // 060 TapNotAvailable                          ModelPrimitiveType bool bool bool Bool
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

            value.StatusLabelBlinkValue                     = GetObject<FloatReactiveProperty>(new IntPtr(p + 0x058), ReversePrism.DataModels.FloatReactiveProperty.FromPointer); // 0x58 StatusLabelBlinkValue       ( ModelClassType FloatReactiveProperty FloatReactiveProperty FloatReactiveProperty Pointer )
            value.TapNotAvailable                           = GetBool(new IntPtr(p + 0x060)); // 0x60 TapNotAvailable             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
