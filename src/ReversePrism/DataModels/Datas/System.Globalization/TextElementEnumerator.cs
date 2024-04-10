using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Str                                      000186671910 ModelPrimitiveType string string string String
    // 018 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C StartIndex                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 StrLen                                   0001865F5290 ModelPrimitiveType int int int Int32
    // 024 CurrTextElementLen                       0001865F5290 ModelPrimitiveType int int int Int32
    // 028 Uc                                       0001866A0E10 ModelEnumType UnicodeCategory UnicodeCategory UnicodeCategory Int32
    // 02C CharLen                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 EndIndex                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 NextTextElementLen                       0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.Str                                       = GetString(new IntPtr(p + 0x010)); // 024666D8E630 0x10 Str                         ( 000186671910 ModelPrimitiveType string string string String )
            value.Index                                     = GetInt32(new IntPtr(p + 0x018)); // 024666D8E650 0x18 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StartIndex                                = GetInt32(new IntPtr(p + 0x01C)); // 024666D8E670 0x1C StartIndex                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StrLen                                    = GetInt32(new IntPtr(p + 0x020)); // 024666D8E690 0x20 StrLen                      ( 0001865F5290 ModelPrimitiveType int int int Int32 )
            value.CurrTextElementLen                        = GetInt32(new IntPtr(p + 0x024)); // 024666D8E6B0 0x24 CurrTextElementLen          ( 0001865F5290 ModelPrimitiveType int int int Int32 )
            value.Uc                                        = (UnicodeCategory)GetInt32(new IntPtr(p + 0x028)); // 024666D8E6D0 0x28 Uc                          ( 0001866A0E10 ModelEnumType UnicodeCategory UnicodeCategory UnicodeCategory Int32 )
            value.CharLen                                   = GetInt32(new IntPtr(p + 0x02C)); // 024666D8E6F0 0x2C CharLen                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EndIndex                                  = GetInt32(new IntPtr(p + 0x030)); // 024666D8E710 0x30 EndIndex                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NextTextElementLen                        = GetInt32(new IntPtr(p + 0x034)); // 024666D8E730 0x34 NextTextElementLen          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
