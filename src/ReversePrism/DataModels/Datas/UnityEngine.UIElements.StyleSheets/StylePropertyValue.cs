using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sheet                                    ModelClassType StyleSheet StyleSheet StyleSheet Pointer
    // 018 Handle                                   ModelEnumType StyleValueHandle StyleValueHandle StyleValueHandle Int32
    public partial class StylePropertyValue : DataModel
    {
        public StyleSheet?                              Sheet                                   { get; set; }
        public StyleValueHandle                         Handle                                  { get; set; }

        public static StylePropertyValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StylePropertyValue() { Pointer= p0 };

            value.Sheet                                     = GetObject<StyleSheet>(new IntPtr(p + 0x010), ReversePrism.DataModels.StyleSheet.FromPointer); // 0x10 Sheet                       ( ModelClassType StyleSheet StyleSheet StyleSheet Pointer )
            value.Handle                                    = (StyleValueHandle)GetInt32(new IntPtr(p + 0x018)); // 0x18 Handle                      ( ModelEnumType StyleValueHandle StyleValueHandle StyleValueHandle Int32 )

            return value;
        }
    }
}
