using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SourceFontFileName                       0001866722E0 ModelPrimitiveType string string string String
    // 018 SourceFontFileGUID                       0001866722E0 ModelPrimitiveType string string string String
    // 020 PointSizeSamplingMode                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 PointSize                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 Padding                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 02C PackingMode                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 AtlasWidth                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 034 AtlasHeight                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 038 CharacterSetSelectionMode                0001865F36C0 ModelPrimitiveType int int int Int32
    // 040 CharacterSequence                        0001866722E0 ModelPrimitiveType string string string String
    // 048 ReferencedFontAssetGUID                  0001866722E0 ModelPrimitiveType string string string String
    // 050 ReferencedTextAssetGUID                  0001866722E0 ModelPrimitiveType string string string String
    // 058 FontStyle                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 05C FontStyleModifier                        000186666050 ModelPrimitiveType float float float Single
    // 060 RenderMode                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 064 IncludeFontFeatures                      000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class FontAssetCreationSettings
    {
        public string                                   SourceFontFileName                      { get; set; }
        public string                                   SourceFontFileGUID                      { get; set; }
        public int                                      PointSizeSamplingMode                   { get; set; }
        public int                                      PointSize                               { get; set; }
        public int                                      Padding                                 { get; set; }
        public int                                      PackingMode                             { get; set; }
        public int                                      AtlasWidth                              { get; set; }
        public int                                      AtlasHeight                             { get; set; }
        public int                                      CharacterSetSelectionMode               { get; set; }
        public string                                   CharacterSequence                       { get; set; }
        public string                                   ReferencedFontAssetGUID                 { get; set; }
        public string                                   ReferencedTextAssetGUID                 { get; set; }
        public int                                      FontStyle                               { get; set; }
        public float                                    FontStyleModifier                       { get; set; }
        public int                                      RenderMode                              { get; set; }
        public bool                                     IncludeFontFeatures                     { get; set; }

        public static FontAssetCreationSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FontAssetCreationSettings();

            value.SourceFontFileName                        = GetString(new IntPtr(p + 0x010)); // 0270D098ED98 0x10 SourceFontFileName          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.SourceFontFileGUID                        = GetString(new IntPtr(p + 0x018)); // 0270D098EDB8 0x18 SourceFontFileGUID          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.PointSizeSamplingMode                     = GetInt32(new IntPtr(p + 0x020)); // 0270D098EDD8 0x20 PointSizeSamplingMode       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.PointSize                                 = GetInt32(new IntPtr(p + 0x024)); // 0270D098EDF8 0x24 PointSize                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Padding                                   = GetInt32(new IntPtr(p + 0x028)); // 0270D098EE18 0x28 Padding                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.PackingMode                               = GetInt32(new IntPtr(p + 0x02C)); // 0270D098EE38 0x2C PackingMode                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.AtlasWidth                                = GetInt32(new IntPtr(p + 0x030)); // 0270D098EE58 0x30 AtlasWidth                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.AtlasHeight                               = GetInt32(new IntPtr(p + 0x034)); // 0270D098EE78 0x34 AtlasHeight                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CharacterSetSelectionMode                 = GetInt32(new IntPtr(p + 0x038)); // 0270D098EE98 0x38 CharacterSetSelectionMode   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CharacterSequence                         = GetString(new IntPtr(p + 0x040)); // 0270D098EEB8 0x40 CharacterSequence           ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ReferencedFontAssetGUID                   = GetString(new IntPtr(p + 0x048)); // 0270D098EED8 0x48 ReferencedFontAssetGUID     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ReferencedTextAssetGUID                   = GetString(new IntPtr(p + 0x050)); // 0270D098EEF8 0x50 ReferencedTextAssetGUID     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.FontStyle                                 = GetInt32(new IntPtr(p + 0x058)); // 0270D098EF18 0x58 FontStyle                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FontStyleModifier                         = GetSingle(new IntPtr(p + 0x05C)); // 0270D098EF38 0x5C FontStyleModifier           ( 000186666050 ModelPrimitiveType float float float Single )
            value.RenderMode                                = GetInt32(new IntPtr(p + 0x060)); // 0270D098EF58 0x60 RenderMode                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IncludeFontFeatures                       = GetBool(new IntPtr(p + 0x064)); // 0270D098EF78 0x64 IncludeFontFeatures         ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
