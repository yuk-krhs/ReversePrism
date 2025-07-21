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
    // 018 Durations                                ModelPrimitiveListType float[] float[] List<float> Pointer
    public partial class Vector3ArrayOptions : DataModel
    {
        public AxisConstraint                           AxisConstraint                          { get; set; }
        public bool                                     Snapping                                { get; set; }
        public List<float>?                             Durations                               { get; set; }

        public static Vector3ArrayOptions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Vector3ArrayOptions() { Pointer= p0 };

            value.AxisConstraint                            = (AxisConstraint)GetInt32(new IntPtr(p + 0x010)); // 0x10 AxisConstraint              ( ModelEnumType AxisConstraint AxisConstraint AxisConstraint Int32 )
            value.Snapping                                  = GetBool(new IntPtr(p + 0x014)); // 0x14 Snapping                    ( ModelPrimitiveType bool bool bool Bool )
            value.Durations                                 = GetSingleList(new IntPtr(p + 0x018)); // 0x18 Durations                   ( ModelPrimitiveListType float[] float[] List<float> Pointer )

            return value;
        }
    }
}
