using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SourceFontFileGUID                       ModelPrimitiveType string string string String
    // 018 FaceIndex                                ModelPrimitiveType int int int Int32
    // 01C PointSizeSamplingMode                    ModelPrimitiveType int int int Int32
    // 020 PointSize                                ModelPrimitiveType int int int Int32
    // 024 Padding                                  ModelPrimitiveType int int int Int32
    // 028 PaddingMode                              ModelPrimitiveType int int int Int32
    // 02C PackingMode                              ModelPrimitiveType int int int Int32
    // 030 AtlasWidth                               ModelPrimitiveType int int int Int32
    // 034 AtlasHeight                              ModelPrimitiveType int int int Int32
    // 038 CharacterSetSelectionMode                ModelPrimitiveType int int int Int32
    // 040 CharacterSequence                        ModelPrimitiveType string string string String
    // 048 ReferencedFontAssetGUID                  ModelPrimitiveType string string string String
    // 050 ReferencedTextAssetGUID                  ModelPrimitiveType string string string String
    // 058 FontStyle                                ModelPrimitiveType int int int Int32
    // 05C FontStyleModifier                        ModelPrimitiveType float float float Single
    // 060 RenderMode                               ModelPrimitiveType int int int Int32
    // 064 IncludeFontFeatures                      ModelPrimitiveType bool bool bool Bool
    public partial class FontAssetCreationEditorSettings : DataModel
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
            var value   = new FontAssetCreationEditorSettings() { Pointer= p0 };

            value.SourceFontFileGUID                        = GetString(new IntPtr(p + 0x010)); // 0x10 SourceFontFileGUID          ( ModelPrimitiveType string string string String )
            value.FaceIndex                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 FaceIndex                   ( ModelPrimitiveType int int int Int32 )
            value.PointSizeSamplingMode                     = GetInt32(new IntPtr(p + 0x01C)); // 0x1C PointSizeSamplingMode       ( ModelPrimitiveType int int int Int32 )
            value.PointSize                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 PointSize                   ( ModelPrimitiveType int int int Int32 )
            value.Padding                                   = GetInt32(new IntPtr(p + 0x024)); // 0x24 Padding                     ( ModelPrimitiveType int int int Int32 )
            value.PaddingMode                               = GetInt32(new IntPtr(p + 0x028)); // 0x28 PaddingMode                 ( ModelPrimitiveType int int int Int32 )
            value.PackingMode                               = GetInt32(new IntPtr(p + 0x02C)); // 0x2C PackingMode                 ( ModelPrimitiveType int int int Int32 )
            value.AtlasWidth                                = GetInt32(new IntPtr(p + 0x030)); // 0x30 AtlasWidth                  ( ModelPrimitiveType int int int Int32 )
            value.AtlasHeight                               = GetInt32(new IntPtr(p + 0x034)); // 0x34 AtlasHeight                 ( ModelPrimitiveType int int int Int32 )
            value.CharacterSetSelectionMode                 = GetInt32(new IntPtr(p + 0x038)); // 0x38 CharacterSetSelectionMode   ( ModelPrimitiveType int int int Int32 )
            value.CharacterSequence                         = GetString(new IntPtr(p + 0x040)); // 0x40 CharacterSequence           ( ModelPrimitiveType string string string String )
            value.ReferencedFontAssetGUID                   = GetString(new IntPtr(p + 0x048)); // 0x48 ReferencedFontAssetGUID     ( ModelPrimitiveType string string string String )
            value.ReferencedTextAssetGUID                   = GetString(new IntPtr(p + 0x050)); // 0x50 ReferencedTextAssetGUID     ( ModelPrimitiveType string string string String )
            value.FontStyle                                 = GetInt32(new IntPtr(p + 0x058)); // 0x58 FontStyle                   ( ModelPrimitiveType int int int Int32 )
            value.FontStyleModifier                         = GetSingle(new IntPtr(p + 0x05C)); // 0x5C FontStyleModifier           ( ModelPrimitiveType float float float Single )
            value.RenderMode                                = GetInt32(new IntPtr(p + 0x060)); // 0x60 RenderMode                  ( ModelPrimitiveType int int int Int32 )
            value.IncludeFontFeatures                       = GetBool(new IntPtr(p + 0x064)); // 0x64 IncludeFontFeatures         ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
