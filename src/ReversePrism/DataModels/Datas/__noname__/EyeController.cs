using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BaseObject                               0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 028 HeadObject                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 TargetObject                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 EyeTargets                               000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 040 FaceTargets                              000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 048 CharacterRoot                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 050 BoneRightHand                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 058 BoneLeftHand                             0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 060 NeckLocalRotY                            0001866656B0 ModelPrimitiveType float float float Single
    // 068 LiveChara                                000186544E10 ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer
    // 070 ParamTex                                 000185CAB3C8 ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer
    // 078 Left                                     000186595960 ModelPrimitiveType bool bool bool Bool
    // 07C HightLightTraceRate                      000186666050 ModelPrimitiveType float float float Single
    // 080 EyeTargetNo                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 084 LastTargetNo                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 088 BlinkFlag                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 089 FlipFlag                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 08C PrevView                                 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 098 BaseTarget                               00018667B9F0 ModelEnumType Target Target Target Int32
    // 0A0 AreaTex                                  000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer
    // 0A8 Top                                      0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0B4 Front                                    0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0C0 BaseCam                                  0001865A2B40 ModelClassType Camera Camera Camera Pointer
    // 0C8 FaceTransform                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0C9 ToolEdit                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0CA IsFixPositionRelative                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0D0 OppositeEye                              0001865401E0 ModelClassType EyeController EyeController EyeController Pointer
    // 0D8 ResetFlipOverwriteFlag                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0D9 ResetFlip                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0DC ParamX                                   000186667B80 ModelPrimitiveType float float float Single
    // 0E0 CameraDatas                              000185D23A68 ModelClassListType List`1<CameraData> List`1<CameraData> List<CameraData> Pointer
    // 0E8 NormalEyeTargets                         000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 0F0 DrawCameraData                           00018667B4F0 ModelClassType CameraData CameraData CameraData Pointer
    // 0F8 RenderCameraSettingId                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 100 AngleHTable                              000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 108 AngleVTable                              000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 110 LengthTable                              000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 118 LastObjectDir                            0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 124 MaxSpeed                                 000186666050 ModelPrimitiveType float float float Single
    // 128 FreeTarget                               0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 138 MirrorCopy                               0001865401E0 ModelClassType EyeController EyeController EyeController Pointer
    // 140 SetUvOuter                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 144 IrisUV                                   0001866AF9F0 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 154 Flip                                     000186667B80 ModelPrimitiveType float float float Single
    // 158 NoLimit                                  000186594D10 ModelPrimitiveType bool bool bool Bool
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
        public float                                    ParamX                                  { get; set; }
        public List<CameraData>?                        CameraDatas                             { get; set; }
        public List<GameObject>?                        NormalEyeTargets                        { get; set; }
        public CameraData?                              DrawCameraData                          { get; set; }
        public int                                      RenderCameraSettingId                   { get; set; }
        public List<float>?                             AngleHTable                             { get; set; }
        public List<float>?                             AngleVTable                             { get; set; }
        public List<float>?                             LengthTable                             { get; set; }
        public Vector3                                  LastObjectDir                           { get; set; }
        public float                                    MaxSpeed                                { get; set; }
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

            value.BaseObject                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0245A69A4778 0x20 BaseObject                  ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.HeadObject                                = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0245A69A4798 0x28 HeadObject                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TargetObject                              = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0245A69A47B8 0x30 TargetObject                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.EyeTargets                                = GetObjectList<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0245A69A47D8 0x38 EyeTargets                  ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.FaceTargets                               = GetObjectList<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0245A69A47F8 0x40 FaceTargets                 ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.CharacterRoot                             = GetObject<Transform>(new IntPtr(p + 0x048), ReversePrism.DataModels.Transform.FromPointer); // 0245A69A4818 0x48 CharacterRoot               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.BoneRightHand                             = GetObject<Transform>(new IntPtr(p + 0x050), ReversePrism.DataModels.Transform.FromPointer); // 0245A69A4838 0x50 BoneRightHand               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.BoneLeftHand                              = GetObject<Transform>(new IntPtr(p + 0x058), ReversePrism.DataModels.Transform.FromPointer); // 0245A69A4858 0x58 BoneLeftHand                ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.NeckLocalRotY                             = GetSingle(new IntPtr(p + 0x060)); // 0245A69A4878 0x60 NeckLocalRotY               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LiveChara                                 = GetObject<LiveCharacterController>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveCharacterController.FromPointer); // 0245A69A4898 0x68 LiveChara                   ( 000186544E10 ModelClassType LiveCharacterController LiveCharacterController LiveCharacterController Pointer )
            value.ParamTex                                  = GetObjectList<Texture2D>(new IntPtr(p + 0x070), ReversePrism.DataModels.Texture2D.FromPointer); // 0245A69A48B8 0x70 ParamTex                    ( 000185CAB3C8 ModelClassListType Texture2D[] Texture2D[] List<Texture2D> Pointer )
            value.Left                                      = GetBool(new IntPtr(p + 0x078)); // 0245A69A48D8 0x78 Left                        ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.HightLightTraceRate                       = GetSingle(new IntPtr(p + 0x07C)); // 0245A69A48F8 0x7C HightLightTraceRate         ( 000186666050 ModelPrimitiveType float float float Single )
            value.EyeTargetNo                               = GetInt32(new IntPtr(p + 0x080)); // 0245A69A4918 0x80 EyeTargetNo                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LastTargetNo                              = GetInt32(new IntPtr(p + 0x084)); // 0245A69A4938 0x84 LastTargetNo                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.BlinkFlag                                 = GetBool(new IntPtr(p + 0x088)); // 0245A69A4958 0x88 BlinkFlag                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.FlipFlag                                  = GetBool(new IntPtr(p + 0x089)); // 0245A69A4978 0x89 FlipFlag                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PrevView                                  = (Vector3)GetInt32(new IntPtr(p + 0x08C)); // 0245A69A4998 0x8C PrevView                    ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.BaseTarget                                = (Target)GetInt32(new IntPtr(p + 0x098)); // 0245A69A49B8 0x98 BaseTarget                  ( 00018667B9F0 ModelEnumType Target Target Target Int32 )
            value.AreaTex                                   = GetObject<Texture2D>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Texture2D.FromPointer); // 0245A69A49D8 0xA0 AreaTex                     ( 000186685A20 ModelClassType Texture2D Texture2D Texture2D Pointer )
            value.Top                                       = (Vector3)GetInt32(new IntPtr(p + 0x0A8)); // 0245A69A49F8 0xA8 Top                         ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Front                                     = (Vector3)GetInt32(new IntPtr(p + 0x0B4)); // 0245A69A4A18 0xB4 Front                       ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.BaseCam                                   = GetObject<Camera>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Camera.FromPointer); // 0245A69A4A38 0xC0 BaseCam                     ( 0001865A2B40 ModelClassType Camera Camera Camera Pointer )
            value.FaceTransform                             = GetBool(new IntPtr(p + 0x0C8)); // 0245A69A4A58 0xC8 FaceTransform               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ToolEdit                                  = GetBool(new IntPtr(p + 0x0C9)); // 0245A69A4A78 0xC9 ToolEdit                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsFixPositionRelative                     = GetBool(new IntPtr(p + 0x0CA)); // 0245A69A4A98 0xCA IsFixPositionRelative       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OppositeEye                               = GetObject<EyeController>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.EyeController.FromPointer); // 0245A69A4AB8 0xD0 OppositeEye                 ( 0001865401E0 ModelClassType EyeController EyeController EyeController Pointer )
            value.ResetFlipOverwriteFlag                    = GetBool(new IntPtr(p + 0x0D8)); // 0245A69A4AD8 0xD8 ResetFlipOverwriteFlag      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ResetFlip                                 = GetBool(new IntPtr(p + 0x0D9)); // 0245A69A4AF8 0xD9 ResetFlip                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ParamX                                    = GetSingle(new IntPtr(p + 0x0DC)); // 0245A69A4B18 0xDC ParamX                      ( 000186667B80 ModelPrimitiveType float float float Single )
            value.CameraDatas                               = GetObjectList<CameraData>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.CameraData.FromPointer); // 0245A69A4B38 0xE0 CameraDatas                 ( 000185D23A68 ModelClassListType List`1<CameraData> List`1<CameraData> List<CameraData> Pointer )
            value.NormalEyeTargets                          = GetObjectList<GameObject>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.GameObject.FromPointer); // 0245A69A4B58 0xE8 NormalEyeTargets            ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.DrawCameraData                            = GetObject<CameraData>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.CameraData.FromPointer); // 0245A69A4B78 0xF0 DrawCameraData              ( 00018667B4F0 ModelClassType CameraData CameraData CameraData Pointer )
            value.RenderCameraSettingId                     = GetInt32(new IntPtr(p + 0x0F8)); // 0245A69A4B98 0xF8 RenderCameraSettingId       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AngleHTable                               = GetSingleList(new IntPtr(p + 0x100)); // 0245A69A4BB8 0x100 AngleHTable                 ( 000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.AngleVTable                               = GetSingleList(new IntPtr(p + 0x108)); // 0245A69A4BD8 0x108 AngleVTable                 ( 000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.LengthTable                               = GetSingleList(new IntPtr(p + 0x110)); // 0245A69A4BF8 0x110 LengthTable                 ( 000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.LastObjectDir                             = (Vector3)GetInt32(new IntPtr(p + 0x118)); // 0245A69A4C18 0x118 LastObjectDir               ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.MaxSpeed                                  = GetSingle(new IntPtr(p + 0x124)); // 0245A69A4C38 0x124 MaxSpeed                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.FreeTarget                                = (Vector3)GetInt32(new IntPtr(p + 0x128)); // 0245A69A4C58 0x128 FreeTarget                  ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.MirrorCopy                                = GetObject<EyeController>(new IntPtr(p + 0x138), ReversePrism.DataModels.EyeController.FromPointer); // 0245A69A4C78 0x138 MirrorCopy                  ( 0001865401E0 ModelClassType EyeController EyeController EyeController Pointer )
            value.SetUvOuter                                = GetBool(new IntPtr(p + 0x140)); // 0245A69A4C98 0x140 SetUvOuter                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IrisUV                                    = (Vector4)GetInt32(new IntPtr(p + 0x144)); // 0245A69A4CB8 0x144 IrisUV                      ( 0001866AF9F0 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.Flip                                      = GetSingle(new IntPtr(p + 0x154)); // 0245A69A4CD8 0x154 Flip                        ( 000186667B80 ModelPrimitiveType float float float Single )
            value.NoLimit                                   = GetBool(new IntPtr(p + 0x158)); // 0245A69A4CF8 0x158 NoLimit                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
