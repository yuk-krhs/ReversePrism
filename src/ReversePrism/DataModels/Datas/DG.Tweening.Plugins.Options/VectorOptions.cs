using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AxisConstraint                           ModelEnumType AxisConstraint AxisConstraint AxisConstraint Int32
    // 014 Snapping                                 ModelPrimitiveType bool bool bool Bool
    public partial class VectorOptions : DataModel
    {
        public AxisConstraint                           AxisConstraint                          { get; set; }
        public bool                                     Snapping                                { get; set; }

        public static VectorOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VectorOptions() { Pointer= p0 };

            value.AxisConstraint                            = (AxisConstraint)GetInt32(new IntPtr(p + 0x010)); // 0x10 AxisConstraint              ( ModelEnumType AxisConstraint AxisConstraint AxisConstraint Int32 )
            value.Snapping                                  = GetBool(new IntPtr(p + 0x014)); // 0x14 Snapping                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
