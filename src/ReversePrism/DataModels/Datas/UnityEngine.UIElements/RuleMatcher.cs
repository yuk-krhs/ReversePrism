using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sheet                                    ModelClassType StyleSheet StyleSheet StyleSheet Pointer
    // 018 ComplexSelector                          ModelClassType StyleComplexSelector StyleComplexSelector StyleComplexSelector Pointer
    public partial class RuleMatcher : DataModel
    {
        public StyleSheet?                              Sheet                                   { get; set; }
        public StyleComplexSelector?                    ComplexSelector                         { get; set; }

        public static RuleMatcher? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuleMatcher() { Pointer= p0 };

            value.Sheet                                     = GetObject<StyleSheet>(new IntPtr(p + 0x010), ReversePrism.DataModels.StyleSheet.FromPointer); // 0x10 Sheet                       ( ModelClassType StyleSheet StyleSheet StyleSheet Pointer )
            value.ComplexSelector                           = GetObject<StyleComplexSelector>(new IntPtr(p + 0x018), ReversePrism.DataModels.StyleComplexSelector.FromPointer); // 0x18 ComplexSelector             ( ModelClassType StyleComplexSelector StyleComplexSelector StyleComplexSelector Pointer )

            return value;
        }
    }
}
