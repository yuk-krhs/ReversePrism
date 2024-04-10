using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sheet                                    0001865CDAA0 ModelClassType StyleSheet StyleSheet StyleSheet Pointer
    // 018 StyleSheetIndexInStack                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 ComplexSelector                          0001865C65F0 ModelClassType StyleComplexSelector StyleComplexSelector StyleComplexSelector Pointer
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

            value.Sheet                                     = GetObject<StyleSheet>(new IntPtr(p + 0x010), ReversePrism.DataModels.StyleSheet.FromPointer); // 0245A6848478 0x10 Sheet                       ( 0001865CDAA0 ModelClassType StyleSheet StyleSheet StyleSheet Pointer )
            value.StyleSheetIndexInStack                    = GetInt32(new IntPtr(p + 0x018)); // 0245A6848498 0x18 StyleSheetIndexInStack      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ComplexSelector                           = GetObject<StyleComplexSelector>(new IntPtr(p + 0x020), ReversePrism.DataModels.StyleComplexSelector.FromPointer); // 0245A68484B8 0x20 ComplexSelector             ( 0001865C65F0 ModelClassType StyleComplexSelector StyleComplexSelector StyleComplexSelector Pointer )

            return value;
        }
    }
}
