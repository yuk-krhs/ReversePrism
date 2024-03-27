using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RootBone                                 0001866AA650 ModelClassType Transform Transform Transform Pointer
    // 028 SwayBone                                 0001865FA1A0 ModelClassType SwayBone SwayBone SwayBone Pointer
    // 030 HeadCollide                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 031 HeadZCollide                             000186595960 ModelPrimitiveType bool bool bool Bool
    // 032 HeadXCollide                             000186595960 ModelPrimitiveType bool bool bool Bool
    // 033 ShoulderCollide                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 034 SpineCollide                             000186595960 ModelPrimitiveType bool bool bool Bool
    // 035 ChestCollide                             000186595960 ModelPrimitiveType bool bool bool Bool
    // 036 ArmCollide                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 037 ThighCollide                             000186595960 ModelPrimitiveType bool bool bool Bool
    // 038 SkirtCollide                             000186595960 ModelPrimitiveType bool bool bool Bool
    // 039 PlaneCollide                             000186595960 ModelPrimitiveType bool bool bool Bool
    // 03A SleeveCollide                            000186595960 ModelPrimitiveType bool bool bool Bool
    // 03B XzPlaneCollide                           000186595960 ModelPrimitiveType bool bool bool Bool
    // 03C NeckCollide                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 03D CollideBothUpper                         000186595960 ModelPrimitiveType bool bool bool Bool
    // 040 ChestConstaint                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 044 AngleCap                                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 048 ChestMoveCollide                         000186597BE0 ModelPrimitiveType bool bool bool Bool
    // 000 speedToCollideSize                       float IL2CPP_TYPE_R4
    // 004 shoulderCollideSize                      float IL2CPP_TYPE_R4
    // 008 shoulderCollideShrinkRate                float IL2CPP_TYPE_R4
    // 00C elbowCollideSize                         float IL2CPP_TYPE_R4
    // 010 ElbowCollideShrinkRate                   000186667DD0 ModelPrimitiveType float float float Single
    // 014 HandCollideSize                          000186667DD0 ModelPrimitiveType float float float Single
    // 018 HandCollideShrinkRate                    000186667DD0 ModelPrimitiveType float float float Single
    // 04C CollideIdx                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 CollideMinimum                           0001866656B0 ModelPrimitiveType float float float Single
    // 058 InitialLocalPos                          000185D1AE38 ModelEnumListType List`1<Vector3> List`1<Vector3> List<Vector3> Pointer
    // 060 CollideOffset                            000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 068 GravityDir                               0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 074 GravityLocalDir                          0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 080 AddCollideRoot                           0001866656B0 ModelPrimitiveType float float float Single
    // 084 AddCollideEnd                            0001866656B0 ModelPrimitiveType float float float Single
    // 088 ForceParam                               000185CC38B8 ModelClassListType ForceParam[] ForceParam[] List<ForceParam> Pointer
    // 090 SwayType                                 0001865D85B0 ModelEnumType Type Type Type Int32
    // 094 SwaySubType                              0001865D85B0 ModelEnumType Type Type Type Int32
    // 098 SubRate                                  000186666050 ModelPrimitiveType float float float Single
    // 0A0 ColliderParam                            000185CC36A8 ModelClassListType ColliderParam[] ColliderParam[] List<ColliderParam> Pointer
    // 0A8 IsLeft                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0AC HeadC0                                   0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0B8 HeadC1                                   0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0C4 HeadR0                                   0001866656B0 ModelPrimitiveType float float float Single
    // 0C8 HeadR1                                   0001866656B0 ModelPrimitiveType float float float Single
    // 0CC StopFlag                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0D0 BaseMat                                  00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 110 PrevStopFlag                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 114 LastArmLV                                0001866656B0 ModelPrimitiveType float float float Single
    // 118 LastArmRV                                0001866656B0 ModelPrimitiveType float float float Single
    // 120 Point                                    000185D2CA68 ModelClassListType List`1<Point> List`1<Point> List<Point> Pointer
    // 128 CurrentForceParam                        0001865D7EB0 ModelClassType ForceParam ForceParam ForceParam Pointer
    // 130 CalcedParam                              000185CC36A8 ModelClassListType ColliderParam[] ColliderParam[] List<ColliderParam> Pointer
    // 138 InvHitBase                               000185B92D50 ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer
    // 140 MatHitBase                               000185B92D50 ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer
    // 148 HitPlane                                 0001866AE8E0 ModelEnumType Vector4 Vector4 Vector4 Int32
    public partial class SwayString
    {
        public Transform?                               RootBone                                { get; set; }
        public SwayBone?                                SwayBone                                { get; set; }
        public bool                                     HeadCollide                             { get; set; }
        public bool                                     HeadZCollide                            { get; set; }
        public bool                                     HeadXCollide                            { get; set; }
        public bool                                     ShoulderCollide                         { get; set; }
        public bool                                     SpineCollide                            { get; set; }
        public bool                                     ChestCollide                            { get; set; }
        public bool                                     ArmCollide                              { get; set; }
        public bool                                     ThighCollide                            { get; set; }
        public bool                                     SkirtCollide                            { get; set; }
        public bool                                     PlaneCollide                            { get; set; }
        public bool                                     SleeveCollide                           { get; set; }
        public bool                                     XzPlaneCollide                          { get; set; }
        public bool                                     NeckCollide                             { get; set; }
        public bool                                     CollideBothUpper                        { get; set; }
        public int                                      ChestConstaint                          { get; set; }
        public int                                      AngleCap                                { get; set; }
        public bool                                     ChestMoveCollide                        { get; set; }
        public float                                    ElbowCollideShrinkRate                  { get; set; }
        public float                                    HandCollideSize                         { get; set; }
        public float                                    HandCollideShrinkRate                   { get; set; }
        public int                                      CollideIdx                              { get; set; }
        public float                                    CollideMinimum                          { get; set; }
        public List<Vector3>?                           InitialLocalPos                         { get; set; }
        public List<int>?                               CollideOffset                           { get; set; }
        public Vector3                                  GravityDir                              { get; set; }
        public Vector3                                  GravityLocalDir                         { get; set; }
        public float                                    AddCollideRoot                          { get; set; }
        public float                                    AddCollideEnd                           { get; set; }
        public List<ForceParam>?                        ForceParam                              { get; set; }
        public Type                                     SwayType                                { get; set; }
        public Type                                     SwaySubType                             { get; set; }
        public float                                    SubRate                                 { get; set; }
        public List<ColliderParam>?                     ColliderParam                           { get; set; }
        public bool                                     IsLeft                                  { get; set; }
        public Vector3                                  HeadC0                                  { get; set; }
        public Vector3                                  HeadC1                                  { get; set; }
        public float                                    HeadR0                                  { get; set; }
        public float                                    HeadR1                                  { get; set; }
        public bool                                     StopFlag                                { get; set; }
        public Matrix4x4                                BaseMat                                 { get; set; }
        public bool                                     PrevStopFlag                            { get; set; }
        public float                                    LastArmLV                               { get; set; }
        public float                                    LastArmRV                               { get; set; }
        public List<Point>?                             Point                                   { get; set; }
        public ForceParam?                              CurrentForceParam                       { get; set; }
        public List<ColliderParam>?                     CalcedParam                             { get; set; }
        public List<Matrix4x4>?                         InvHitBase                              { get; set; }
        public List<Matrix4x4>?                         MatHitBase                              { get; set; }
        public Vector4                                  HitPlane                                { get; set; }

        public static SwayString? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwayString();

            value.RootBone                                  = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 027006A05E98 0x20 RootBone                    ( 0001866AA650 ModelClassType Transform Transform Transform Pointer )
            value.SwayBone                                  = GetObject<SwayBone>(new IntPtr(p + 0x028), ReversePrism.DataModels.SwayBone.FromPointer); // 027006A05EB8 0x28 SwayBone                    ( 0001865FA1A0 ModelClassType SwayBone SwayBone SwayBone Pointer )
            value.HeadCollide                               = GetBool(new IntPtr(p + 0x030)); // 027006A05ED8 0x30 HeadCollide                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.HeadZCollide                              = GetBool(new IntPtr(p + 0x031)); // 027006A05EF8 0x31 HeadZCollide                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.HeadXCollide                              = GetBool(new IntPtr(p + 0x032)); // 027006A05F18 0x32 HeadXCollide                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ShoulderCollide                           = GetBool(new IntPtr(p + 0x033)); // 027006A05F38 0x33 ShoulderCollide             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SpineCollide                              = GetBool(new IntPtr(p + 0x034)); // 027006A05F58 0x34 SpineCollide                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ChestCollide                              = GetBool(new IntPtr(p + 0x035)); // 027006A05F78 0x35 ChestCollide                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ArmCollide                                = GetBool(new IntPtr(p + 0x036)); // 027006A05F98 0x36 ArmCollide                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ThighCollide                              = GetBool(new IntPtr(p + 0x037)); // 027006A05FB8 0x37 ThighCollide                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SkirtCollide                              = GetBool(new IntPtr(p + 0x038)); // 027006A05FD8 0x38 SkirtCollide                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.PlaneCollide                              = GetBool(new IntPtr(p + 0x039)); // 027006A05FF8 0x39 PlaneCollide                ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.SleeveCollide                             = GetBool(new IntPtr(p + 0x03A)); // 027006A06018 0x3A SleeveCollide               ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.XzPlaneCollide                            = GetBool(new IntPtr(p + 0x03B)); // 027006A06038 0x3B XzPlaneCollide              ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.NeckCollide                               = GetBool(new IntPtr(p + 0x03C)); // 027006A06058 0x3C NeckCollide                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.CollideBothUpper                          = GetBool(new IntPtr(p + 0x03D)); // 027006A06078 0x3D CollideBothUpper            ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ChestConstaint                            = GetInt32(new IntPtr(p + 0x040)); // 027006A06098 0x40 ChestConstaint              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.AngleCap                                  = GetInt32(new IntPtr(p + 0x044)); // 027006A060B8 0x44 AngleCap                    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ChestMoveCollide                          = GetBool(new IntPtr(p + 0x048)); // 027006A060D8 0x48 ChestMoveCollide            ( 000186597BE0 ModelPrimitiveType bool bool bool Bool )
            value.ElbowCollideShrinkRate                    = GetSingle(new IntPtr(p + 0x010)); // 027006A06178 0x10 ElbowCollideShrinkRate      ( 000186667DD0 ModelPrimitiveType float float float Single )
            value.HandCollideSize                           = GetSingle(new IntPtr(p + 0x014)); // 027006A06198 0x14 HandCollideSize             ( 000186667DD0 ModelPrimitiveType float float float Single )
            value.HandCollideShrinkRate                     = GetSingle(new IntPtr(p + 0x018)); // 027006A061B8 0x18 HandCollideShrinkRate       ( 000186667DD0 ModelPrimitiveType float float float Single )
            value.CollideIdx                                = GetInt32(new IntPtr(p + 0x04C)); // 027006A061D8 0x4C CollideIdx                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CollideMinimum                            = GetSingle(new IntPtr(p + 0x050)); // 027006A061F8 0x50 CollideMinimum              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.InitialLocalPos                           = GetEnumList<Vector3>(new IntPtr(p + 0x058)); // 027006A06218 0x58 InitialLocalPos             ( 000185D1AE38 ModelEnumListType List`1<Vector3> List`1<Vector3> List<Vector3> Pointer )
            value.CollideOffset                             = GetInt32List(new IntPtr(p + 0x060)); // 027006A06238 0x60 CollideOffset               ( 000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.GravityDir                                = (Vector3)GetInt32(new IntPtr(p + 0x068)); // 027006A06258 0x68 GravityDir                  ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.GravityLocalDir                           = (Vector3)GetInt32(new IntPtr(p + 0x074)); // 027006A06278 0x74 GravityLocalDir             ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.AddCollideRoot                            = GetSingle(new IntPtr(p + 0x080)); // 027006A06298 0x80 AddCollideRoot              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.AddCollideEnd                             = GetSingle(new IntPtr(p + 0x084)); // 027006A062B8 0x84 AddCollideEnd               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ForceParam                                = GetObjectList<ForceParam>(new IntPtr(p + 0x088), ReversePrism.DataModels.ForceParam.FromPointer); // 027006A062D8 0x88 ForceParam                  ( 000185CC38B8 ModelClassListType ForceParam[] ForceParam[] List<ForceParam> Pointer )
            value.SwayType                                  = (Type)GetInt32(new IntPtr(p + 0x090)); // 027006A062F8 0x90 SwayType                    ( 0001865D85B0 ModelEnumType Type Type Type Int32 )
            value.SwaySubType                               = (Type)GetInt32(new IntPtr(p + 0x094)); // 027006A06318 0x94 SwaySubType                 ( 0001865D85B0 ModelEnumType Type Type Type Int32 )
            value.SubRate                                   = GetSingle(new IntPtr(p + 0x098)); // 027006A06338 0x98 SubRate                     ( 000186666050 ModelPrimitiveType float float float Single )
            value.ColliderParam                             = GetObjectList<ColliderParam>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ColliderParam.FromPointer); // 027006A06358 0xA0 ColliderParam               ( 000185CC36A8 ModelClassListType ColliderParam[] ColliderParam[] List<ColliderParam> Pointer )
            value.IsLeft                                    = GetBool(new IntPtr(p + 0x0A8)); // 027006A06378 0xA8 IsLeft                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.HeadC0                                    = (Vector3)GetInt32(new IntPtr(p + 0x0AC)); // 027006A06398 0xAC HeadC0                      ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.HeadC1                                    = (Vector3)GetInt32(new IntPtr(p + 0x0B8)); // 027006A063B8 0xB8 HeadC1                      ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.HeadR0                                    = GetSingle(new IntPtr(p + 0x0C4)); // 027006A063D8 0xC4 HeadR0                      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.HeadR1                                    = GetSingle(new IntPtr(p + 0x0C8)); // 027006A063F8 0xC8 HeadR1                      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.StopFlag                                  = GetBool(new IntPtr(p + 0x0CC)); // 027006A06418 0xCC StopFlag                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BaseMat                                   = (Matrix4x4)GetInt32(new IntPtr(p + 0x0D0)); // 027006A06438 0xD0 BaseMat                     ( 00018660D8C0 ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.PrevStopFlag                              = GetBool(new IntPtr(p + 0x110)); // 027006A06458 0x110 PrevStopFlag                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LastArmLV                                 = GetSingle(new IntPtr(p + 0x114)); // 027006A06478 0x114 LastArmLV                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LastArmRV                                 = GetSingle(new IntPtr(p + 0x118)); // 027006A06498 0x118 LastArmRV                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.Point                                     = GetObjectList<Point>(new IntPtr(p + 0x120), ReversePrism.DataModels.Point.FromPointer); // 027006A064B8 0x120 Point                       ( 000185D2CA68 ModelClassListType List`1<Point> List`1<Point> List<Point> Pointer )
            value.CurrentForceParam                         = GetObject<ForceParam>(new IntPtr(p + 0x128), ReversePrism.DataModels.ForceParam.FromPointer); // 027006A064D8 0x128 CurrentForceParam           ( 0001865D7EB0 ModelClassType ForceParam ForceParam ForceParam Pointer )
            value.CalcedParam                               = GetObjectList<ColliderParam>(new IntPtr(p + 0x130), ReversePrism.DataModels.ColliderParam.FromPointer); // 027006A064F8 0x130 CalcedParam                 ( 000185CC36A8 ModelClassListType ColliderParam[] ColliderParam[] List<ColliderParam> Pointer )
            value.InvHitBase                                = GetEnumList<Matrix4x4>(new IntPtr(p + 0x138)); // 027006A06518 0x138 InvHitBase                  ( 000185B92D50 ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer )
            value.MatHitBase                                = GetEnumList<Matrix4x4>(new IntPtr(p + 0x140)); // 027006A06538 0x140 MatHitBase                  ( 000185B92D50 ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer )
            value.HitPlane                                  = (Vector4)GetInt32(new IntPtr(p + 0x148)); // 027006A06558 0x148 HitPlane                    ( 0001866AE8E0 ModelEnumType Vector4 Vector4 Vector4 Int32 )

            return value;
        }
    }
}
