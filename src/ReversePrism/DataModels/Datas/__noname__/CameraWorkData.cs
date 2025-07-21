using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartFrame                               ModelPrimitiveType int int int Int32
    // 018 ObjectList                               ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 ShootingType                             ModelEnumType ShootingType ShootingType ShootingType Int32
    // 024 CameraType                               ModelEnumType CameraType CameraType CameraType Int32
    // 028 MoveID                                   ModelPrimitiveType string string string String
    // 030 MoveSpeed                                ModelPrimitiveType float float float Single
    // 038 Easing                                   ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 040 MoveTrace                                ModelPrimitiveType float float float Single
    // 044 MoveTransition                           ModelPrimitiveType float float float Single
    // 048 Flip                                     ModelPrimitiveType bool bool bool Bool
    // 04C OffsetRotate                             ModelEnumType Vector3 Vector3 Vector3 Int32
    // 058 ClippingList                             ModelPrimitiveListType int[] int[] List<int> Pointer
    // 060 SwayReset                                ModelPrimitiveType bool bool bool Bool
    // 061 NoDissolve                               ModelPrimitiveType bool bool bool Bool
    // 064 StopFrame                                ModelPrimitiveType int int int Int32
    // 068 UseStartTargetData                       ModelPrimitiveType bool bool bool Bool
    // 06C TargetBasePoint                          ModelEnumType Vector3 Vector3 Vector3 Int32
    // 078 TargetNormalized                         ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class CameraWorkData : DataModel
    {
        public int                                      StartFrame                              { get; set; }
        public List<int>?                               ObjectList                              { get; set; }
        public ShootingType                             ShootingType                            { get; set; }
        public CameraType                               CameraType                              { get; set; }
        public string                                   MoveID                                  { get; set; }
        public float                                    MoveSpeed                               { get; set; }
        public AnimationCurve?                          Easing                                  { get; set; }
        public float                                    MoveTrace                               { get; set; }
        public float                                    MoveTransition                          { get; set; }
        public bool                                     Flip                                    { get; set; }
        public Vector3                                  OffsetRotate                            { get; set; }
        public List<int>?                               ClippingList                            { get; set; }
        public bool                                     SwayReset                               { get; set; }
        public bool                                     NoDissolve                              { get; set; }
        public int                                      StopFrame                               { get; set; }
        public bool                                     UseStartTargetData                      { get; set; }
        public Vector3                                  TargetBasePoint                         { get; set; }
        public Vector3                                  TargetNormalized                        { get; set; }

        public static CameraWorkData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraWorkData() { Pointer= p0 };

            value.StartFrame                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 StartFrame                  ( ModelPrimitiveType int int int Int32 )
            value.ObjectList                                = GetInt32List(new IntPtr(p + 0x018)); // 0x18 ObjectList                  ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.ShootingType                              = (ShootingType)GetInt32(new IntPtr(p + 0x020)); // 0x20 ShootingType                ( ModelEnumType ShootingType ShootingType ShootingType Int32 )
            value.CameraType                                = (CameraType)GetInt32(new IntPtr(p + 0x024)); // 0x24 CameraType                  ( ModelEnumType CameraType CameraType CameraType Int32 )
            value.MoveID                                    = GetString(new IntPtr(p + 0x028)); // 0x28 MoveID                      ( ModelPrimitiveType string string string String )
            value.MoveSpeed                                 = GetSingle(new IntPtr(p + 0x030)); // 0x30 MoveSpeed                   ( ModelPrimitiveType float float float Single )
            value.Easing                                    = GetObject<AnimationCurve>(new IntPtr(p + 0x038), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x38 Easing                      ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.MoveTrace                                 = GetSingle(new IntPtr(p + 0x040)); // 0x40 MoveTrace                   ( ModelPrimitiveType float float float Single )
            value.MoveTransition                            = GetSingle(new IntPtr(p + 0x044)); // 0x44 MoveTransition              ( ModelPrimitiveType float float float Single )
            value.Flip                                      = GetBool(new IntPtr(p + 0x048)); // 0x48 Flip                        ( ModelPrimitiveType bool bool bool Bool )
            value.OffsetRotate                              = (Vector3)GetInt32(new IntPtr(p + 0x04C)); // 0x4C OffsetRotate                ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.ClippingList                              = GetInt32List(new IntPtr(p + 0x058)); // 0x58 ClippingList                ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SwayReset                                 = GetBool(new IntPtr(p + 0x060)); // 0x60 SwayReset                   ( ModelPrimitiveType bool bool bool Bool )
            value.NoDissolve                                = GetBool(new IntPtr(p + 0x061)); // 0x61 NoDissolve                  ( ModelPrimitiveType bool bool bool Bool )
            value.StopFrame                                 = GetInt32(new IntPtr(p + 0x064)); // 0x64 StopFrame                   ( ModelPrimitiveType int int int Int32 )
            value.UseStartTargetData                        = GetBool(new IntPtr(p + 0x068)); // 0x68 UseStartTargetData          ( ModelPrimitiveType bool bool bool Bool )
            value.TargetBasePoint                           = (Vector3)GetInt32(new IntPtr(p + 0x06C)); // 0x6C TargetBasePoint             ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.TargetNormalized                          = (Vector3)GetInt32(new IntPtr(p + 0x078)); // 0x78 TargetNormalized            ( ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
