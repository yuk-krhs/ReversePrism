using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BaseObject                               ModelClassType GameObject GameObject GameObject Pointer
    // 028 EyeL                                     ModelClassType GameObject GameObject GameObject Pointer
    // 030 EyeR                                     ModelClassType GameObject GameObject GameObject Pointer
    // 038 Nose                                     ModelClassType GameObject GameObject GameObject Pointer
    // 040 Mouth                                    ModelClassType GameObject GameObject GameObject Pointer
    // 048 Chin                                     ModelClassType GameObject GameObject GameObject Pointer
    // 050 EyeBrowL                                 ModelClassType GameObject GameObject GameObject Pointer
    // 058 EyeBrowR                                 ModelClassType GameObject GameObject GameObject Pointer
    // 060 CharaModelName                           ModelPrimitiveType string string string String
    // 068 TopDir                                   ModelEnumType Vector3 Vector3 Vector3 Int32
    // 074 FrontDir                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 080 BasePos                                  ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 088 ZbiasParam                               ModelPrimitiveListType float[] float[] List<float> Pointer
    // 090 ZbiasList                                ModelClassListType List`1<ZBiasData> List`1<ZBiasData> List<ZBiasData> Pointer
    // 098 AnimParam                                ModelPrimitiveListType float[] float[] List<float> Pointer
    // 0A0 AnimParamID                              ModelPrimitiveListType string[] string[] List<string> Pointer
    // 0A8 Animator                                 ModelClassType Animator Animator Animator Pointer
    // 0B0 UParam                                   ModelPrimitiveType float float float Single
    // 0B4 VParam                                   ModelPrimitiveType float float float Single
    // 0B8 EditMode                                 ModelPrimitiveType bool bool bool Bool
    // 0C0 TransformDataPath                        ModelPrimitiveType string string string String
    // 0C8 CachedRendererListExecutor               ModelClassType CachedRendererListExecutor CachedRendererListExecutor CachedRendererListExecutor Pointer
    // 0D0 FaceBasePos                              ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0DC ParamVec                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0E8 Character                                ModelClassType Character Character Character Pointer
    // 0F0 valTable                                 <Array> IL2CPP_TYPE_ARRAY
    // 0F8 TransformData                            ModelClassType TransformDataArray TransformDataArray TransformDataArray Pointer
    public partial class FaceBoneController : DataModel
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
            var value   = new FaceBoneController() { Pointer= p0 };

            value.BaseObject                                = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 BaseObject                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EyeL                                      = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 EyeL                        ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EyeR                                      = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 EyeR                        ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Nose                                      = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 Nose                        ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Mouth                                     = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 0x40 Mouth                       ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Chin                                      = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 Chin                        ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EyeBrowL                                  = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 EyeBrowL                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EyeBrowR                                  = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 EyeBrowR                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CharaModelName                            = GetString(new IntPtr(p + 0x060)); // 0x60 CharaModelName              ( ModelPrimitiveType string string string String )
            value.TopDir                                    = (Vector3)GetInt32(new IntPtr(p + 0x068)); // 0x68 TopDir                      ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.FrontDir                                  = (Vector3)GetInt32(new IntPtr(p + 0x074)); // 0x74 FrontDir                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.BasePos                                   = GetEnumList<Vector3>(new IntPtr(p + 0x080)); // 0x80 BasePos                     ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.ZbiasParam                                = GetSingleList(new IntPtr(p + 0x088)); // 0x88 ZbiasParam                  ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.ZbiasList                                 = GetObjectList<ZBiasData>(new IntPtr(p + 0x090), ReversePrism.DataModels.ZBiasData.FromPointer); // 0x90 ZbiasList                   ( ModelClassListType List`1<ZBiasData> List`1<ZBiasData> List<ZBiasData> Pointer )
            value.AnimParam                                 = GetSingleList(new IntPtr(p + 0x098)); // 0x98 AnimParam                   ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.AnimParamID                               = GetStringList(new IntPtr(p + 0x0A0)); // 0xA0 AnimParamID                 ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Animator.FromPointer); // 0xA8 Animator                    ( ModelClassType Animator Animator Animator Pointer )
            value.UParam                                    = GetSingle(new IntPtr(p + 0x0B0)); // 0xB0 UParam                      ( ModelPrimitiveType float float float Single )
            value.VParam                                    = GetSingle(new IntPtr(p + 0x0B4)); // 0xB4 VParam                      ( ModelPrimitiveType float float float Single )
            value.EditMode                                  = GetBool(new IntPtr(p + 0x0B8)); // 0xB8 EditMode                    ( ModelPrimitiveType bool bool bool Bool )
            value.TransformDataPath                         = GetString(new IntPtr(p + 0x0C0)); // 0xC0 TransformDataPath           ( ModelPrimitiveType string string string String )
            value.CachedRendererListExecutor                = GetObject<CachedRendererListExecutor>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.CachedRendererListExecutor.FromPointer); // 0xC8 CachedRendererListExecutor  ( ModelClassType CachedRendererListExecutor CachedRendererListExecutor CachedRendererListExecutor Pointer )
            value.FaceBasePos                               = (Vector3)GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 FaceBasePos                 ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.ParamVec                                  = (Vector3)GetInt32(new IntPtr(p + 0x0DC)); // 0xDC ParamVec                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Character                                 = GetObject<Character>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Character.FromPointer); // 0xE8 Character                   ( ModelClassType Character Character Character Pointer )
            value.TransformData                             = GetObject<TransformDataArray>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.TransformDataArray.FromPointer); // 0xF8 TransformData               ( ModelClassType TransformDataArray TransformDataArray TransformDataArray Pointer )

            return value;
        }
    }
}
