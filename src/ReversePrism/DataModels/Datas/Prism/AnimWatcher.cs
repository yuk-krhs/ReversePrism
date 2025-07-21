using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AudienceController                       ModelClassType AudienceController AudienceController AudienceController Pointer
    // 028 TargetFrameRate                          ModelPrimitiveType float float float Single
    // 030 ThisTra                                  ModelClassType Transform Transform Transform Pointer
    // 038 OrgPosition                              ModelEnumType Vector3 Vector3 Vector3 Int32
    // 048 SilTra                                   ModelClassType Transform Transform Transform Pointer
    // 050 HandTras                                 ModelClassListType Transform[] Transform[] List<Transform> Pointer
    // 058 OrgSilVerts                              ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 060 orgCyaVertss                             Vector3[][] IL2CPP_TYPE_SZARRAY
    // 068 CtrlVs0                                  ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 070 SilVerts                                 ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 000 CYAVERTS_HAND                            int IL2CPP_TYPE_I4
    // 000 CYAVERTS_LENGTH                          int IL2CPP_TYPE_I4
    // 078 cyaVertss                                Vector3[][] IL2CPP_TYPE_SZARRAY
    // 080 TowelOffsets                             ModelEnumListType Vector2[] Vector2[] List<Vector2> Pointer
    // 088 IDelay                                   ModelPrimitiveType int int int Int32
    // 08C NDelay                                   ModelPrimitiveType int int int Int32
    // 090 CyaIdxs                                  ModelPrimitiveListType int[] int[] List<int> Pointer
    // 098 quis                                     <Array> IL2CPP_TYPE_ARRAY
    // 000 quiverSpeed                              float IL2CPP_TYPE_R4
    // 000 baraKizami                               float IL2CPP_TYPE_R4
    // 000 baraRecTime                              float IL2CPP_TYPE_R4
    // 000 baraSusTime                              float IL2CPP_TYPE_R4
    // 000 baraLen                                  int IL2CPP_TYPE_I4
    // 0A0 BaraTimer                                ModelPrimitiveType float float float Single
    // 0A4 BaraPtr                                  ModelPrimitiveType int int int Int32
    // 0A8 Bara1st                                  ModelPrimitiveType bool bool bool Bool
    // 0B0 BaraPosis                                ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 0B8 BaraAmps                                 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 0C0 BaraVelos                                ModelPrimitiveListType float[] float[] List<float> Pointer
    // 0C8 TargAmp                                  ModelPrimitiveType float float float Single
    // 0CC TargVelo                                 ModelPrimitiveType float float float Single
    // 0D0 AveAmp                                   ModelPrimitiveType float float float Single
    // 0D4 AveVelo                                  ModelPrimitiveType float float float Single
    // 0D8 VelAmp                                   ModelPrimitiveType float float float Single
    // 0DC VelVelo                                  ModelPrimitiveType float float float Single
    // 0E0 T0                                       ModelPrimitiveType float float float Single
    // 000 NDELTA                                   int IL2CPP_TYPE_I4
    // 0E8 Deltas                                   ModelPrimitiveListType float[] float[] List<float> Pointer
    // 0F0 PDelta                                   ModelPrimitiveType int int int Int32
    // 0F4 HasTowel                                 ModelPrimitiveType bool bool bool Bool
    // 0F8 TowelObj                                 ModelClassType GameObject GameObject GameObject Pointer
    // 100 TowelTra                                 ModelClassType Transform Transform Transform Pointer
    // 108 TowelRen                                 ModelClassType Renderer Renderer Renderer Pointer
    // 110 TowelMat                                 ModelClassType Material Material Material Pointer
    // 118 Blk                                      ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer
    // 120 Id_MainTex_ST                            ModelPrimitiveType int int int Int32
    // 124 Scale_offset                             ModelEnumType Vector4 Vector4 Vector4 Int32
    // 138 TowelUVs                                 ModelEnumListType Vector2[] Vector2[] List<Vector2> Pointer
    // 140 Markers                                  ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 148 Cols                                     ModelEnumListType Color[] Color[] List<Color> Pointer
    // 150 Ready                                    ModelPrimitiveType bool bool bool Bool
    // 151 Show                                     ModelPrimitiveType bool bool bool Bool
    // 158 DelayedVerts                             ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    public partial class AnimWatcher : DataModel
    {
        public AudienceController?                      AudienceController                      { get; set; }
        public float                                    TargetFrameRate                         { get; set; }
        public Transform?                               ThisTra                                 { get; set; }
        public Vector3                                  OrgPosition                             { get; set; }
        public Transform?                               SilTra                                  { get; set; }
        public List<Transform>?                         HandTras                                { get; set; }
        public List<Vector3>?                           OrgSilVerts                             { get; set; }
        public List<Vector3>?                           CtrlVs0                                 { get; set; }
        public List<Vector4>?                           SilVerts                                { get; set; }
        public List<Vector2>?                           TowelOffsets                            { get; set; }
        public int                                      IDelay                                  { get; set; }
        public int                                      NDelay                                  { get; set; }
        public List<int>?                               CyaIdxs                                 { get; set; }
        public float                                    BaraTimer                               { get; set; }
        public int                                      BaraPtr                                 { get; set; }
        public bool                                     Bara1st                                 { get; set; }
        public List<Vector3>?                           BaraPosis                               { get; set; }
        public List<float>?                             BaraAmps                                { get; set; }
        public List<float>?                             BaraVelos                               { get; set; }
        public float                                    TargAmp                                 { get; set; }
        public float                                    TargVelo                                { get; set; }
        public float                                    AveAmp                                  { get; set; }
        public float                                    AveVelo                                 { get; set; }
        public float                                    VelAmp                                  { get; set; }
        public float                                    VelVelo                                 { get; set; }
        public float                                    T0                                      { get; set; }
        public List<float>?                             Deltas                                  { get; set; }
        public int                                      PDelta                                  { get; set; }
        public bool                                     HasTowel                                { get; set; }
        public GameObject?                              TowelObj                                { get; set; }
        public Transform?                               TowelTra                                { get; set; }
        public Renderer?                                TowelRen                                { get; set; }
        public Material?                                TowelMat                                { get; set; }
        public MaterialPropertyBlock?                   Blk                                     { get; set; }
        public int                                      Id_MainTex_ST                           { get; set; }
        public Vector4                                  Scale_offset                            { get; set; }
        public List<Vector2>?                           TowelUVs                                { get; set; }
        public List<GameObject>?                        Markers                                 { get; set; }
        public List<Color>?                             Cols                                    { get; set; }
        public bool                                     Ready                                   { get; set; }
        public bool                                     Show                                    { get; set; }
        public List<Vector3>?                           DelayedVerts                            { get; set; }

        public static AnimWatcher? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnimWatcher() { Pointer= p0 };

            value.AudienceController                        = GetObject<AudienceController>(new IntPtr(p + 0x020), ReversePrism.DataModels.AudienceController.FromPointer); // 0x20 AudienceController          ( ModelClassType AudienceController AudienceController AudienceController Pointer )
            value.TargetFrameRate                           = GetSingle(new IntPtr(p + 0x028)); // 0x28 TargetFrameRate             ( ModelPrimitiveType float float float Single )
            value.ThisTra                                   = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0x30 ThisTra                     ( ModelClassType Transform Transform Transform Pointer )
            value.OrgPosition                               = (Vector3)GetInt32(new IntPtr(p + 0x038)); // 0x38 OrgPosition                 ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.SilTra                                    = GetObject<Transform>(new IntPtr(p + 0x048), ReversePrism.DataModels.Transform.FromPointer); // 0x48 SilTra                      ( ModelClassType Transform Transform Transform Pointer )
            value.HandTras                                  = GetObjectList<Transform>(new IntPtr(p + 0x050), ReversePrism.DataModels.Transform.FromPointer); // 0x50 HandTras                    ( ModelClassListType Transform[] Transform[] List<Transform> Pointer )
            value.OrgSilVerts                               = GetEnumList<Vector3>(new IntPtr(p + 0x058)); // 0x58 OrgSilVerts                 ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.CtrlVs0                                   = GetEnumList<Vector3>(new IntPtr(p + 0x068)); // 0x68 CtrlVs0                     ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.SilVerts                                  = GetEnumList<Vector4>(new IntPtr(p + 0x070)); // 0x70 SilVerts                    ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.TowelOffsets                              = GetEnumList<Vector2>(new IntPtr(p + 0x080)); // 0x80 TowelOffsets                ( ModelEnumListType Vector2[] Vector2[] List<Vector2> Pointer )
            value.IDelay                                    = GetInt32(new IntPtr(p + 0x088)); // 0x88 IDelay                      ( ModelPrimitiveType int int int Int32 )
            value.NDelay                                    = GetInt32(new IntPtr(p + 0x08C)); // 0x8C NDelay                      ( ModelPrimitiveType int int int Int32 )
            value.CyaIdxs                                   = GetInt32List(new IntPtr(p + 0x090)); // 0x90 CyaIdxs                     ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.BaraTimer                                 = GetSingle(new IntPtr(p + 0x0A0)); // 0xA0 BaraTimer                   ( ModelPrimitiveType float float float Single )
            value.BaraPtr                                   = GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 BaraPtr                     ( ModelPrimitiveType int int int Int32 )
            value.Bara1st                                   = GetBool(new IntPtr(p + 0x0A8)); // 0xA8 Bara1st                     ( ModelPrimitiveType bool bool bool Bool )
            value.BaraPosis                                 = GetEnumList<Vector3>(new IntPtr(p + 0x0B0)); // 0xB0 BaraPosis                   ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.BaraAmps                                  = GetSingleList(new IntPtr(p + 0x0B8)); // 0xB8 BaraAmps                    ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.BaraVelos                                 = GetSingleList(new IntPtr(p + 0x0C0)); // 0xC0 BaraVelos                   ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.TargAmp                                   = GetSingle(new IntPtr(p + 0x0C8)); // 0xC8 TargAmp                     ( ModelPrimitiveType float float float Single )
            value.TargVelo                                  = GetSingle(new IntPtr(p + 0x0CC)); // 0xCC TargVelo                    ( ModelPrimitiveType float float float Single )
            value.AveAmp                                    = GetSingle(new IntPtr(p + 0x0D0)); // 0xD0 AveAmp                      ( ModelPrimitiveType float float float Single )
            value.AveVelo                                   = GetSingle(new IntPtr(p + 0x0D4)); // 0xD4 AveVelo                     ( ModelPrimitiveType float float float Single )
            value.VelAmp                                    = GetSingle(new IntPtr(p + 0x0D8)); // 0xD8 VelAmp                      ( ModelPrimitiveType float float float Single )
            value.VelVelo                                   = GetSingle(new IntPtr(p + 0x0DC)); // 0xDC VelVelo                     ( ModelPrimitiveType float float float Single )
            value.T0                                        = GetSingle(new IntPtr(p + 0x0E0)); // 0xE0 T0                          ( ModelPrimitiveType float float float Single )
            value.Deltas                                    = GetSingleList(new IntPtr(p + 0x0E8)); // 0xE8 Deltas                      ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.PDelta                                    = GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 PDelta                      ( ModelPrimitiveType int int int Int32 )
            value.HasTowel                                  = GetBool(new IntPtr(p + 0x0F4)); // 0xF4 HasTowel                    ( ModelPrimitiveType bool bool bool Bool )
            value.TowelObj                                  = GetObject<GameObject>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.GameObject.FromPointer); // 0xF8 TowelObj                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TowelTra                                  = GetObject<Transform>(new IntPtr(p + 0x100), ReversePrism.DataModels.Transform.FromPointer); // 0x100 TowelTra                    ( ModelClassType Transform Transform Transform Pointer )
            value.TowelRen                                  = GetObject<Renderer>(new IntPtr(p + 0x108), ReversePrism.DataModels.Renderer.FromPointer); // 0x108 TowelRen                    ( ModelClassType Renderer Renderer Renderer Pointer )
            value.TowelMat                                  = GetObject<Material>(new IntPtr(p + 0x110), ReversePrism.DataModels.Material.FromPointer); // 0x110 TowelMat                    ( ModelClassType Material Material Material Pointer )
            value.Blk                                       = GetObject<MaterialPropertyBlock>(new IntPtr(p + 0x118), ReversePrism.DataModels.MaterialPropertyBlock.FromPointer); // 0x118 Blk                         ( ModelClassType MaterialPropertyBlock MaterialPropertyBlock MaterialPropertyBlock Pointer )
            value.Id_MainTex_ST                             = GetInt32(new IntPtr(p + 0x120)); // 0x120 Id_MainTex_ST               ( ModelPrimitiveType int int int Int32 )
            value.Scale_offset                              = (Vector4)GetInt32(new IntPtr(p + 0x124)); // 0x124 Scale_offset                ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.TowelUVs                                  = GetEnumList<Vector2>(new IntPtr(p + 0x138)); // 0x138 TowelUVs                    ( ModelEnumListType Vector2[] Vector2[] List<Vector2> Pointer )
            value.Markers                                   = GetObjectList<GameObject>(new IntPtr(p + 0x140), ReversePrism.DataModels.GameObject.FromPointer); // 0x140 Markers                     ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.Cols                                      = GetEnumList<Color>(new IntPtr(p + 0x148)); // 0x148 Cols                        ( ModelEnumListType Color[] Color[] List<Color> Pointer )
            value.Ready                                     = GetBool(new IntPtr(p + 0x150)); // 0x150 Ready                       ( ModelPrimitiveType bool bool bool Bool )
            value.Show                                      = GetBool(new IntPtr(p + 0x151)); // 0x151 Show                        ( ModelPrimitiveType bool bool bool Bool )
            value.DelayedVerts                              = GetEnumList<Vector3>(new IntPtr(p + 0x158)); // 0x158 DelayedVerts                ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )

            return value;
        }
    }
}
