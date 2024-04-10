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
    public partial class InheritanceUnitSelectClickObservableIntContext : DataModel
    {
        public FloatReactiveProperty?                   StatusLabelBlinkValue                   { get; set; }
        public bool                                     TapNotAvailable                         { get; set; }
        public string                                   SelectedFesUnitId                       { get; set; }

        public static InheritanceUnitSelectClickObservableIntContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InheritanceUnitSelectClickObservableIntContext() { Pointer= p0 };

            value.StatusLabelBlinkValue                     = GetObject<FloatReactiveProperty>(new IntPtr(p + 0x050), ReversePrism.DataModels.FloatReactiveProperty.FromPointer); // 024665A08AE8 0x50 StatusLabelBlinkValue       ( 0001865A8B80 ModelClassType FloatReactiveProperty FloatReactiveProperty FloatReactiveProperty Pointer )
            value.TapNotAvailable                           = GetBool(new IntPtr(p + 0x058)); // 024665A08B08 0x58 TapNotAvailable             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SelectedFesUnitId                         = GetString(new IntPtr(p + 0x060)); // 024665A08B28 0x60 SelectedFesUnitId           ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
