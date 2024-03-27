using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_NormalStyle                            TMP_Style IL2CPP_TYPE_CLASS
    // 010 M_Name                                   000186671910 ModelPrimitiveType string string string String
    // 018 M_HashCode                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 M_OpeningDefinition                      000186671910 ModelPrimitiveType string string string String
    // 028 M_ClosingDefinition                      000186671910 ModelPrimitiveType string string string String
    // 030 M_OpeningTagArray                        000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 038 M_ClosingTagArray                        000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 040 M_OpeningTagUnicodeArray                 000185B83950 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 048 M_ClosingTagUnicodeArray                 000185B83950 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    public partial class TMP_Style
    {
        public string                                   M_Name                                  { get; set; }
        public int                                      M_HashCode                              { get; set; }
        public string                                   M_OpeningDefinition                     { get; set; }
        public string                                   M_ClosingDefinition                     { get; set; }
        public List<int>?                               M_OpeningTagArray                       { get; set; }
        public List<int>?                               M_ClosingTagArray                       { get; set; }
        public List<uint>?                              M_OpeningTagUnicodeArray                { get; set; }
        public List<uint>?                              M_ClosingTagUnicodeArray                { get; set; }

        public static TMP_Style? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_Style();

            value.M_Name                                    = GetString(new IntPtr(p + 0x010)); // 0270D0F84570 0x10 M_Name                      ( 000186671910 ModelPrimitiveType string string string String )
            value.M_HashCode                                = GetInt32(new IntPtr(p + 0x018)); // 0270D0F84590 0x18 M_HashCode                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_OpeningDefinition                       = GetString(new IntPtr(p + 0x020)); // 0270D0F845B0 0x20 M_OpeningDefinition         ( 000186671910 ModelPrimitiveType string string string String )
            value.M_ClosingDefinition                       = GetString(new IntPtr(p + 0x028)); // 0270D0F845D0 0x28 M_ClosingDefinition         ( 000186671910 ModelPrimitiveType string string string String )
            value.M_OpeningTagArray                         = GetInt32List(new IntPtr(p + 0x030)); // 0270D0F845F0 0x30 M_OpeningTagArray           ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_ClosingTagArray                         = GetInt32List(new IntPtr(p + 0x038)); // 0270D0F84610 0x38 M_ClosingTagArray           ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_OpeningTagUnicodeArray                  = GetUInt32List(new IntPtr(p + 0x040)); // 0270D0F84630 0x40 M_OpeningTagUnicodeArray    ( 000185B83950 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.M_ClosingTagUnicodeArray                  = GetUInt32List(new IntPtr(p + 0x048)); // 0270D0F84650 0x48 M_ClosingTagUnicodeArray    ( 000185B83950 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )

            return value;
        }
    }
}
