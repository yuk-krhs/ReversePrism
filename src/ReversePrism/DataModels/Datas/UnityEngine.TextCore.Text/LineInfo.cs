using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ControlCharacterCount                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 014 CharacterCount                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 VisibleCharacterCount                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C SpaceCount                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 VisibleSpaceCount                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 WordCount                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 FirstCharacterIndex                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C FirstVisibleCharacterIndex               0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 LastCharacterIndex                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 LastVisibleCharacterIndex                0001865F36C0 ModelPrimitiveType int int int Int32
    // 038 Length                                   000186666050 ModelPrimitiveType float float float Single
    // 03C LineHeight                               000186666050 ModelPrimitiveType float float float Single
    // 040 Ascender                                 000186666050 ModelPrimitiveType float float float Single
    // 044 Baseline                                 000186666050 ModelPrimitiveType float float float Single
    // 048 Descender                                000186666050 ModelPrimitiveType float float float Single
    // 04C MaxAdvance                               000186666050 ModelPrimitiveType float float float Single
    // 050 Width                                    000186666050 ModelPrimitiveType float float float Single
    // 054 MarginLeft                               000186666050 ModelPrimitiveType float float float Single
    // 058 MarginRight                              000186666050 ModelPrimitiveType float float float Single
    // 05C Alignment                                0001866327C0 ModelEnumType TextAlignment TextAlignment TextAlignment Int32
    // 060 LineExtents                              0001865367D0 ModelEnumType Extents Extents Extents Int32
    public partial class LineInfo : DataModel
    {
        public int                                      ControlCharacterCount                   { get; set; }
        public int                                      CharacterCount                          { get; set; }
        public int                                      VisibleCharacterCount                   { get; set; }
        public int                                      SpaceCount                              { get; set; }
        public int                                      VisibleSpaceCount                       { get; set; }
        public int                                      WordCount                               { get; set; }
        public int                                      FirstCharacterIndex                     { get; set; }
        public int                                      FirstVisibleCharacterIndex              { get; set; }
        public int                                      LastCharacterIndex                      { get; set; }
        public int                                      LastVisibleCharacterIndex               { get; set; }
        public float                                    Length                                  { get; set; }
        public float                                    LineHeight                              { get; set; }
        public float                                    Ascender                                { get; set; }
        public float                                    Baseline                                { get; set; }
        public float                                    Descender                               { get; set; }
        public float                                    MaxAdvance                              { get; set; }
        public float                                    Width                                   { get; set; }
        public float                                    MarginLeft                              { get; set; }
        public float                                    MarginRight                             { get; set; }
        public TextAlignment                            Alignment                               { get; set; }
        public Extents                                  LineExtents                             { get; set; }

        public static LineInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LineInfo() { Pointer= p0 };

            value.ControlCharacterCount                     = GetInt32(new IntPtr(p + 0x010)); // 0245A68ABAB0 0x10 ControlCharacterCount       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.CharacterCount                            = GetInt32(new IntPtr(p + 0x014)); // 0245A68ABAD0 0x14 CharacterCount              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.VisibleCharacterCount                     = GetInt32(new IntPtr(p + 0x018)); // 0245A68ABAF0 0x18 VisibleCharacterCount       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SpaceCount                                = GetInt32(new IntPtr(p + 0x01C)); // 0245A68ABB10 0x1C SpaceCount                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.VisibleSpaceCount                         = GetInt32(new IntPtr(p + 0x020)); // 0245A68ABB30 0x20 VisibleSpaceCount           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.WordCount                                 = GetInt32(new IntPtr(p + 0x024)); // 0245A68ABB50 0x24 WordCount                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FirstCharacterIndex                       = GetInt32(new IntPtr(p + 0x028)); // 0245A68ABB70 0x28 FirstCharacterIndex         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FirstVisibleCharacterIndex                = GetInt32(new IntPtr(p + 0x02C)); // 0245A68ABB90 0x2C FirstVisibleCharacterIndex  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LastCharacterIndex                        = GetInt32(new IntPtr(p + 0x030)); // 0245A68ABBB0 0x30 LastCharacterIndex          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LastVisibleCharacterIndex                 = GetInt32(new IntPtr(p + 0x034)); // 0245A68ABBD0 0x34 LastVisibleCharacterIndex   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetSingle(new IntPtr(p + 0x038)); // 0245A68ABBF0 0x38 Length                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.LineHeight                                = GetSingle(new IntPtr(p + 0x03C)); // 0245A68ABC10 0x3C LineHeight                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.Ascender                                  = GetSingle(new IntPtr(p + 0x040)); // 0245A68ABC30 0x40 Ascender                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.Baseline                                  = GetSingle(new IntPtr(p + 0x044)); // 0245A68ABC50 0x44 Baseline                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.Descender                                 = GetSingle(new IntPtr(p + 0x048)); // 0245A68ABC70 0x48 Descender                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.MaxAdvance                                = GetSingle(new IntPtr(p + 0x04C)); // 0245A68ABC90 0x4C MaxAdvance                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.Width                                     = GetSingle(new IntPtr(p + 0x050)); // 0245A68ABCB0 0x50 Width                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.MarginLeft                                = GetSingle(new IntPtr(p + 0x054)); // 0245A68ABCD0 0x54 MarginLeft                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.MarginRight                               = GetSingle(new IntPtr(p + 0x058)); // 0245A68ABCF0 0x58 MarginRight                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.Alignment                                 = (TextAlignment)GetInt32(new IntPtr(p + 0x05C)); // 0245A68ABD10 0x5C Alignment                   ( 0001866327C0 ModelEnumType TextAlignment TextAlignment TextAlignment Int32 )
            value.LineExtents                               = (Extents)GetInt32(new IntPtr(p + 0x060)); // 0245A68ABD30 0x60 LineExtents                 ( 0001865367D0 ModelEnumType Extents Extents Extents Int32 )

            return value;
        }
    }
}
