using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Value                                    ModelPrimitiveType float float float Single
    // 014 UseCurve                                 ModelPrimitiveType bool bool bool Bool
    // 018 Curve                                    ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    public partial class CurveSerializeData : DataModel
    {
        public float                                    Value                                   { get; set; }
        public bool                                     UseCurve                                { get; set; }
        public AnimationCurve?                          Curve                                   { get; set; }

        public static CurveSerializeData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CurveSerializeData() { Pointer= p0 };

            value.Value                                     = GetSingle(new IntPtr(p + 0x010)); // 0x10 Value                       ( ModelPrimitiveType float float float Single )
            value.UseCurve                                  = GetBool(new IntPtr(p + 0x014)); // 0x14 UseCurve                    ( ModelPrimitiveType bool bool bool Bool )
            value.Curve                                     = GetObject<AnimationCurve>(new IntPtr(p + 0x018), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x18 Curve                       ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )

            return value;
        }
    }
}
