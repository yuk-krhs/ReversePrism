using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Unit                                     ModelEnumType Unit Unit Unit Int32
    // 014 Value                                    ModelPrimitiveType float float float Single
    public partial class Dimension : DataModel
    {
        public Unit                                     Unit                                    { get; set; }
        public float                                    Value                                   { get; set; }

        public static Dimension? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Dimension() { Pointer= p0 };

            value.Unit                                      = (Unit)GetInt32(new IntPtr(p + 0x010)); // 0x10 Unit                        ( ModelEnumType Unit Unit Unit Int32 )
            value.Value                                     = GetSingle(new IntPtr(p + 0x014)); // 0x14 Value                       ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
