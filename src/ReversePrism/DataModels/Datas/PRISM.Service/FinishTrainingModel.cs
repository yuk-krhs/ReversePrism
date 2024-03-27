using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheFinishScheduleTrainingReply         000186513480 ModelClassType IFinishScheduleTrainingReply IFinishScheduleTrainingReply IFinishScheduleTrainingReply Pointer
    public partial class FinishTrainingModel
    {
        public IFinishScheduleTrainingReply?            CacheFinishScheduleTrainingReply        { get; set; }

        public static FinishTrainingModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishTrainingModel();

            value.CacheFinishScheduleTrainingReply          = GetObject<IFinishScheduleTrainingReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFinishScheduleTrainingReply.FromPointer); // 0270D65BF5D8 0x10 CacheFinishScheduleTrainingReply ( 000186513480 ModelClassType IFinishScheduleTrainingReply IFinishScheduleTrainingReply IFinishScheduleTrainingReply Pointer )

            return value;
        }
    }
}
