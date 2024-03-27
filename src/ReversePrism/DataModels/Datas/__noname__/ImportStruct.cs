using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StyleSheet                               0001865CDAA0 ModelClassType StyleSheet StyleSheet StyleSheet Pointer
    // 018 MediaQueries                             000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class ImportStruct
    {
        public StyleSheet?                              StyleSheet                              { get; set; }
        public List<string>?                            MediaQueries                            { get; set; }

        public static ImportStruct? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ImportStruct();

            value.StyleSheet                                = GetObject<StyleSheet>(new IntPtr(p + 0x010), ReversePrism.DataModels.StyleSheet.FromPointer); // 027006842958 0x10 StyleSheet                  ( 0001865CDAA0 ModelClassType StyleSheet StyleSheet StyleSheet Pointer )
            value.MediaQueries                              = GetStringList(new IntPtr(p + 0x018)); // 027006842978 0x18 MediaQueries                ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
