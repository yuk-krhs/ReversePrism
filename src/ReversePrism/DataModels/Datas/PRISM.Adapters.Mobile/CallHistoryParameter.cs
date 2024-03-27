using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScrollPosition                           0001866656B0 ModelPrimitiveType float float float Single
    // 014 PhoneUserId                              0001865F4260 ModelPrimitiveType int int int Int32
    public partial class CallHistoryParameter
    {
        public float                                    ScrollPosition                          { get; set; }
        public int                                      PhoneUserId                             { get; set; }

        public static CallHistoryParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CallHistoryParameter();

            value.ScrollPosition                            = GetSingle(new IntPtr(p + 0x010)); // 0270D68429C0 0x10 ScrollPosition              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.PhoneUserId                               = GetInt32(new IntPtr(p + 0x014)); // 0270D68429E0 0x14 PhoneUserId                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
