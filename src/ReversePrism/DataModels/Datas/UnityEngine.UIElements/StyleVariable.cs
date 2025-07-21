using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Sheet                                    ModelClassType StyleSheet StyleSheet StyleSheet Pointer
    // 020 Handles                                  ModelEnumListType StyleValueHandle[] StyleValueHandle[] List<StyleValueHandle> Pointer
    public partial class StyleVariable : DataModel
    {
        public string                                   Name                                    { get; set; }
        public StyleSheet?                              Sheet                                   { get; set; }
        public List<StyleValueHandle>?                  Handles                                 { get; set; }

        public static StyleVariable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StyleVariable() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Sheet                                     = GetObject<StyleSheet>(new IntPtr(p + 0x018), ReversePrism.DataModels.StyleSheet.FromPointer); // 0x18 Sheet                       ( ModelClassType StyleSheet StyleSheet StyleSheet Pointer )
            value.Handles                                   = GetEnumList<StyleValueHandle>(new IntPtr(p + 0x020)); // 0x20 Handles                     ( ModelEnumListType StyleValueHandle[] StyleValueHandle[] List<StyleValueHandle> Pointer )

            return value;
        }
    }
}
