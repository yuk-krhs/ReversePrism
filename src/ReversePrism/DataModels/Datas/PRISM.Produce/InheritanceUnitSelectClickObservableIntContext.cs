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
    // 060 SelectedFesUnitId                        000186671910 ModelPrimitiveType string string string String
    public partial class InheritanceUnitSelectClickObservableIntContext
    {
        public FloatReactiveProperty?                   StatusLabelBlinkValue                   { get; set; }
        public bool                                     TapNotAvailable                         { get; set; }
        public string                                   SelectedFesUnitId                       { get; set; }

        public static InheritanceUnitSelectClickObservableIntContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InheritanceUnitSelectClickObservableIntContext();

            value.StatusLabelBlinkValue                     = GetObject<FloatReactiveProperty>(new IntPtr(p + 0x050), ReversePrism.DataModels.FloatReactiveProperty.FromPointer); // 0270D59A8340 0x50 StatusLabelBlinkValue       ( 0001865A8B80 ModelClassType FloatReactiveProperty FloatReactiveProperty FloatReactiveProperty Pointer )
            value.TapNotAvailable                           = GetBool(new IntPtr(p + 0x058)); // 0270D59A8360 0x58 TapNotAvailable             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SelectedFesUnitId                         = GetString(new IntPtr(p + 0x060)); // 0270D59A8380 0x60 SelectedFesUnitId           ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
