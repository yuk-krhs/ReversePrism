using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sheet                                    0001865CDAA0 ModelClassType StyleSheet StyleSheet StyleSheet Pointer
    // 018 Handles                                  000185CA8288 ModelEnumListType StyleValueHandle[] StyleValueHandle[] List<StyleValueHandle> Pointer
    public partial class ResolveContext
    {
        public StyleSheet?                              Sheet                                   { get; set; }
        public List<StyleValueHandle>?                  Handles                                 { get; set; }

        public static ResolveContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResolveContext();

            value.Sheet                                     = GetObject<StyleSheet>(new IntPtr(p + 0x010), ReversePrism.DataModels.StyleSheet.FromPointer); // 0270068440A8 0x10 Sheet                       ( 0001865CDAA0 ModelClassType StyleSheet StyleSheet StyleSheet Pointer )
            value.Handles                                   = GetEnumList<StyleValueHandle>(new IntPtr(p + 0x018)); // 0270068440C8 0x18 Handles                     ( 000185CA8288 ModelEnumListType StyleValueHandle[] StyleValueHandle[] List<StyleValueHandle> Pointer )

            return value;
        }
    }
}
