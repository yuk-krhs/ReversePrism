using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Str                                      ModelPrimitiveType string string string String
    // 018 Index                                    ModelPrimitiveType int int int Int32
    // 01C StartIndex                               ModelPrimitiveType int int int Int32
    // 020 StrLen                                   ModelPrimitiveType int int int Int32
    // 024 CurrTextElementLen                       ModelPrimitiveType int int int Int32
    // 028 Uc                                       ModelEnumType UnicodeCategory UnicodeCategory UnicodeCategory Int32
    // 02C CharLen                                  ModelPrimitiveType int int int Int32
    // 030 EndIndex                                 ModelPrimitiveType int int int Int32
    // 034 NextTextElementLen                       ModelPrimitiveType int int int Int32
    public partial class TextElementEnumerator : DataModel
    {
        public string                                   Str                                     { get; set; }
        public int                                      Index                                   { get; set; }
        public int                                      StartIndex                              { get; set; }
        public int                                      StrLen                                  { get; set; }
        public int                                      CurrTextElementLen                      { get; set; }
        public UnicodeCategory                          Uc                                      { get; set; }
        public int                                      CharLen                                 { get; set; }
        public int                                      EndIndex                                { get; set; }
        public int                                      NextTextElementLen                      { get; set; }

        public static TextElementEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextElementEnumerator() { Pointer= p0 };

            value.Str                                       = GetString(new IntPtr(p + 0x010)); // 0x10 Str                         ( ModelPrimitiveType string string string String )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 Index                       ( ModelPrimitiveType int int int Int32 )
            value.StartIndex                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C StartIndex                  ( ModelPrimitiveType int int int Int32 )
            value.StrLen                                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 StrLen                      ( ModelPrimitiveType int int int Int32 )
            value.CurrTextElementLen                        = GetInt32(new IntPtr(p + 0x024)); // 0x24 CurrTextElementLen          ( ModelPrimitiveType int int int Int32 )
            value.Uc                                        = (UnicodeCategory)GetInt32(new IntPtr(p + 0x028)); // 0x28 Uc                          ( ModelEnumType UnicodeCategory UnicodeCategory UnicodeCategory Int32 )
            value.CharLen                                   = GetInt32(new IntPtr(p + 0x02C)); // 0x2C CharLen                     ( ModelPrimitiveType int int int Int32 )
            value.EndIndex                                  = GetInt32(new IntPtr(p + 0x030)); // 0x30 EndIndex                    ( ModelPrimitiveType int int int Int32 )
            value.NextTextElementLen                        = GetInt32(new IntPtr(p + 0x034)); // 0x34 NextTextElementLen          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
