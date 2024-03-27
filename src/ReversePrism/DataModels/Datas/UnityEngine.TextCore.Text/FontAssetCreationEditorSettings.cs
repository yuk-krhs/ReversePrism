using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SourceFontFileGUID                       0001866722E0 ModelPrimitiveType string string string String
    // 018 FaceIndex                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C PointSizeSamplingMode                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 PointSize                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 Padding                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 PaddingMode                              0001865F36C0 ModelPrimitiveType int int int Int32
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
    public partial class FontAssetCreationEditorSettings
    {
        public string                                   SourceFontFileGUID                      { get; set; }
        public int                                      FaceIndex                               { get; set; }
        public int                                      PointSizeSamplingMode                   { get; set; }
        public int                                      PointSize                               { get; set; }
        public int                                      Padding                                 { get; set; }
        public int                                      PaddingMode                             { get; set; }
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

        public static FontAssetCreationEditorSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FontAssetCreationEditorSettings();

            value.SourceFontFileGUID                        = GetString(new IntPtr(p + 0x010)); // 0270068E7168 0x10 SourceFontFileGUID          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.FaceIndex                                 = GetInt32(new IntPtr(p + 0x018)); // 0270068E7188 0x18 FaceIndex                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.PointSizeSamplingMode                     = GetInt32(new IntPtr(p + 0x01C)); // 0270068E71A8 0x1C PointSizeSamplingMode       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.PointSize                                 = GetInt32(new IntPtr(p + 0x020)); // 0270068E71C8 0x20 PointSize                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Padding                                   = GetInt32(new IntPtr(p + 0x024)); // 0270068E71E8 0x24 Padding                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.PaddingMode                               = GetInt32(new IntPtr(p + 0x028)); // 0270068E7208 0x28 PaddingMode                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.PackingMode                               = GetInt32(new IntPtr(p + 0x02C)); // 0270068E7228 0x2C PackingMode                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.AtlasWidth                                = GetInt32(new IntPtr(p + 0x030)); // 0270068E7248 0x30 AtlasWidth                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.AtlasHeight                               = GetInt32(new IntPtr(p + 0x034)); // 0270068E7268 0x34 AtlasHeight                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CharacterSetSelectionMode                 = GetInt32(new IntPtr(p + 0x038)); // 0270068E7288 0x38 CharacterSetSelectionMode   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.CharacterSequence                         = GetString(new IntPtr(p + 0x040)); // 0270068E72A8 0x40 CharacterSequence           ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ReferencedFontAssetGUID                   = GetString(new IntPtr(p + 0x048)); // 0270068E72C8 0x48 ReferencedFontAssetGUID     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ReferencedTextAssetGUID                   = GetString(new IntPtr(p + 0x050)); // 0270068E72E8 0x50 ReferencedTextAssetGUID     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.FontStyle                                 = GetInt32(new IntPtr(p + 0x058)); // 0270068E7308 0x58 FontStyle                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FontStyleModifier                         = GetSingle(new IntPtr(p + 0x05C)); // 0270068E7328 0x5C FontStyleModifier           ( 000186666050 ModelPrimitiveType float float float Single )
            value.RenderMode                                = GetInt32(new IntPtr(p + 0x060)); // 0270068E7348 0x60 RenderMode                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IncludeFontFeatures                       = GetBool(new IntPtr(p + 0x064)); // 0270068E7368 0x64 IncludeFontFeatures         ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
