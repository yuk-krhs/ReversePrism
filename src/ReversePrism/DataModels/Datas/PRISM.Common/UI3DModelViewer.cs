using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PostProcessLayer                         00018676C2C0 ModelClassType PostProcessLayer PostProcessLayer PostProcessLayer Pointer
    // 018 LiveCharacterController                  000186544E10 ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer
    // 020 CameraController                         000186536460 ModelClassType CameraController CameraController CameraController Pointer
    // 028 SwayBoneManager                          0001865FA8D0 ModelClassType SwayBoneManager SwayBoneManager SwayBoneManager Pointer
    // 030 PreviousShadowResolution                 000186750BD0 ModelEnumType ShadowResolution ShadowResolution ShadowResolution Int32
    // 034 PreviousPostprocessEnabled               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 RenderData                               0001865A3220 ModelClassType CameraRenderData CameraRenderData CameraRenderData Pointer
    // 040 SceneLoader                              0001866CC6B0 ModelClassType SceneLoaderAddressable SceneLoaderAddressable SceneLoaderAddressable Pointer
    // 048 ScenarioManager                          0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    public partial class UI3DModelViewer : DataModel
    {
        public PostProcessLayer?                        PostProcessLayer                        { get; set; }
        public LiveCharacterController?                 LiveCharacterController                 { get; set; }
        public CameraController?                        CameraController                        { get; set; }
        public SwayBoneManager?                         SwayBoneManager                         { get; set; }
        public ShadowResolution                         PreviousShadowResolution                { get; set; }
        public bool                                     PreviousPostprocessEnabled              { get; set; }
        public CameraRenderData?                        RenderData                              { get; set; }
        public SceneLoaderAddressable?                  SceneLoader                             { get; set; }
        public ScenarioManager?                         ScenarioManager                         { get; set; }

        public static UI3DModelViewer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UI3DModelViewer() { Pointer= p0 };

            value.PostProcessLayer                          = GetObject<PostProcessLayer>(new IntPtr(p + 0x010), ReversePrism.DataModels.PostProcessLayer.FromPointer); // 024665479538 0x10 PostProcessLayer            ( 00018676C2C0 ModelClassType PostProcessLayer PostProcessLayer PostProcessLayer Pointer )
            value.LiveCharacterController                   = GetObject<LiveCharacterController>(new IntPtr(p + 0x018), ReversePrism.DataModels.LiveCharacterController.FromPointer); // 024665479558 0x18 LiveCharacterController     ( 000186544E10 ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer )
            value.CameraController                          = GetObject<CameraController>(new IntPtr(p + 0x020), ReversePrism.DataModels.CameraController.FromPointer); // 024665479578 0x20 CameraController            ( 000186536460 ModelClassType CameraController CameraController CameraController Pointer )
            value.SwayBoneManager                           = GetObject<SwayBoneManager>(new IntPtr(p + 0x028), ReversePrism.DataModels.SwayBoneManager.FromPointer); // 024665479598 0x28 SwayBoneManager             ( 0001865FA8D0 ModelClassType SwayBoneManager SwayBoneManager SwayBoneManager Pointer )
            value.PreviousShadowResolution                  = (ShadowResolution)GetInt32(new IntPtr(p + 0x030)); // 0246654795B8 0x30 PreviousShadowResolution    ( 000186750BD0 ModelEnumType ShadowResolution ShadowResolution ShadowResolution Int32 )
            value.PreviousPostprocessEnabled                = GetBool(new IntPtr(p + 0x034)); // 0246654795D8 0x34 PreviousPostprocessEnabled  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RenderData                                = GetObject<CameraRenderData>(new IntPtr(p + 0x038), ReversePrism.DataModels.CameraRenderData.FromPointer); // 0246654795F8 0x38 RenderData                  ( 0001865A3220 ModelClassType CameraRenderData CameraRenderData CameraRenderData Pointer )
            value.SceneLoader                               = GetObject<SceneLoaderAddressable>(new IntPtr(p + 0x040), ReversePrism.DataModels.SceneLoaderAddressable.FromPointer); // 024665479618 0x40 SceneLoader                 ( 0001866CC6B0 ModelClassType SceneLoaderAddressable SceneLoaderAddressable SceneLoaderAddressable Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x048), ReversePrism.DataModels.ScenarioManager.FromPointer); // 024665479638 0x48 ScenarioManager             ( 0001866C9D90 ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )

            return value;
        }
    }
}
