using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AOMethod                                 ModelEnumType AOMethodOptions AOMethodOptions AOMethodOptions Int32
    // 014 Downsample                               ModelPrimitiveType bool bool bool Bool
    // 015 AfterOpaque                              ModelPrimitiveType bool bool bool Bool
    // 018 Source                                   ModelEnumType DepthSource DepthSource DepthSource Int32
    // 01C NormalSamples                            ModelEnumType NormalQuality NormalQuality NormalQuality Int32
    // 020 Intensity                                ModelPrimitiveType float float float Single
    // 024 DirectLightingStrength                   ModelPrimitiveType float float float Single
    // 028 Radius                                   ModelPrimitiveType float float float Single
    // 02C Samples                                  ModelEnumType AOSampleOption AOSampleOption AOSampleOption Int32
    // 030 BlurQuality                              ModelEnumType BlurQualityOptions BlurQualityOptions BlurQualityOptions Int32
    // 034 Falloff                                  ModelPrimitiveType float float float Single
    // 038 SampleCount                              ModelPrimitiveType int int int Int32
    public partial class ScreenSpaceAmbientOcclusionSettings : DataModel
    {
        public AOMethodOptions                          AOMethod                                { get; set; }
        public bool                                     Downsample                              { get; set; }
        public bool                                     AfterOpaque                             { get; set; }
        public DepthSource                              Source                                  { get; set; }
        public NormalQuality                            NormalSamples                           { get; set; }
        public float                                    Intensity                               { get; set; }
        public float                                    DirectLightingStrength                  { get; set; }
        public float                                    Radius                                  { get; set; }
        public AOSampleOption                           Samples                                 { get; set; }
        public BlurQualityOptions                       BlurQuality                             { get; set; }
        public float                                    Falloff                                 { get; set; }
        public int                                      SampleCount                             { get; set; }

        public static ScreenSpaceAmbientOcclusionSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScreenSpaceAmbientOcclusionSettings() { Pointer= p0 };

            value.AOMethod                                  = (AOMethodOptions)GetInt32(new IntPtr(p + 0x010)); // 0x10 AOMethod                    ( ModelEnumType AOMethodOptions AOMethodOptions AOMethodOptions Int32 )
            value.Downsample                                = GetBool(new IntPtr(p + 0x014)); // 0x14 Downsample                  ( ModelPrimitiveType bool bool bool Bool )
            value.AfterOpaque                               = GetBool(new IntPtr(p + 0x015)); // 0x15 AfterOpaque                 ( ModelPrimitiveType bool bool bool Bool )
            value.Source                                    = (DepthSource)GetInt32(new IntPtr(p + 0x018)); // 0x18 Source                      ( ModelEnumType DepthSource DepthSource DepthSource Int32 )
            value.NormalSamples                             = (NormalQuality)GetInt32(new IntPtr(p + 0x01C)); // 0x1C NormalSamples               ( ModelEnumType NormalQuality NormalQuality NormalQuality Int32 )
            value.Intensity                                 = GetSingle(new IntPtr(p + 0x020)); // 0x20 Intensity                   ( ModelPrimitiveType float float float Single )
            value.DirectLightingStrength                    = GetSingle(new IntPtr(p + 0x024)); // 0x24 DirectLightingStrength      ( ModelPrimitiveType float float float Single )
            value.Radius                                    = GetSingle(new IntPtr(p + 0x028)); // 0x28 Radius                      ( ModelPrimitiveType float float float Single )
            value.Samples                                   = (AOSampleOption)GetInt32(new IntPtr(p + 0x02C)); // 0x2C Samples                     ( ModelEnumType AOSampleOption AOSampleOption AOSampleOption Int32 )
            value.BlurQuality                               = (BlurQualityOptions)GetInt32(new IntPtr(p + 0x030)); // 0x30 BlurQuality                 ( ModelEnumType BlurQualityOptions BlurQualityOptions BlurQualityOptions Int32 )
            value.Falloff                                   = GetSingle(new IntPtr(p + 0x034)); // 0x34 Falloff                     ( ModelPrimitiveType float float float Single )
            value.SampleCount                               = GetInt32(new IntPtr(p + 0x038)); // 0x38 SampleCount                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
