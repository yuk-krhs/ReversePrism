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
    // 0B8 M_AnimatedTarget                         ModelClassType Animator Animator Animator Pointer
    // 0C0 M_LayerIndex                             ModelPrimitiveType int int int Int32
    // 0C4 M_ShowDebugText                          ModelPrimitiveType bool bool bool Bool
    // 0C8 M_ChildCameras                           ModelClassListType CinemachineVirtualCameraBase[] CinemachineVirtualCameraBase[] List<CinemachineVirtualCameraBase> Pointer
    // 0D0 M_Instructions                           ModelEnumListType Instruction[] Instruction[] List<Instruction> Pointer
    // 0D8 M_DefaultBlend                           ModelEnumType CinemachineBlendDefinition CinemachineBlendDefinition CinemachineBlendDefinition Int32
    // 0E8 M_CustomBlends                           ModelClassType CinemachineBlenderSettings CinemachineBlenderSettings CinemachineBlenderSettings Pointer
    // 0F0 M_ParentHash                             ModelEnumListType ParentHash[] ParentHash[] List<ParentHash> Pointer
    // 0F8 LiveChild                                ModelClassType ICinemachineCamera ICinemachineCamera ICinemachineCamera Pointer
    // 100 M_TransitioningFrom                      ModelClassType ICinemachineCamera ICinemachineCamera ICinemachineCamera Pointer
    // 108 M_State                                  ModelEnumType CameraState CameraState CameraState Int32
    // 1F0 mHashCache                               Dictionary`2<AnimationClip, List`1<HashPair>> IL2CPP_TYPE_GENERICINST
    // 1F8 MActivationTime                          ModelPrimitiveType float float float Single
    // 200 MActiveInstruction                       ModelEnumType Instruction Instruction Instruction Int32
    // 218 MPendingActivationTime                   ModelPrimitiveType float float float Single
    // 220 MPendingInstruction                      ModelEnumType Instruction Instruction Instruction Int32
    // 238 MActiveBlend                             ModelClassType CinemachineBlend CinemachineBlend CinemachineBlend Pointer
    // 240 mInstructionDictionary                   Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 248 mStateParentLookup                       Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 250 M_clipInfoList                           ModelEnumListType List`1<AnimatorClipInfo> List`1<AnimatorClipInfo> List<AnimatorClipInfo> Pointer
    public partial class CinemachineStateDrivenCamera : DataModel
    {
        public Transform?                               M_LookAt                                { get; set; }
        public Transform?                               M_Follow                                { get; set; }
        public Animator?                                M_AnimatedTarget                        { get; set; }
        public int                                      M_LayerIndex                            { get; set; }
        public bool                                     M_ShowDebugText                         { get; set; }
        public List<CinemachineVirtualCameraBase>?      M_ChildCameras                          { get; set; }
        public List<Instruction>?                       M_Instructions                          { get; set; }
        public CinemachineBlendDefinition               M_DefaultBlend                          { get; set; }
        public CinemachineBlenderSettings?              M_CustomBlends                          { get; set; }
        public List<ParentHash>?                        M_ParentHash                            { get; set; }
        public ICinemachineCamera?                      LiveChild                               { get; set; }
        public ICinemachineCamera?                      M_TransitioningFrom                     { get; set; }
        public CameraState                              M_State                                 { get; set; }
        public float                                    MActivationTime                         { get; set; }
        public Instruction                              MActiveInstruction                      { get; set; }
        public float                                    MPendingActivationTime                  { get; set; }
        public Instruction                              MPendingInstruction                     { get; set; }
        public CinemachineBlend?                        MActiveBlend                            { get; set; }
        public List<AnimatorClipInfo>?                  M_clipInfoList                          { get; set; }

        public static CinemachineStateDrivenCamera? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineStateDrivenCamera() { Pointer= p0 };

            value.M_LookAt                                  = GetObject<Transform>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Transform.FromPointer); // 0xA8 M_LookAt                    ( ModelClassType Transform Transform Transform Pointer )
            value.M_Follow                                  = GetObject<Transform>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Transform.FromPointer); // 0xB0 M_Follow                    ( ModelClassType Transform Transform Transform Pointer )
            value.M_AnimatedTarget                          = GetObject<Animator>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.Animator.FromPointer); // 0xB8 M_AnimatedTarget            ( ModelClassType Animator Animator Animator Pointer )
            value.M_LayerIndex                              = GetInt32(new IntPtr(p + 0x0C0)); // 0xC0 M_LayerIndex                ( ModelPrimitiveType int int int Int32 )
            value.M_ShowDebugText                           = GetBool(new IntPtr(p + 0x0C4)); // 0xC4 M_ShowDebugText             ( ModelPrimitiveType bool bool bool Bool )
            value.M_ChildCameras                            = GetObjectList<CinemachineVirtualCameraBase>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.CinemachineVirtualCameraBase.FromPointer); // 0xC8 M_ChildCameras              ( ModelClassListType CinemachineVirtualCameraBase[] CinemachineVirtualCameraBase[] List<CinemachineVirtualCameraBase> Pointer )
            value.M_Instructions                            = GetEnumList<Instruction>(new IntPtr(p + 0x0D0)); // 0xD0 M_Instructions              ( ModelEnumListType Instruction[] Instruction[] List<Instruction> Pointer )
            value.M_DefaultBlend                            = (CinemachineBlendDefinition)GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 M_DefaultBlend              ( ModelEnumType CinemachineBlendDefinition CinemachineBlendDefinition CinemachineBlendDefinition Int32 )
            value.M_CustomBlends                            = GetObject<CinemachineBlenderSettings>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.CinemachineBlenderSettings.FromPointer); // 0xE8 M_CustomBlends              ( ModelClassType CinemachineBlenderSettings CinemachineBlenderSettings CinemachineBlenderSettings Pointer )
            value.M_ParentHash                              = GetEnumList<ParentHash>(new IntPtr(p + 0x0F0)); // 0xF0 M_ParentHash                ( ModelEnumListType ParentHash[] ParentHash[] List<ParentHash> Pointer )
            value.LiveChild                                 = GetObject<ICinemachineCamera>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.ICinemachineCamera.FromPointer); // 0xF8 LiveChild                   ( ModelClassType ICinemachineCamera ICinemachineCamera ICinemachineCamera Pointer )
            value.M_TransitioningFrom                       = GetObject<ICinemachineCamera>(new IntPtr(p + 0x100), ReversePrism.DataModels.ICinemachineCamera.FromPointer); // 0x100 M_TransitioningFrom         ( ModelClassType ICinemachineCamera ICinemachineCamera ICinemachineCamera Pointer )
            value.M_State                                   = (CameraState)GetInt32(new IntPtr(p + 0x108)); // 0x108 M_State                     ( ModelEnumType CameraState CameraState CameraState Int32 )
            value.MActivationTime                           = GetSingle(new IntPtr(p + 0x1F8)); // 0x1F8 MActivationTime             ( ModelPrimitiveType float float float Single )
            value.MActiveInstruction                        = (Instruction)GetInt32(new IntPtr(p + 0x200)); // 0x200 MActiveInstruction          ( ModelEnumType Instruction Instruction Instruction Int32 )
            value.MPendingActivationTime                    = GetSingle(new IntPtr(p + 0x218)); // 0x218 MPendingActivationTime      ( ModelPrimitiveType float float float Single )
            value.MPendingInstruction                       = (Instruction)GetInt32(new IntPtr(p + 0x220)); // 0x220 MPendingInstruction         ( ModelEnumType Instruction Instruction Instruction Int32 )
            value.MActiveBlend                              = GetObject<CinemachineBlend>(new IntPtr(p + 0x238), ReversePrism.DataModels.CinemachineBlend.FromPointer); // 0x238 MActiveBlend                ( ModelClassType CinemachineBlend CinemachineBlend CinemachineBlend Pointer )
            value.M_clipInfoList                            = GetEnumList<AnimatorClipInfo>(new IntPtr(p + 0x250)); // 0x250 M_clipInfoList              ( ModelEnumListType List`1<AnimatorClipInfo> List`1<AnimatorClipInfo> List<AnimatorClipInfo> Pointer )

            return value;
        }
    }
}
