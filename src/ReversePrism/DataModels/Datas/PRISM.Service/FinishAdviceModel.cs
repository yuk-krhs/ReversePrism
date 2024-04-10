using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheFinishScheduleAdviceReply           000186510C20 ModelClassType IFinishScheduleAdviceReply IFinishScheduleAdviceReply IFinishScheduleAdviceReply Pointer
    public partial class FinishAdviceModel : DataModel
    {
        public IFinishScheduleAdviceReply?              CacheFinishScheduleAdviceReply          { get; set; }

        public static FinishAdviceModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishAdviceModel() { Pointer= p0 };

            value.CacheFinishScheduleAdviceReply            = GetObject<IFinishScheduleAdviceReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFinishScheduleAdviceReply.FromPointer); // 024666612C68 0x10 CacheFinishScheduleAdviceReply ( 000186510C20 ModelClassType IFinishScheduleAdviceReply IFinishScheduleAdviceReply IFinishScheduleAdviceReply Pointer )

            return value;
        }
    }
}
