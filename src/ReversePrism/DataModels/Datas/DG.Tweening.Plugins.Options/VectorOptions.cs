using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AxisConstraint                           0001867305B0 ModelEnumType AxisConstraint AxisConstraint AxisConstraint Int32
    // 014 Snapping                                 000186595960 ModelPrimitiveType bool bool bool Bool
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

            value.AxisConstraint                            = (AxisConstraint)GetInt32(new IntPtr(p + 0x010)); // 0245A72A54B0 0x10 AxisConstraint              ( 0001867305B0 ModelEnumType AxisConstraint AxisConstraint AxisConstraint Int32 )
            value.Snapping                                  = GetBool(new IntPtr(p + 0x014)); // 0245A72A54D0 0x14 Snapping                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
