using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Camera                                 ModelClassType Camera Camera Camera Pointer
    // 018 Command                                  ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer
    // 020 Source                                   ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32
    // 048 Destination                              ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32
    // 070 SourceFormat                             ModelEnumType RenderTextureFormat RenderTextureFormat RenderTextureFormat Int32
    // 074 Flip                                     ModelPrimitiveType bool bool bool Bool
    // 078 Resources                                ModelClassType PostProcessResources PostProcessResources PostProcessResources Pointer
    // 080 PropertySheets                           ModelClassType PropertySheetFactory PropertySheetFactory PropertySheetFactory Pointer
    // 088 <userData>k__BackingField                Dictionary`2<string, <object>> IL2CPP_TYPE_GENERICINST
    // 090 Width                                    ModelPrimitiveType int int int Int32
    // 094 Height                                   ModelPrimitiveType int int int Int32
    // 098 StereoActive                             ModelPrimitiveType bool bool bool Bool
    // 09C XrActiveEye                              ModelPrimitiveType int int int Int32
    // 0A0 NumberOfEyes                             ModelPrimitiveType int int int Int32
    // 0A4 StereoRenderingMode                      ModelEnumType StereoRenderingMode StereoRenderingMode StereoRenderingMode Int32
    // 0A8 ScreenWidth                              ModelPrimitiveType int int int Int32
    // 0AC ScreenHeight                             ModelPrimitiveType int int int Int32
    // 0B0 IsSceneView                              ModelPrimitiveType bool bool bool Bool
    // 0B4 Antialiasing                             ModelEnumType Antialiasing Antialiasing Antialiasing Int32
    // 0B8 UberSheet                                ModelClassType PropertySheet PropertySheet PropertySheet Pointer
    // 0C0 AutoExposureTexture                      ModelClassType Texture Texture Texture Pointer
    // 0C8 LogLut                                   ModelClassType Texture Texture Texture Pointer
    // 0D0 BloomBufferNameID                        ModelPrimitiveType int int int Int32
    // 0D4 PhysicalCamera                           ModelPrimitiveType bool bool bool Bool
    // 0D8 M_sourceDescriptor                       ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32
    public partial class PostProcessRenderContext : DataModel
    {
        public Camera?                                  M_Camera                                { get; set; }
        public CommandBuffer?                           Command                                 { get; set; }
        public RenderTargetIdentifier                   Source                                  { get; set; }
        public RenderTargetIdentifier                   Destination                             { get; set; }
        public RenderTextureFormat                      SourceFormat                            { get; set; }
        public bool                                     Flip                                    { get; set; }
        public PostProcessResources?                    Resources                               { get; set; }
        public PropertySheetFactory?                    PropertySheets                          { get; set; }
        public int                                      Width                                   { get; set; }
        public int                                      Height                                  { get; set; }
        public bool                                     StereoActive                            { get; set; }
        public int                                      XrActiveEye                             { get; set; }
        public int                                      NumberOfEyes                            { get; set; }
        public StereoRenderingMode                      StereoRenderingMode                     { get; set; }
        public int                                      ScreenWidth                             { get; set; }
        public int                                      ScreenHeight                            { get; set; }
        public bool                                     IsSceneView                             { get; set; }
        public Antialiasing                             Antialiasing                            { get; set; }
        public PropertySheet?                           UberSheet                               { get; set; }
        public Texture?                                 AutoExposureTexture                     { get; set; }
        public Texture?                                 LogLut                                  { get; set; }
        public int                                      BloomBufferNameID                       { get; set; }
        public bool                                     PhysicalCamera                          { get; set; }
        public RenderTextureDescriptor                  M_sourceDescriptor                      { get; set; }

        public static PostProcessRenderContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PostProcessRenderContext() { Pointer= p0 };

            value.M_Camera                                  = GetObject<Camera>(new IntPtr(p + 0x010), ReversePrism.DataModels.Camera.FromPointer); // 0x10 M_Camera                    ( ModelClassType Camera Camera Camera Pointer )
            value.Command                                   = GetObject<CommandBuffer>(new IntPtr(p + 0x018), ReversePrism.DataModels.CommandBuffer.FromPointer); // 0x18 Command                     ( ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer )
            value.Source                                    = (RenderTargetIdentifier)GetInt32(new IntPtr(p + 0x020)); // 0x20 Source                      ( ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32 )
            value.Destination                               = (RenderTargetIdentifier)GetInt32(new IntPtr(p + 0x048)); // 0x48 Destination                 ( ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32 )
            value.SourceFormat                              = (RenderTextureFormat)GetInt32(new IntPtr(p + 0x070)); // 0x70 SourceFormat                ( ModelEnumType RenderTextureFormat RenderTextureFormat RenderTextureFormat Int32 )
            value.Flip                                      = GetBool(new IntPtr(p + 0x074)); // 0x74 Flip                        ( ModelPrimitiveType bool bool bool Bool )
            value.Resources                                 = GetObject<PostProcessResources>(new IntPtr(p + 0x078), ReversePrism.DataModels.PostProcessResources.FromPointer); // 0x78 Resources                   ( ModelClassType PostProcessResources PostProcessResources PostProcessResources Pointer )
            value.PropertySheets                            = GetObject<PropertySheetFactory>(new IntPtr(p + 0x080), ReversePrism.DataModels.PropertySheetFactory.FromPointer); // 0x80 PropertySheets              ( ModelClassType PropertySheetFactory PropertySheetFactory PropertySheetFactory Pointer )
            value.Width                                     = GetInt32(new IntPtr(p + 0x090)); // 0x90 Width                       ( ModelPrimitiveType int int int Int32 )
            value.Height                                    = GetInt32(new IntPtr(p + 0x094)); // 0x94 Height                      ( ModelPrimitiveType int int int Int32 )
            value.StereoActive                              = GetBool(new IntPtr(p + 0x098)); // 0x98 StereoActive                ( ModelPrimitiveType bool bool bool Bool )
            value.XrActiveEye                               = GetInt32(new IntPtr(p + 0x09C)); // 0x9C XrActiveEye                 ( ModelPrimitiveType int int int Int32 )
            value.NumberOfEyes                              = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 NumberOfEyes                ( ModelPrimitiveType int int int Int32 )
            value.StereoRenderingMode                       = (StereoRenderingMode)GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 StereoRenderingMode         ( ModelEnumType StereoRenderingMode StereoRenderingMode StereoRenderingMode Int32 )
            value.ScreenWidth                               = GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 ScreenWidth                 ( ModelPrimitiveType int int int Int32 )
            value.ScreenHeight                              = GetInt32(new IntPtr(p + 0x0AC)); // 0xAC ScreenHeight                ( ModelPrimitiveType int int int Int32 )
            value.IsSceneView                               = GetBool(new IntPtr(p + 0x0B0)); // 0xB0 IsSceneView                 ( ModelPrimitiveType bool bool bool Bool )
            value.Antialiasing                              = (Antialiasing)GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 Antialiasing                ( ModelEnumType Antialiasing Antialiasing Antialiasing Int32 )
            value.UberSheet                                 = GetObject<PropertySheet>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.PropertySheet.FromPointer); // 0xB8 UberSheet                   ( ModelClassType PropertySheet PropertySheet PropertySheet Pointer )
            value.AutoExposureTexture                       = GetObject<Texture>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Texture.FromPointer); // 0xC0 AutoExposureTexture         ( ModelClassType Texture Texture Texture Pointer )
            value.LogLut                                    = GetObject<Texture>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Texture.FromPointer); // 0xC8 LogLut                      ( ModelClassType Texture Texture Texture Pointer )
            value.BloomBufferNameID                         = GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 BloomBufferNameID           ( ModelPrimitiveType int int int Int32 )
            value.PhysicalCamera                            = GetBool(new IntPtr(p + 0x0D4)); // 0xD4 PhysicalCamera              ( ModelPrimitiveType bool bool bool Bool )
            value.M_sourceDescriptor                        = (RenderTextureDescriptor)GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 M_sourceDescriptor          ( ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32 )

            return value;
        }
    }
}
