using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartFrame                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 ObjectList                               000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 ShootingType                             0001866722E0 ModelPrimitiveType string string string String
    // 028 CameraType                               0001866722E0 ModelPrimitiveType string string string String
    // 030 MoveID                                   0001866722E0 ModelPrimitiveType string string string String
    // 038 MoveSpeed                                000186666050 ModelPrimitiveType float float float Single
    // 040 Easing                                   000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 048 MoveTrace                                000186666050 ModelPrimitiveType float float float Single
    // 04C MoveTransition                           000186666050 ModelPrimitiveType float float float Single
    // 050 Flip                                     000186595960 ModelPrimitiveType bool bool bool Bool
    // 054 OffsetRotate                             0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 060 ClippingList                             000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 068 SwayReset                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 069 NoDissolve                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 06C StopFrame                                0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class CameraWorkDataSave
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

        public static CameraWorkDataSave? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraWorkDataSave();

            value.StartFrame                                = GetInt32(new IntPtr(p + 0x010)); // 027006B218A0 0x10 StartFrame                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ObjectList                                = GetInt32List(new IntPtr(p + 0x018)); // 027006B218C0 0x18 ObjectList                  ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.ShootingType                              = GetString(new IntPtr(p + 0x020)); // 027006B218E0 0x20 ShootingType                ( 0001866722E0 ModelPrimitiveType string string string String )
            value.CameraType                                = GetString(new IntPtr(p + 0x028)); // 027006B21900 0x28 CameraType                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.MoveID                                    = GetString(new IntPtr(p + 0x030)); // 027006B21920 0x30 MoveID                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.MoveSpeed                                 = GetSingle(new IntPtr(p + 0x038)); // 027006B21940 0x38 MoveSpeed                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.Easing                                    = GetObject<AnimationCurve>(new IntPtr(p + 0x040), ReversePrism.DataModels.AnimationCurve.FromPointer); // 027006B21960 0x40 Easing                      ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.MoveTrace                                 = GetSingle(new IntPtr(p + 0x048)); // 027006B21980 0x48 MoveTrace                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.MoveTransition                            = GetSingle(new IntPtr(p + 0x04C)); // 027006B219A0 0x4C MoveTransition              ( 000186666050 ModelPrimitiveType float float float Single )
            value.Flip                                      = GetBool(new IntPtr(p + 0x050)); // 027006B219C0 0x50 Flip                        ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.OffsetRotate                              = (Vector3)GetInt32(new IntPtr(p + 0x054)); // 027006B219E0 0x54 OffsetRotate                ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.ClippingList                              = GetInt32List(new IntPtr(p + 0x060)); // 027006B21A00 0x60 ClippingList                ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SwayReset                                 = GetBool(new IntPtr(p + 0x068)); // 027006B21A20 0x68 SwayReset                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.NoDissolve                                = GetBool(new IntPtr(p + 0x069)); // 027006B21A40 0x69 NoDissolve                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.StopFrame                                 = GetInt32(new IntPtr(p + 0x06C)); // 027006B21A60 0x6C StopFrame                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
