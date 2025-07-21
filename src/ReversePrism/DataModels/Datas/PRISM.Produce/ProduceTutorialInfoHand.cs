using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 MoveSec                                  float IL2CPP_TYPE_R4
    // 020 RectTransform                            ModelClassType RectTransform RectTransform RectTransform Pointer
    // 028 DefaultPos                               ModelEnumType Vector3 Vector3 Vector3 Int32
    // 034 TargetPos                                ModelEnumType Vector3 Vector3 Vector3 Int32
    // 040 Sec                                      ModelPrimitiveType float float float Single
    public partial class ProduceTutorialInfoHand : DataModel
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
            var value   = new ProduceTutorialInfoHand() { Pointer= p0 };

            value.RectTransform                             = GetObject<RectTransform>(new IntPtr(p + 0x020), ReversePrism.DataModels.RectTransform.FromPointer); // 0x20 RectTransform               ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.DefaultPos                                = (Vector3)GetInt32(new IntPtr(p + 0x028)); // 0x28 DefaultPos                  ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.TargetPos                                 = (Vector3)GetInt32(new IntPtr(p + 0x034)); // 0x34 TargetPos                   ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Sec                                       = GetSingle(new IntPtr(p + 0x040)); // 0x40 Sec                         ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
