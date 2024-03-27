using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheStartScheduleWorkingReply           000186655470 ModelClassType IStartScheduleWorkingReply IStartScheduleWorkingReply IStartScheduleWorkingReply Pointer
    public partial class StartWorkingModel
    {
        public IStartScheduleWorkingReply?              CacheStartScheduleWorkingReply          { get; set; }

        public static StartWorkingModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartWorkingModel();

            value.CacheStartScheduleWorkingReply            = GetObject<IStartScheduleWorkingReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStartScheduleWorkingReply.FromPointer); // 0270D65E0DD0 0x10 CacheStartScheduleWorkingReply ( 000186655470 ModelClassType IStartScheduleWorkingReply IStartScheduleWorkingReply IStartScheduleWorkingReply Pointer )

            return value;
        }
    }
}
