using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StyleSheet                               ModelClassType StyleSheet StyleSheet StyleSheet Pointer
    // 018 MediaQueries                             ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class ImportStruct : DataModel
    {
        public StyleSheet?                              StyleSheet                              { get; set; }
        public List<string>?                            MediaQueries                            { get; set; }

        public static ImportStruct? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ImportStruct() { Pointer= p0 };

            value.StyleSheet                                = GetObject<StyleSheet>(new IntPtr(p + 0x010), ReversePrism.DataModels.StyleSheet.FromPointer); // 0x10 StyleSheet                  ( ModelClassType StyleSheet StyleSheet StyleSheet Pointer )
            value.MediaQueries                              = GetStringList(new IntPtr(p + 0x018)); // 0x18 MediaQueries                ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
