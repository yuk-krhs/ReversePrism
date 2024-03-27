using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 token_chars                              bool[] IL2CPP_TYPE_SZARRAY
    // 008 last_token_char                          int IL2CPP_TYPE_I4
    // 010 Dt_formats                               000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 010 S                                        000186672F10 ModelPrimitiveType string string string String
    // 018 Pos                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class Lexer
    {
        public List<string>?                            Dt_formats                              { get; set; }
        public string                                   S                                       { get; set; }
        public int                                      Pos                                     { get; set; }

        public static Lexer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Lexer();

            value.Dt_formats                                = GetStringList(new IntPtr(p + 0x010)); // 0270DB842CE0 0x10 Dt_formats                  ( 000185B820A0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.S                                         = GetString(new IntPtr(p + 0x010)); // 0270DB842D00 0x10 S                           ( 000186672F10 ModelPrimitiveType string string string String )
            value.Pos                                       = GetInt32(new IntPtr(p + 0x018)); // 0270DB842D20 0x18 Pos                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
