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
    // 020 ShootingType                             ModelPrimitiveType string string string String
    // 028 CameraType                               ModelPrimitiveType string string string String
    // 030 MoveID                                   ModelPrimitiveType string string string String
    // 038 MoveSpeed                                ModelPrimitiveType float float float Single
    // 040 Easing                                   ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 048 MoveTrace                                ModelPrimitiveType float float float Single
    // 04C MoveTransition                           ModelPrimitiveType float float float Single
    // 050 Flip                                     ModelPrimitiveType bool bool bool Bool
    // 054 OffsetRotate                             ModelEnumType Vector3 Vector3 Vector3 Int32
    // 060 ClippingList                             ModelPrimitiveListType int[] int[] List<int> Pointer
    // 068 SwayReset                                ModelPrimitiveType bool bool bool Bool
    // 069 NoDissolve                               ModelPrimitiveType bool bool bool Bool
    // 06C StopFrame                                ModelPrimitiveType int int int Int32
    // 070 UseStartTargetData                       ModelPrimitiveType bool bool bool Bool
    // 074 TargetBasePoint                          ModelEnumType Vector3 Vector3 Vector3 Int32
    // 080 TargetNormalized                         ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class CameraWorkDataSave : DataModel
    {
        public int                                      StartFrame                              { get; set; }
        public List<int>?                               ObjectList                              { get; set; }
        public string                                   ShootingType                            { get; set; }
        public string                                   CameraType                              { get; set; }
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

        public static CameraWorkDataSave? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraWorkDataSave() { Pointer= p0 };

            value.StartFrame                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 StartFrame                  ( ModelPrimitiveType int int int Int32 )
            value.ObjectList                                = GetInt32List(new IntPtr(p + 0x018)); // 0x18 ObjectList                  ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.ShootingType                              = GetString(new IntPtr(p + 0x020)); // 0x20 ShootingType                ( ModelPrimitiveType string string string String )
            value.CameraType                                = GetString(new IntPtr(p + 0x028)); // 0x28 CameraType                  ( ModelPrimitiveType string string string String )
            value.MoveID                                    = GetString(new IntPtr(p + 0x030)); // 0x30 MoveID                      ( ModelPrimitiveType string string string String )
            value.MoveSpeed                                 = GetSingle(new IntPtr(p + 0x038)); // 0x38 MoveSpeed                   ( ModelPrimitiveType float float float Single )
            value.Easing                                    = GetObject<AnimationCurve>(new IntPtr(p + 0x040), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x40 Easing                      ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.MoveTrace                                 = GetSingle(new IntPtr(p + 0x048)); // 0x48 MoveTrace                   ( ModelPrimitiveType float float float Single )
            value.MoveTransition                            = GetSingle(new IntPtr(p + 0x04C)); // 0x4C MoveTransition              ( ModelPrimitiveType float float float Single )
            value.Flip                                      = GetBool(new IntPtr(p + 0x050)); // 0x50 Flip                        ( ModelPrimitiveType bool bool bool Bool )
            value.OffsetRotate                              = (Vector3)GetInt32(new IntPtr(p + 0x054)); // 0x54 OffsetRotate                ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.ClippingList                              = GetInt32List(new IntPtr(p + 0x060)); // 0x60 ClippingList                ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SwayReset                                 = GetBool(new IntPtr(p + 0x068)); // 0x68 SwayReset                   ( ModelPrimitiveType bool bool bool Bool )
            value.NoDissolve                                = GetBool(new IntPtr(p + 0x069)); // 0x69 NoDissolve                  ( ModelPrimitiveType bool bool bool Bool )
            value.StopFrame                                 = GetInt32(new IntPtr(p + 0x06C)); // 0x6C StopFrame                   ( ModelPrimitiveType int int int Int32 )
            value.UseStartTargetData                        = GetBool(new IntPtr(p + 0x070)); // 0x70 UseStartTargetData          ( ModelPrimitiveType bool bool bool Bool )
            value.TargetBasePoint                           = (Vector3)GetInt32(new IntPtr(p + 0x074)); // 0x74 TargetBasePoint             ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.TargetNormalized                          = (Vector3)GetInt32(new IntPtr(p + 0x080)); // 0x80 TargetNormalized            ( ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
