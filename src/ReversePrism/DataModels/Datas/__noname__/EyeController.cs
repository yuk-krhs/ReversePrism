using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BaseObject                               ModelClassType GameObject GameObject GameObject Pointer
    // 028 HeadObject                               ModelClassType GameObject GameObject GameObject Pointer
    // 030 TargetObject                             ModelClassType GameObject GameObject GameObject Pointer
    // 038 EyeTargets                               ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 040 FaceTargets                              ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 048 CharacterRoot                            ModelClassType Transform Transform Transform Pointer
    // 050 BoneRightHand                            ModelClassType Transform Transform Transform Pointer
    // 058 BoneLeftHand                             ModelClassType Transform Transform Transform Pointer
    // 060 NeckLocalRotY                            ModelPrimitiveType float float float Single
    // 068 LiveChara                                ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer
    // 070 ParamTex                                 ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer
    // 078 Left                                     ModelPrimitiveType bool bool bool Bool
    // 07C HightLightTraceRate                      ModelPrimitiveType float float float Single
    // 080 EyeTargetNo                              ModelPrimitiveType int int int Int32
    // 084 LastTargetNo                             ModelPrimitiveType int int int Int32
    // 088 BlinkFlag                                ModelPrimitiveType bool bool bool Bool
    // 089 FlipFlag                                 ModelPrimitiveType bool bool bool Bool
    // 08C PrevView                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 098 BaseTarget                               ModelEnumType Target Target Target Int32
    // 0A0 AreaTex                                  ModelClassType Texture2D Texture2D Texture2D Pointer
    // 0A8 Top                                      ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0B4 Front                                    ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0C0 BaseCam                                  ModelClassType Camera Camera Camera Pointer
    // 0C8 FaceTransform                            ModelPrimitiveType bool bool bool Bool
    // 0C9 ToolEdit                                 ModelPrimitiveType bool bool bool Bool
    // 0CA IsFixPositionRelative                    ModelPrimitiveType bool bool bool Bool
    // 0D0 OppositeEye                              ModelClassType EyeController EyeController EyeController Pointer
    // 0D8 ResetFlipOverwriteFlag                   ModelPrimitiveType bool bool bool Bool
    // 0D9 ResetFlip                                ModelPrimitiveType bool bool bool Bool
    // 0DA RemoveHighLight                          ModelPrimitiveType bool bool bool Bool
    // 0DB RemoveEyeIris                            ModelPrimitiveType bool bool bool Bool
    // 000 OutUvConst                               float IL2CPP_TYPE_R4
    // 0DC ParamX                                   ModelPrimitiveType float float float Single
    // 0E0 CameraDatas                              ModelClassListType List`1<CameraData> List`1<CameraData> List<CameraData> Pointer
    // 0E8 NormalEyeTargets                         ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 0F0 DrawCameraData                           ModelClassType CameraData CameraData CameraData Pointer
    // 0F8 AngleHTable                              ModelPrimitiveListType float[] float[] List<float> Pointer
    // 100 AngleVTable                              ModelPrimitiveListType float[] float[] List<float> Pointer
    // 108 LengthTable                              ModelPrimitiveListType float[] float[] List<float> Pointer
    // 110 LastObjectDir                            ModelEnumType Vector3 Vector3 Vector3 Int32
    // 11C MoveMax                                  ModelPrimitiveType float float float Single
    // 120 FreeTarget                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 130 MirrorCopy                               ModelClassType EyeController EyeController EyeController Pointer
    // 138 SetUvOuter                               ModelPrimitiveType bool bool bool Bool
    // 13C IrisUV                                   ModelEnumType Vector4 Vector4 Vector4 Int32
    // 14C Flip                                     ModelPrimitiveType float float float Single
    // 150 NoLimit                                  ModelPrimitiveType bool bool bool Bool
    public partial class EyeController : DataModel
    {
        public GameObject?                              BaseObject                              { get; set; }
        public GameObject?                              HeadObject                              { get; set; }
        public GameObject?                              TargetObject                            { get; set; }
        public List<GameObject>?                        EyeTargets                              { get; set; }
        public List<GameObject>?                        FaceTargets                             { get; set; }
        public Transform?                               CharacterRoot                           { get; set; }
        public Transform?                               BoneRightHand                           { get; set; }
        public Transform?                               BoneLeftHand                            { get; set; }
        public float                                    NeckLocalRotY                           { get; set; }
        public LiveCharacterController?                 LiveChara                               { get; set; }
        public List<Texture2D>?                         ParamTex                                { get; set; }
        public bool                                     Left                                    { get; set; }
        public float                                    HightLightTraceRate                     { get; set; }
        public int                                      EyeTargetNo                             { get; set; }
        public int                                      LastTargetNo                            { get; set; }
        public bool                                     BlinkFlag                               { get; set; }
        public bool                                     FlipFlag                                { get; set; }
        public Vector3                                  PrevView                                { get; set; }
        public Target                                   BaseTarget                              { get; set; }
        public Texture2D?                               AreaTex                                 { get; set; }
        public Vector3                                  Top                                     { get; set; }
        public Vector3                                  Front                                   { get; set; }
        public Camera?                                  BaseCam                                 { get; set; }
        public bool                                     FaceTransform                           { get; set; }
        public bool                                     ToolEdit                                { get; set; }
        public bool                                     IsFixPositionRelative                   { get; set; }
        public EyeController?                           OppositeEye                             { get; set; }
        public bool                                     ResetFlipOverwriteFlag                  { get; set; }
        public bool                                     ResetFlip                               { get; set; }
        public bool                                     RemoveHighLight                         { get; set; }
        public bool                                     RemoveEyeIris                           { get; set; }
        public float                                    ParamX                                  { get; set; }
        public List<CameraData>?                        CameraDatas                             { get; set; }
        public List<GameObject>?                        NormalEyeTargets                        { get; set; }
        public CameraData?                              DrawCameraData                          { get; set; }
        public List<float>?                             AngleHTable                             { get; set; }
        public List<float>?                             AngleVTable                             { get; set; }
        public List<float>?                             LengthTable                             { get; set; }
        public Vector3                                  LastObjectDir                           { get; set; }
        public float                                    MoveMax                                 { get; set; }
        public Vector3                                  FreeTarget                              { get; set; }
        public EyeController?                           MirrorCopy                              { get; set; }
        public bool                                     SetUvOuter                              { get; set; }
        public Vector4                                  IrisUV                                  { get; set; }
        public float                                    Flip                                    { get; set; }
        public bool                                     NoLimit                                 { get; set; }

        public static EyeController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EyeController() { Pointer= p0 };

            value.BaseObject                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 BaseObject                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.HeadObject                                = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 HeadObject                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TargetObject                              = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 TargetObject                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EyeTargets                                = GetObjectList<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 EyeTargets                  ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.FaceTargets                               = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 FaceTargets                 ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.CharacterRoot                             = GetObject<Transform>(new IntPtr(p + 0x048), ReversePrism.DataModels.Transform.FromPointer); // 0x48 CharacterRoot               ( ModelClassType Transform Transform Transform Pointer )
            value.BoneRightHand                             = GetObject<Transform>(new IntPtr(p + 0x050), ReversePrism.DataModels.Transform.FromPointer); // 0x50 BoneRightHand               ( ModelClassType Transform Transform Transform Pointer )
            value.BoneLeftHand                              = GetObject<Transform>(new IntPtr(p + 0x058), ReversePrism.DataModels.Transform.FromPointer); // 0x58 BoneLeftHand                ( ModelClassType Transform Transform Transform Pointer )
            value.NeckLocalRotY                             = GetSingle(new IntPtr(p + 0x060)); // 0x60 NeckLocalRotY               ( ModelPrimitiveType float float float Single )
            value.LiveChara                                 = GetObject<LiveCharacterController>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveCharacterController.FromPointer); // 0x68 LiveChara                   ( ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer )
            value.ParamTex                                  = GetObjectList<Texture2D>(new IntPtr(p + 0x070), ReversePrism.DataModels.Texture2D.FromPointer); // 0x70 ParamTex                    ( ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer )
            value.Left                                      = GetBool(new IntPtr(p + 0x078)); // 0x78 Left                        ( ModelPrimitiveType bool bool bool Bool )
            value.HightLightTraceRate                       = GetSingle(new IntPtr(p + 0x07C)); // 0x7C HightLightTraceRate         ( ModelPrimitiveType float float float Single )
            value.EyeTargetNo                               = GetInt32(new IntPtr(p + 0x080)); // 0x80 EyeTargetNo                 ( ModelPrimitiveType int int int Int32 )
            value.LastTargetNo                              = GetInt32(new IntPtr(p + 0x084)); // 0x84 LastTargetNo                ( ModelPrimitiveType int int int Int32 )
            value.BlinkFlag                                 = GetBool(new IntPtr(p + 0x088)); // 0x88 BlinkFlag                   ( ModelPrimitiveType bool bool bool Bool )
            value.FlipFlag                                  = GetBool(new IntPtr(p + 0x089)); // 0x89 FlipFlag                    ( ModelPrimitiveType bool bool bool Bool )
            value.PrevView                                  = (Vector3)GetInt32(new IntPtr(p + 0x08C)); // 0x8C PrevView                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.BaseTarget                                = (Target)GetInt32(new IntPtr(p + 0x098)); // 0x98 BaseTarget                  ( ModelEnumType Target Target Target Int32 )
            value.AreaTex                                   = GetObject<Texture2D>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Texture2D.FromPointer); // 0xA0 AreaTex                     ( ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.Top                                       = (Vector3)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 Top                         ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Front                                     = (Vector3)GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 Front                       ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.BaseCam                                   = GetObject<Camera>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Camera.FromPointer); // 0xC0 BaseCam                     ( ModelClassType Camera Camera Camera Pointer )
            value.FaceTransform                             = GetBool(new IntPtr(p + 0x0C8)); // 0xC8 FaceTransform               ( ModelPrimitiveType bool bool bool Bool )
            value.ToolEdit                                  = GetBool(new IntPtr(p + 0x0C9)); // 0xC9 ToolEdit                    ( ModelPrimitiveType bool bool bool Bool )
            value.IsFixPositionRelative                     = GetBool(new IntPtr(p + 0x0CA)); // 0xCA IsFixPositionRelative       ( ModelPrimitiveType bool bool bool Bool )
            value.OppositeEye                               = GetObject<EyeController>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.EyeController.FromPointer); // 0xD0 OppositeEye                 ( ModelClassType EyeController EyeController EyeController Pointer )
            value.ResetFlipOverwriteFlag                    = GetBool(new IntPtr(p + 0x0D8)); // 0xD8 ResetFlipOverwriteFlag      ( ModelPrimitiveType bool bool bool Bool )
            value.ResetFlip                                 = GetBool(new IntPtr(p + 0x0D9)); // 0xD9 ResetFlip                   ( ModelPrimitiveType bool bool bool Bool )
            value.RemoveHighLight                           = GetBool(new IntPtr(p + 0x0DA)); // 0xDA RemoveHighLight             ( ModelPrimitiveType bool bool bool Bool )
            value.RemoveEyeIris                             = GetBool(new IntPtr(p + 0x0DB)); // 0xDB RemoveEyeIris               ( ModelPrimitiveType bool bool bool Bool )
            value.ParamX                                    = GetSingle(new IntPtr(p + 0x0DC)); // 0xDC ParamX                      ( ModelPrimitiveType float float float Single )
            value.CameraDatas                               = GetObjectList<CameraData>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.CameraData.FromPointer); // 0xE0 CameraDatas                 ( ModelClassListType List`1<CameraData> List`1<CameraData> List<CameraData> Pointer )
            value.NormalEyeTargets                          = GetObjectList<GameObject>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.GameObject.FromPointer); // 0xE8 NormalEyeTargets            ( ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.DrawCameraData                            = GetObject<CameraData>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.CameraData.FromPointer); // 0xF0 DrawCameraData              ( ModelClassType CameraData CameraData CameraData Pointer )
            value.AngleHTable                               = GetSingleList(new IntPtr(p + 0x0F8)); // 0xF8 AngleHTable                 ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.AngleVTable                               = GetSingleList(new IntPtr(p + 0x100)); // 0x100 AngleVTable                 ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.LengthTable                               = GetSingleList(new IntPtr(p + 0x108)); // 0x108 LengthTable                 ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.LastObjectDir                             = (Vector3)GetInt32(new IntPtr(p + 0x110)); // 0x110 LastObjectDir               ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.MoveMax                                   = GetSingle(new IntPtr(p + 0x11C)); // 0x11C MoveMax                     ( ModelPrimitiveType float float float Single )
            value.FreeTarget                                = (Vector3)GetInt32(new IntPtr(p + 0x120)); // 0x120 FreeTarget                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.MirrorCopy                                = GetObject<EyeController>(new IntPtr(p + 0x130), ReversePrism.DataModels.EyeController.FromPointer); // 0x130 MirrorCopy                  ( ModelClassType EyeController EyeController EyeController Pointer )
            value.SetUvOuter                                = GetBool(new IntPtr(p + 0x138)); // 0x138 SetUvOuter                  ( ModelPrimitiveType bool bool bool Bool )
            value.IrisUV                                    = (Vector4)GetInt32(new IntPtr(p + 0x13C)); // 0x13C IrisUV                      ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.Flip                                      = GetSingle(new IntPtr(p + 0x14C)); // 0x14C Flip                        ( ModelPrimitiveType float float float Single )
            value.NoLimit                                   = GetBool(new IntPtr(p + 0x150)); // 0x150 NoLimit                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
