using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sheet                                    ModelClassType StyleSheet StyleSheet StyleSheet Pointer
    // 018 StyleSheetIndexInStack                   ModelPrimitiveType int int int Int32
    // 020 ComplexSelector                          ModelClassType StyleComplexSelector StyleComplexSelector StyleComplexSelector Pointer
    public partial class SelectorMatchRecord : DataModel
    {
        public StyleSheet?                              Sheet                                   { get; set; }
        public int                                      StyleSheetIndexInStack                  { get; set; }
        public StyleComplexSelector?                    ComplexSelector                         { get; set; }

        public static SelectorMatchRecord? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SelectorMatchRecord() { Pointer= p0 };

            value.Sheet                                     = GetObject<StyleSheet>(new IntPtr(p + 0x010), ReversePrism.DataModels.StyleSheet.FromPointer); // 0x10 Sheet                       ( ModelClassType StyleSheet StyleSheet StyleSheet Pointer )
            value.StyleSheetIndexInStack                    = GetInt32(new IntPtr(p + 0x018)); // 0x18 StyleSheetIndexInStack      ( ModelPrimitiveType int int int Int32 )
            value.ComplexSelector                           = GetObject<StyleComplexSelector>(new IntPtr(p + 0x020), ReversePrism.DataModels.StyleComplexSelector.FromPointer); // 0x20 ComplexSelector             ( ModelClassType StyleComplexSelector StyleComplexSelector StyleComplexSelector Pointer )

            return value;
        }
    }
}
