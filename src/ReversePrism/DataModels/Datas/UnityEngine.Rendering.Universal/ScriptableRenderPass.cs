using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_CameraTarget                           RTHandle IL2CPP_TYPE_CLASS
    // 010 RenderPassEvent                          ModelEnumType RenderPassEvent RenderPassEvent RenderPassEvent Int32
    // 018 M_ColorStoreActions                      ModelEnumListType RenderBufferStoreAction[] RenderBufferStoreAction[] List<RenderBufferStoreAction> Pointer
    // 020 M_DepthStoreAction                       ModelEnumType RenderBufferStoreAction RenderBufferStoreAction RenderBufferStoreAction Int32
    // 028 M_OverriddenColorStoreActions            ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    // 030 M_OverriddenDepthStoreAction             ModelPrimitiveType bool bool bool Bool
    // 038 ProfilingSampler                         ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 040 OverrideCameraTarget                     ModelPrimitiveType bool bool bool Bool
    // 041 IsBlitRenderPass                         ModelPrimitiveType bool bool bool Bool
    // 042 UseNativeRenderPass                      ModelPrimitiveType bool bool bool Bool
    // 044 RenderPassQueueIndex                     ModelPrimitiveType int int int Int32
    // 048 m_ColorAttachmentIndices                 NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 058 m_InputAttachmentIndices                 NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 068 RenderTargetFormat                       ModelEnumListType GraphicsFormat[] GraphicsFormat[] List<GraphicsFormat> Pointer
    // 070 M_UsesRTHandles                          ModelPrimitiveType bool bool bool Bool
    // 078 M_ColorAttachments                       ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer
    // 080 M_ColorAttachmentIds                     ModelEnumListType RenderTargetIdentifier[] RenderTargetIdentifier[] List<RenderTargetIdentifier> Pointer
    // 088 M_InputAttachments                       ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer
    // 090 M_InputAttachmentIsTransient             ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    // 098 M_DepthAttachment                        ModelClassType RTHandle RTHandle RTHandle Pointer
    // 0A0 M_DepthAttachmentId                      ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32
    // 0C8 M_Input                                  ModelEnumType ScriptableRenderPassInput ScriptableRenderPassInput ScriptableRenderPassInput Int32
    // 0CC M_ClearFlag                              ModelEnumType ClearFlag ClearFlag ClearFlag Int32
    // 0D0 M_ClearColor                             ModelEnumType Color Color Color Int32
    public partial class ScriptableRenderPass : DataModel
    {
        public RenderPassEvent                          RenderPassEvent                         { get; set; }
        public List<RenderBufferStoreAction>?           M_ColorStoreActions                     { get; set; }
        public RenderBufferStoreAction                  M_DepthStoreAction                      { get; set; }
        public List<bool>?                              M_OverriddenColorStoreActions           { get; set; }
        public bool                                     M_OverriddenDepthStoreAction            { get; set; }
        public ProfilingSampler?                        ProfilingSampler                        { get; set; }
        public bool                                     OverrideCameraTarget                    { get; set; }
        public bool                                     IsBlitRenderPass                        { get; set; }
        public bool                                     UseNativeRenderPass                     { get; set; }
        public int                                      RenderPassQueueIndex                    { get; set; }
        public List<GraphicsFormat>?                    RenderTargetFormat                      { get; set; }
        public bool                                     M_UsesRTHandles                         { get; set; }
        public List<RTHandle>?                          M_ColorAttachments                      { get; set; }
        public List<RenderTargetIdentifier>?            M_ColorAttachmentIds                    { get; set; }
        public List<RTHandle>?                          M_InputAttachments                      { get; set; }
        public List<bool>?                              M_InputAttachmentIsTransient            { get; set; }
        public RTHandle?                                M_DepthAttachment                       { get; set; }
        public RenderTargetIdentifier                   M_DepthAttachmentId                     { get; set; }
        public ScriptableRenderPassInput                M_Input                                 { get; set; }
        public ClearFlag                                M_ClearFlag                             { get; set; }
        public Color                                    M_ClearColor                            { get; set; }

        public static ScriptableRenderPass? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScriptableRenderPass() { Pointer= p0 };

            value.RenderPassEvent                           = (RenderPassEvent)GetInt32(new IntPtr(p + 0x010)); // 0x10 RenderPassEvent             ( ModelEnumType RenderPassEvent RenderPassEvent RenderPassEvent Int32 )
            value.M_ColorStoreActions                       = GetEnumList<RenderBufferStoreAction>(new IntPtr(p + 0x018)); // 0x18 M_ColorStoreActions         ( ModelEnumListType RenderBufferStoreAction[] RenderBufferStoreAction[] List<RenderBufferStoreAction> Pointer )
            value.M_DepthStoreAction                        = (RenderBufferStoreAction)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_DepthStoreAction          ( ModelEnumType RenderBufferStoreAction RenderBufferStoreAction RenderBufferStoreAction Int32 )
            value.M_OverriddenColorStoreActions             = GetBoolList(new IntPtr(p + 0x028)); // 0x28 M_OverriddenColorStoreActions ( ModelPrimitiveListType bool[] bool[] List<bool> Pointer )
            value.M_OverriddenDepthStoreAction              = GetBool(new IntPtr(p + 0x030)); // 0x30 M_OverriddenDepthStoreAction ( ModelPrimitiveType bool bool bool Bool )
            value.ProfilingSampler                          = GetObject<ProfilingSampler>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x38 ProfilingSampler            ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.OverrideCameraTarget                      = GetBool(new IntPtr(p + 0x040)); // 0x40 OverrideCameraTarget        ( ModelPrimitiveType bool bool bool Bool )
            value.IsBlitRenderPass                          = GetBool(new IntPtr(p + 0x041)); // 0x41 IsBlitRenderPass            ( ModelPrimitiveType bool bool bool Bool )
            value.UseNativeRenderPass                       = GetBool(new IntPtr(p + 0x042)); // 0x42 UseNativeRenderPass         ( ModelPrimitiveType bool bool bool Bool )
            value.RenderPassQueueIndex                      = GetInt32(new IntPtr(p + 0x044)); // 0x44 RenderPassQueueIndex        ( ModelPrimitiveType int int int Int32 )
            value.RenderTargetFormat                        = GetEnumList<GraphicsFormat>(new IntPtr(p + 0x068)); // 0x68 RenderTargetFormat          ( ModelEnumListType GraphicsFormat[] GraphicsFormat[] List<GraphicsFormat> Pointer )
            value.M_UsesRTHandles                           = GetBool(new IntPtr(p + 0x070)); // 0x70 M_UsesRTHandles             ( ModelPrimitiveType bool bool bool Bool )
            value.M_ColorAttachments                        = GetObjectList<RTHandle>(new IntPtr(p + 0x078), ReversePrism.DataModels.RTHandle.FromPointer); // 0x78 M_ColorAttachments          ( ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer )
            value.M_ColorAttachmentIds                      = GetEnumList<RenderTargetIdentifier>(new IntPtr(p + 0x080)); // 0x80 M_ColorAttachmentIds        ( ModelEnumListType RenderTargetIdentifier[] RenderTargetIdentifier[] List<RenderTargetIdentifier> Pointer )
            value.M_InputAttachments                        = GetObjectList<RTHandle>(new IntPtr(p + 0x088), ReversePrism.DataModels.RTHandle.FromPointer); // 0x88 M_InputAttachments          ( ModelClassListType RTHandle[] RTHandle[] List<RTHandle> Pointer )
            value.M_InputAttachmentIsTransient              = GetBoolList(new IntPtr(p + 0x090)); // 0x90 M_InputAttachmentIsTransient ( ModelPrimitiveListType bool[] bool[] List<bool> Pointer )
            value.M_DepthAttachment                         = GetObject<RTHandle>(new IntPtr(p + 0x098), ReversePrism.DataModels.RTHandle.FromPointer); // 0x98 M_DepthAttachment           ( ModelClassType RTHandle RTHandle RTHandle Pointer )
            value.M_DepthAttachmentId                       = (RenderTargetIdentifier)GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 M_DepthAttachmentId         ( ModelEnumType RenderTargetIdentifier RenderTargetIdentifier RenderTargetIdentifier Int32 )
            value.M_Input                                   = (ScriptableRenderPassInput)GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 M_Input                     ( ModelEnumType ScriptableRenderPassInput ScriptableRenderPassInput ScriptableRenderPassInput Int32 )
            value.M_ClearFlag                               = (ClearFlag)GetInt32(new IntPtr(p + 0x0CC)); // 0xCC M_ClearFlag                 ( ModelEnumType ClearFlag ClearFlag ClearFlag Int32 )
            value.M_ClearColor                              = (Color)GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 M_ClearColor                ( ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
