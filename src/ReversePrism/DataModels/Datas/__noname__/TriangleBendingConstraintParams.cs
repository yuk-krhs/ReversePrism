using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Method                                   ModelEnumType Method Method Method Int32
    // 014 Stiffness                                ModelPrimitiveType float float float Single
    public partial class TriangleBendingConstraintParams : DataModel
    {
        public Method                                   Method                                  { get; set; }
        public float                                    Stiffness                               { get; set; }

        public static TriangleBendingConstraintParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TriangleBendingConstraintParams() { Pointer= p0 };

            value.Method                                    = (Method)GetInt32(new IntPtr(p + 0x010)); // 0x10 Method                      ( ModelEnumType Method Method Method Int32 )
            value.Stiffness                                 = GetSingle(new IntPtr(p + 0x014)); // 0x14 Stiffness                   ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
