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
    // 0B8 M_Lens                                   ModelEnumType LensSettings LensSettings LensSettings Int32
    // 0F0 M_Transitions                            ModelEnumType TransitionParams TransitionParams TransitionParams Int32
    // 100 M_LegacyBlendHint                        ModelEnumType BlendHint BlendHint BlendHint Int32
    // 000 PipelineName                             string IL2CPP_TYPE_STRING
    // 000 CreatePipelineOverride                   CreatePipelineDelegate IL2CPP_TYPE_CLASS
    // 008 DestroyPipelineOverride                  DestroyPipelineDelegate IL2CPP_TYPE_CLASS
    // 108 M_State                                  ModelEnumType CameraState CameraState CameraState Int32
    // 1F0 M_ComponentPipeline                      ModelClassListType CinemachineComponentBase[] CinemachineComponentBase[] List<CinemachineComponentBase> Pointer
    // 1F8 M_ComponentOwner                         ModelClassType Transform Transform Transform Pointer
    // 200 MCachedLookAtTarget                      ModelClassType Transform Transform Transform Pointer
    // 208 MCachedLookAtTargetVcam                  ModelClassType CinemachineVirtualCameraBase CinemachineVirtualCameraBase CinemachineVirtualCameraBase Pointer
    public partial class CinemachineVirtualCamera : DataModel
    {
        public Transform?                               M_LookAt                                { get; set; }
        public Transform?                               M_Follow                                { get; set; }
        public LensSettings                             M_Lens                                  { get; set; }
        public TransitionParams                         M_Transitions                           { get; set; }
        public BlendHint                                M_LegacyBlendHint                       { get; set; }
        public CameraState                              M_State                                 { get; set; }
        public List<CinemachineComponentBase>?          M_ComponentPipeline                     { get; set; }
        public Transform?                               M_ComponentOwner                        { get; set; }
        public Transform?                               MCachedLookAtTarget                     { get; set; }
        public CinemachineVirtualCameraBase?            MCachedLookAtTargetVcam                 { get; set; }

        public static CinemachineVirtualCamera? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineVirtualCamera() { Pointer= p0 };

            value.M_LookAt                                  = GetObject<Transform>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Transform.FromPointer); // 0xA8 M_LookAt                    ( ModelClassType Transform Transform Transform Pointer )
            value.M_Follow                                  = GetObject<Transform>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Transform.FromPointer); // 0xB0 M_Follow                    ( ModelClassType Transform Transform Transform Pointer )
            value.M_Lens                                    = (LensSettings)GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 M_Lens                      ( ModelEnumType LensSettings LensSettings LensSettings Int32 )
            value.M_Transitions                             = (TransitionParams)GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 M_Transitions               ( ModelEnumType TransitionParams TransitionParams TransitionParams Int32 )
            value.M_LegacyBlendHint                         = (BlendHint)GetInt32(new IntPtr(p + 0x100)); // 0x100 M_LegacyBlendHint           ( ModelEnumType BlendHint BlendHint BlendHint Int32 )
            value.M_State                                   = (CameraState)GetInt32(new IntPtr(p + 0x108)); // 0x108 M_State                     ( ModelEnumType CameraState CameraState CameraState Int32 )
            value.M_ComponentPipeline                       = GetObjectList<CinemachineComponentBase>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.CinemachineComponentBase.FromPointer); // 0x1F0 M_ComponentPipeline         ( ModelClassListType CinemachineComponentBase[] CinemachineComponentBase[] List<CinemachineComponentBase> Pointer )
            value.M_ComponentOwner                          = GetObject<Transform>(new IntPtr(p + 0x1F8), ReversePrism.DataModels.Transform.FromPointer); // 0x1F8 M_ComponentOwner            ( ModelClassType Transform Transform Transform Pointer )
            value.MCachedLookAtTarget                       = GetObject<Transform>(new IntPtr(p + 0x200), ReversePrism.DataModels.Transform.FromPointer); // 0x200 MCachedLookAtTarget         ( ModelClassType Transform Transform Transform Pointer )
            value.MCachedLookAtTargetVcam                   = GetObject<CinemachineVirtualCameraBase>(new IntPtr(p + 0x208), ReversePrism.DataModels.CinemachineVirtualCameraBase.FromPointer); // 0x208 MCachedLookAtTargetVcam     ( ModelClassType CinemachineVirtualCameraBase CinemachineVirtualCameraBase CinemachineVirtualCameraBase Pointer )

            return value;
        }
    }
}
