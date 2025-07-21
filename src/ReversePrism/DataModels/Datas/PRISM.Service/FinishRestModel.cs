using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheFinishScheduleRestReply             ModelClassType IFinishScheduleRestReply IFinishScheduleRestReply IFinishScheduleRestReply Pointer
    public partial class FinishRestModel : DataModel
    {
        public IFinishScheduleRestReply?                CacheFinishScheduleRestReply            { get; set; }

        public static FinishRestModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishRestModel() { Pointer= p0 };

            value.CacheFinishScheduleRestReply              = GetObject<IFinishScheduleRestReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFinishScheduleRestReply.FromPointer); // 0x10 CacheFinishScheduleRestReply ( ModelClassType IFinishScheduleRestReply IFinishScheduleRestReply IFinishScheduleRestReply Pointer )

            return value;
        }
    }
}
