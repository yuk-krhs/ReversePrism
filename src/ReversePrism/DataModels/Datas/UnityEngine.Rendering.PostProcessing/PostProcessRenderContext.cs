using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Camera                                 0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 018 Command                                  0001865DFD10 ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer
    // 020 Source                                   000186655450 ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32
    // 048 Destination                              000186655450 ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32
    // 070 SourceFormat                             00018665C190 ModelEnumType RenderTextureFormat RenderTextureFormat RenderTextureFormat Int32
    // 074 Flip                                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 078 Resources                                00018676DC00 ModelClassType PostProcessResources PostProcessResources PostProcessResources Pointer
    // 080 PropertySheets                           0001865D6000 ModelClassType PropertySheetFactory PropertySheetFactory PropertySheetFactory Pointer
    // 088 <userData>k__BackingField                Dictionary`2<string, <object>> IL2CPP_TYPE_GENERICINST
    // 090 Width                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 094 Height                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 098 StereoActive                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 09C XrActiveEye                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0A0 NumberOfEyes                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0A4 StereoRenderingMode                      00018659AD90 ModelEnumType StereoRenderingMode StereoRenderingMode StereoRenderingMode Int32
    // 0A8 ScreenWidth                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0AC ScreenHeight                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0B0 IsSceneView                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0B4 Antialiasing                             0001865997A0 ModelEnumType Antialiasing Antialiasing Antialiasing Int32
    // 0B8 UberSheet                                0001865D5920 ModelClassType PropertySheet PropertySheet PropertySheet Pointer
    // 0C0 AutoExposureTexture                      00018664D240 ModelClassType Texture Texture Texture Pointer
    // 0C8 LogLut                                   00018664D240 ModelClassType Texture Texture Texture Pointer
    // 0D0 BloomBufferNameID                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 0D4 PhysicalCamera                           000186595210 ModelPrimitiveType bool bool bool Bool
    // 0D8 M_sourceDescriptor                       000186657320 ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32
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

            value.M_Camera                                  = GetObject<Camera>(new IntPtr(p + 0x010), ReversePrism.DataModels.Camera.FromPointer); // 0245A3FFCA68 0x10 M_Camera                    ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.Command                                   = GetObject<CommandBuffer>(new IntPtr(p + 0x018), ReversePrism.DataModels.CommandBuffer.FromPointer); // 0245A3FFCA88 0x18 Command                     ( 0001865DFD10 ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer )
            value.Source                                    = (RenderTargetIdentifier)GetInt32(new IntPtr(p + 0x020)); // 0245A3FFCAA8 0x20 Source                      ( 000186655450 ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32 )
            value.Destination                               = (RenderTargetIdentifier)GetInt32(new IntPtr(p + 0x048)); // 0245A3FFCAC8 0x48 Destination                 ( 000186655450 ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32 )
            value.SourceFormat                              = (RenderTextureFormat)GetInt32(new IntPtr(p + 0x070)); // 0245A3FFCAE8 0x70 SourceFormat                ( 00018665C190 ModelEnumType RenderTextureFormat RenderTextureFormat RenderTextureFormat Int32 )
            value.Flip                                      = GetBool(new IntPtr(p + 0x074)); // 0245A3FFCB08 0x74 Flip                        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Resources                                 = GetObject<PostProcessResources>(new IntPtr(p + 0x078), ReversePrism.DataModels.PostProcessResources.FromPointer); // 0245A3FFCB28 0x78 Resources                   ( 00018676DC00 ModelClassType PostProcessResources PostProcessResources PostProcessResources Pointer )
            value.PropertySheets                            = GetObject<PropertySheetFactory>(new IntPtr(p + 0x080), ReversePrism.DataModels.PropertySheetFactory.FromPointer); // 0245A3FFCB48 0x80 PropertySheets              ( 0001865D6000 ModelClassType PropertySheetFactory PropertySheetFactory PropertySheetFactory Pointer )
            value.Width                                     = GetInt32(new IntPtr(p + 0x090)); // 0245A3FFCB88 0x90 Width                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Height                                    = GetInt32(new IntPtr(p + 0x094)); // 0245A3FFCBA8 0x94 Height                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StereoActive                              = GetBool(new IntPtr(p + 0x098)); // 0245A3FFCBC8 0x98 StereoActive                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.XrActiveEye                               = GetInt32(new IntPtr(p + 0x09C)); // 0245A3FFCBE8 0x9C XrActiveEye                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NumberOfEyes                              = GetInt32(new IntPtr(p + 0x0A0)); // 0245A3FFCC08 0xA0 NumberOfEyes                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.StereoRenderingMode                       = (StereoRenderingMode)GetInt32(new IntPtr(p + 0x0A4)); // 0245A3FFCC28 0xA4 StereoRenderingMode         ( 00018659AD90 ModelEnumType StereoRenderingMode StereoRenderingMode StereoRenderingMode Int32 )
            value.ScreenWidth                               = GetInt32(new IntPtr(p + 0x0A8)); // 0245A3FFCC48 0xA8 ScreenWidth                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ScreenHeight                              = GetInt32(new IntPtr(p + 0x0AC)); // 0245A3FFCC68 0xAC ScreenHeight                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsSceneView                               = GetBool(new IntPtr(p + 0x0B0)); // 0245A3FFCC88 0xB0 IsSceneView                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Antialiasing                              = (Antialiasing)GetInt32(new IntPtr(p + 0x0B4)); // 0245A3FFCCA8 0xB4 Antialiasing                ( 0001865997A0 ModelEnumType Antialiasing Antialiasing Antialiasing Int32 )
            value.UberSheet                                 = GetObject<PropertySheet>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.PropertySheet.FromPointer); // 0245A3FFCCC8 0xB8 UberSheet                   ( 0001865D5920 ModelClassType PropertySheet PropertySheet PropertySheet Pointer )
            value.AutoExposureTexture                       = GetObject<Texture>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Texture.FromPointer); // 0245A3FFCCE8 0xC0 AutoExposureTexture         ( 00018664D240 ModelClassType Texture Texture Texture Pointer )
            value.LogLut                                    = GetObject<Texture>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.Texture.FromPointer); // 0245A3FFCD08 0xC8 LogLut                      ( 00018664D240 ModelClassType Texture Texture Texture Pointer )
            value.BloomBufferNameID                         = GetInt32(new IntPtr(p + 0x0D0)); // 0245A3FFCD28 0xD0 BloomBufferNameID           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.PhysicalCamera                            = GetBool(new IntPtr(p + 0x0D4)); // 0245A3FFCD48 0xD4 PhysicalCamera              ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.M_sourceDescriptor                        = (RenderTextureDescriptor)GetInt32(new IntPtr(p + 0x0D8)); // 0245A3FFCD68 0xD8 M_sourceDescriptor          ( 000186657320 ModelEnumType RenderTextureDescriptor RenderTextureDescriptor RenderTextureDescriptor Int32 )

            return value;
        }
    }
}
