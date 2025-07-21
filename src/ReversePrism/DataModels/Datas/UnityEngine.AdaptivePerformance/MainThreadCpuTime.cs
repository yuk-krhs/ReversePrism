using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_LastAbsoluteMainThreadCpuTime          ModelPrimitiveType double double double Double
    // 018 M_LatestMainthreadCpuTime                ModelPrimitiveType float float float Single
    public partial class MainThreadCpuTime : DataModel
    {
        public double                                   M_LastAbsoluteMainThreadCpuTime         { get; set; }
        public float                                    M_LatestMainthreadCpuTime               { get; set; }

        public static MainThreadCpuTime? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MainThreadCpuTime() { Pointer= p0 };

            value.M_LastAbsoluteMainThreadCpuTime           = GetDouble(new IntPtr(p + 0x010)); // 0x10 M_LastAbsoluteMainThreadCpuTime ( ModelPrimitiveType double double double Double )
            value.M_LatestMainthreadCpuTime                 = GetSingle(new IntPtr(p + 0x018)); // 0x18 M_LatestMainthreadCpuTime   ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
