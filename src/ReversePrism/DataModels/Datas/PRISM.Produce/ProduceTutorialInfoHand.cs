using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MoveSec                                  float IL2CPP_TYPE_R4
    // 020 RectTransform                            000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 DefaultPos                               0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 034 TargetPos                                0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 040 Sec                                      0001866656B0 ModelPrimitiveType float float float Single
    public partial class ProduceTutorialInfoHand
    {
        public RectTransform?                           RectTransform                           { get; set; }
        public Vector3                                  DefaultPos                              { get; set; }
        public Vector3                                  TargetPos                               { get; set; }
        public float                                    Sec                                     { get; set; }

        public static ProduceTutorialInfoHand? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialInfoHand();

            value.RectTransform                             = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D5D4F9A0 0x20 RectTransform               ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.DefaultPos                                = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 0270D5D4F9C0 0x28 DefaultPos                  ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.TargetPos                                 = (Vector3)GetInt32(new IntPtr(p + 0x034)); // 0270D5D4F9E0 0x34 TargetPos                   ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Sec                                       = GetSingle(new IntPtr(p + 0x040)); // 0270D5D4FA00 0x40 Sec                         ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
