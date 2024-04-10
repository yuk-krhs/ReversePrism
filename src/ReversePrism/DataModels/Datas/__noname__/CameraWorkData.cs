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
    // 020 ShootingType                             000186726000 ModelEnumType ShootingType ShootingType ShootingType Int32
    // 024 CameraType                               000186724D30 ModelEnumType CameraType CameraType CameraType Int32
    // 028 MoveID                                   0001866722E0 ModelPrimitiveType string string string String
    // 030 MoveSpeed                                000186666050 ModelPrimitiveType float float float Single
    // 038 Easing                                   000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 040 MoveTrace                                000186666050 ModelPrimitiveType float float float Single
    // 044 MoveTransition                           000186666050 ModelPrimitiveType float float float Single
    // 048 Flip                                     000186595960 ModelPrimitiveType bool bool bool Bool
    // 04C OffsetRotate                             0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 058 ClippingList                             000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 060 SwayReset                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 061 NoDissolve                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 064 StopFrame                                0001865F36C0 ModelPrimitiveType int int int Int32
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

        public static CameraWorkData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraWorkData() { Pointer= p0 };

            value.StartFrame                                = GetInt32(new IntPtr(p + 0x010)); // 0245A6ACEE90 0x10 StartFrame                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ObjectList                                = GetInt32List(new IntPtr(p + 0x018)); // 0245A6ACEEB0 0x18 ObjectList                  ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.ShootingType                              = (ShootingType)GetInt32(new IntPtr(p + 0x020)); // 0245A6ACEED0 0x20 ShootingType                ( 000186726000 ModelEnumType ShootingType ShootingType ShootingType Int32 )
            value.CameraType                                = (CameraType)GetInt32(new IntPtr(p + 0x024)); // 0245A6ACEEF0 0x24 CameraType                  ( 000186724D30 ModelEnumType CameraType CameraType CameraType Int32 )
            value.MoveID                                    = GetString(new IntPtr(p + 0x028)); // 0245A6ACEF10 0x28 MoveID                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.MoveSpeed                                 = GetSingle(new IntPtr(p + 0x030)); // 0245A6ACEF30 0x30 MoveSpeed                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.Easing                                    = GetObject<AnimationCurve>(new IntPtr(p + 0x038), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0245A6ACEF50 0x38 Easing                      ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.MoveTrace                                 = GetSingle(new IntPtr(p + 0x040)); // 0245A6ACEF70 0x40 MoveTrace                   ( 000186666050 ModelPrimitiveType float float float Single )
            value.MoveTransition                            = GetSingle(new IntPtr(p + 0x044)); // 0245A6ACEF90 0x44 MoveTransition              ( 000186666050 ModelPrimitiveType float float float Single )
            value.Flip                                      = GetBool(new IntPtr(p + 0x048)); // 0245A6ACEFB0 0x48 Flip                        ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.OffsetRotate                              = (Vector3)GetInt32(new IntPtr(p + 0x04C)); // 0245A6ACEFD0 0x4C OffsetRotate                ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.ClippingList                              = GetInt32List(new IntPtr(p + 0x058)); // 0245A6ACEFF0 0x58 ClippingList                ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SwayReset                                 = GetBool(new IntPtr(p + 0x060)); // 0245A6ACF010 0x60 SwayReset                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.NoDissolve                                = GetBool(new IntPtr(p + 0x061)); // 0245A6ACF030 0x61 NoDissolve                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.StopFrame                                 = GetInt32(new IntPtr(p + 0x064)); // 0245A6ACF050 0x64 StopFrame                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
