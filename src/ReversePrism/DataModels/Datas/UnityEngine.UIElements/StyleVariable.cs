using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866736C0 ModelPrimitiveType string string string String
    // 018 Sheet                                    0001865CDD10 ModelClassType StyleSheet StyleSheet StyleSheet Pointer
    // 020 Handles                                  000185CA83A8 ModelEnumListType StyleValueHandle[] StyleValueHandle[] List<StyleValueHandle> Pointer
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

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0245A68051C0 0x10 Name                        ( 0001866736C0 ModelPrimitiveType string string string String )
            value.Sheet                                     = GetObject<StyleSheet>(new IntPtr(p + 0x018), ReversePrism.DataModels.StyleSheet.FromPointer); // 0245A68051E0 0x18 Sheet                       ( 0001865CDD10 ModelClassType StyleSheet StyleSheet StyleSheet Pointer )
            value.Handles                                   = GetEnumList<StyleValueHandle>(new IntPtr(p + 0x020)); // 0245A6805200 0x20 Handles                     ( 000185CA83A8 ModelEnumListType StyleValueHandle[] StyleValueHandle[] List<StyleValueHandle> Pointer )

            return value;
        }
    }
}
