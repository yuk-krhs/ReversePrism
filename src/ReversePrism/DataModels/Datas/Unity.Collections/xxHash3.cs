using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 STRIPE_LEN                               int IL2CPP_TYPE_I4
    // 000 ACC_NB                                   int IL2CPP_TYPE_I4
    // 000 SECRET_CONSUME_RATE                      int IL2CPP_TYPE_I4
    // 000 SECRET_KEY_SIZE                          int IL2CPP_TYPE_I4
    // 000 SECRET_KEY_MIN_SIZE                      int IL2CPP_TYPE_I4
    // 000 SECRET_LASTACC_START                     int IL2CPP_TYPE_I4
    // 000 NB_ROUNDS                                int IL2CPP_TYPE_I4
    // 000 BLOCK_LEN                                int IL2CPP_TYPE_I4
    // 000 PRIME32_1                                uint IL2CPP_TYPE_U4
    // 000 PRIME32_2                                uint IL2CPP_TYPE_U4
    // 000 PRIME32_3                                uint IL2CPP_TYPE_U4
    // 000 PRIME32_5                                uint IL2CPP_TYPE_U4
    // 000 PRIME64_1                                ulong IL2CPP_TYPE_U8
    // 000 PRIME64_2                                ulong IL2CPP_TYPE_U8
    // 000 PRIME64_3                                ulong IL2CPP_TYPE_U8
    // 000 PRIME64_4                                ulong IL2CPP_TYPE_U8
    // 000 PRIME64_5                                ulong IL2CPP_TYPE_U8
    // 000 MIDSIZE_MAX                              int IL2CPP_TYPE_I4
    // 000 MIDSIZE_STARTOFFSET                      int IL2CPP_TYPE_I4
    // 000 MIDSIZE_LASTOFFSET                       int IL2CPP_TYPE_I4
    // 000 SECRET_MERGEACCS_START                   int IL2CPP_TYPE_I4
    public partial class xxHash3 : DataModel
    {

        public static xxHash3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new xxHash3() { Pointer= p0 };


            return value;
        }
    }
}
