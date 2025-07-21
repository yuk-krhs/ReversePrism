using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_owner                                  ModelPrimitiveType int int int Int32
    // 000 SPINNING_FACTOR                          int IL2CPP_TYPE_I4
    // 000 SLEEP_ONE_FREQUENCY                      int IL2CPP_TYPE_I4
    // 000 SLEEP_ZERO_FREQUENCY                     int IL2CPP_TYPE_I4
    // 000 TIMEOUT_CHECK_FREQUENCY                  int IL2CPP_TYPE_I4
    // 000 LOCK_ID_DISABLE_MASK                     int IL2CPP_TYPE_I4
    // 000 LOCK_ANONYMOUS_OWNED                     int IL2CPP_TYPE_I4
    // 000 WAITERS_MASK                             int IL2CPP_TYPE_I4
    // 000 ID_DISABLED_AND_ANONYMOUS_OWNED          int IL2CPP_TYPE_I4
    // 000 LOCK_UNOWNED                             int IL2CPP_TYPE_I4
    // 000 MAXIMUM_WAITERS                          int IL2CPP_TYPE_I4
    public partial class SpinLock : DataModel
    {
        public int                                      M_owner                                 { get; set; }

        public static SpinLock? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpinLock() { Pointer= p0 };

            value.M_owner                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_owner                     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
