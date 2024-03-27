using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheStartScheduleShoppingReply          0001866540F0 ModelClassType IStartScheduleShoppingReply IStartScheduleShoppingReply IStartScheduleShoppingReply Pointer
    public partial class StartShoppingModel
    {
        public IStartScheduleShoppingReply?             CacheStartScheduleShoppingReply         { get; set; }

        public static StartShoppingModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartShoppingModel();

            value.CacheStartScheduleShoppingReply           = GetObject<IStartScheduleShoppingReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStartScheduleShoppingReply.FromPointer); // 0270D65DB920 0x10 CacheStartScheduleShoppingReply ( 0001866540F0 ModelClassType IStartScheduleShoppingReply IStartScheduleShoppingReply IStartScheduleShoppingReply Pointer )

            return value;
        }
    }
}
