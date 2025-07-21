using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model3dLoader                            ModelClassType SimpleModel3dLoader SimpleModel3dLoader SimpleModel3dLoader Pointer
    // 018 PostProcessLayer                         ModelClassType PostProcessLayer PostProcessLayer PostProcessLayer Pointer
    // 020 LiveCharacterController                  ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer
    // 028 CameraController                         ModelClassType CameraController CameraController CameraController Pointer
    // 030 SwayBoneManager                          ModelClassType SwayBoneManager SwayBoneManager SwayBoneManager Pointer
    // 038 PreviousShadowResolution                 ModelEnumType ShadowResolution ShadowResolution ShadowResolution Int32
    // 03C PreviousPostprocessEnabled               ModelPrimitiveType bool bool bool Bool
    // 040 RenderData                               ModelClassType CameraRenderData CameraRenderData CameraRenderData Pointer
    // 048 ScenarioManager                          ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer
    public partial class UI3DModelViewer : DataModel
    {
        public SimpleModel3dLoader?                     Model3dLoader                           { get; set; }
        public PostProcessLayer?                        PostProcessLayer                        { get; set; }
        public LiveCharacterController?                 LiveCharacterController                 { get; set; }
        public CameraController?                        CameraController                        { get; set; }
        public SwayBoneManager?                         SwayBoneManager                         { get; set; }
        public ShadowResolution                         PreviousShadowResolution                { get; set; }
        public bool                                     PreviousPostprocessEnabled              { get; set; }
        public CameraRenderData?                        RenderData                              { get; set; }
        public ScenarioManager?                         ScenarioManager                         { get; set; }

        public static UI3DModelViewer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UI3DModelViewer() { Pointer= p0 };

            value.Model3dLoader                             = GetObject<SimpleModel3dLoader>(new IntPtr(p + 0x010), ReversePrism.DataModels.SimpleModel3dLoader.FromPointer); // 0x10 Model3dLoader               ( ModelClassType SimpleModel3dLoader SimpleModel3dLoader SimpleModel3dLoader Pointer )
            value.PostProcessLayer                          = GetObject<PostProcessLayer>(new IntPtr(p + 0x018), ReversePrism.DataModels.PostProcessLayer.FromPointer); // 0x18 PostProcessLayer            ( ModelClassType PostProcessLayer PostProcessLayer PostProcessLayer Pointer )
            value.LiveCharacterController                   = GetObject<LiveCharacterController>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveCharacterController.FromPointer); // 0x20 LiveCharacterController     ( ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer )
            value.CameraController                          = GetObject<CameraController>(new IntPtr(p + 0x028), ReversePrism.DataModels.CameraController.FromPointer); // 0x28 CameraController            ( ModelClassType CameraController CameraController CameraController Pointer )
            value.SwayBoneManager                           = GetObject<SwayBoneManager>(new IntPtr(p + 0x030), ReversePrism.DataModels.SwayBoneManager.FromPointer); // 0x30 SwayBoneManager             ( ModelClassType SwayBoneManager SwayBoneManager SwayBoneManager Pointer )
            value.PreviousShadowResolution                  = (ShadowResolution)GetInt32(new IntPtr(p + 0x038)); // 0x38 PreviousShadowResolution    ( ModelEnumType ShadowResolution ShadowResolution ShadowResolution Int32 )
            value.PreviousPostprocessEnabled                = GetBool(new IntPtr(p + 0x03C)); // 0x3C PreviousPostprocessEnabled  ( ModelPrimitiveType bool bool bool Bool )
            value.RenderData                                = GetObject<CameraRenderData>(new IntPtr(p + 0x040), ReversePrism.DataModels.CameraRenderData.FromPointer); // 0x40 RenderData                  ( ModelClassType CameraRenderData CameraRenderData CameraRenderData Pointer )
            value.ScenarioManager                           = GetObject<ScenarioManager>(new IntPtr(p + 0x048), ReversePrism.DataModels.ScenarioManager.FromPointer); // 0x48 ScenarioManager             ( ModelClassType ScenarioManager ScenarioManager ScenarioManager Pointer )

            return value;
        }
    }
}
