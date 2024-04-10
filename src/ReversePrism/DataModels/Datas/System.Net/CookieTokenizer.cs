using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_eofCookie                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 M_index                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 M_length                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 M_name                                   000186671910 ModelPrimitiveType string string string String
    // 028 M_quoted                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02C M_start                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 M_token                                  00018661F5D0 ModelEnumType CookieToken CookieToken CookieToken Int32
    // 034 M_tokenLength                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 M_tokenStream                            000186671910 ModelPrimitiveType string string string String
    // 040 M_value                                  000186671910 ModelPrimitiveType string string string String
    // 000 RecognizedAttributes                     RecognizedAttribute[] IL2CPP_TYPE_SZARRAY
    // 008 RecognizedServerAttributes               RecognizedAttribute[] IL2CPP_TYPE_SZARRAY
    public partial class CookieTokenizer : DataModel
    {
        public bool                                     M_eofCookie                             { get; set; }
        public int                                      M_index                                 { get; set; }
        public int                                      M_length                                { get; set; }
        public string                                   M_name                                  { get; set; }
        public bool                                     M_quoted                                { get; set; }
        public int                                      M_start                                 { get; set; }
        public CookieToken                              M_token                                 { get; set; }
        public int                                      M_tokenLength                           { get; set; }
        public string                                   M_tokenStream                           { get; set; }
        public string                                   M_value                                 { get; set; }

        public static CookieTokenizer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CookieTokenizer() { Pointer= p0 };

            value.M_eofCookie                               = GetBool(new IntPtr(p + 0x010)); // 024667A95910 0x10 M_eofCookie                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_index                                   = GetInt32(new IntPtr(p + 0x014)); // 024667A95930 0x14 M_index                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_length                                  = GetInt32(new IntPtr(p + 0x018)); // 024667A95950 0x18 M_length                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_name                                    = GetString(new IntPtr(p + 0x020)); // 024667A95970 0x20 M_name                      ( 000186671910 ModelPrimitiveType string string string String )
            value.M_quoted                                  = GetBool(new IntPtr(p + 0x028)); // 024667A95990 0x28 M_quoted                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_start                                   = GetInt32(new IntPtr(p + 0x02C)); // 024667A959B0 0x2C M_start                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_token                                   = (CookieToken)GetInt32(new IntPtr(p + 0x030)); // 024667A959D0 0x30 M_token                     ( 00018661F5D0 ModelEnumType CookieToken CookieToken CookieToken Int32 )
            value.M_tokenLength                             = GetInt32(new IntPtr(p + 0x034)); // 024667A959F0 0x34 M_tokenLength               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_tokenStream                             = GetString(new IntPtr(p + 0x038)); // 024667A95A10 0x38 M_tokenStream               ( 000186671910 ModelPrimitiveType string string string String )
            value.M_value                                   = GetString(new IntPtr(p + 0x040)); // 024667A95A30 0x40 M_value                     ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
