using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Samples                                Queue`1<float> IL2CPP_TYPE_GENERICINST
    // 018 M_SampleCapacity                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C Trend                                    0001866656B0 ModelPrimitiveType float float float Single
    public partial class PerformanceStateTracker : DataModel
    {
        public int                                      M_SampleCapacity                        { get; set; }
        public float                                    Trend                                   { get; set; }

        public static PerformanceStateTracker? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PerformanceStateTracker() { Pointer= p0 };

            value.M_SampleCapacity                          = GetInt32(new IntPtr(p + 0x018)); // 02466B6F2760 0x18 M_SampleCapacity            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Trend                                     = GetSingle(new IntPtr(p + 0x01C)); // 02466B6F2780 0x1C Trend                       ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
