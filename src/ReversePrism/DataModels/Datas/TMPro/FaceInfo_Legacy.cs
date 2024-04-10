using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 PointSize                                000186666050 ModelPrimitiveType float float float Single
    // 01C Scale                                    000186666050 ModelPrimitiveType float float float Single
    // 020 CharacterCount                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 LineHeight                               000186666050 ModelPrimitiveType float float float Single
    // 028 Baseline                                 000186666050 ModelPrimitiveType float float float Single
    // 02C Ascender                                 000186666050 ModelPrimitiveType float float float Single
    // 030 CapHeight                                000186666050 ModelPrimitiveType float float float Single
    // 034 Descender                                000186666050 ModelPrimitiveType float float float Single
    // 038 CenterLine                               000186666050 ModelPrimitiveType float float float Single
    // 03C SuperscriptOffset                        000186666050 ModelPrimitiveType float float float Single
    // 040 SubscriptOffset                          000186666050 ModelPrimitiveType float float float Single
    // 044 SubSize                                  000186666050 ModelPrimitiveType float float float Single
    // 048 Underline                                000186666050 ModelPrimitiveType float float float Single
    // 04C UnderlineThickness                       000186666050 ModelPrimitiveType float float float Single
    // 050 Strikethrough                            000186666050 ModelPrimitiveType float float float Single
    // 054 StrikethroughThickness                   000186666050 ModelPrimitiveType float float float Single
    // 058 TabWidth                                 000186666050 ModelPrimitiveType float float float Single
    // 05C Padding                                  000186666050 ModelPrimitiveType float float float Single
    // 060 AtlasWidth                               000186666050 ModelPrimitiveType float float float Single
    // 064 AtlasHeight                              000186666050 ModelPrimitiveType float float float Single
    public partial class FaceInfo_Legacy : DataModel
    {
        public string                                   Name                                    { get; set; }
        public float                                    PointSize                               { get; set; }
        public float                                    Scale                                   { get; set; }
        public int                                      CharacterCount                          { get; set; }
        public float                                    LineHeight                              { get; set; }
        public float                                    Baseline                                { get; set; }
        public float                                    Ascender                                { get; set; }
        public float                                    CapHeight                               { get; set; }
        public float                                    Descender                               { get; set; }
        public float                                    CenterLine                              { get; set; }
        public float                                    SuperscriptOffset                       { get; set; }
        public float                                    SubscriptOffset                         { get; set; }
        public float                                    SubSize                                 { get; set; }
        public float                                    Underline                               { get; set; }
        public float                                    UnderlineThickness                      { get; set; }
        public float                                    Strikethrough                           { get; set; }
        public float                                    StrikethroughThickness                  { get; set; }
        public float                                    TabWidth                                { get; set; }
        public float                                    Padding                                 { get; set; }
        public float                                    AtlasWidth                              { get; set; }
        public float                                    AtlasHeight                             { get; set; }

        public static FaceInfo_Legacy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FaceInfo_Legacy() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0246609D6030 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.PointSize                                 = GetSingle(new IntPtr(p + 0x018)); // 0246609D6050 0x18 PointSize                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.Scale                                     = GetSingle(new IntPtr(p + 0x01C)); // 0246609D6070 0x1C Scale                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.CharacterCount                            = GetInt32(new IntPtr(p + 0x020)); // 0246609D6090 0x20 CharacterCount              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LineHeight                                = GetSingle(new IntPtr(p + 0x024)); // 0246609D60B0 0x24 LineHeight                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.Baseline                                  = GetSingle(new IntPtr(p + 0x028)); // 0246609D60D0 0x28 Baseline                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.Ascender                                  = GetSingle(new IntPtr(p + 0x02C)); // 0246609D60F0 0x2C Ascender                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.CapHeight                                 = GetSingle(new IntPtr(p + 0x030)); // 0246609D6110 0x30 CapHeight                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.Descender                                 = GetSingle(new IntPtr(p + 0x034)); // 0246609D6130 0x34 Descender                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.CenterLine                                = GetSingle(new IntPtr(p + 0x038)); // 0246609D6150 0x38 CenterLine                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.SuperscriptOffset                         = GetSingle(new IntPtr(p + 0x03C)); // 0246609D6170 0x3C SuperscriptOffset           ( 000186666050 ModelPrimitiveType float float float Single )
            value.SubscriptOffset                           = GetSingle(new IntPtr(p + 0x040)); // 0246609D6190 0x40 SubscriptOffset             ( 000186666050 ModelPrimitiveType float float float Single )
            value.SubSize                                   = GetSingle(new IntPtr(p + 0x044)); // 0246609D61B0 0x44 SubSize                     ( 000186666050 ModelPrimitiveType float float float Single )
            value.Underline                                 = GetSingle(new IntPtr(p + 0x048)); // 0246609D61D0 0x48 Underline                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.UnderlineThickness                        = GetSingle(new IntPtr(p + 0x04C)); // 0246609D61F0 0x4C UnderlineThickness          ( 000186666050 ModelPrimitiveType float float float Single )
            value.Strikethrough                             = GetSingle(new IntPtr(p + 0x050)); // 0246609D6210 0x50 Strikethrough               ( 000186666050 ModelPrimitiveType float float float Single )
            value.StrikethroughThickness                    = GetSingle(new IntPtr(p + 0x054)); // 0246609D6230 0x54 StrikethroughThickness      ( 000186666050 ModelPrimitiveType float float float Single )
            value.TabWidth                                  = GetSingle(new IntPtr(p + 0x058)); // 0246609D6250 0x58 TabWidth                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.Padding                                   = GetSingle(new IntPtr(p + 0x05C)); // 0246609D6270 0x5C Padding                     ( 000186666050 ModelPrimitiveType float float float Single )
            value.AtlasWidth                                = GetSingle(new IntPtr(p + 0x060)); // 0246609D6290 0x60 AtlasWidth                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.AtlasHeight                               = GetSingle(new IntPtr(p + 0x064)); // 0246609D62B0 0x64 AtlasHeight                 ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
