using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RootBone                                 ModelClassType Transform Transform Transform Pointer
    // 028 SwayBone                                 ModelClassType SwayBone SwayBone SwayBone Pointer
    // 030 HeadCollide                              ModelPrimitiveType bool bool bool Bool
    // 031 HeadZCollide                             ModelPrimitiveType bool bool bool Bool
    // 032 HeadXCollide                             ModelPrimitiveType bool bool bool Bool
    // 033 ShoulderCollide                          ModelPrimitiveType bool bool bool Bool
    // 034 SpineCollide                             ModelPrimitiveType bool bool bool Bool
    // 035 ChestCollide                             ModelPrimitiveType bool bool bool Bool
    // 036 ArmCollide                               ModelPrimitiveType bool bool bool Bool
    // 037 ThighCollide                             ModelPrimitiveType bool bool bool Bool
    // 038 SkirtCollide                             ModelPrimitiveType bool bool bool Bool
    // 039 PlaneCollide                             ModelPrimitiveType bool bool bool Bool
    // 03A SleeveCollide                            ModelPrimitiveType bool bool bool Bool
    // 03B XzPlaneCollide                           ModelPrimitiveType bool bool bool Bool
    // 03C NeckCollide                              ModelPrimitiveType bool bool bool Bool
    // 03D CollideBothUpper                         ModelPrimitiveType bool bool bool Bool
    // 040 ChestConstaint                           ModelPrimitiveType int int int Int32
    // 044 AngleCap                                 ModelPrimitiveType int int int Int32
    // 048 ChestMoveCollide                         ModelPrimitiveType bool bool bool Bool
    // 000 speedToCollideSize                       float IL2CPP_TYPE_R4
    // 004 shoulderCollideSize                      float IL2CPP_TYPE_R4
    // 008 shoulderCollideShrinkRate                float IL2CPP_TYPE_R4
    // 00C elbowCollideSize                         float IL2CPP_TYPE_R4
    // 010 ElbowCollideShrinkRate                   ModelPrimitiveType float float float Single
    // 014 HandCollideSize                          ModelPrimitiveType float float float Single
    // 018 HandCollideShrinkRate                    ModelPrimitiveType float float float Single
    // 04C CollideIdx                               ModelPrimitiveType int int int Int32
    // 050 CollideMinimum                           ModelPrimitiveType float float float Single
    // 058 InitialLocalPos                          ModelEnumListType List`1<Vector3> List`1<Vector3> List<Vector3> Pointer
    // 060 CollideOffset                            ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 068 GravityDir                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 074 GravityLocalDir                          ModelEnumType Vector3 Vector3 Vector3 Int32
    // 080 AddCollideRoot                           ModelPrimitiveType float float float Single
    // 084 AddCollideEnd                            ModelPrimitiveType float float float Single
    // 088 ForceParam                               ModelClassListType ForceParam[] ForceParam[] List<ForceParam> Pointer
    // 090 SwayType                                 ModelEnumType Type Type Type Int32
    // 094 SwaySubType                              ModelEnumType Type Type Type Int32
    // 098 SubRate                                  ModelPrimitiveType float float float Single
    // 0A0 ColliderParam                            ModelClassListType ColliderParam[] ColliderParam[] List<ColliderParam> Pointer
    // 0A8 IsLeft                                   ModelPrimitiveType bool bool bool Bool
    // 0AC HeadC0                                   ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0B8 HeadC1                                   ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0C4 HeadR0                                   ModelPrimitiveType float float float Single
    // 0C8 HeadR1                                   ModelPrimitiveType float float float Single
    // 0CC StopFlag                                 ModelPrimitiveType bool bool bool Bool
    // 0D0 BaseMat                                  ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 110 PrevStopFlag                             ModelPrimitiveType bool bool bool Bool
    // 114 LastArmLV                                ModelPrimitiveType float float float Single
    // 118 LastArmRV                                ModelPrimitiveType float float float Single
    // 120 Point                                    ModelClassListType List`1<Point> List`1<Point> List<Point> Pointer
    // 128 CurrentForceParam                        ModelClassType ForceParam ForceParam ForceParam Pointer
    // 130 CalcedParam                              ModelClassListType ColliderParam[] ColliderParam[] List<ColliderParam> Pointer
    // 138 InvHitBase                               ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer
    // 140 MatHitBase                               ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer
    // 148 HitPlane                                 ModelEnumType Vector4 Vector4 Vector4 Int32
    public partial class SwayString : DataModel
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
            var value   = new SwayString() { Pointer= p0 };

            value.RootBone                                  = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 RootBone                    ( ModelClassType Transform Transform Transform Pointer )
            value.SwayBone                                  = GetObject<SwayBone>(new IntPtr(p + 0x028), ReversePrism.DataModels.SwayBone.FromPointer); // 0x28 SwayBone                    ( ModelClassType SwayBone SwayBone SwayBone Pointer )
            value.HeadCollide                               = GetBool(new IntPtr(p + 0x030)); // 0x30 HeadCollide                 ( ModelPrimitiveType bool bool bool Bool )
            value.HeadZCollide                              = GetBool(new IntPtr(p + 0x031)); // 0x31 HeadZCollide                ( ModelPrimitiveType bool bool bool Bool )
            value.HeadXCollide                              = GetBool(new IntPtr(p + 0x032)); // 0x32 HeadXCollide                ( ModelPrimitiveType bool bool bool Bool )
            value.ShoulderCollide                           = GetBool(new IntPtr(p + 0x033)); // 0x33 ShoulderCollide             ( ModelPrimitiveType bool bool bool Bool )
            value.SpineCollide                              = GetBool(new IntPtr(p + 0x034)); // 0x34 SpineCollide                ( ModelPrimitiveType bool bool bool Bool )
            value.ChestCollide                              = GetBool(new IntPtr(p + 0x035)); // 0x35 ChestCollide                ( ModelPrimitiveType bool bool bool Bool )
            value.ArmCollide                                = GetBool(new IntPtr(p + 0x036)); // 0x36 ArmCollide                  ( ModelPrimitiveType bool bool bool Bool )
            value.ThighCollide                              = GetBool(new IntPtr(p + 0x037)); // 0x37 ThighCollide                ( ModelPrimitiveType bool bool bool Bool )
            value.SkirtCollide                              = GetBool(new IntPtr(p + 0x038)); // 0x38 SkirtCollide                ( ModelPrimitiveType bool bool bool Bool )
            value.PlaneCollide                              = GetBool(new IntPtr(p + 0x039)); // 0x39 PlaneCollide                ( ModelPrimitiveType bool bool bool Bool )
            value.SleeveCollide                             = GetBool(new IntPtr(p + 0x03A)); // 0x3A SleeveCollide               ( ModelPrimitiveType bool bool bool Bool )
            value.XzPlaneCollide                            = GetBool(new IntPtr(p + 0x03B)); // 0x3B XzPlaneCollide              ( ModelPrimitiveType bool bool bool Bool )
            value.NeckCollide                               = GetBool(new IntPtr(p + 0x03C)); // 0x3C NeckCollide                 ( ModelPrimitiveType bool bool bool Bool )
            value.CollideBothUpper                          = GetBool(new IntPtr(p + 0x03D)); // 0x3D CollideBothUpper            ( ModelPrimitiveType bool bool bool Bool )
            value.ChestConstaint                            = GetInt32(new IntPtr(p + 0x040)); // 0x40 ChestConstaint              ( ModelPrimitiveType int int int Int32 )
            value.AngleCap                                  = GetInt32(new IntPtr(p + 0x044)); // 0x44 AngleCap                    ( ModelPrimitiveType int int int Int32 )
            value.ChestMoveCollide                          = GetBool(new IntPtr(p + 0x048)); // 0x48 ChestMoveCollide            ( ModelPrimitiveType bool bool bool Bool )
            value.ElbowCollideShrinkRate                    = GetSingle(new IntPtr(p + 0x010)); // 0x10 ElbowCollideShrinkRate      ( ModelPrimitiveType float float float Single )
            value.HandCollideSize                           = GetSingle(new IntPtr(p + 0x014)); // 0x14 HandCollideSize             ( ModelPrimitiveType float float float Single )
            value.HandCollideShrinkRate                     = GetSingle(new IntPtr(p + 0x018)); // 0x18 HandCollideShrinkRate       ( ModelPrimitiveType float float float Single )
            value.CollideIdx                                = GetInt32(new IntPtr(p + 0x04C)); // 0x4C CollideIdx                  ( ModelPrimitiveType int int int Int32 )
            value.CollideMinimum                            = GetSingle(new IntPtr(p + 0x050)); // 0x50 CollideMinimum              ( ModelPrimitiveType float float float Single )
            value.InitialLocalPos                           = GetEnumList<Vector3>(new IntPtr(p + 0x058)); // 0x58 InitialLocalPos             ( ModelEnumListType List`1<Vector3> List`1<Vector3> List<Vector3> Pointer )
            value.CollideOffset                             = GetInt32List(new IntPtr(p + 0x060)); // 0x60 CollideOffset               ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.GravityDir                                = (Vector3)GetInt32(new IntPtr(p + 0x068)); // 0x68 GravityDir                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.GravityLocalDir                           = (Vector3)GetInt32(new IntPtr(p + 0x074)); // 0x74 GravityLocalDir             ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.AddCollideRoot                            = GetSingle(new IntPtr(p + 0x080)); // 0x80 AddCollideRoot              ( ModelPrimitiveType float float float Single )
            value.AddCollideEnd                             = GetSingle(new IntPtr(p + 0x084)); // 0x84 AddCollideEnd               ( ModelPrimitiveType float float float Single )
            value.ForceParam                                = GetObjectList<ForceParam>(new IntPtr(p + 0x088), ReversePrism.DataModels.ForceParam.FromPointer); // 0x88 ForceParam                  ( ModelClassListType ForceParam[] ForceParam[] List<ForceParam> Pointer )
            value.SwayType                                  = (Type)GetInt32(new IntPtr(p + 0x090)); // 0x90 SwayType                    ( ModelEnumType Type Type Type Int32 )
            value.SwaySubType                               = (Type)GetInt32(new IntPtr(p + 0x094)); // 0x94 SwaySubType                 ( ModelEnumType Type Type Type Int32 )
            value.SubRate                                   = GetSingle(new IntPtr(p + 0x098)); // 0x98 SubRate                     ( ModelPrimitiveType float float float Single )
            value.ColliderParam                             = GetObjectList<ColliderParam>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ColliderParam.FromPointer); // 0xA0 ColliderParam               ( ModelClassListType ColliderParam[] ColliderParam[] List<ColliderParam> Pointer )
            value.IsLeft                                    = GetBool(new IntPtr(p + 0x0A8)); // 0xA8 IsLeft                      ( ModelPrimitiveType bool bool bool Bool )
            value.HeadC0                                    = (Vector3)GetInt32(new IntPtr(p + 0x0AC)); // 0xAC HeadC0                      ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.HeadC1                                    = (Vector3)GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 HeadC1                      ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.HeadR0                                    = GetSingle(new IntPtr(p + 0x0C4)); // 0xC4 HeadR0                      ( ModelPrimitiveType float float float Single )
            value.HeadR1                                    = GetSingle(new IntPtr(p + 0x0C8)); // 0xC8 HeadR1                      ( ModelPrimitiveType float float float Single )
            value.StopFlag                                  = GetBool(new IntPtr(p + 0x0CC)); // 0xCC StopFlag                    ( ModelPrimitiveType bool bool bool Bool )
            value.BaseMat                                   = (Matrix4x4)GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 BaseMat                     ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.PrevStopFlag                              = GetBool(new IntPtr(p + 0x110)); // 0x110 PrevStopFlag                ( ModelPrimitiveType bool bool bool Bool )
            value.LastArmLV                                 = GetSingle(new IntPtr(p + 0x114)); // 0x114 LastArmLV                   ( ModelPrimitiveType float float float Single )
            value.LastArmRV                                 = GetSingle(new IntPtr(p + 0x118)); // 0x118 LastArmRV                   ( ModelPrimitiveType float float float Single )
            value.Point                                     = GetObjectList<Point>(new IntPtr(p + 0x120), ReversePrism.DataModels.Point.FromPointer); // 0x120 Point                       ( ModelClassListType List`1<Point> List`1<Point> List<Point> Pointer )
            value.CurrentForceParam                         = GetObject<ForceParam>(new IntPtr(p + 0x128), ReversePrism.DataModels.ForceParam.FromPointer); // 0x128 CurrentForceParam           ( ModelClassType ForceParam ForceParam ForceParam Pointer )
            value.CalcedParam                               = GetObjectList<ColliderParam>(new IntPtr(p + 0x130), ReversePrism.DataModels.ColliderParam.FromPointer); // 0x130 CalcedParam                 ( ModelClassListType ColliderParam[] ColliderParam[] List<ColliderParam> Pointer )
            value.InvHitBase                                = GetEnumList<Matrix4x4>(new IntPtr(p + 0x138)); // 0x138 InvHitBase                  ( ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer )
            value.MatHitBase                                = GetEnumList<Matrix4x4>(new IntPtr(p + 0x140)); // 0x140 MatHitBase                  ( ModelEnumListType Matrix4x4[] Matrix4x4[] List<Matrix4x4> Pointer )
            value.HitPlane                                  = (Vector4)GetInt32(new IntPtr(p + 0x148)); // 0x148 HitPlane                    ( ModelEnumType Vector4 Vector4 Vector4 Int32 )

            return value;
        }
    }
}
