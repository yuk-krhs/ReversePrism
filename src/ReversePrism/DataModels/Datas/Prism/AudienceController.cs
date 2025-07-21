using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Camera                                   ModelClassType Camera Camera Camera Pointer
    // 028 ShowZaseki                               ModelPrimitiveType bool bool bool Bool
    // 029 RandomLayout                             ModelPrimitiveType bool bool bool Bool
    // 02C AnimMag                                  ModelPrimitiveType float float float Single
    // 030 SilMag                                   ModelPrimitiveType float float float Single
    // 034 CyaMag                                   ModelPrimitiveType float float float Single
    // 038 CyaOffset                                ModelEnumType Vector3 Vector3 Vector3 Int32
    // 044 CyaAssignTest                            ModelPrimitiveType bool bool bool Bool
    // 048 UoRatio                                  ModelPrimitiveType float float float Single
    // 04C UltraColor                               ModelEnumType Color Color Color Int32
    // 05C SilRatio                                 ModelPrimitiveType float float float Single
    // 060 TriRatio                                 ModelPrimitiveType float float float Single
    // 064 QuadRatio                                ModelPrimitiveType float float float Single
    // 068 CyaBriAdd                                ModelPrimitiveType float float float Single
    // 06C CyaBriMul                                ModelPrimitiveType float float float Single
    // 070 CyaRenderQueues                          ModelPrimitiveListType int[] int[] List<int> Pointer
    // 000 RichCoronaConfig                         CoronaConfig IL2CPP_TYPE_CLASS
    // 008 NormalCoronaConfig                       CoronaConfig IL2CPP_TYPE_CLASS
    // 010 BaseCoronaConfig                         ModelClassType CoronaConfig CoronaConfig CoronaConfig Pointer
    // 078 RichCoronaConfig                         ModelClassType CoronaConfig CoronaConfig CoronaConfig Pointer
    // 080 NormalCoronaConfig                       ModelClassType CoronaConfig CoronaConfig CoronaConfig Pointer
    // 088 BaseCoronaConfig                         ModelClassType CoronaConfig CoronaConfig CoronaConfig Pointer
    // 090 CoronaWidth                              ModelPrimitiveType float float float Single
    // 094 CoronaShift                              ModelPrimitiveType int int int Int32
    // 098 EnableAnyCorona                          ModelPrimitiveType bool bool bool Bool
    // 099 ForceNormalCorona                        ModelPrimitiveType bool bool bool Bool
    // 0A0 Honsuus                                  ModelPrimitiveListType float[] float[] List<float> Pointer
    // 0A8 Cps                                      ModelEnumType Vector4 Vector4 Vector4 Int32
    // 0B8 MaxCyaDelay                              ModelPrimitiveType float float float Single
    // 0BC CyaDelay                                 ModelPrimitiveType float float float Single
    // 0C0 EnableMovpats                            ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    // 0C8 QuiverOn                                 ModelPrimitiveType bool bool bool Bool
    // 0CC QuiverSpeedMag                           ModelPrimitiveType float float float Single
    // 0D0 QuiverAmpMagT                            ModelPrimitiveType float float float Single
    // 0D4 QuiverAmpMagTy                           ModelPrimitiveType float float float Single
    // 0D8 QuiverAmpMagR                            ModelPrimitiveType float float float Single
    // 0DC QuiverMinAmp                             ModelPrimitiveType float float float Single
    // 0E0 QuiverMinVelo                            ModelPrimitiveType float float float Single
    // 0E4 AutoSetLookAts                           ModelPrimitiveType bool bool bool Bool
    // 0E8 LookAts                                  ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 0F0 Cyaquads                                 ModelClassListType List`1<CyaQuad> List`1<CyaQuad> List<CyaQuad> Pointer
    // 0F8 Sqs                                      ModelClassListType List`1<SeatQuad> List`1<SeatQuad> List<SeatQuad> Pointer
    // 018 Reduction                                ModelPrimitiveType bool bool bool Bool
    // 019 UltraReduction                           ModelPrimitiveType bool bool bool Bool
    // 100 CyalumeMaterialArray                     ModelClassListType Material[] Material[] List<Material> Pointer
    // 000 nCyaPattern                              int IL2CPP_TYPE_I4
    // 108 SEH                                      ModelClassType Transform Transform Transform Pointer
    // 110 Sholder                                  ModelClassType Transform Transform Transform Pointer
    // 118 Elbow                                    ModelClassType Transform Transform Transform Pointer
    // 120 Hand                                     ModelClassType Transform Transform Transform Pointer
    // 000 zasekiName                               string IL2CPP_TYPE_STRING
    // 128 ZasekiRenderers                          ModelClassListType Renderer[] Renderer[] List<Renderer> Pointer
    // 130 FloorMesh                                ModelClassType FloorMesh FloorMesh FloorMesh Pointer
    // 138 AnimWatcher                              ModelClassType AnimWatcher AnimWatcher AnimWatcher Pointer
    // 140 AnimToggles                              ModelClassType GameObject GameObject GameObject Pointer
    // 148 MarkerPrefab                             ModelClassType GameObject GameObject GameObject Pointer
    // 150 ShowMarker                               ModelPrimitiveType bool bool bool Bool
    // 154 FillRatioTestMode                        ModelPrimitiveType int int int Int32
    // 158 FillRatioUp                              ModelPrimitiveType bool bool bool Bool
    // 15C OrgSilRatio                              ModelPrimitiveType float float float Single
    // 160 TestFillRatio                            ModelPrimitiveType float float float Single
    // 164 DispRatioDebug                           ModelPrimitiveType float float float Single
    // 01C DispRatio                                ModelPrimitiveType float float float Single
    // 168 DispDist                                 ModelPrimitiveType float float float Single
    // 170 LookAtVecs                               ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 000 animPrefabPath                           string IL2CPP_TYPE_STRING
    // 178 TglObjs                                  ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 180 ToggleOrg                                ModelClassType GameObject GameObject GameObject Pointer
    // 188 Tglready                                 ModelPrimitiveType bool bool bool Bool
    // 18C NAnim                                    ModelPrimitiveType int int int Int32
    // 190 AnimKickID                               ModelPrimitiveType int int int Int32
    // 198 RegToggle                                ModelClassType Regex Regex Regex Pointer
    // 1A0 Repeat                                   ModelPrimitiveType bool bool bool Bool
    // 1A8 _palette                                 IReadOnlyCollection`1<Color> IL2CPP_TYPE_GENERICINST
    // 1B0 UoRatio                                  ModelPrimitiveType float float float Single
    // 1B4 TriRatio                                 ModelPrimitiveType float float float Single
    // 1B8 QuadRatio                                ModelPrimitiveType float float float Single
    // 1BC SilRatio                                 ModelPrimitiveType float float float Single
    // 1C0 CyaBriAdd                                ModelPrimitiveType float float float Single
    // 1C4 CyaBriMul                                ModelPrimitiveType float float float Single
    // 020 FuncNames                                ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 NFUNC                                    ModelPrimitiveType int int int Int32
    // 1C8 AnimPrefabDebug                          ModelClassType GameObject GameObject GameObject Pointer
    // 1D0 AnimLposi                                ModelEnumType Vector3 Vector3 Vector3 Int32
    // 1DC XPitchn                                  ModelPrimitiveType float float float Single
    // 1E0 ZPitchn                                  ModelPrimitiveType float float float Single
    // 1E8 CyMotion                                 ModelClassType ChemicalLightMotion ChemicalLightMotion ChemicalLightMotion Pointer
    // 1F0 AnimObj                                  ModelClassType GameObject GameObject GameObject Pointer
    // 1F8 IsLiteMode                               ModelPrimitiveType bool bool bool Bool
    public partial class AudienceController : DataModel
    {
        public Camera?                                  Camera                                  { get; set; }
        public bool                                     ShowZaseki                              { get; set; }
        public bool                                     RandomLayout                            { get; set; }
        public float                                    AnimMag                                 { get; set; }
        public float                                    SilMag                                  { get; set; }
        public float                                    CyaMag                                  { get; set; }
        public Vector3                                  CyaOffset                               { get; set; }
        public bool                                     CyaAssignTest                           { get; set; }
        public float                                    UoRatio                                 { get; set; }
        public Color                                    UltraColor                              { get; set; }
        public float                                    SilRatio                                { get; set; }
        public float                                    TriRatio                                { get; set; }
        public float                                    QuadRatio                               { get; set; }
        public float                                    CyaBriAdd                               { get; set; }
        public float                                    CyaBriMul                               { get; set; }
        public List<int>?                               CyaRenderQueues                         { get; set; }
        public CoronaConfig?                            BaseCoronaConfig                        { get; set; }
        public CoronaConfig?                            RichCoronaConfig                        { get; set; }
        public CoronaConfig?                            NormalCoronaConfig                      { get; set; }
        public float                                    CoronaWidth                             { get; set; }
        public int                                      CoronaShift                             { get; set; }
        public bool                                     EnableAnyCorona                         { get; set; }
        public bool                                     ForceNormalCorona                       { get; set; }
        public List<float>?                             Honsuus                                 { get; set; }
        public Vector4                                  Cps                                     { get; set; }
        public float                                    MaxCyaDelay                             { get; set; }
        public float                                    CyaDelay                                { get; set; }
        public List<bool>?                              EnableMovpats                           { get; set; }
        public bool                                     QuiverOn                                { get; set; }
        public float                                    QuiverSpeedMag                          { get; set; }
        public float                                    QuiverAmpMagT                           { get; set; }
        public float                                    QuiverAmpMagTy                          { get; set; }
        public float                                    QuiverAmpMagR                           { get; set; }
        public float                                    QuiverMinAmp                            { get; set; }
        public float                                    QuiverMinVelo                           { get; set; }
        public bool                                     AutoSetLookAts                          { get; set; }
        public List<Transform>?                         LookAts                                 { get; set; }
        public List<CyaQuad>?                           Cyaquads                                { get; set; }
        public List<SeatQuad>?                          Sqs                                     { get; set; }
        public bool                                     Reduction                               { get; set; }
        public bool                                     UltraReduction                          { get; set; }
        public List<Material>?                          CyalumeMaterialArray                    { get; set; }
        public Transform?                               SEH                                     { get; set; }
        public Transform?                               Sholder                                 { get; set; }
        public Transform?                               Elbow                                   { get; set; }
        public Transform?                               Hand                                    { get; set; }
        public List<Renderer>?                          ZasekiRenderers                         { get; set; }
        public FloorMesh?                               FloorMesh                               { get; set; }
        public AnimWatcher?                             AnimWatcher                             { get; set; }
        public GameObject?                              AnimToggles                             { get; set; }
        public GameObject?                              MarkerPrefab                            { get; set; }
        public bool                                     ShowMarker                              { get; set; }
        public int                                      FillRatioTestMode                       { get; set; }
        public bool                                     FillRatioUp                             { get; set; }
        public float                                    OrgSilRatio                             { get; set; }
        public float                                    TestFillRatio                           { get; set; }
        public float                                    DispRatioDebug                          { get; set; }
        public float                                    DispRatio                               { get; set; }
        public float                                    DispDist                                { get; set; }
        public List<Vector3>?                           LookAtVecs                              { get; set; }
        public List<GameObject>?                        TglObjs                                 { get; set; }
        public GameObject?                              ToggleOrg                               { get; set; }
        public bool                                     Tglready                                { get; set; }
        public int                                      NAnim                                   { get; set; }
        public int                                      AnimKickID                              { get; set; }
        public Regex?                                   RegToggle                               { get; set; }
        public bool                                     Repeat                                  { get; set; }
        public List<string>?                            FuncNames                               { get; set; }
        public int                                      NFUNC                                   { get; set; }
        public GameObject?                              AnimPrefabDebug                         { get; set; }
        public Vector3                                  AnimLposi                               { get; set; }
        public float                                    XPitchn                                 { get; set; }
        public float                                    ZPitchn                                 { get; set; }
        public ChemicalLightMotion?                     CyMotion                                { get; set; }
        public GameObject?                              AnimObj                                 { get; set; }
        public bool                                     IsLiteMode                              { get; set; }

        public static AudienceController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AudienceController() { Pointer= p0 };

            value.Camera                                    = GetObject<Camera>(new IntPtr(p + 0x020), ReversePrism.DataModels.Camera.FromPointer); // 0x20 Camera                      ( ModelClassType Camera Camera Camera Pointer )
            value.ShowZaseki                                = GetBool(new IntPtr(p + 0x028)); // 0x28 ShowZaseki                  ( ModelPrimitiveType bool bool bool Bool )
            value.RandomLayout                              = GetBool(new IntPtr(p + 0x029)); // 0x29 RandomLayout                ( ModelPrimitiveType bool bool bool Bool )
            value.AnimMag                                   = GetSingle(new IntPtr(p + 0x02C)); // 0x2C AnimMag                     ( ModelPrimitiveType float float float Single )
            value.SilMag                                    = GetSingle(new IntPtr(p + 0x030)); // 0x30 SilMag                      ( ModelPrimitiveType float float float Single )
            value.CyaMag                                    = GetSingle(new IntPtr(p + 0x034)); // 0x34 CyaMag                      ( ModelPrimitiveType float float float Single )
            value.CyaOffset                                 = (Vector3)GetInt32(new IntPtr(p + 0x038)); // 0x38 CyaOffset                   ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.CyaAssignTest                             = GetBool(new IntPtr(p + 0x044)); // 0x44 CyaAssignTest               ( ModelPrimitiveType bool bool bool Bool )
            value.UoRatio                                   = GetSingle(new IntPtr(p + 0x1B0)); // 0x1B0 UoRatio                     ( ModelPrimitiveType float float float Single )
            value.UltraColor                                = (Color)GetInt32(new IntPtr(p + 0x04C)); // 0x4C UltraColor                  ( ModelEnumType Color Color Color Int32 )
            value.SilRatio                                  = GetSingle(new IntPtr(p + 0x1BC)); // 0x1BC SilRatio                    ( ModelPrimitiveType float float float Single )
            value.TriRatio                                  = GetSingle(new IntPtr(p + 0x1B4)); // 0x1B4 TriRatio                    ( ModelPrimitiveType float float float Single )
            value.QuadRatio                                 = GetSingle(new IntPtr(p + 0x1B8)); // 0x1B8 QuadRatio                   ( ModelPrimitiveType float float float Single )
            value.CyaBriAdd                                 = GetSingle(new IntPtr(p + 0x1C0)); // 0x1C0 CyaBriAdd                   ( ModelPrimitiveType float float float Single )
            value.CyaBriMul                                 = GetSingle(new IntPtr(p + 0x1C4)); // 0x1C4 CyaBriMul                   ( ModelPrimitiveType float float float Single )
            value.CyaRenderQueues                           = GetInt32List(new IntPtr(p + 0x070)); // 0x70 CyaRenderQueues             ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.BaseCoronaConfig                          = GetObject<CoronaConfig>(new IntPtr(p + 0x088), ReversePrism.DataModels.CoronaConfig.FromPointer); // 0x88 BaseCoronaConfig            ( ModelClassType CoronaConfig CoronaConfig CoronaConfig Pointer )
            value.RichCoronaConfig                          = GetObject<CoronaConfig>(new IntPtr(p + 0x078), ReversePrism.DataModels.CoronaConfig.FromPointer); // 0x78 RichCoronaConfig            ( ModelClassType CoronaConfig CoronaConfig CoronaConfig Pointer )
            value.NormalCoronaConfig                        = GetObject<CoronaConfig>(new IntPtr(p + 0x080), ReversePrism.DataModels.CoronaConfig.FromPointer); // 0x80 NormalCoronaConfig          ( ModelClassType CoronaConfig CoronaConfig CoronaConfig Pointer )
            value.CoronaWidth                               = GetSingle(new IntPtr(p + 0x090)); // 0x90 CoronaWidth                 ( ModelPrimitiveType float float float Single )
            value.CoronaShift                               = GetInt32(new IntPtr(p + 0x094)); // 0x94 CoronaShift                 ( ModelPrimitiveType int int int Int32 )
            value.EnableAnyCorona                           = GetBool(new IntPtr(p + 0x098)); // 0x98 EnableAnyCorona             ( ModelPrimitiveType bool bool bool Bool )
            value.ForceNormalCorona                         = GetBool(new IntPtr(p + 0x099)); // 0x99 ForceNormalCorona           ( ModelPrimitiveType bool bool bool Bool )
            value.Honsuus                                   = GetSingleList(new IntPtr(p + 0x0A0)); // 0xA0 Honsuus                     ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.Cps                                       = (Vector4)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 Cps                         ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.MaxCyaDelay                               = GetSingle(new IntPtr(p + 0x0B8)); // 0xB8 MaxCyaDelay                 ( ModelPrimitiveType float float float Single )
            value.CyaDelay                                  = GetSingle(new IntPtr(p + 0x0BC)); // 0xBC CyaDelay                    ( ModelPrimitiveType float float float Single )
            value.EnableMovpats                             = GetBoolList(new IntPtr(p + 0x0C0)); // 0xC0 EnableMovpats               ( ModelPrimitiveListType bool[] bool[] List<bool> Pointer )
            value.QuiverOn                                  = GetBool(new IntPtr(p + 0x0C8)); // 0xC8 QuiverOn                    ( ModelPrimitiveType bool bool bool Bool )
            value.QuiverSpeedMag                            = GetSingle(new IntPtr(p + 0x0CC)); // 0xCC QuiverSpeedMag              ( ModelPrimitiveType float float float Single )
            value.QuiverAmpMagT                             = GetSingle(new IntPtr(p + 0x0D0)); // 0xD0 QuiverAmpMagT               ( ModelPrimitiveType float float float Single )
            value.QuiverAmpMagTy                            = GetSingle(new IntPtr(p + 0x0D4)); // 0xD4 QuiverAmpMagTy              ( ModelPrimitiveType float float float Single )
            value.QuiverAmpMagR                             = GetSingle(new IntPtr(p + 0x0D8)); // 0xD8 QuiverAmpMagR               ( ModelPrimitiveType float float float Single )
            value.QuiverMinAmp                              = GetSingle(new IntPtr(p + 0x0DC)); // 0xDC QuiverMinAmp                ( ModelPrimitiveType float float float Single )
            value.QuiverMinVelo                             = GetSingle(new IntPtr(p + 0x0E0)); // 0xE0 QuiverMinVelo               ( ModelPrimitiveType float float float Single )
            value.AutoSetLookAts                            = GetBool(new IntPtr(p + 0x0E4)); // 0xE4 AutoSetLookAts              ( ModelPrimitiveType bool bool bool Bool )
            value.LookAts                                   = GetObjectList<Transform>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.Transform.FromPointer); // 0xE8 LookAts                     ( ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.Cyaquads                                  = GetObjectList<CyaQuad>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.CyaQuad.FromPointer); // 0xF0 Cyaquads                    ( ModelClassListType List`1<CyaQuad> List`1<CyaQuad> List<CyaQuad> Pointer )
            value.Sqs                                       = GetObjectList<SeatQuad>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.SeatQuad.FromPointer); // 0xF8 Sqs                         ( ModelClassListType List`1<SeatQuad> List`1<SeatQuad> List<SeatQuad> Pointer )
            value.Reduction                                 = GetBool(new IntPtr(p + 0x018)); // 0x18 Reduction                   ( ModelPrimitiveType bool bool bool Bool )
            value.UltraReduction                            = GetBool(new IntPtr(p + 0x019)); // 0x19 UltraReduction              ( ModelPrimitiveType bool bool bool Bool )
            value.CyalumeMaterialArray                      = GetObjectList<Material>(new IntPtr(p + 0x100), ReversePrism.DataModels.Material.FromPointer); // 0x100 CyalumeMaterialArray        ( ModelClassListType Material[] Material[] List<Material> Pointer )
            value.SEH                                       = GetObject<Transform>(new IntPtr(p + 0x108), ReversePrism.DataModels.Transform.FromPointer); // 0x108 SEH                         ( ModelClassType Transform Transform Transform Pointer )
            value.Sholder                                   = GetObject<Transform>(new IntPtr(p + 0x110), ReversePrism.DataModels.Transform.FromPointer); // 0x110 Sholder                     ( ModelClassType Transform Transform Transform Pointer )
            value.Elbow                                     = GetObject<Transform>(new IntPtr(p + 0x118), ReversePrism.DataModels.Transform.FromPointer); // 0x118 Elbow                       ( ModelClassType Transform Transform Transform Pointer )
            value.Hand                                      = GetObject<Transform>(new IntPtr(p + 0x120), ReversePrism.DataModels.Transform.FromPointer); // 0x120 Hand                        ( ModelClassType Transform Transform Transform Pointer )
            value.ZasekiRenderers                           = GetObjectList<Renderer>(new IntPtr(p + 0x128), ReversePrism.DataModels.Renderer.FromPointer); // 0x128 ZasekiRenderers             ( ModelClassListType Renderer[] Renderer[] List<Renderer> Pointer )
            value.FloorMesh                                 = GetObject<FloorMesh>(new IntPtr(p + 0x130), ReversePrism.DataModels.FloorMesh.FromPointer); // 0x130 FloorMesh                   ( ModelClassType FloorMesh FloorMesh FloorMesh Pointer )
            value.AnimWatcher                               = GetObject<AnimWatcher>(new IntPtr(p + 0x138), ReversePrism.DataModels.AnimWatcher.FromPointer); // 0x138 AnimWatcher                 ( ModelClassType AnimWatcher AnimWatcher AnimWatcher Pointer )
            value.AnimToggles                               = GetObject<GameObject>(new IntPtr(p + 0x140), ReversePrism.DataModels.GameObject.FromPointer); // 0x140 AnimToggles                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.MarkerPrefab                              = GetObject<GameObject>(new IntPtr(p + 0x148), ReversePrism.DataModels.GameObject.FromPointer); // 0x148 MarkerPrefab                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ShowMarker                                = GetBool(new IntPtr(p + 0x150)); // 0x150 ShowMarker                  ( ModelPrimitiveType bool bool bool Bool )
            value.FillRatioTestMode                         = GetInt32(new IntPtr(p + 0x154)); // 0x154 FillRatioTestMode           ( ModelPrimitiveType int int int Int32 )
            value.FillRatioUp                               = GetBool(new IntPtr(p + 0x158)); // 0x158 FillRatioUp                 ( ModelPrimitiveType bool bool bool Bool )
            value.OrgSilRatio                               = GetSingle(new IntPtr(p + 0x15C)); // 0x15C OrgSilRatio                 ( ModelPrimitiveType float float float Single )
            value.TestFillRatio                             = GetSingle(new IntPtr(p + 0x160)); // 0x160 TestFillRatio               ( ModelPrimitiveType float float float Single )
            value.DispRatioDebug                            = GetSingle(new IntPtr(p + 0x164)); // 0x164 DispRatioDebug              ( ModelPrimitiveType float float float Single )
            value.DispRatio                                 = GetSingle(new IntPtr(p + 0x01C)); // 0x1C DispRatio                   ( ModelPrimitiveType float float float Single )
            value.DispDist                                  = GetSingle(new IntPtr(p + 0x168)); // 0x168 DispDist                    ( ModelPrimitiveType float float float Single )
            value.LookAtVecs                                = GetEnumList<Vector3>(new IntPtr(p + 0x170)); // 0x170 LookAtVecs                  ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.TglObjs                                   = GetObjectList<GameObject>(new IntPtr(p + 0x178), ReversePrism.DataModels.GameObject.FromPointer); // 0x178 TglObjs                     ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.ToggleOrg                                 = GetObject<GameObject>(new IntPtr(p + 0x180), ReversePrism.DataModels.GameObject.FromPointer); // 0x180 ToggleOrg                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.Tglready                                  = GetBool(new IntPtr(p + 0x188)); // 0x188 Tglready                    ( ModelPrimitiveType bool bool bool Bool )
            value.NAnim                                     = GetInt32(new IntPtr(p + 0x18C)); // 0x18C NAnim                       ( ModelPrimitiveType int int int Int32 )
            value.AnimKickID                                = GetInt32(new IntPtr(p + 0x190)); // 0x190 AnimKickID                  ( ModelPrimitiveType int int int Int32 )
            value.RegToggle                                 = GetObject<Regex>(new IntPtr(p + 0x198), ReversePrism.DataModels.Regex.FromPointer); // 0x198 RegToggle                   ( ModelClassType Regex Regex Regex Pointer )
            value.Repeat                                    = GetBool(new IntPtr(p + 0x1A0)); // 0x1A0 Repeat                      ( ModelPrimitiveType bool bool bool Bool )
            value.FuncNames                                 = GetStringList(new IntPtr(p + 0x020)); // 0x20 FuncNames                   ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.NFUNC                                     = GetInt32(new IntPtr(p + 0x028)); // 0x28 NFUNC                       ( ModelPrimitiveType int int int Int32 )
            value.AnimPrefabDebug                           = GetObject<GameObject>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.GameObject.FromPointer); // 0x1C8 AnimPrefabDebug             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.AnimLposi                                 = (Vector3)GetInt32(new IntPtr(p + 0x1D0)); // 0x1D0 AnimLposi                   ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.XPitchn                                   = GetSingle(new IntPtr(p + 0x1DC)); // 0x1DC XPitchn                     ( ModelPrimitiveType float float float Single )
            value.ZPitchn                                   = GetSingle(new IntPtr(p + 0x1E0)); // 0x1E0 ZPitchn                     ( ModelPrimitiveType float float float Single )
            value.CyMotion                                  = GetObject<ChemicalLightMotion>(new IntPtr(p + 0x1E8), ReversePrism.DataModels.ChemicalLightMotion.FromPointer); // 0x1E8 CyMotion                    ( ModelClassType ChemicalLightMotion ChemicalLightMotion ChemicalLightMotion Pointer )
            value.AnimObj                                   = GetObject<GameObject>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.GameObject.FromPointer); // 0x1F0 AnimObj                     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.IsLiteMode                                = GetBool(new IntPtr(p + 0x1F8)); // 0x1F8 IsLiteMode                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
