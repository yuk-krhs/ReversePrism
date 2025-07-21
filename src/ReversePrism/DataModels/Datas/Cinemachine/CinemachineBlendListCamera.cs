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
    // 0B9 M_Loop                                   ModelPrimitiveType bool bool bool Bool
    // 0C0 M_ChildCameras                           ModelClassListType CinemachineVirtualCameraBase[] CinemachineVirtualCameraBase[] List<CinemachineVirtualCameraBase> Pointer
    // 0C8 M_Instructions                           ModelEnumListType Instruction[] Instruction[] List<Instruction> Pointer
    // 0D0 LiveChild                                ModelClassType ICinemachineCamera ICinemachineCamera ICinemachineCamera Pointer
    // 0D8 M_TransitioningFrom                      ModelClassType ICinemachineCamera ICinemachineCamera ICinemachineCamera Pointer
    // 0E0 M_State                                  ModelEnumType CameraState CameraState CameraState Int32
    // 1C8 MActivationTime                          ModelPrimitiveType float float float Single
    // 1CC MCurrentInstruction                      ModelPrimitiveType int int int Int32
    // 1D0 MActiveBlend                             ModelClassType CinemachineBlend CinemachineBlend CinemachineBlend Pointer
    public partial class CinemachineBlendListCamera : DataModel
    {
        public Transform?                               M_LookAt                                { get; set; }
        public Transform?                               M_Follow                                { get; set; }
        public bool                                     M_ShowDebugText                         { get; set; }
        public bool                                     M_Loop                                  { get; set; }
        public List<CinemachineVirtualCameraBase>?      M_ChildCameras                          { get; set; }
        public List<Instruction>?                       M_Instructions                          { get; set; }
        public ICinemachineCamera?                      LiveChild                               { get; set; }
        public ICinemachineCamera?                      M_TransitioningFrom                     { get; set; }
        public CameraState                              M_State                                 { get; set; }
        public float                                    MActivationTime                         { get; set; }
        public int                                      MCurrentInstruction                     { get; set; }
        public CinemachineBlend?                        MActiveBlend                            { get; set; }

        public static CinemachineBlendListCamera? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineBlendListCamera() { Pointer= p0 };

            value.M_LookAt                                  = GetObject<Transform>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Transform.FromPointer); // 0xA8 M_LookAt                    ( ModelClassType Transform Transform Transform Pointer )
            value.M_Follow                                  = GetObject<Transform>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Transform.FromPointer); // 0xB0 M_Follow                    ( ModelClassType Transform Transform Transform Pointer )
            value.M_ShowDebugText                           = GetBool(new IntPtr(p + 0x0B8)); // 0xB8 M_ShowDebugText             ( ModelPrimitiveType bool bool bool Bool )
            value.M_Loop                                    = GetBool(new IntPtr(p + 0x0B9)); // 0xB9 M_Loop                      ( ModelPrimitiveType bool bool bool Bool )
            value.M_ChildCameras                            = GetObjectList<CinemachineVirtualCameraBase>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.CinemachineVirtualCameraBase.FromPointer); // 0xC0 M_ChildCameras              ( ModelClassListType CinemachineVirtualCameraBase[] CinemachineVirtualCameraBase[] List<CinemachineVirtualCameraBase> Pointer )
            value.M_Instructions                            = GetEnumList<Instruction>(new IntPtr(p + 0x0C8)); // 0xC8 M_Instructions              ( ModelEnumListType Instruction[] Instruction[] List<Instruction> Pointer )
            value.LiveChild                                 = GetObject<ICinemachineCamera>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.ICinemachineCamera.FromPointer); // 0xD0 LiveChild                   ( ModelClassType ICinemachineCamera ICinemachineCamera ICinemachineCamera Pointer )
            value.M_TransitioningFrom                       = GetObject<ICinemachineCamera>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.ICinemachineCamera.FromPointer); // 0xD8 M_TransitioningFrom         ( ModelClassType ICinemachineCamera ICinemachineCamera ICinemachineCamera Pointer )
            value.M_State                                   = (CameraState)GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 M_State                     ( ModelEnumType CameraState CameraState CameraState Int32 )
            value.MActivationTime                           = GetSingle(new IntPtr(p + 0x1C8)); // 0x1C8 MActivationTime             ( ModelPrimitiveType float float float Single )
            value.MCurrentInstruction                       = GetInt32(new IntPtr(p + 0x1CC)); // 0x1CC MCurrentInstruction         ( ModelPrimitiveType int int int Int32 )
            value.MActiveBlend                              = GetObject<CinemachineBlend>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.CinemachineBlend.FromPointer); // 0x1D0 MActiveBlend                ( ModelClassType CinemachineBlend CinemachineBlend CinemachineBlend Pointer )

            return value;
        }
    }
}
