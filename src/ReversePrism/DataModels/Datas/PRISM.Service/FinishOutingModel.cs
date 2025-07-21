using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheFinishScheduleOutingReply           ModelClassType IFinishScheduleOutingReply IFinishScheduleOutingReply IFinishScheduleOutingReply Pointer
    public partial class FinishOutingModel : DataModel
    {
        public IFinishScheduleOutingReply?              CacheFinishScheduleOutingReply          { get; set; }

        public static FinishOutingModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishOutingModel() { Pointer= p0 };

            value.CacheFinishScheduleOutingReply            = GetObject<IFinishScheduleOutingReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFinishScheduleOutingReply.FromPointer); // 0x10 CacheFinishScheduleOutingReply ( ModelClassType IFinishScheduleOutingReply IFinishScheduleOutingReply IFinishScheduleOutingReply Pointer )

            return value;
        }
    }
}
