using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 VolumeTrigger                            ModelClassType Transform Transform Transform Pointer
    // 028 VolumeLayer                              ModelEnumType LayerMask LayerMask LayerMask Int32
    // 02C StopNaNPropagation                       ModelPrimitiveType bool bool bool Bool
    // 02D FinalBlitToCameraTarget                  ModelPrimitiveType bool bool bool Bool
    // 030 AntialiasingMode                         ModelEnumType Antialiasing Antialiasing Antialiasing Int32
    // 038 FastApproximateAntialiasing              ModelClassType FastApproximateAntialiasing FastApproximateAntialiasing FastApproximateAntialiasing Pointer
    // 040 M_Resources                              ModelClassType PostProcessResources PostProcessResources PostProcessResources Pointer
    // 048 M_OldResources                           ModelClassType PostProcessResources PostProcessResources PostProcessResources Pointer
    // 050 M_ShowToolkit                            ModelPrimitiveType bool bool bool Bool
    // 051 M_ShowCustomSorter                       ModelPrimitiveType bool bool bool Bool
    // 052 BreakBeforeColorGrading                  ModelPrimitiveType bool bool bool Bool
    // 058 M_BeforeTransparentBundles               ModelClassListType List`1<SerializedBundleRef> List`1<SerializedBundleRef> List<SerializedBundleRef> Pointer
    // 060 M_BeforeStackBundles                     ModelClassListType List`1<SerializedBundleRef> List`1<SerializedBundleRef> List<SerializedBundleRef> Pointer
    // 068 M_AfterStackBundles                      ModelClassListType List`1<SerializedBundleRef> List`1<SerializedBundleRef> List<SerializedBundleRef> Pointer
    // 070 <sortedBundles>k__BackingField           Dictionary`2<PostProcessEvent, List`1<SerializedBundleRef>> IL2CPP_TYPE_GENERICINST
    // 078 CameraDepthFlags                         ModelEnumType DepthTextureMode DepthTextureMode DepthTextureMode Int32
    // 07C HaveBundlesBeenInited                    ModelPrimitiveType bool bool bool Bool
    // 080 m_Bundles                                Dictionary`2<Type, PostProcessBundle> IL2CPP_TYPE_GENERICINST
    // 088 M_PropertySheetFactory                   ModelClassType PropertySheetFactory PropertySheetFactory PropertySheetFactory Pointer
    // 090 M_LegacyCmdBufferBeforeReflections       ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer
    // 098 M_LegacyCmdBufferBeforeLighting          ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer
    // 0A0 M_LegacyCmdBufferOpaque                  ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer
    // 0A8 M_LegacyCmdBuffer                        ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer
    // 0B0 M_Camera                                 ModelClassType Camera Camera Camera Pointer
    // 0B8 M_CurrentContext                         ModelClassType PostProcessRenderContext PostProcessRenderContext PostProcessRenderContext Pointer
    // 0C0 M_SettingsUpdateNeeded                   ModelPrimitiveType bool bool bool Bool
    // 0C1 M_IsRenderingInSceneView                 ModelPrimitiveType bool bool bool Bool
    // 0C8 M_TargetPool                             ModelClassType TargetPool TargetPool TargetPool Pointer
    // 0D0 M_NaNKilled                              ModelPrimitiveType bool bool bool Bool
    // 0D8 M_ActiveEffects                          ModelClassListType List`1<PostProcessEffectRenderer> List`1<PostProcessEffectRenderer> List<PostProcessEffectRenderer> Pointer
    // 0E0 M_Targets                                ModelEnumListType List`1<RenderTargetIdentifier> List`1<RenderTargetIdentifier> List<RenderTargetIdentifier> Pointer
    // 000 PostProcessLayerList                     List`1<PostProcessLayer> IL2CPP_TYPE_GENERICINST
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

            value.VolumeTrigger                             = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 VolumeTrigger               ( ModelClassType Transform Transform Transform Pointer )
            value.VolumeLayer                               = (LayerMask)GetInt32(new IntPtr(p + 0x028)); // 0x28 VolumeLayer                 ( ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.StopNaNPropagation                        = GetBool(new IntPtr(p + 0x02C)); // 0x2C StopNaNPropagation          ( ModelPrimitiveType bool bool bool Bool )
            value.FinalBlitToCameraTarget                   = GetBool(new IntPtr(p + 0x02D)); // 0x2D FinalBlitToCameraTarget     ( ModelPrimitiveType bool bool bool Bool )
            value.AntialiasingMode                          = (Antialiasing)GetInt32(new IntPtr(p + 0x030)); // 0x30 AntialiasingMode            ( ModelEnumType Antialiasing Antialiasing Antialiasing Int32 )
            value.FastApproximateAntialiasing               = GetObject<FastApproximateAntialiasing>(new IntPtr(p + 0x038), ReversePrism.DataModels.FastApproximateAntialiasing.FromPointer); // 0x38 FastApproximateAntialiasing ( ModelClassType FastApproximateAntialiasing FastApproximateAntialiasing FastApproximateAntialiasing Pointer )
            value.M_Resources                               = GetObject<PostProcessResources>(new IntPtr(p + 0x040), ReversePrism.DataModels.PostProcessResources.FromPointer); // 0x40 M_Resources                 ( ModelClassType PostProcessResources PostProcessResources PostProcessResources Pointer )
            value.M_OldResources                            = GetObject<PostProcessResources>(new IntPtr(p + 0x048), ReversePrism.DataModels.PostProcessResources.FromPointer); // 0x48 M_OldResources              ( ModelClassType PostProcessResources PostProcessResources PostProcessResources Pointer )
            value.M_ShowToolkit                             = GetBool(new IntPtr(p + 0x050)); // 0x50 M_ShowToolkit               ( ModelPrimitiveType bool bool bool Bool )
            value.M_ShowCustomSorter                        = GetBool(new IntPtr(p + 0x051)); // 0x51 M_ShowCustomSorter          ( ModelPrimitiveType bool bool bool Bool )
            value.BreakBeforeColorGrading                   = GetBool(new IntPtr(p + 0x052)); // 0x52 BreakBeforeColorGrading     ( ModelPrimitiveType bool bool bool Bool )
            value.M_BeforeTransparentBundles                = GetObjectList<SerializedBundleRef>(new IntPtr(p + 0x058), ReversePrism.DataModels.SerializedBundleRef.FromPointer); // 0x58 M_BeforeTransparentBundles  ( ModelClassListType List`1<SerializedBundleRef> List`1<SerializedBundleRef> List<SerializedBundleRef> Pointer )
            value.M_BeforeStackBundles                      = GetObjectList<SerializedBundleRef>(new IntPtr(p + 0x060), ReversePrism.DataModels.SerializedBundleRef.FromPointer); // 0x60 M_BeforeStackBundles        ( ModelClassListType List`1<SerializedBundleRef> List`1<SerializedBundleRef> List<SerializedBundleRef> Pointer )
            value.M_AfterStackBundles                       = GetObjectList<SerializedBundleRef>(new IntPtr(p + 0x068), ReversePrism.DataModels.SerializedBundleRef.FromPointer); // 0x68 M_AfterStackBundles         ( ModelClassListType List`1<SerializedBundleRef> List`1<SerializedBundleRef> List<SerializedBundleRef> Pointer )
            value.CameraDepthFlags                          = (DepthTextureMode)GetInt32(new IntPtr(p + 0x078)); // 0x78 CameraDepthFlags            ( ModelEnumType DepthTextureMode DepthTextureMode DepthTextureMode Int32 )
            value.HaveBundlesBeenInited                     = GetBool(new IntPtr(p + 0x07C)); // 0x7C HaveBundlesBeenInited       ( ModelPrimitiveType bool bool bool Bool )
            value.M_PropertySheetFactory                    = GetObject<PropertySheetFactory>(new IntPtr(p + 0x088), ReversePrism.DataModels.PropertySheetFactory.FromPointer); // 0x88 M_PropertySheetFactory      ( ModelClassType PropertySheetFactory PropertySheetFactory PropertySheetFactory Pointer )
            value.M_LegacyCmdBufferBeforeReflections        = GetObject<CommandBuffer>(new IntPtr(p + 0x090), ReversePrism.DataModels.CommandBuffer.FromPointer); // 0x90 M_LegacyCmdBufferBeforeReflections ( ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer )
            value.M_LegacyCmdBufferBeforeLighting           = GetObject<CommandBuffer>(new IntPtr(p + 0x098), ReversePrism.DataModels.CommandBuffer.FromPointer); // 0x98 M_LegacyCmdBufferBeforeLighting ( ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer )
            value.M_LegacyCmdBufferOpaque                   = GetObject<CommandBuffer>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.CommandBuffer.FromPointer); // 0xA0 M_LegacyCmdBufferOpaque     ( ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer )
            value.M_LegacyCmdBuffer                         = GetObject<CommandBuffer>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.CommandBuffer.FromPointer); // 0xA8 M_LegacyCmdBuffer           ( ModelClassType CommandBuffer CommandBuffer CommandBuffer Pointer )
            value.M_Camera                                  = GetObject<Camera>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Camera.FromPointer); // 0xB0 M_Camera                    ( ModelClassType Camera Camera Camera Pointer )
            value.M_CurrentContext                          = GetObject<PostProcessRenderContext>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.PostProcessRenderContext.FromPointer); // 0xB8 M_CurrentContext            ( ModelClassType PostProcessRenderContext PostProcessRenderContext PostProcessRenderContext Pointer )
            value.M_SettingsUpdateNeeded                    = GetBool(new IntPtr(p + 0x0C0)); // 0xC0 M_SettingsUpdateNeeded      ( ModelPrimitiveType bool bool bool Bool )
            value.M_IsRenderingInSceneView                  = GetBool(new IntPtr(p + 0x0C1)); // 0xC1 M_IsRenderingInSceneView    ( ModelPrimitiveType bool bool bool Bool )
            value.M_TargetPool                              = GetObject<TargetPool>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.TargetPool.FromPointer); // 0xC8 M_TargetPool                ( ModelClassType TargetPool TargetPool TargetPool Pointer )
            value.M_NaNKilled                               = GetBool(new IntPtr(p + 0x0D0)); // 0xD0 M_NaNKilled                 ( ModelPrimitiveType bool bool bool Bool )
            value.M_ActiveEffects                           = GetObjectList<PostProcessEffectRenderer>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.PostProcessEffectRenderer.FromPointer); // 0xD8 M_ActiveEffects             ( ModelClassListType List`1<PostProcessEffectRenderer> List`1<PostProcessEffectRenderer> List<PostProcessEffectRenderer> Pointer )
            value.M_Targets                                 = GetEnumList<RenderTargetIdentifier>(new IntPtr(p + 0x0E0)); // 0xE0 M_Targets                   ( ModelEnumListType List`1<RenderTargetIdentifier> List`1<RenderTargetIdentifier> List<RenderTargetIdentifier> Pointer )

            return value;
        }
    }
}
