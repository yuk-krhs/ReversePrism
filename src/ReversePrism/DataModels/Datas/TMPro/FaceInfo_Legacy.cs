using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 PointSize                                ModelPrimitiveType float float float Single
    // 01C Scale                                    ModelPrimitiveType float float float Single
    // 020 CharacterCount                           ModelPrimitiveType int int int Int32
    // 024 LineHeight                               ModelPrimitiveType float float float Single
    // 028 Baseline                                 ModelPrimitiveType float float float Single
    // 02C Ascender                                 ModelPrimitiveType float float float Single
    // 030 CapHeight                                ModelPrimitiveType float float float Single
    // 034 Descender                                ModelPrimitiveType float float float Single
    // 038 CenterLine                               ModelPrimitiveType float float float Single
    // 03C SuperscriptOffset                        ModelPrimitiveType float float float Single
    // 040 SubscriptOffset                          ModelPrimitiveType float float float Single
    // 044 SubSize                                  ModelPrimitiveType float float float Single
    // 048 Underline                                ModelPrimitiveType float float float Single
    // 04C UnderlineThickness                       ModelPrimitiveType float float float Single
    // 050 Strikethrough                            ModelPrimitiveType float float float Single
    // 054 StrikethroughThickness                   ModelPrimitiveType float float float Single
    // 058 TabWidth                                 ModelPrimitiveType float float float Single
    // 05C Padding                                  ModelPrimitiveType float float float Single
    // 060 AtlasWidth                               ModelPrimitiveType float float float Single
    // 064 AtlasHeight                              ModelPrimitiveType float float float Single
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

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.PointSize                                 = GetSingle(new IntPtr(p + 0x018)); // 0x18 PointSize                   ( ModelPrimitiveType float float float Single )
            value.Scale                                     = GetSingle(new IntPtr(p + 0x01C)); // 0x1C Scale                       ( ModelPrimitiveType float float float Single )
            value.CharacterCount                            = GetInt32(new IntPtr(p + 0x020)); // 0x20 CharacterCount              ( ModelPrimitiveType int int int Int32 )
            value.LineHeight                                = GetSingle(new IntPtr(p + 0x024)); // 0x24 LineHeight                  ( ModelPrimitiveType float float float Single )
            value.Baseline                                  = GetSingle(new IntPtr(p + 0x028)); // 0x28 Baseline                    ( ModelPrimitiveType float float float Single )
            value.Ascender                                  = GetSingle(new IntPtr(p + 0x02C)); // 0x2C Ascender                    ( ModelPrimitiveType float float float Single )
            value.CapHeight                                 = GetSingle(new IntPtr(p + 0x030)); // 0x30 CapHeight                   ( ModelPrimitiveType float float float Single )
            value.Descender                                 = GetSingle(new IntPtr(p + 0x034)); // 0x34 Descender                   ( ModelPrimitiveType float float float Single )
            value.CenterLine                                = GetSingle(new IntPtr(p + 0x038)); // 0x38 CenterLine                  ( ModelPrimitiveType float float float Single )
            value.SuperscriptOffset                         = GetSingle(new IntPtr(p + 0x03C)); // 0x3C SuperscriptOffset           ( ModelPrimitiveType float float float Single )
            value.SubscriptOffset                           = GetSingle(new IntPtr(p + 0x040)); // 0x40 SubscriptOffset             ( ModelPrimitiveType float float float Single )
            value.SubSize                                   = GetSingle(new IntPtr(p + 0x044)); // 0x44 SubSize                     ( ModelPrimitiveType float float float Single )
            value.Underline                                 = GetSingle(new IntPtr(p + 0x048)); // 0x48 Underline                   ( ModelPrimitiveType float float float Single )
            value.UnderlineThickness                        = GetSingle(new IntPtr(p + 0x04C)); // 0x4C UnderlineThickness          ( ModelPrimitiveType float float float Single )
            value.Strikethrough                             = GetSingle(new IntPtr(p + 0x050)); // 0x50 Strikethrough               ( ModelPrimitiveType float float float Single )
            value.StrikethroughThickness                    = GetSingle(new IntPtr(p + 0x054)); // 0x54 StrikethroughThickness      ( ModelPrimitiveType float float float Single )
            value.TabWidth                                  = GetSingle(new IntPtr(p + 0x058)); // 0x58 TabWidth                    ( ModelPrimitiveType float float float Single )
            value.Padding                                   = GetSingle(new IntPtr(p + 0x05C)); // 0x5C Padding                     ( ModelPrimitiveType float float float Single )
            value.AtlasWidth                                = GetSingle(new IntPtr(p + 0x060)); // 0x60 AtlasWidth                  ( ModelPrimitiveType float float float Single )
            value.AtlasHeight                               = GetSingle(new IntPtr(p + 0x064)); // 0x64 AtlasHeight                 ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
