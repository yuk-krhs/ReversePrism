using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Sheet                                    ModelClassType StyleSheet StyleSheet StyleSheet Pointer
    // 018 Handles                                  ModelEnumListType StyleValueHandle[] StyleValueHandle[] List<StyleValueHandle> Pointer
    public partial class ResolveContext : DataModel
    {
        public StyleSheet?                              Sheet                                   { get; set; }
        public List<StyleValueHandle>?                  Handles                                 { get; set; }

        public static ResolveContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResolveContext() { Pointer= p0 };

            value.Sheet                                     = GetObject<StyleSheet>(new IntPtr(p + 0x010), ReversePrism.DataModels.StyleSheet.FromPointer); // 0x10 Sheet                       ( ModelClassType StyleSheet StyleSheet StyleSheet Pointer )
            value.Handles                                   = GetEnumList<StyleValueHandle>(new IntPtr(p + 0x018)); // 0x18 Handles                     ( ModelEnumListType StyleValueHandle[] StyleValueHandle[] List<StyleValueHandle> Pointer )

            return value;
        }
    }
}
