using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Value                                  ModelPrimitiveType float float float Single
    // 014 M_Unit                                   ModelEnumType Unit Unit Unit Int32
    public partial class Angle : DataModel
    {
        public float                                    M_Value                                 { get; set; }
        public Unit                                     M_Unit                                  { get; set; }

        public static Angle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Angle() { Pointer= p0 };

            value.M_Value                                   = GetSingle(new IntPtr(p + 0x010)); // 0x10 M_Value                     ( ModelPrimitiveType float float float Single )
            value.M_Unit                                    = (Unit)GetInt32(new IntPtr(p + 0x014)); // 0x14 M_Unit                      ( ModelEnumType Unit Unit Unit Int32 )

            return value;
        }
    }
}
