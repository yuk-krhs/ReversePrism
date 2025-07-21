using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_eofCookie                              ModelPrimitiveType bool bool bool Bool
    // 014 M_index                                  ModelPrimitiveType int int int Int32
    // 018 M_length                                 ModelPrimitiveType int int int Int32
    // 020 M_name                                   ModelPrimitiveType string string string String
    // 028 M_quoted                                 ModelPrimitiveType bool bool bool Bool
    // 02C M_start                                  ModelPrimitiveType int int int Int32
    // 030 M_token                                  ModelEnumType CookieToken CookieToken CookieToken Int32
    // 034 M_tokenLength                            ModelPrimitiveType int int int Int32
    // 038 M_tokenStream                            ModelPrimitiveType string string string String
    // 040 M_value                                  ModelPrimitiveType string string string String
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

            value.M_eofCookie                               = GetBool(new IntPtr(p + 0x010)); // 0x10 M_eofCookie                 ( ModelPrimitiveType bool bool bool Bool )
            value.M_index                                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 M_index                     ( ModelPrimitiveType int int int Int32 )
            value.M_length                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_length                    ( ModelPrimitiveType int int int Int32 )
            value.M_name                                    = GetString(new IntPtr(p + 0x020)); // 0x20 M_name                      ( ModelPrimitiveType string string string String )
            value.M_quoted                                  = GetBool(new IntPtr(p + 0x028)); // 0x28 M_quoted                    ( ModelPrimitiveType bool bool bool Bool )
            value.M_start                                   = GetInt32(new IntPtr(p + 0x02C)); // 0x2C M_start                     ( ModelPrimitiveType int int int Int32 )
            value.M_token                                   = (CookieToken)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_token                     ( ModelEnumType CookieToken CookieToken CookieToken Int32 )
            value.M_tokenLength                             = GetInt32(new IntPtr(p + 0x034)); // 0x34 M_tokenLength               ( ModelPrimitiveType int int int Int32 )
            value.M_tokenStream                             = GetString(new IntPtr(p + 0x038)); // 0x38 M_tokenStream               ( ModelPrimitiveType string string string String )
            value.M_value                                   = GetString(new IntPtr(p + 0x040)); // 0x40 M_value                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
