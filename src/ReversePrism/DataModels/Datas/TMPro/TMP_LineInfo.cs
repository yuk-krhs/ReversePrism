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
    // 020 WordCount                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 FirstCharacterIndex                      0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 FirstVisibleCharacterIndex               0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C LastCharacterIndex                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 LastVisibleCharacterIndex                0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 Length                                   000186666050 ModelPrimitiveType float float float Single
    // 038 LineHeight                               000186666050 ModelPrimitiveType float float float Single
    // 03C Ascender                                 000186666050 ModelPrimitiveType float float float Single
    // 040 Baseline                                 000186666050 ModelPrimitiveType float float float Single
    // 044 Descender                                000186666050 ModelPrimitiveType float float float Single
    // 048 MaxAdvance                               000186666050 ModelPrimitiveType float float float Single
    // 04C Width                                    000186666050 ModelPrimitiveType float float float Single
    // 050 MarginLeft                               000186666050 ModelPrimitiveType float float float Single
    // 054 MarginRight                              000186666050 ModelPrimitiveType float float float Single
    // 058 Alignment                                0001866D54B0 ModelEnumType HorizontalAlignmentOptions HorizontalAlignmentOptions HorizontalAlignmentOptions Int32
    // 05C LineExtents                              000186535DE0 ModelEnumType Extents Extents Extents Int32
    public partial class TMP_LineInfo : DataModel
    {
        public int                                      ControlCharacterCount                   { get; set; }
        public int                                      CharacterCount                          { get; set; }
        public int                                      VisibleCharacterCount                   { get; set; }
        public int                                      SpaceCount                              { get; set; }
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
        public HorizontalAlignmentOptions               Alignment                               { get; set; }
        public Extents                                  LineExtents                             { get; set; }

        public static TMP_LineInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_LineInfo() { Pointer= p0 };

            value.ControlCharacterCount                     = GetInt32(new IntPtr(p + 0x010)); // 0246609440B8 0x10 ControlCharacterCount       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.CharacterCount                            = GetInt32(new IntPtr(p + 0x014)); // 0246609440D8 0x14 CharacterCount              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.VisibleCharacterCount                     = GetInt32(new IntPtr(p + 0x018)); // 0246609440F8 0x18 VisibleCharacterCount       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SpaceCount                                = GetInt32(new IntPtr(p + 0x01C)); // 024660944118 0x1C SpaceCount                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.WordCount                                 = GetInt32(new IntPtr(p + 0x020)); // 024660944138 0x20 WordCount                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FirstCharacterIndex                       = GetInt32(new IntPtr(p + 0x024)); // 024660944158 0x24 FirstCharacterIndex         ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FirstVisibleCharacterIndex                = GetInt32(new IntPtr(p + 0x028)); // 024660944178 0x28 FirstVisibleCharacterIndex  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LastCharacterIndex                        = GetInt32(new IntPtr(p + 0x02C)); // 024660944198 0x2C LastCharacterIndex          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LastVisibleCharacterIndex                 = GetInt32(new IntPtr(p + 0x030)); // 0246609441B8 0x30 LastVisibleCharacterIndex   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetSingle(new IntPtr(p + 0x034)); // 0246609441D8 0x34 Length                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.LineHeight                                = GetSingle(new IntPtr(p + 0x038)); // 0246609441F8 0x38 LineHeight                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.Ascender                                  = GetSingle(new IntPtr(p + 0x03C)); // 024660944218 0x3C Ascender                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.Baseline                                  = GetSingle(new IntPtr(p + 0x040)); // 024660944238 0x40 Baseline                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.Descender                                 = GetSingle(new IntPtr(p + 0x044)); // 024660944258 0x44 Descender                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.MaxAdvance                                = GetSingle(new IntPtr(p + 0x048)); // 024660944278 0x48 MaxAdvance                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.Width                                     = GetSingle(new IntPtr(p + 0x04C)); // 024660944298 0x4C Width                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.MarginLeft                                = GetSingle(new IntPtr(p + 0x050)); // 0246609442B8 0x50 MarginLeft                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.MarginRight                               = GetSingle(new IntPtr(p + 0x054)); // 0246609442D8 0x54 MarginRight                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.Alignment                                 = (HorizontalAlignmentOptions)GetInt32(new IntPtr(p + 0x058)); // 0246609442F8 0x58 Alignment                   ( 0001866D54B0 ModelEnumType HorizontalAlignmentOptions HorizontalAlignmentOptions HorizontalAlignmentOptions Int32 )
            value.LineExtents                               = (Extents)GetInt32(new IntPtr(p + 0x05C)); // 024660944318 0x5C LineExtents                 ( 000186535DE0 ModelEnumType Extents Extents Extents Int32 )

            return value;
        }
    }
}
