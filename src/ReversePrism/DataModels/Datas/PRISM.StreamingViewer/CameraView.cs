using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PrefabPath                               string IL2CPP_TYPE_STRING
    // 020 LiveCamera                               ModelClassType Camera Camera Camera Pointer
    // 028 PostProcessVolume                        ModelClassType PostProcessVolume PostProcessVolume PostProcessVolume Pointer
    // 030 DepthOfField                             ModelClassType DepthOfField DepthOfField DepthOfField Pointer
    // 038 AddPCameraRotationX                      ModelPrimitiveType float float float Single
    // 03C AddPCameraRotationY                      ModelPrimitiveType float float float Single
    // 040 AddPCameraZoomValue                      ModelPrimitiveType float float float Single
    // 048 isAvailableCameraControl                 ReactiveProperty`1<bool> IL2CPP_TYPE_GENERICINST
    // 050 receivedData                             Queue`1<ReceivedData> IL2CPP_TYPE_GENERICINST
    // 058 ProducerModeEnabled                      ModelPrimitiveType bool bool bool Bool
    // 059 ProducerModeWatching                     ModelPrimitiveType bool bool bool Bool
    // 05A IsViewPaused                             ModelPrimitiveType bool bool bool Bool
    public partial class CameraView : DataModel
    {
        public Camera?                                  LiveCamera                              { get; set; }
        public PostProcessVolume?                       PostProcessVolume                       { get; set; }
        public DepthOfField?                            DepthOfField                            { get; set; }
        public float                                    AddPCameraRotationX                     { get; set; }
        public float                                    AddPCameraRotationY                     { get; set; }
        public float                                    AddPCameraZoomValue                     { get; set; }
        public bool                                     ProducerModeEnabled                     { get; set; }
        public bool                                     ProducerModeWatching                    { get; set; }
        public bool                                     IsViewPaused                            { get; set; }

        public static CameraView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraView() { Pointer= p0 };

            value.LiveCamera                                = GetObject<Camera>(new IntPtr(p + 0x020), ReversePrism.DataModels.Camera.FromPointer); // 0x20 LiveCamera                  ( ModelClassType Camera Camera Camera Pointer )
            value.PostProcessVolume                         = GetObject<PostProcessVolume>(new IntPtr(p + 0x028), ReversePrism.DataModels.PostProcessVolume.FromPointer); // 0x28 PostProcessVolume           ( ModelClassType PostProcessVolume PostProcessVolume PostProcessVolume Pointer )
            value.DepthOfField                              = GetObject<DepthOfField>(new IntPtr(p + 0x030), ReversePrism.DataModels.DepthOfField.FromPointer); // 0x30 DepthOfField                ( ModelClassType DepthOfField DepthOfField DepthOfField Pointer )
            value.AddPCameraRotationX                       = GetSingle(new IntPtr(p + 0x038)); // 0x38 AddPCameraRotationX         ( ModelPrimitiveType float float float Single )
            value.AddPCameraRotationY                       = GetSingle(new IntPtr(p + 0x03C)); // 0x3C AddPCameraRotationY         ( ModelPrimitiveType float float float Single )
            value.AddPCameraZoomValue                       = GetSingle(new IntPtr(p + 0x040)); // 0x40 AddPCameraZoomValue         ( ModelPrimitiveType float float float Single )
            value.ProducerModeEnabled                       = GetBool(new IntPtr(p + 0x058)); // 0x58 ProducerModeEnabled         ( ModelPrimitiveType bool bool bool Bool )
            value.ProducerModeWatching                      = GetBool(new IntPtr(p + 0x059)); // 0x59 ProducerModeWatching        ( ModelPrimitiveType bool bool bool Bool )
            value.IsViewPaused                              = GetBool(new IntPtr(p + 0x05A)); // 0x5A IsViewPaused                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
