using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MaxCameras                               int IL2CPP_TYPE_I4
    // 0A8 M_Weight0                                ModelPrimitiveType float float float Single
    // 0AC M_Weight1                                ModelPrimitiveType float float float Single
    // 0B0 M_Weight2                                ModelPrimitiveType float float float Single
    // 0B4 M_Weight3                                ModelPrimitiveType float float float Single
    // 0B8 M_Weight4                                ModelPrimitiveType float float float Single
    // 0BC M_Weight5                                ModelPrimitiveType float float float Single
    // 0C0 M_Weight6                                ModelPrimitiveType float float float Single
    // 0C4 M_Weight7                                ModelPrimitiveType float float float Single
    // 0C8 M_State                                  ModelEnumType CameraState CameraState CameraState Int32
    // 1B0 LiveChild                                ModelClassType ICinemachineCamera ICinemachineCamera ICinemachineCamera Pointer
    // 1B8 LookAt                                   ModelClassType Transform Transform Transform Pointer
    // 1C0 Follow                                   ModelClassType Transform Transform Transform Pointer
    // 1C8 M_ChildCameras                           ModelClassListType CinemachineVirtualCameraBase[] CinemachineVirtualCameraBase[] List<CinemachineVirtualCameraBase> Pointer
    // 1D0 m_indexMap                               Dictionary`2<CinemachineVirtualCameraBase, int> IL2CPP_TYPE_GENERICINST
    public partial class CinemachineMixingCamera : DataModel
    {
        public float                                    M_Weight0                               { get; set; }
        public float                                    M_Weight1                               { get; set; }
        public float                                    M_Weight2                               { get; set; }
        public float                                    M_Weight3                               { get; set; }
        public float                                    M_Weight4                               { get; set; }
        public float                                    M_Weight5                               { get; set; }
        public float                                    M_Weight6                               { get; set; }
        public float                                    M_Weight7                               { get; set; }
        public CameraState                              M_State                                 { get; set; }
        public ICinemachineCamera?                      LiveChild                               { get; set; }
        public Transform?                               LookAt                                  { get; set; }
        public Transform?                               Follow                                  { get; set; }
        public List<CinemachineVirtualCameraBase>?      M_ChildCameras                          { get; set; }

        public static CinemachineMixingCamera? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineMixingCamera() { Pointer= p0 };

            value.M_Weight0                                 = GetSingle(new IntPtr(p + 0x0A8)); // 0xA8 M_Weight0                   ( ModelPrimitiveType float float float Single )
            value.M_Weight1                                 = GetSingle(new IntPtr(p + 0x0AC)); // 0xAC M_Weight1                   ( ModelPrimitiveType float float float Single )
            value.M_Weight2                                 = GetSingle(new IntPtr(p + 0x0B0)); // 0xB0 M_Weight2                   ( ModelPrimitiveType float float float Single )
            value.M_Weight3                                 = GetSingle(new IntPtr(p + 0x0B4)); // 0xB4 M_Weight3                   ( ModelPrimitiveType float float float Single )
            value.M_Weight4                                 = GetSingle(new IntPtr(p + 0x0B8)); // 0xB8 M_Weight4                   ( ModelPrimitiveType float float float Single )
            value.M_Weight5                                 = GetSingle(new IntPtr(p + 0x0BC)); // 0xBC M_Weight5                   ( ModelPrimitiveType float float float Single )
            value.M_Weight6                                 = GetSingle(new IntPtr(p + 0x0C0)); // 0xC0 M_Weight6                   ( ModelPrimitiveType float float float Single )
            value.M_Weight7                                 = GetSingle(new IntPtr(p + 0x0C4)); // 0xC4 M_Weight7                   ( ModelPrimitiveType float float float Single )
            value.M_State                                   = (CameraState)GetInt32(new IntPtr(p + 0x0C8)); // 0xC8 M_State                     ( ModelEnumType CameraState CameraState CameraState Int32 )
            value.LiveChild                                 = GetObject<ICinemachineCamera>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.ICinemachineCamera.FromPointer); // 0x1B0 LiveChild                   ( ModelClassType ICinemachineCamera ICinemachineCamera ICinemachineCamera Pointer )
            value.LookAt                                    = GetObject<Transform>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.Transform.FromPointer); // 0x1B8 LookAt                      ( ModelClassType Transform Transform Transform Pointer )
            value.Follow                                    = GetObject<Transform>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.Transform.FromPointer); // 0x1C0 Follow                      ( ModelClassType Transform Transform Transform Pointer )
            value.M_ChildCameras                            = GetObjectList<CinemachineVirtualCameraBase>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.CinemachineVirtualCameraBase.FromPointer); // 0x1C8 M_ChildCameras              ( ModelClassListType CinemachineVirtualCameraBase[] CinemachineVirtualCameraBase[] List<CinemachineVirtualCameraBase> Pointer )

            return value;
        }
    }
}
