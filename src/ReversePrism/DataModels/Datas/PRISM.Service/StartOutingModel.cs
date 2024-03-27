using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheStartScheduleOutingReply            000186652D10 ModelClassType IStartScheduleOutingReply IStartScheduleOutingReply IStartScheduleOutingReply Pointer
    public partial class StartOutingModel
    {
        public IStartScheduleOutingReply?               CacheStartScheduleOutingReply           { get; set; }

        public static StartOutingModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartOutingModel();

            value.CacheStartScheduleOutingReply             = GetObject<IStartScheduleOutingReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStartScheduleOutingReply.FromPointer); // 0270D65D97F0 0x10 CacheStartScheduleOutingReply ( 000186652D10 ModelClassType IStartScheduleOutingReply IStartScheduleOutingReply IStartScheduleOutingReply Pointer )

            return value;
        }
    }
}
