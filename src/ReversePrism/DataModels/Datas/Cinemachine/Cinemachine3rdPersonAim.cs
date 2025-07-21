using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 AimCollisionFilter                       ModelEnumType LayerMask LayerMask LayerMask Int32
    // 038 IgnoreTag                                ModelPrimitiveType string string string String
    // 040 AimDistance                              ModelPrimitiveType float float float Single
    // 048 AimTargetReticle                         ModelClassType RectTransform RectTransform RectTransform Pointer
    // 050 AimTarget                                ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class Cinemachine3rdPersonAim : DataModel
    {
        public LayerMask                                AimCollisionFilter                      { get; set; }
        public string                                   IgnoreTag                               { get; set; }
        public float                                    AimDistance                             { get; set; }
        public RectTransform?                           AimTargetReticle                        { get; set; }
        public Vector3                                  AimTarget                               { get; set; }

        public static Cinemachine3rdPersonAim? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Cinemachine3rdPersonAim() { Pointer= p0 };

            value.AimCollisionFilter                        = (LayerMask)GetInt32(new IntPtr(p + 0x030)); // 0x30 AimCollisionFilter          ( ModelEnumType LayerMask LayerMask LayerMask Int32 )
            value.IgnoreTag                                 = GetString(new IntPtr(p + 0x038)); // 0x38 IgnoreTag                   ( ModelPrimitiveType string string string String )
            value.AimDistance                               = GetSingle(new IntPtr(p + 0x040)); // 0x40 AimDistance                 ( ModelPrimitiveType float float float Single )
            value.AimTargetReticle                          = GetObject<RectTransform>(new IntPtr(p + 0x048), ReversePrism.DataModels.RectTransform.FromPointer); // 0x48 AimTargetReticle            ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.AimTarget                                 = (Vector3)GetInt32(new IntPtr(p + 0x050)); // 0x50 AimTarget                   ( ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
