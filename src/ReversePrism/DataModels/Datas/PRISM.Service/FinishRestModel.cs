using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheFinishScheduleRestReply             000186512060 ModelClassType IFinishScheduleRestReply IFinishScheduleRestReply IFinishScheduleRestReply Pointer
    public partial class FinishRestModel
    {
        public IFinishScheduleRestReply?                CacheFinishScheduleRestReply            { get; set; }

        public static FinishRestModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishRestModel();

            value.CacheFinishScheduleRestReply              = GetObject<IFinishScheduleRestReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFinishScheduleRestReply.FromPointer); // 0270D65BA2B0 0x10 CacheFinishScheduleRestReply ( 000186512060 ModelClassType IFinishScheduleRestReply IFinishScheduleRestReply IFinishScheduleRestReply Pointer )

            return value;
        }
    }
}
