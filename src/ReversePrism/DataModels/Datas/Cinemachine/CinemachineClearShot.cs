using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A8 M_LookAt                                 ModelClassType Transform Transform Transform Pointer
    // 0B0 M_Follow                                 ModelClassType Transform Transform Transform Pointer
    // 0B8 M_ShowDebugText                          ModelPrimitiveType bool bool bool Bool
    // 0C0 M_ChildCameras                           ModelClassListType CinemachineVirtualCameraBase[] CinemachineVirtualCameraBase[] List<CinemachineVirtualCameraBase> Pointer
    // 0C8 M_ActivateAfter                          ModelPrimitiveType float float float Single
    // 0CC M_MinDuration                            ModelPrimitiveType float float float Single
    // 0D0 M_RandomizeChoice                        ModelPrimitiveType bool bool bool Bool
    // 0D8 M_DefaultBlend                           ModelEnumType CinemachineBlendDefinition CinemachineBlendDefinition CinemachineBlendDefinition Int32
    // 0E8 M_CustomBlends                           ModelClassType CinemachineBlenderSettings CinemachineBlenderSettings CinemachineBlenderSettings Pointer
    // 0F0 LiveChild                                ModelClassType ICinemachineCamera ICinemachineCamera ICinemachineCamera Pointer
    // 0F8 M_State                                  ModelEnumType CameraState CameraState CameraState Int32
    // 1E0 MActivationTime                          ModelPrimitiveType float float float Single
    // 1E4 MPendingActivationTime                   ModelPrimitiveType float float float Single
    // 1E8 MPendingCamera                           ModelClassType ICinemachineCamera ICinemachineCamera ICinemachineCamera Pointer
    // 1F0 MActiveBlend                             ModelClassType CinemachineBlend CinemachineBlend CinemachineBlend Pointer
    // 1F8 MRandomizeNow                            ModelPrimitiveType bool bool bool Bool
    // 200 M_RandomizedChilden                      ModelClassListType CinemachineVirtualCameraBase[] CinemachineVirtualCameraBase[] List<CinemachineVirtualCameraBase> Pointer
    // 208 M_TransitioningFrom                      ModelClassType ICinemachineCamera ICinemachineCamera ICinemachineCamera Pointer
    public partial class CinemachineClearShot : DataModel
    {
        public Transform?                               M_LookAt                                { get; set; }
        public Transform?                               M_Follow                                { get; set; }
        public bool                                     M_ShowDebugText                         { get; set; }
        public List<CinemachineVirtualCameraBase>?      M_ChildCameras                          { get; set; }
        public float                                    M_ActivateAfter                         { get; set; }
        public float                                    M_MinDuration                           { get; set; }
        public bool                                     M_RandomizeChoice                       { get; set; }
        public CinemachineBlendDefinition               M_DefaultBlend                          { get; set; }
        public CinemachineBlenderSettings?              M_CustomBlends                          { get; set; }
        public ICinemachineCamera?                      LiveChild                               { get; set; }
        public CameraState                              M_State                                 { get; set; }
        public float                                    MActivationTime                         { get; set; }
        public float                                    MPendingActivationTime                  { get; set; }
        public ICinemachineCamera?                      MPendingCamera                          { get; set; }
        public CinemachineBlend?                        MActiveBlend                            { get; set; }
        public bool                                     MRandomizeNow                           { get; set; }
        public List<CinemachineVirtualCameraBase>?      M_RandomizedChilden                     { get; set; }
        public ICinemachineCamera?                      M_TransitioningFrom                     { get; set; }

        public static CinemachineClearShot? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineClearShot() { Pointer= p0 };

            value.M_LookAt                                  = GetObject<Transform>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Transform.FromPointer); // 0xA8 M_LookAt                    ( ModelClassType Transform Transform Transform Pointer )
            value.M_Follow                                  = GetObject<Transform>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Transform.FromPointer); // 0xB0 M_Follow                    ( ModelClassType Transform Transform Transform Pointer )
            value.M_ShowDebugText                           = GetBool(new IntPtr(p + 0x0B8)); // 0xB8 M_ShowDebugText             ( ModelPrimitiveType bool bool bool Bool )
            value.M_ChildCameras                            = GetObjectList<CinemachineVirtualCameraBase>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.CinemachineVirtualCameraBase.FromPointer); // 0xC0 M_ChildCameras              ( ModelClassListType CinemachineVirtualCameraBase[] CinemachineVirtualCameraBase[] List<CinemachineVirtualCameraBase> Pointer )
            value.M_ActivateAfter                           = GetSingle(new IntPtr(p + 0x0C8)); // 0xC8 M_ActivateAfter             ( ModelPrimitiveType float float float Single )
            value.M_MinDuration                             = GetSingle(new IntPtr(p + 0x0CC)); // 0xCC M_MinDuration               ( ModelPrimitiveType float float float Single )
            value.M_RandomizeChoice                         = GetBool(new IntPtr(p + 0x0D0)); // 0xD0 M_RandomizeChoice           ( ModelPrimitiveType bool bool bool Bool )
            value.M_DefaultBlend                            = (CinemachineBlendDefinition)GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 M_DefaultBlend              ( ModelEnumType CinemachineBlendDefinition CinemachineBlendDefinition CinemachineBlendDefinition Int32 )
            value.M_CustomBlends                            = GetObject<CinemachineBlenderSettings>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.CinemachineBlenderSettings.FromPointer); // 0xE8 M_CustomBlends              ( ModelClassType CinemachineBlenderSettings CinemachineBlenderSettings CinemachineBlenderSettings Pointer )
            value.LiveChild                                 = GetObject<ICinemachineCamera>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.ICinemachineCamera.FromPointer); // 0xF0 LiveChild                   ( ModelClassType ICinemachineCamera ICinemachineCamera ICinemachineCamera Pointer )
            value.M_State                                   = (CameraState)GetInt32(new IntPtr(p + 0x0F8)); // 0xF8 M_State                     ( ModelEnumType CameraState CameraState CameraState Int32 )
            value.MActivationTime                           = GetSingle(new IntPtr(p + 0x1E0)); // 0x1E0 MActivationTime             ( ModelPrimitiveType float float float Single )
            value.MPendingActivationTime                    = GetSingle(new IntPtr(p + 0x1E4)); // 0x1E4 MPendingActivationTime      ( ModelPrimitiveType float float float Single )
            value.MPendingCamera                            = GetObject<ICinemachineCamera>(new IntPtr(p + 0x1E8), ReversePrism.DataModels.ICinemachineCamera.FromPointer); // 0x1E8 MPendingCamera              ( ModelClassType ICinemachineCamera ICinemachineCamera ICinemachineCamera Pointer )
            value.MActiveBlend                              = GetObject<CinemachineBlend>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.CinemachineBlend.FromPointer); // 0x1F0 MActiveBlend                ( ModelClassType CinemachineBlend CinemachineBlend CinemachineBlend Pointer )
            value.MRandomizeNow                             = GetBool(new IntPtr(p + 0x1F8)); // 0x1F8 MRandomizeNow               ( ModelPrimitiveType bool bool bool Bool )
            value.M_RandomizedChilden                       = GetObjectList<CinemachineVirtualCameraBase>(new IntPtr(p + 0x200), ReversePrism.DataModels.CinemachineVirtualCameraBase.FromPointer); // 0x200 M_RandomizedChilden         ( ModelClassListType CinemachineVirtualCameraBase[] CinemachineVirtualCameraBase[] List<CinemachineVirtualCameraBase> Pointer )
            value.M_TransitioningFrom                       = GetObject<ICinemachineCamera>(new IntPtr(p + 0x208), ReversePrism.DataModels.ICinemachineCamera.FromPointer); // 0x208 M_TransitioningFrom         ( ModelClassType ICinemachineCamera ICinemachineCamera ICinemachineCamera Pointer )

            return value;
        }
    }
}
