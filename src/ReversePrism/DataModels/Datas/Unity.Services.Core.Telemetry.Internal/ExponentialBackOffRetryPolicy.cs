using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_MaxTryCount                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 M_BaseDelaySeconds                       0001866656B0 ModelPrimitiveType float float float Single
    public partial class ExponentialBackOffRetryPolicy
    {
        public int                                      M_MaxTryCount                           { get; set; }
        public float                                    M_BaseDelaySeconds                      { get; set; }

        public static ExponentialBackOffRetryPolicy? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExponentialBackOffRetryPolicy();

            value.M_MaxTryCount                             = GetInt32(new IntPtr(p + 0x010)); // 02700666B018 0x10 M_MaxTryCount               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_BaseDelaySeconds                        = GetSingle(new IntPtr(p + 0x014)); // 02700666B038 0x14 M_BaseDelaySeconds          ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
