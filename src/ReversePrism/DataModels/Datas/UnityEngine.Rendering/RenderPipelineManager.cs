using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_CurrentPipelineAsset                   RenderPipelineAsset IL2CPP_TYPE_CLASS
    // 008 s_Cameras                                List`1<Camera> IL2CPP_TYPE_GENERICINST
    // 010 S_CurrentPipelineType                    000186672530 ModelPrimitiveType string string string String
    // 018 S_CurrentPipeline                        0001866581D0 ModelClassType RenderPipeline RenderPipeline RenderPipeline Pointer
    // 020 beginFrameRendering                      Action`2<ScriptableRenderContext, Camera[]> IL2CPP_TYPE_GENERICINST
    // 028 endFrameRendering                        Action`2<ScriptableRenderContext, Camera[]> IL2CPP_TYPE_GENERICINST
    // 030 beginContextRendering                    Action`2<ScriptableRenderContext, List`1<Camera>> IL2CPP_TYPE_GENERICINST
    // 038 endContextRendering                      Action`2<ScriptableRenderContext, List`1<Camera>> IL2CPP_TYPE_GENERICINST
    // 040 beginCameraRendering                     Action`2<ScriptableRenderContext, Camera> IL2CPP_TYPE_GENERICINST
    // 048 endCameraRendering                       Action`2<ScriptableRenderContext, Camera> IL2CPP_TYPE_GENERICINST
    // 050 ActiveRenderPipelineTypeChanged          000186679C50 ModelClassType Action Action Action Pointer
    // 058 activeRenderPipelineAssetChanged         Action`2<RenderPipelineAsset, RenderPipelineAsset> IL2CPP_TYPE_GENERICINST
    // 060 ActiveRenderPipelineCreated              000186679C50 ModelClassType Action Action Action Pointer
    // 068 ActiveRenderPipelineDisposed             000186679C50 ModelClassType Action Action Action Pointer
    public partial class RenderPipelineManager
    {
        public string                                   S_CurrentPipelineType                   { get; set; }
        public RenderPipeline?                          S_CurrentPipeline                       { get; set; }
        public Action?                                  ActiveRenderPipelineTypeChanged         { get; set; }
        public Action?                                  ActiveRenderPipelineCreated             { get; set; }
        public Action?                                  ActiveRenderPipelineDisposed            { get; set; }

        public static RenderPipelineManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderPipelineManager();

            value.S_CurrentPipelineType                     = GetString(new IntPtr(p + 0x010)); // 027002472AF0 0x10 S_CurrentPipelineType       ( 000186672530 ModelPrimitiveType string string string String )
            value.S_CurrentPipeline                         = GetObject<RenderPipeline>(new IntPtr(p + 0x018), ReversePrism.DataModels.RenderPipeline.FromPointer); // 027002472B10 0x18 S_CurrentPipeline           ( 0001866581D0 ModelClassType RenderPipeline RenderPipeline RenderPipeline Pointer )
            value.ActiveRenderPipelineTypeChanged           = GetObject<Action>(new IntPtr(p + 0x050), ReversePrism.DataModels.Action.FromPointer); // 027002472BF0 0x50 ActiveRenderPipelineTypeChanged ( 000186679C50 ModelClassType Action Action Action Pointer )
            value.ActiveRenderPipelineCreated               = GetObject<Action>(new IntPtr(p + 0x060), ReversePrism.DataModels.Action.FromPointer); // 027002472C30 0x60 ActiveRenderPipelineCreated ( 000186679C50 ModelClassType Action Action Action Pointer )
            value.ActiveRenderPipelineDisposed              = GetObject<Action>(new IntPtr(p + 0x068), ReversePrism.DataModels.Action.FromPointer); // 027002472C50 0x68 ActiveRenderPipelineDisposed ( 000186679C50 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
