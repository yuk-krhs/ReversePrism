using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 JobHandle                                000186600F20 ModelEnumType JobHandle JobHandle JobHandle Int32
    // 020 core                                     UniTaskCompletionSourceCore`1<AsyncUnit> IL2CPP_TYPE_GENERICINST
    public partial class JobHandlePromise
    {
        public JobHandle                                JobHandle                               { get; set; }

        public static JobHandlePromise? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JobHandlePromise();

            value.JobHandle                                 = (JobHandle)GetInt32(new IntPtr(p + 0x010)); // 0270D8F8D558 0x10 JobHandle                   ( 000186600F20 ModelEnumType JobHandle JobHandle JobHandle Int32 )

            return value;
        }
    }
}
