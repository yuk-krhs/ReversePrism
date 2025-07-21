using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sheet                                    ModelClassType StyleSheet StyleSheet StyleSheet Pointer
    // 018 Rule                                     ModelClassType StyleRule StyleRule StyleRule Pointer
    // 020 PropertyIds                              ModelEnumListType StylePropertyId[] StylePropertyId[] List<StylePropertyId> Pointer
    public partial class InlineRule : DataModel
    {
        public StyleSheet?                              Sheet                                   { get; set; }
        public StyleRule?                               Rule                                    { get; set; }
        public List<StylePropertyId>?                   PropertyIds                             { get; set; }

        public static InlineRule? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InlineRule() { Pointer= p0 };

            value.Sheet                                     = GetObject<StyleSheet>(new IntPtr(p + 0x010), ReversePrism.DataModels.StyleSheet.FromPointer); // 0x10 Sheet                       ( ModelClassType StyleSheet StyleSheet StyleSheet Pointer )
            value.Rule                                      = GetObject<StyleRule>(new IntPtr(p + 0x018), ReversePrism.DataModels.StyleRule.FromPointer); // 0x18 Rule                        ( ModelClassType StyleRule StyleRule StyleRule Pointer )
            value.PropertyIds                               = GetEnumList<StylePropertyId>(new IntPtr(p + 0x020)); // 0x20 PropertyIds                 ( ModelEnumListType StylePropertyId[] StylePropertyId[] List<StylePropertyId> Pointer )

            return value;
        }
    }
}
