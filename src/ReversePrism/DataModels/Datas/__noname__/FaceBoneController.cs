using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BaseObject                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 EyeL                                     0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 030 EyeR                                     0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 038 Nose                                     0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 040 Mouth                                    0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 048 Chin                                     0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 050 EyeBrowL                                 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 058 EyeBrowR                                 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 060 CharaModelName                           000186671910 ModelPrimitiveType string string string String
    // 068 TopDir                                   0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 074 FrontDir                                 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 080 BasePos                                  000185CB0BC8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 088 ZbiasParam                               000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 090 ZbiasList                                000185D23CC8 ModelClassListType List`1<ZBiasData> List`1<ZBiasData> List<ZBiasData> Pointer
    // 098 AnimParam                                000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 0A0 AnimParamID                              000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0A8 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 0B0 UParam                                   0001866656B0 ModelPrimitiveType float float float Single
    // 0B4 VParam                                   0001866656B0 ModelPrimitiveType float float float Single
    // 0B8 EditMode                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 0C0 TransformDataPath                        000186671910 ModelPrimitiveType string string string String
    // 0C8 RenderCameraSettingId                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0D0 CachedRendererListExecutor               000186522B30 ModelClassType CachedRendererListExecutor CachedRendererListExecutor CachedRendererListExecutor Pointer
    // 0D8 FaceBasePos                              0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0E4 ParamVec                                 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0F0 Character                                000186596FD0 ModelClassType Character Character Character Pointer
    // 0F8 valTable                                 <Array> IL2CPP_TYPE_ARRAY
    // 100 TransformData                            00018668F450 ModelClassType TransformDataArray TransformDataArray TransformDataArray Pointer
    public partial class FaceBoneController
    {
        public GameObject?                              BaseObject                              { get; set; }
        public GameObject?                              EyeL                                    { get; set; }
        public GameObject?                              EyeR                                    { get; set; }
        public GameObject?                              Nose                                    { get; set; }
        public GameObject?                              Mouth                                   { get; set; }
        public GameObject?                              Chin                                    { get; set; }
        public GameObject?                              EyeBrowL                                { get; set; }
        public GameObject?                              EyeBrowR                                { get; set; }
        public string                                   CharaModelName                          { get; set; }
        public Vector3                                  TopDir                                  { get; set; }
        public Vector3                                  FrontDir                                { get; set; }
        public List<Vector3>?                           BasePos                                 { get; set; }
        public List<float>?                             ZbiasParam                              { get; set; }
        public List<ZBiasData>?                         ZbiasList                               { get; set; }
        public List<float>?                             AnimParam                               { get; set; }
        public List<string>?                            AnimParamID                             { get; set; }
        public Animator?                                Animator                                { get; set; }
        public float                                    UParam                                  { get; set; }
        public float                                    VParam                                  { get; set; }
        public bool                                     EditMode                                { get; set; }
        public string                                   TransformDataPath                       { get; set; }
        public int                                      RenderCameraSettingId                   { get; set; }
        public CachedRendererListExecutor?              CachedRendererListExecutor              { get; set; }
        public Vector3                                  FaceBasePos                             { get; set; }
        public Vector3                                  ParamVec                                { get; set; }
        public Character?                               Character                               { get; set; }
        public TransformDataArray?                      TransformData                           { get; set; }

        public static FaceBoneController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FaceBoneController();

            value.BaseObject                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270069E8438 0x20 BaseObject                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.EyeL                                      = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270069E8458 0x28 EyeL                        ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.EyeR                                      = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0270069E8478 0x30 EyeR                        ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.Nose                                      = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270069E8498 0x38 Nose                        ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.Mouth                                     = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0270069E84B8 0x40 Mouth                       ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.Chin                                      = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270069E84D8 0x48 Chin                        ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.EyeBrowL                                  = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270069E84F8 0x50 EyeBrowL                    ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.EyeBrowR                                  = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270069E8518 0x58 EyeBrowR                    ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.CharaModelName                            = GetString(new IntPtr(p + 0x060)); // 0270069E8538 0x60 CharaModelName              ( 000186671910 ModelPrimitiveType string string string String )
            value.TopDir                                    = (Vector3)GetInt32(new IntPtr(p + 0x068)); // 0270069E8558 0x68 TopDir                      ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.FrontDir                                  = (Vector3)GetInt32(new IntPtr(p + 0x074)); // 0270069E8578 0x74 FrontDir                    ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.BasePos                                   = GetEnumList<Vector3>(new IntPtr(p + 0x080)); // 0270069E8598 0x80 BasePos                     ( 000185CB0BC8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.ZbiasParam                                = GetSingleList(new IntPtr(p + 0x088)); // 0270069E85B8 0x88 ZbiasParam                  ( 000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.ZbiasList                                 = GetObjectList<ZBiasData>(new IntPtr(p + 0x090), ReversePrism.DataModels.ZBiasData.FromPointer); // 0270069E85D8 0x90 ZbiasList                   ( 000185D23CC8 ModelClassListType List`1<ZBiasData> List`1<ZBiasData> List<ZBiasData> Pointer )
            value.AnimParam                                 = GetSingleList(new IntPtr(p + 0x098)); // 0270069E85F8 0x98 AnimParam                   ( 000185B80920 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.AnimParamID                               = GetStringList(new IntPtr(p + 0x0A0)); // 0270069E8618 0xA0 AnimParamID                 ( 000185B81990 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Animator.FromPointer); // 0270069E8638 0xA8 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.UParam                                    = GetSingle(new IntPtr(p + 0x0B0)); // 0270069E8658 0xB0 UParam                      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.VParam                                    = GetSingle(new IntPtr(p + 0x0B4)); // 0270069E8678 0xB4 VParam                      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.EditMode                                  = GetBool(new IntPtr(p + 0x0B8)); // 0270069E8698 0xB8 EditMode                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.TransformDataPath                         = GetString(new IntPtr(p + 0x0C0)); // 0270069E86B8 0xC0 TransformDataPath           ( 000186671910 ModelPrimitiveType string string string String )
            value.RenderCameraSettingId                     = GetInt32(new IntPtr(p + 0x0C8)); // 0270069E86D8 0xC8 RenderCameraSettingId       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CachedRendererListExecutor                = GetObject<CachedRendererListExecutor>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.CachedRendererListExecutor.FromPointer); // 0270069E86F8 0xD0 CachedRendererListExecutor  ( 000186522B30 ModelClassType CachedRendererListExecutor CachedRendererListExecutor CachedRendererListExecutor Pointer )
            value.FaceBasePos                               = (Vector3)GetInt32(new IntPtr(p + 0x0D8)); // 0270069E8718 0xD8 FaceBasePos                 ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.ParamVec                                  = (Vector3)GetInt32(new IntPtr(p + 0x0E4)); // 0270069E8738 0xE4 ParamVec                    ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.Character.FromPointer); // 0270069E8758 0xF0 Character                   ( 000186596FD0 ModelClassType Character Character Character Pointer )
            value.TransformData                             = GetObject<TransformDataArray>(new IntPtr(p + 0x100), ReversePrism.DataModels.TransformDataArray.FromPointer); // 0270069E8798 0x100 TransformData               ( 00018668F450 ModelClassType TransformDataArray TransformDataArray TransformDataArray Pointer )

            return value;
        }
    }
}
