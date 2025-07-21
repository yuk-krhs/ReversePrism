using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kRenderPassMapSize                       int IL2CPP_TYPE_I4
    // 000 kRenderPassMaxCount                      int IL2CPP_TYPE_I4
    // 010 M_LastBeginSubpassPassIndex              ModelPrimitiveType int int int Int32
    // 018 m_MergeableRenderPassesMap               Dictionary`2<Hash128, int[]> IL2CPP_TYPE_GENERICINST
    // 020 m_MergeableRenderPassesMapArrays         int[][] IL2CPP_TYPE_SZARRAY
    // 028 M_PassIndexToPassHash                    ModelEnumListType Hash128[] Hash128[] List<Hash128> Pointer
    // 030 m_RenderPassesAttachmentCount            Dictionary`2<Hash128, int> IL2CPP_TYPE_GENERICINST
    // 038 M_ActiveColorAttachmentDescriptors       ModelEnumListType AttachmentDescriptor[] AttachmentDescriptor[] List<AttachmentDescriptor> Pointer
    // 040 M_ActiveDepthAttachmentDescriptor        ModelEnumType AttachmentDescriptor AttachmentDescriptor AttachmentDescriptor Int32
    // 0B8 M_IsActiveColorAttachmentTransient       ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    // 0C0 M_FinalColorStoreAction                  ModelEnumListType RenderBufferStoreAction[] RenderBufferStoreAction[] List<RenderBufferStoreAction> Pointer
    // 0C8 M_FinalDepthStoreAction                  ModelEnumType RenderBufferStoreAction RenderBufferStoreAction RenderBufferStoreAction Int32
    // 0D0 ProfilingExecute                         ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 0D8 HasReleasedRTs                           ModelPrimitiveType bool bool bool Bool
    // 0E0 DebugHandler                             ModelClassType DebugHandler DebugHandler DebugHandler Pointer
    // 000 current                                  ScriptableRenderer IL2CPP_TYPE_CLASS
    // 0E8 SupportedRenderingFeatures               ModelClassType RenderingFeatures RenderingFeatures RenderingFeatures Pointer
    // 0F0 UnsupportedGraphicsDeviceTypes           ModelEnumListType GraphicsDeviceType[] GraphicsDeviceType[] List<GraphicsDeviceType> Pointer
    // 0F8 M_StoreActionsOptimizationSetting        ModelEnumType StoreActionsOptimization StoreActionsOptimization StoreActionsOptimization Int32
    // 008 m_UseOptimizedStoreActions               bool IL2CPP_TYPE_BOOLEAN
    // 000 k_RenderPassBlockCount                   int IL2CPP_TYPE_I4
    // 010 K_CameraTarget                           ModelClassType RTHandle RTHandle RTHandle Pointer
    // 100 M_ActiveRenderPassQueue                  ModelClassListType List`1<ScriptableRenderPass> List`1<ScriptableRenderPass> List<ScriptableRenderPass> Pointer
    // 108 M_RendererFeatures                       ModelClassListType List`1<ScriptableRendererFeature> List`1<ScriptableRendererFeature> List<ScriptableRendererFeature> Pointer
    // 110 M_CameraColorTarget                      ModelEnumType RTHandleRenderTargetIdentifierCompat RTHandleRenderTargetIdentifierCompat RTHandleRenderTargetIdentifierCompat Int32
    // 140 M_CameraDepthTarget                      ModelEnumType RTHandleRenderTargetIdentifierCompat RTHandleRenderTargetIdentifierCompat RTHandleRenderTargetIdentifierCompat Int32
    // 170 M_CameraResolveTarget                    ModelEnumType RTHandleRenderTargetIdentifierCompat RTHandleRenderTargetIdentifierCompat RTHandleRenderTargetIdentifierCompat Int32
    // 1A0 M_FirstTimeCameraColorTargetIsBound      ModelPrimitiveType bool bool bool Bool
    // 1A1 M_FirstTimeCameraDepthTargetIsBound      ModelPrimitiveType bool bool bool Bool
    // 1A2 M_IsPipelineExecuting                    ModelPrimitiveType bool bool bool Bool
    // 1A3 DisableNativeRenderPassInFeatures        ModelPrimitiveType bool bool bool Bool
    // 1A4 UseRenderPassEnabled                     ModelPrimitiveType bool bool bool Bool
    // 018 M_ActiveColorAttachments                 ModelEnumListType RenderTargetIdentifier[] RenderTargetIdentifier[] List<RenderTargetIdentifier> Pointer
    // 020 M_ActiveDepthAttachment                  ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32
    // 048 M_ActiveColorStoreActions                ModelEnumListType RenderBufferStoreAction[] RenderBufferStoreAction[] List<RenderBufferStoreAction> Pointer
    // 050 M_ActiveDepthStoreAction                 ModelEnumType RenderBufferStoreAction RenderBufferStoreAction RenderBufferStoreAction Int32
    // 058 m_TrimmedColorAttachmentCopies           RenderTargetIdentifier[][] IL2CPP_TYPE_SZARRAY
    // 060 S_Planes                                 ModelEnumListType Plane[] Plane[] List<Plane> Pointer
    // 068 S_VectorPlanes                           ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 1A5 UseDepthPriming                          ModelPrimitiveType bool bool bool Bool
    // 1A6 StripShadowsOffVariants                  ModelPrimitiveType bool bool bool Bool
    // 1A7 StripAdditionalLightOffVariants          ModelPrimitiveType bool bool bool Bool
    public partial class ScriptableRenderer : DataModel
    {
        public int                                      M_LastBeginSubpassPassIndex             { get; set; }
        public List<Hash128>?                           M_PassIndexToPassHash                   { get; set; }
        public List<AttachmentDescriptor>?              M_ActiveColorAttachmentDescriptors      { get; set; }
        public AttachmentDescriptor                     M_ActiveDepthAttachmentDescriptor       { get; set; }
        public List<bool>?                              M_IsActiveColorAttachmentTransient      { get; set; }
        public List<RenderBufferStoreAction>?           M_FinalColorStoreAction                 { get; set; }
        public RenderBufferStoreAction                  M_FinalDepthStoreAction                 { get; set; }
        public ProfilingSampler?                        ProfilingExecute                        { get; set; }
        public bool                                     HasReleasedRTs                          { get; set; }
        public DebugHandler?                            DebugHandler                            { get; set; }
        public RenderingFeatures?                       SupportedRenderingFeatures              { get; set; }
        public List<GraphicsDeviceType>?                UnsupportedGraphicsDeviceTypes          { get; set; }
        public StoreActionsOptimization                 M_StoreActionsOptimizationSetting       { get; set; }
        public RTHandle?                                K_CameraTarget                          { get; set; }
        public List<ScriptableRenderPass>?              M_ActiveRenderPassQueue                 { get; set; }
        public List<ScriptableRendererFeature>?         M_RendererFeatures                      { get; set; }
        public RTHandleRenderTargetIdentifierCompat     M_CameraColorTarget                     { get; set; }
        public RTHandleRenderTargetIdentifierCompat     M_CameraDepthTarget                     { get; set; }
        public RTHandleRenderTargetIdentifierCompat     M_CameraResolveTarget                   { get; set; }
        public bool                                     M_FirstTimeCameraColorTargetIsBound     { get; set; }
        public bool                                     M_FirstTimeCameraDepthTargetIsBound     { get; set; }
        public bool                                     M_IsPipelineExecuting                   { get; set; }
        public bool                                     DisableNativeRenderPassInFeatures       { get; set; }
        public bool                                     UseRenderPassEnabled                    { get; set; }
        public List<RenderTargetIdentifier>?            M_ActiveColorAttachments                { get; set; }
        public RenderTargetIdentifier                   M_ActiveDepthAttachment                 { get; set; }
        public List<RenderBufferStoreAction>?           M_ActiveColorStoreActions               { get; set; }
        public RenderBufferStoreAction                  M_ActiveDepthStoreAction                { get; set; }
        public List<Plane>?                             S_Planes                                { get; set; }
        public List<Vector4>?                           S_VectorPlanes                          { get; set; }
        public bool                                     UseDepthPriming                         { get; set; }
        public bool                                     StripShadowsOffVariants                 { get; set; }
        public bool                                     StripAdditionalLightOffVariants         { get; set; }

        public static ScriptableRenderer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScriptableRenderer() { Pointer= p0 };

            value.M_LastBeginSubpassPassIndex               = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_LastBeginSubpassPassIndex ( ModelPrimitiveType int int int Int32 )
            value.M_PassIndexToPassHash                     = GetEnumList<Hash128>(new IntPtr(p + 0x028)); // 0x28 M_PassIndexToPassHash       ( ModelEnumListType Hash128[] Hash128[] List<Hash128> Pointer )
            value.M_ActiveColorAttachmentDescriptors        = GetEnumList<AttachmentDescriptor>(new IntPtr(p + 0x038)); // 0x38 M_ActiveColorAttachmentDescriptors ( ModelEnumListType AttachmentDescriptor[] AttachmentDescriptor[] List<AttachmentDescriptor> Pointer )
            value.M_ActiveDepthAttachmentDescriptor         = (AttachmentDescriptor)GetInt32(new IntPtr(p + 0x040)); // 0x40 M_ActiveDepthAttachmentDescriptor ( ModelEnumType AttachmentDescriptor AttachmentDescriptor AttachmentDescriptor Int32 )
            value.M_IsActiveColorAttachmentTransient        = GetBoolList(new IntPtr(p + 0x0B8)); // 0xB8 M_IsActiveColorAttachmentTransient ( ModelPrimitiveListType bool[] bool[] List<bool> Pointer )
            value.M_FinalColorStoreAction                   = GetEnumList<RenderBufferStoreAction>(new IntPtr(p + 0x0C0)); // 0xC0 M_FinalColorStoreAction     ( ModelEnumListType RenderBufferStoreAction[] RenderBufferStoreAction[] List<RenderBufferStoreAction> Pointer )
            value.M_FinalDepthStoreAction                   = (RenderBufferStoreAction)GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 M_FinalDepthStoreAction     ( ModelEnumType RenderBufferStoreAction RenderBufferStoreAction RenderBufferStoreAction Int32 )
            value.ProfilingExecute                          = GetObject<ProfilingSampler>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0xD0 ProfilingExecute            ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.HasReleasedRTs                            = GetBool(new IntPtr(p + 0x0D8)); // 0xD8 HasReleasedRTs              ( ModelPrimitiveType bool bool bool Bool )
            value.DebugHandler                              = GetObject<DebugHandler>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.DebugHandler.FromPointer); // 0xE0 DebugHandler                ( ModelClassType DebugHandler DebugHandler DebugHandler Pointer )
            value.SupportedRenderingFeatures                = GetObject<RenderingFeatures>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.RenderingFeatures.FromPointer); // 0xE8 SupportedRenderingFeatures  ( ModelClassType RenderingFeatures RenderingFeatures RenderingFeatures Pointer )
            value.UnsupportedGraphicsDeviceTypes            = GetEnumList<GraphicsDeviceType>(new IntPtr(p + 0x0F0)); // 0xF0 UnsupportedGraphicsDeviceTypes ( ModelEnumListType GraphicsDeviceType[] GraphicsDeviceType[] List<GraphicsDeviceType> Pointer )
            value.M_StoreActionsOptimizationSetting         = (StoreActionsOptimization)GetInt32(new IntPtr(p + 0x0F8)); // 0xF8 M_StoreActionsOptimizationSetting ( ModelEnumType StoreActionsOptimization StoreActionsOptimization StoreActionsOptimization Int32 )
            value.K_CameraTarget                            = GetObject<RTHandle>(new IntPtr(p + 0x010), ReversePrism.DataModels.RTHandle.FromPointer); // 0x10 K_CameraTarget              ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_ActiveRenderPassQueue                   = GetObjectList<ScriptableRenderPass>(new IntPtr(p + 0x100), ReversePrism.DataModels.ScriptableRenderPass.FromPointer); // 0x100 M_ActiveRenderPassQueue     ( ModelClassListType List`1<ScriptableRenderPass> List`1<ScriptableRenderPass> List<ScriptableRenderPass> Pointer )
            value.M_RendererFeatures                        = GetObjectList<ScriptableRendererFeature>(new IntPtr(p + 0x108), ReversePrism.DataModels.ScriptableRendererFeature.FromPointer); // 0x108 M_RendererFeatures          ( ModelClassListType List`1<ScriptableRendererFeature> List`1<ScriptableRendererFeature> List<ScriptableRendererFeature> Pointer )
            value.M_CameraColorTarget                       = (RTHandleRenderTargetIdentifierCompat)GetInt32(new IntPtr(p + 0x110)); // 0x110 M_CameraColorTarget         ( ModelEnumType RTHandleRenderTargetIdentifierCompat RTHandleRenderTargetIdentifierCompat RTHandleRenderTargetIdentifierCompat Int32 )
            value.M_CameraDepthTarget                       = (RTHandleRenderTargetIdentifierCompat)GetInt32(new IntPtr(p + 0x140)); // 0x140 M_CameraDepthTarget         ( ModelEnumType RTHandleRenderTargetIdentifierCompat RTHandleRenderTargetIdentifierCompat RTHandleRenderTargetIdentifierCompat Int32 )
            value.M_CameraResolveTarget                     = (RTHandleRenderTargetIdentifierCompat)GetInt32(new IntPtr(p + 0x170)); // 0x170 M_CameraResolveTarget       ( ModelEnumType RTHandleRenderTargetIdentifierCompat RTHandleRenderTargetIdentifierCompat RTHandleRenderTargetIdentifierCompat Int32 )
            value.M_FirstTimeCameraColorTargetIsBound       = GetBool(new IntPtr(p + 0x1A0)); // 0x1A0 M_FirstTimeCameraColorTargetIsBound ( ModelPrimitiveType bool bool bool Bool )
            value.M_FirstTimeCameraDepthTargetIsBound       = GetBool(new IntPtr(p + 0x1A1)); // 0x1A1 M_FirstTimeCameraDepthTargetIsBound ( ModelPrimitiveType bool bool bool Bool )
            value.M_IsPipelineExecuting                     = GetBool(new IntPtr(p + 0x1A2)); // 0x1A2 M_IsPipelineExecuting       ( ModelPrimitiveType bool bool bool Bool )
            value.DisableNativeRenderPassInFeatures         = GetBool(new IntPtr(p + 0x1A3)); // 0x1A3 DisableNativeRenderPassInFeatures ( ModelPrimitiveType bool bool bool Bool )
            value.UseRenderPassEnabled                      = GetBool(new IntPtr(p + 0x1A4)); // 0x1A4 UseRenderPassEnabled        ( ModelPrimitiveType bool bool bool Bool )
            value.M_ActiveColorAttachments                  = GetEnumList<RenderTargetIdentifier>(new IntPtr(p + 0x018)); // 0x18 M_ActiveColorAttachments    ( ModelEnumListType RenderTargetIdentifier[] RenderTargetIdentifier[] List<RenderTargetIdentifier> Pointer )
            value.M_ActiveDepthAttachment                   = (RenderTargetIdentifier)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_ActiveDepthAttachment     ( ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32 )
            value.M_ActiveColorStoreActions                 = GetEnumList<RenderBufferStoreAction>(new IntPtr(p + 0x048)); // 0x48 M_ActiveColorStoreActions   ( ModelEnumListType RenderBufferStoreAction[] RenderBufferStoreAction[] List<RenderBufferStoreAction> Pointer )
            value.M_ActiveDepthStoreAction                  = (RenderBufferStoreAction)GetInt32(new IntPtr(p + 0x050)); // 0x50 M_ActiveDepthStoreAction    ( ModelEnumType RenderBufferStoreAction RenderBufferStoreAction RenderBufferStoreAction Int32 )
            value.S_Planes                                  = GetEnumList<Plane>(new IntPtr(p + 0x060)); // 0x60 S_Planes                    ( ModelEnumListType Plane[] Plane[] List<Plane> Pointer )
            value.S_VectorPlanes                            = GetEnumList<Vector4>(new IntPtr(p + 0x068)); // 0x68 S_VectorPlanes              ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.UseDepthPriming                           = GetBool(new IntPtr(p + 0x1A5)); // 0x1A5 UseDepthPriming             ( ModelPrimitiveType bool bool bool Bool )
            value.StripShadowsOffVariants                   = GetBool(new IntPtr(p + 0x1A6)); // 0x1A6 StripShadowsOffVariants     ( ModelPrimitiveType bool bool bool Bool )
            value.StripAdditionalLightOffVariants           = GetBool(new IntPtr(p + 0x1A7)); // 0x1A7 StripAdditionalLightOffVariants ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
