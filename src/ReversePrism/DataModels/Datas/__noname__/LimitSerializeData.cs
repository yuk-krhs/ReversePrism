using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseAngleLimit                            ModelPrimitiveType bool bool bool Bool
    // 018 LimitAngle                               ModelClassType CurveSerializeData CurveSerializeData CurveSerializeData Pointer
    // 020 Stiffness                                ModelPrimitiveType float float float Single
    public partial class LimitSerializeData : DataModel
    {
        public bool                                     UseAngleLimit                           { get; set; }
        public CurveSerializeData?                      LimitAngle                              { get; set; }
        public float                                    Stiffness                               { get; set; }

        public static LimitSerializeData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LimitSerializeData() { Pointer= p0 };

            value.UseAngleLimit                             = GetBool(new IntPtr(p + 0x010)); // 0x10 UseAngleLimit               ( ModelPrimitiveType bool bool bool Bool )
            value.LimitAngle                                = GetObject<CurveSerializeData>(new IntPtr(p + 0x018), ReversePrism.DataModels.CurveSerializeData.FromPointer); // 0x18 LimitAngle                  ( ModelClassType CurveSerializeData CurveSerializeData CurveSerializeData Pointer )
            value.Stiffness                                 = GetSingle(new IntPtr(p + 0x020)); // 0x20 Stiffness                   ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
