using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 VolumeTrigger                            0001866AA650 ModelClassType Transform Transform Transform Pointer
    // 028 VolumeLayer                              00018650B660 ModelEnumType LayerMask LayerMask LayerMask Int32
    // 02C StopNaNPropagation                       000186595960 ModelPrimitiveType bool bool bool Bool
    // 02D FinalBlitToCameraTarget                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 030 AntialiasingMode                         0001865999F0 ModelEnumType Antialiasing Antialiasing Antialiasing Int32
    // 038 FastApproximateAntialiasing              000186557B30 ModelClassType FastApproximateAntialiasing FastApproximateAntialiasing FastApproximateAntialiasing Pointer
    // 040 M_Resources                              00018676DC00 ModelClassType PostProcessResources PostProcessResources PostProcessResources Pointer
    // 048 M_OldResources                           00018676E100 ModelClassType PostProcessResources PostProcessResources PostProcessResources Pointer
    // 050 M_ShowToolkit                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 051 M_ShowCustomSorter                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 052 BreakBeforeColorGrading                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 058 M_BeforeTransparentBundles               000185D28448 ModelClassListType List`1<SerializedBundleRef> List`1<SerializedBundleRef> List<SerializedBundleRef> Pointer
    // 060 M_BeforeStackBundles                     000185D28448 ModelClassListType List`1<SerializedBundleRef> List`1<SerializedBundleRef> List<SerializedBundleRef> Pointer
    // 068 M_AfterStackBundles                      000185D28448 ModelClassListType List`1<SerializedBundleRef> List`1<SerializedBundleRef> List<SerializedBundleRef> Pointer
    // 070 <sortedBundles>k__BackingField           Dictionary`2<PostProcessEvent, List`1<SerializedBundleRef>> IL2CPP_TYPE_GENERICINST
    // 078 CameraDepthFlags                         0001866C3F10 ModelEnumType DepthTextureMode DepthTextureMode DepthTextureMode Int32
    // 07C HaveBundlesBeenInited                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 080 m_Bundles                                Dictionary`2<Type, PostProcessBundle> IL2CPP_TYPE_GENERICINST
    // 088 M_PropertySheetFactory                   0001865D6000 ModelClassType PropertySheetFactory PropertySheetFactory PropertySheetFactory Pointer
    // 090 M_LegacyCmdBufferBeforeReflections       0001865DFD10 ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer
    // 098 M_LegacyCmdBufferBeforeLighting          0001865DFD10 ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer
    // 0A0 M_LegacyCmdBufferOpaque                  0001865DFD10 ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer
    // 0A8 M_LegacyCmdBuffer                        0001865DFD10 ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer
    // 0B0 M_Camera                                 0001865A1C90 ModelClassType Camera Camera Camera Pointer
    // 0B8 M_CurrentContext                         00018676D470 ModelClassType PostProcessRenderContext PostProcessRenderContext PostProcessRenderContext Pointer
    // 0C0 M_SettingsUpdateNeeded                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0C1 M_IsRenderingInSceneView                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0C8 M_TargetPool                             0001866200C0 ModelClassType TargetPool TargetPool TargetPool Pointer
    // 0D0 M_NaNKilled                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0D8 M_ActiveEffects                          000185CFA678 ModelClassListType List`1<PostProcessEffectRenderer> List`1<PostProcessEffectRenderer> List<PostProcessEffectRenderer> Pointer
    // 0E0 M_Targets                                000185D01DE8 ModelEnumListType List`1<RenderTargetIdentifier> List`1<RenderTargetIdentifier> List<RenderTargetIdentifier> Pointer
    public partial class PostProcessLayer : DataModel
    {
        public Transform?                               VolumeTrigger                           { get; set; }
        public LayerMask                                VolumeLayer                             { get; set; }
        public bool                                     StopNaNPropagation                      { get; set; }
        public bool                                     FinalBlitToCameraTarget                 { get; set; }
        public Antialiasing                             AntialiasingMode                        { get; set; }
        public FastApproximateAntialiasing?             FastApproximateAntialiasing             { get; set; }
        public PostProcessResources?                    M_Resources                             { get; set; }
        public PostProcessResources?                    M_OldResources                          { get; set; }
        public bool                                     M_ShowToolkit                           { get; set; }
        public bool                                     M_ShowCustomSorter                      { get; set; }
        public bool                                     BreakBeforeColorGrading                 { get; set; }
        public List<SerializedBundleRef>?               M_BeforeTransparentBundles              { get; set; }
        public List<SerializedBundleRef>?               M_BeforeStackBundles                    { get; set; }
        public List<SerializedBundleRef>?               M_AfterStackBundles                     { get; set; }
        public DepthTextureMode                         CameraDepthFlags                        { get; set; }
        public bool                                     HaveBundlesBeenInited                   { get; set; }
        public PropertySheetFactory?                    M_PropertySheetFactory                  { get; set; }
        public CommandBuffer?                           M_LegacyCmdBufferBeforeReflections      { get; set; }
        public CommandBuffer?                           M_LegacyCmdBufferBeforeLighting         { get; set; }
        public CommandBuffer?                           M_LegacyCmdBufferOpaque                 { get; set; }
        public CommandBuffer?                           M_LegacyCmdBuffer                       { get; set; }
        public Camera?                                  M_Camera                                { get; set; }
        public PostProcessRenderContext?                M_CurrentContext                        { get; set; }
        public bool                                     M_SettingsUpdateNeeded                  { get; set; }
        public bool                                     M_IsRenderingInSceneView                { get; set; }
        public TargetPool?                              M_TargetPool                            { get; set; }
        public bool                                     M_NaNKilled                             { get; set; }
        public List<PostProcessEffectRenderer>?         M_ActiveEffects                         { get; set; }
        public List<RenderTargetIdentifier>?            M_Targets                               { get; set; }

        public static PostProcessLayer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PostProcessLayer() { Pointer= p0 };

            value.VolumeTrigger                             = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 024660F33B10 0x20 VolumeTrigger               ( 0001866AA650 ModelClassType Transform Transform Transform Pointer )
            value.VolumeLayer                               = (LayerMask)GetInt32(new IntPtr(p + 0x028)); // 024660F33B30 0x28 VolumeLayer                 ( 00018650B660 ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.StopNaNPropagation                        = GetBool(new IntPtr(p + 0x02C)); // 024660F33B50 0x2C StopNaNPropagation          ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.FinalBlitToCameraTarget                   = GetBool(new IntPtr(p + 0x02D)); // 024660F33B70 0x2D FinalBlitToCameraTarget     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.AntialiasingMode                          = (Antialiasing)GetInt32(new IntPtr(p + 0x030)); // 024660F33B90 0x30 AntialiasingMode            ( 0001865999F0 ModelEnumType Antialiasing Antialiasing Antialiasing Int32 )
            value.FastApproximateAntialiasing               = GetObject<FastApproximateAntialiasing>(new IntPtr(p + 0x038), ReversePrism.DataModels.FastApproximateAntialiasing.FromPointer); // 024660F33BB0 0x38 FastApproximateAntialiasing ( 000186557B30 ModelClassType FastApproximateAntialiasing FastApproximateAntialiasing FastApproximateAntialiasing Pointer )
            value.M_Resources                               = GetObject<PostProcessResources>(new IntPtr(p + 0x040), ReversePrism.DataModels.PostProcessResources.FromPointer); // 024660F33BD0 0x40 M_Resources                 ( 00018676DC00 ModelClassType PostProcessResources PostProcessResources PostProcessResources Pointer )
            value.M_OldResources                            = GetObject<PostProcessResources>(new IntPtr(p + 0x048), ReversePrism.DataModels.PostProcessResources.FromPointer); // 024660F33BF0 0x48 M_OldResources              ( 00018676E100 ModelClassType PostProcessResources PostProcessResources PostProcessResources Pointer )
            value.M_ShowToolkit                             = GetBool(new IntPtr(p + 0x050)); // 024660F33C10 0x50 M_ShowToolkit               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ShowCustomSorter                        = GetBool(new IntPtr(p + 0x051)); // 024660F33C30 0x51 M_ShowCustomSorter          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BreakBeforeColorGrading                   = GetBool(new IntPtr(p + 0x052)); // 024660F33C50 0x52 BreakBeforeColorGrading     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.M_BeforeTransparentBundles                = GetObjectList<SerializedBundleRef>(new IntPtr(p + 0x058), ReversePrism.DataModels.SerializedBundleRef.FromPointer); // 024660F33C70 0x58 M_BeforeTransparentBundles  ( 000185D28448 ModelClassListType List`1<SerializedBundleRef> List`1<SerializedBundleRef> List<SerializedBundleRef> Pointer )
            value.M_BeforeStackBundles                      = GetObjectList<SerializedBundleRef>(new IntPtr(p + 0x060), ReversePrism.DataModels.SerializedBundleRef.FromPointer); // 024660F33C90 0x60 M_BeforeStackBundles        ( 000185D28448 ModelClassListType List`1<SerializedBundleRef> List`1<SerializedBundleRef> List<SerializedBundleRef> Pointer )
            value.M_AfterStackBundles                       = GetObjectList<SerializedBundleRef>(new IntPtr(p + 0x068), ReversePrism.DataModels.SerializedBundleRef.FromPointer); // 024660F33CB0 0x68 M_AfterStackBundles         ( 000185D28448 ModelClassListType List`1<SerializedBundleRef> List`1<SerializedBundleRef> List<SerializedBundleRef> Pointer )
            value.CameraDepthFlags                          = (DepthTextureMode)GetInt32(new IntPtr(p + 0x078)); // 024660F33CF0 0x78 CameraDepthFlags            ( 0001866C3F10 ModelEnumType DepthTextureMode DepthTextureMode DepthTextureMode Int32 )
            value.HaveBundlesBeenInited                     = GetBool(new IntPtr(p + 0x07C)); // 024660F33D10 0x7C HaveBundlesBeenInited       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_PropertySheetFactory                    = GetObject<PropertySheetFactory>(new IntPtr(p + 0x088), ReversePrism.DataModels.PropertySheetFactory.FromPointer); // 024660F33D50 0x88 M_PropertySheetFactory      ( 0001865D6000 ModelClassType PropertySheetFactory PropertySheetFactory PropertySheetFactory Pointer )
            value.M_LegacyCmdBufferBeforeReflections        = GetObject<CommandBuffer>(new IntPtr(p + 0x090), ReversePrism.DataModels.CommandBuffer.FromPointer); // 024660F33D70 0x90 M_LegacyCmdBufferBeforeReflections ( 0001865DFD10 ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer )
            value.M_LegacyCmdBufferBeforeLighting           = GetObject<CommandBuffer>(new IntPtr(p + 0x098), ReversePrism.DataModels.CommandBuffer.FromPointer); // 024660F33D90 0x98 M_LegacyCmdBufferBeforeLighting ( 0001865DFD10 ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer )
            value.M_LegacyCmdBufferOpaque                   = GetObject<CommandBuffer>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.CommandBuffer.FromPointer); // 024660F33DB0 0xA0 M_LegacyCmdBufferOpaque     ( 0001865DFD10 ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer )
            value.M_LegacyCmdBuffer                         = GetObject<CommandBuffer>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.CommandBuffer.FromPointer); // 024660F33DD0 0xA8 M_LegacyCmdBuffer           ( 0001865DFD10 ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer )
            value.M_Camera                                  = GetObject<Camera>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Camera.FromPointer); // 024660F33DF0 0xB0 M_Camera                    ( 0001865A1C90 ModelClassType Camera Camera Camera Pointer )
            value.M_CurrentContext                          = GetObject<PostProcessRenderContext>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.PostProcessRenderContext.FromPointer); // 024660F33E10 0xB8 M_CurrentContext            ( 00018676D470 ModelClassType PostProcessRenderContext PostProcessRenderContext PostProcessRenderContext Pointer )
            value.M_SettingsUpdateNeeded                    = GetBool(new IntPtr(p + 0x0C0)); // 024660F33E30 0xC0 M_SettingsUpdateNeeded      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_IsRenderingInSceneView                  = GetBool(new IntPtr(p + 0x0C1)); // 024660F33E50 0xC1 M_IsRenderingInSceneView    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_TargetPool                              = GetObject<TargetPool>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.TargetPool.FromPointer); // 024660F33E70 0xC8 M_TargetPool                ( 0001866200C0 ModelClassType TargetPool TargetPool TargetPool Pointer )
            value.M_NaNKilled                               = GetBool(new IntPtr(p + 0x0D0)); // 024660F33E90 0xD0 M_NaNKilled                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ActiveEffects                           = GetObjectList<PostProcessEffectRenderer>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.PostProcessEffectRenderer.FromPointer); // 024660F33EB0 0xD8 M_ActiveEffects             ( 000185CFA678 ModelClassListType List`1<PostProcessEffectRenderer> List`1<PostProcessEffectRenderer> List<PostProcessEffectRenderer> Pointer )
            value.M_Targets                                 = GetEnumList<RenderTargetIdentifier>(new IntPtr(p + 0x0E0)); // 024660F33ED0 0xE0 M_Targets                   ( 000185D01DE8 ModelEnumListType List`1<RenderTargetIdentifier> List`1<RenderTargetIdentifier> List<RenderTargetIdentifier> Pointer )

            return value;
        }
    }
}
