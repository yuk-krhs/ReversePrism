using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sheet                                    0001865CDAA0 ModelClassType StyleSheet StyleSheet StyleSheet Pointer
    // 018 Handle                                   0001865D05F0 ModelEnumType StyleValueHandle StyleValueHandle StyleValueHandle Int32
    public partial class StylePropertyValue
    {
        public StyleSheet?                              Sheet                                   { get; set; }
        public StyleValueHandle                         Handle                                  { get; set; }

        public static StylePropertyValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StylePropertyValue();

            value.Sheet                                     = GetObject<StyleSheet>(new IntPtr(p + 0x010), ReversePrism.DataModels.StyleSheet.FromPointer); // 0270068848F8 0x10 Sheet                       ( 0001865CDAA0 ModelClassType StyleSheet StyleSheet StyleSheet Pointer )
            value.Handle                                    = (StyleValueHandle)GetInt32(new IntPtr(p + 0x018)); // 027006884918 0x18 Handle                      ( 0001865D05F0 ModelEnumType StyleValueHandle StyleValueHandle StyleValueHandle Int32 )

            return value;
        }
    }
}
