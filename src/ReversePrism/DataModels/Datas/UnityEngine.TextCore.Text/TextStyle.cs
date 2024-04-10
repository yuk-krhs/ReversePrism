using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_NormalStyle                            TextStyle IL2CPP_TYPE_CLASS
    // 010 M_Name                                   000186671910 ModelPrimitiveType string string string String
    // 018 M_HashCode                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 M_OpeningDefinition                      000186671910 ModelPrimitiveType string string string String
    // 028 M_ClosingDefinition                      000186671910 ModelPrimitiveType string string string String
    // 030 M_OpeningTagArray                        000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 038 M_ClosingTagArray                        000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 040 M_OpeningTagUnicodeArray                 000185B83950 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    // 048 M_ClosingTagUnicodeArray                 000185B83950 ModelPrimitiveListType uint[] uint[] List<uint> Pointer
    public partial class TextStyle : DataModel
    {
        public string                                   M_Name                                  { get; set; }
        public int                                      M_HashCode                              { get; set; }
        public string                                   M_OpeningDefinition                     { get; set; }
        public string                                   M_ClosingDefinition                     { get; set; }
        public List<uint>?                              M_OpeningTagArray                       { get; set; }
        public List<uint>?                              M_ClosingTagArray                       { get; set; }
        public List<uint>?                              M_OpeningTagUnicodeArray                { get; set; }
        public List<uint>?                              M_ClosingTagUnicodeArray                { get; set; }

        public static TextStyle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextStyle() { Pointer= p0 };

            value.M_Name                                    = GetString(new IntPtr(p + 0x010)); // 0245A68BED48 0x10 M_Name                      ( 000186671910 ModelPrimitiveType string string string String )
            value.M_HashCode                                = GetInt32(new IntPtr(p + 0x018)); // 0245A68BED68 0x18 M_HashCode                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_OpeningDefinition                       = GetString(new IntPtr(p + 0x020)); // 0245A68BED88 0x20 M_OpeningDefinition         ( 000186671910 ModelPrimitiveType string string string String )
            value.M_ClosingDefinition                       = GetString(new IntPtr(p + 0x028)); // 0245A68BEDA8 0x28 M_ClosingDefinition         ( 000186671910 ModelPrimitiveType string string string String )
            value.M_OpeningTagArray                         = GetUInt32List(new IntPtr(p + 0x030)); // 0245A68BEDC8 0x30 M_OpeningTagArray           ( 000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.M_ClosingTagArray                         = GetUInt32List(new IntPtr(p + 0x038)); // 0245A68BEDE8 0x38 M_ClosingTagArray           ( 000185B83830 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.M_OpeningTagUnicodeArray                  = GetUInt32List(new IntPtr(p + 0x040)); // 0245A68BEE08 0x40 M_OpeningTagUnicodeArray    ( 000185B83950 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )
            value.M_ClosingTagUnicodeArray                  = GetUInt32List(new IntPtr(p + 0x048)); // 0245A68BEE28 0x48 M_ClosingTagUnicodeArray    ( 000185B83950 ModelPrimitiveListType uint[] uint[] List<uint> Pointer )

            return value;
        }
    }
}
