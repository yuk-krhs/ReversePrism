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
    // 0B8 M_CommonLens                             ModelPrimitiveType bool bool bool Bool
    // 0BC M_Lens                                   ModelEnumType LensSettings LensSettings LensSettings Int32
    // 0F0 M_Transitions                            ModelEnumType TransitionParams TransitionParams TransitionParams Int32
    // 100 M_LegacyBlendHint                        ModelEnumType BlendHint BlendHint BlendHint Int32
    // 108 M_YAxis                                  ModelEnumType AxisState AxisState AxisState Int32
    // 178 M_YAxisRecentering                       ModelEnumType Recentering Recentering Recentering Int32
    // 198 M_XAxis                                  ModelEnumType AxisState AxisState AxisState Int32
    // 208 M_Heading                                ModelEnumType Heading Heading Heading Int32
    // 214 M_RecenterToTargetHeading                ModelEnumType Recentering Recentering Recentering Int32
    // 234 M_BindingMode                            ModelEnumType BindingMode BindingMode BindingMode Int32
    // 238 M_SplineCurvature                        ModelPrimitiveType float float float Single
    // 240 M_Orbits                                 ModelEnumListType Orbit[] Orbit[] List<Orbit> Pointer
    // 248 M_LegacyHeadingBias                      ModelPrimitiveType float float float Single
    // 24C MUseLegacyRigDefinitions                 ModelPrimitiveType bool bool bool Bool
    // 24D MIsDestroyed                             ModelPrimitiveType bool bool bool Bool
    // 250 M_State                                  ModelEnumType CameraState CameraState CameraState Int32
    // 338 M_Rigs                                   ModelClassListType CinemachineVirtualCamera[] CinemachineVirtualCamera[] List<CinemachineVirtualCamera> Pointer
    // 340 MOrbitals                                ModelClassListType CinemachineOrbitalTransposer[] CinemachineOrbitalTransposer[] List<CinemachineOrbitalTransposer> Pointer
    // 348 MBlendA                                  ModelClassType CinemachineBlend CinemachineBlend CinemachineBlend Pointer
    // 350 MBlendB                                  ModelClassType CinemachineBlend CinemachineBlend CinemachineBlend Pointer
    // 000 CreateRigOverride                        CreateRigDelegate IL2CPP_TYPE_CLASS
    // 008 DestroyRigOverride                       DestroyRigDelegate IL2CPP_TYPE_CLASS
    // 358 M_CachedXAxisHeading                     ModelPrimitiveType float float float Single
    // 35C M_LastHeadingUpdateFrame                 ModelPrimitiveType float float float Single
    // 360 M_CachedOrbits                           ModelEnumListType Orbit[] Orbit[] List<Orbit> Pointer
    // 368 M_CachedTension                          ModelPrimitiveType float float float Single
    // 370 M_CachedKnots                            ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 378 M_CachedCtrl1                            ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 380 M_CachedCtrl2                            ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    public partial class CinemachineFreeLook : DataModel
    {
        public Transform?                               M_LookAt                                { get; set; }
        public Transform?                               M_Follow                                { get; set; }
        public bool                                     M_CommonLens                            { get; set; }
        public LensSettings                             M_Lens                                  { get; set; }
        public TransitionParams                         M_Transitions                           { get; set; }
        public BlendHint                                M_LegacyBlendHint                       { get; set; }
        public AxisState                                M_YAxis                                 { get; set; }
        public Recentering                              M_YAxisRecentering                      { get; set; }
        public AxisState                                M_XAxis                                 { get; set; }
        public Heading                                  M_Heading                               { get; set; }
        public Recentering                              M_RecenterToTargetHeading               { get; set; }
        public BindingMode                              M_BindingMode                           { get; set; }
        public float                                    M_SplineCurvature                       { get; set; }
        public List<Orbit>?                             M_Orbits                                { get; set; }
        public float                                    M_LegacyHeadingBias                     { get; set; }
        public bool                                     MUseLegacyRigDefinitions                { get; set; }
        public bool                                     MIsDestroyed                            { get; set; }
        public CameraState                              M_State                                 { get; set; }
        public List<CinemachineVirtualCamera>?          M_Rigs                                  { get; set; }
        public List<CinemachineOrbitalTransposer>?      MOrbitals                               { get; set; }
        public CinemachineBlend?                        MBlendA                                 { get; set; }
        public CinemachineBlend?                        MBlendB                                 { get; set; }
        public float                                    M_CachedXAxisHeading                    { get; set; }
        public float                                    M_LastHeadingUpdateFrame                { get; set; }
        public List<Orbit>?                             M_CachedOrbits                          { get; set; }
        public float                                    M_CachedTension                         { get; set; }
        public List<Vector4>?                           M_CachedKnots                           { get; set; }
        public List<Vector4>?                           M_CachedCtrl1                           { get; set; }
        public List<Vector4>?                           M_CachedCtrl2                           { get; set; }

        public static CinemachineFreeLook? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineFreeLook() { Pointer= p0 };

            value.M_LookAt                                  = GetObject<Transform>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Transform.FromPointer); // 0xA8 M_LookAt                    ( ModelClassType Transform Transform Transform Pointer )
            value.M_Follow                                  = GetObject<Transform>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.Transform.FromPointer); // 0xB0 M_Follow                    ( ModelClassType Transform Transform Transform Pointer )
            value.M_CommonLens                              = GetBool(new IntPtr(p + 0x0B8)); // 0xB8 M_CommonLens                ( ModelPrimitiveType bool bool bool Bool )
            value.M_Lens                                    = (LensSettings)GetInt32(new IntPtr(p + 0x0BC)); // 0xBC M_Lens                      ( ModelEnumType LensSettings LensSettings LensSettings Int32 )
            value.M_Transitions                             = (TransitionParams)GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 M_Transitions               ( ModelEnumType TransitionParams TransitionParams TransitionParams Int32 )
            value.M_LegacyBlendHint                         = (BlendHint)GetInt32(new IntPtr(p + 0x100)); // 0x100 M_LegacyBlendHint           ( ModelEnumType BlendHint BlendHint BlendHint Int32 )
            value.M_YAxis                                   = (AxisState)GetInt32(new IntPtr(p + 0x108)); // 0x108 M_YAxis                     ( ModelEnumType AxisState AxisState AxisState Int32 )
            value.M_YAxisRecentering                        = (Recentering)GetInt32(new IntPtr(p + 0x178)); // 0x178 M_YAxisRecentering          ( ModelEnumType Recentering Recentering Recentering Int32 )
            value.M_XAxis                                   = (AxisState)GetInt32(new IntPtr(p + 0x198)); // 0x198 M_XAxis                     ( ModelEnumType AxisState AxisState AxisState Int32 )
            value.M_Heading                                 = (Heading)GetInt32(new IntPtr(p + 0x208)); // 0x208 M_Heading                   ( ModelEnumType Heading Heading Heading Int32 )
            value.M_RecenterToTargetHeading                 = (Recentering)GetInt32(new IntPtr(p + 0x214)); // 0x214 M_RecenterToTargetHeading   ( ModelEnumType Recentering Recentering Recentering Int32 )
            value.M_BindingMode                             = (BindingMode)GetInt32(new IntPtr(p + 0x234)); // 0x234 M_BindingMode               ( ModelEnumType BindingMode BindingMode BindingMode Int32 )
            value.M_SplineCurvature                         = GetSingle(new IntPtr(p + 0x238)); // 0x238 M_SplineCurvature           ( ModelPrimitiveType float float float Single )
            value.M_Orbits                                  = GetEnumList<Orbit>(new IntPtr(p + 0x240)); // 0x240 M_Orbits                    ( ModelEnumListType Orbit[] Orbit[] List<Orbit> Pointer )
            value.M_LegacyHeadingBias                       = GetSingle(new IntPtr(p + 0x248)); // 0x248 M_LegacyHeadingBias         ( ModelPrimitiveType float float float Single )
            value.MUseLegacyRigDefinitions                  = GetBool(new IntPtr(p + 0x24C)); // 0x24C MUseLegacyRigDefinitions    ( ModelPrimitiveType bool bool bool Bool )
            value.MIsDestroyed                              = GetBool(new IntPtr(p + 0x24D)); // 0x24D MIsDestroyed                ( ModelPrimitiveType bool bool bool Bool )
            value.M_State                                   = (CameraState)GetInt32(new IntPtr(p + 0x250)); // 0x250 M_State                     ( ModelEnumType CameraState CameraState CameraState Int32 )
            value.M_Rigs                                    = GetObjectList<CinemachineVirtualCamera>(new IntPtr(p + 0x338), ReversePrism.DataModels.CinemachineVirtualCamera.FromPointer); // 0x338 M_Rigs                      ( ModelClassListType CinemachineVirtualCamera[] CinemachineVirtualCamera[] List<CinemachineVirtualCamera> Pointer )
            value.MOrbitals                                 = GetObjectList<CinemachineOrbitalTransposer>(new IntPtr(p + 0x340), ReversePrism.DataModels.CinemachineOrbitalTransposer.FromPointer); // 0x340 MOrbitals                   ( ModelClassListType CinemachineOrbitalTransposer[] CinemachineOrbitalTransposer[] List<CinemachineOrbitalTransposer> Pointer )
            value.MBlendA                                   = GetObject<CinemachineBlend>(new IntPtr(p + 0x348), ReversePrism.DataModels.CinemachineBlend.FromPointer); // 0x348 MBlendA                     ( ModelClassType CinemachineBlend CinemachineBlend CinemachineBlend Pointer )
            value.MBlendB                                   = GetObject<CinemachineBlend>(new IntPtr(p + 0x350), ReversePrism.DataModels.CinemachineBlend.FromPointer); // 0x350 MBlendB                     ( ModelClassType CinemachineBlend CinemachineBlend CinemachineBlend Pointer )
            value.M_CachedXAxisHeading                      = GetSingle(new IntPtr(p + 0x358)); // 0x358 M_CachedXAxisHeading        ( ModelPrimitiveType float float float Single )
            value.M_LastHeadingUpdateFrame                  = GetSingle(new IntPtr(p + 0x35C)); // 0x35C M_LastHeadingUpdateFrame    ( ModelPrimitiveType float float float Single )
            value.M_CachedOrbits                            = GetEnumList<Orbit>(new IntPtr(p + 0x360)); // 0x360 M_CachedOrbits              ( ModelEnumListType Orbit[] Orbit[] List<Orbit> Pointer )
            value.M_CachedTension                           = GetSingle(new IntPtr(p + 0x368)); // 0x368 M_CachedTension             ( ModelPrimitiveType float float float Single )
            value.M_CachedKnots                             = GetEnumList<Vector4>(new IntPtr(p + 0x370)); // 0x370 M_CachedKnots               ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.M_CachedCtrl1                             = GetEnumList<Vector4>(new IntPtr(p + 0x378)); // 0x378 M_CachedCtrl1               ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.M_CachedCtrl2                             = GetEnumList<Vector4>(new IntPtr(p + 0x380)); // 0x380 M_CachedCtrl2               ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )

            return value;
        }
    }
}
