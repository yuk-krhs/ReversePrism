using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheFinishScheduleWorkingReply          000186513C00 ModelClassType IFinishScheduleWorkingReply IFinishScheduleWorkingReply IFinishScheduleWorkingReply Pointer
    public partial class FinishWorkingModel : DataModel
    {
        public IFinishScheduleWorkingReply?             CacheFinishScheduleWorkingReply         { get; set; }

        public static FinishWorkingModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishWorkingModel() { Pointer= p0 };

            value.CacheFinishScheduleWorkingReply           = GetObject<IFinishScheduleWorkingReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFinishScheduleWorkingReply.FromPointer); // 024666620EA0 0x10 CacheFinishScheduleWorkingReply ( 000186513C00 ModelClassType IFinishScheduleWorkingReply IFinishScheduleWorkingReply IFinishScheduleWorkingReply Pointer )

            return value;
        }
    }
}
