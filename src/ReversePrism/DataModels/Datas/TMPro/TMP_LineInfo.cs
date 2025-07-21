using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ControlCharacterCount                    ModelPrimitiveType int int int Int32
    // 014 CharacterCount                           ModelPrimitiveType int int int Int32
    // 018 VisibleCharacterCount                    ModelPrimitiveType int int int Int32
    // 01C SpaceCount                               ModelPrimitiveType int int int Int32
    // 020 WordCount                                ModelPrimitiveType int int int Int32
    // 024 FirstCharacterIndex                      ModelPrimitiveType int int int Int32
    // 028 FirstVisibleCharacterIndex               ModelPrimitiveType int int int Int32
    // 02C LastCharacterIndex                       ModelPrimitiveType int int int Int32
    // 030 LastVisibleCharacterIndex                ModelPrimitiveType int int int Int32
    // 034 Length                                   ModelPrimitiveType float float float Single
    // 038 LineHeight                               ModelPrimitiveType float float float Single
    // 03C Ascender                                 ModelPrimitiveType float float float Single
    // 040 Baseline                                 ModelPrimitiveType float float float Single
    // 044 Descender                                ModelPrimitiveType float float float Single
    // 048 MaxAdvance                               ModelPrimitiveType float float float Single
    // 04C Width                                    ModelPrimitiveType float float float Single
    // 050 MarginLeft                               ModelPrimitiveType float float float Single
    // 054 MarginRight                              ModelPrimitiveType float float float Single
    // 058 Alignment                                ModelEnumType HorizontalAlignmentOptions HorizontalAlignmentOptions HorizontalAlignmentOptions Int32
    // 05C LineExtents                              ModelEnumType Extents Extents Extents Int32
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

            value.ControlCharacterCount                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 ControlCharacterCount       ( ModelPrimitiveType int int int Int32 )
            value.CharacterCount                            = GetInt32(new IntPtr(p + 0x014)); // 0x14 CharacterCount              ( ModelPrimitiveType int int int Int32 )
            value.VisibleCharacterCount                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 VisibleCharacterCount       ( ModelPrimitiveType int int int Int32 )
            value.SpaceCount                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C SpaceCount                  ( ModelPrimitiveType int int int Int32 )
            value.WordCount                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 WordCount                   ( ModelPrimitiveType int int int Int32 )
            value.FirstCharacterIndex                       = GetInt32(new IntPtr(p + 0x024)); // 0x24 FirstCharacterIndex         ( ModelPrimitiveType int int int Int32 )
            value.FirstVisibleCharacterIndex                = GetInt32(new IntPtr(p + 0x028)); // 0x28 FirstVisibleCharacterIndex  ( ModelPrimitiveType int int int Int32 )
            value.LastCharacterIndex                        = GetInt32(new IntPtr(p + 0x02C)); // 0x2C LastCharacterIndex          ( ModelPrimitiveType int int int Int32 )
            value.LastVisibleCharacterIndex                 = GetInt32(new IntPtr(p + 0x030)); // 0x30 LastVisibleCharacterIndex   ( ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetSingle(new IntPtr(p + 0x034)); // 0x34 Length                      ( ModelPrimitiveType float float float Single )
            value.LineHeight                                = GetSingle(new IntPtr(p + 0x038)); // 0x38 LineHeight                  ( ModelPrimitiveType float float float Single )
            value.Ascender                                  = GetSingle(new IntPtr(p + 0x03C)); // 0x3C Ascender                    ( ModelPrimitiveType float float float Single )
            value.Baseline                                  = GetSingle(new IntPtr(p + 0x040)); // 0x40 Baseline                    ( ModelPrimitiveType float float float Single )
            value.Descender                                 = GetSingle(new IntPtr(p + 0x044)); // 0x44 Descender                   ( ModelPrimitiveType float float float Single )
            value.MaxAdvance                                = GetSingle(new IntPtr(p + 0x048)); // 0x48 MaxAdvance                  ( ModelPrimitiveType float float float Single )
            value.Width                                     = GetSingle(new IntPtr(p + 0x04C)); // 0x4C Width                       ( ModelPrimitiveType float float float Single )
            value.MarginLeft                                = GetSingle(new IntPtr(p + 0x050)); // 0x50 MarginLeft                  ( ModelPrimitiveType float float float Single )
            value.MarginRight                               = GetSingle(new IntPtr(p + 0x054)); // 0x54 MarginRight                 ( ModelPrimitiveType float float float Single )
            value.Alignment                                 = (HorizontalAlignmentOptions)GetInt32(new IntPtr(p + 0x058)); // 0x58 Alignment                   ( ModelEnumType HorizontalAlignmentOptions HorizontalAlignmentOptions HorizontalAlignmentOptions Int32 )
            value.LineExtents                               = (Extents)GetInt32(new IntPtr(p + 0x05C)); // 0x5C LineExtents                 ( ModelEnumType Extents Extents Extents Int32 )

            return value;
        }
    }
}
