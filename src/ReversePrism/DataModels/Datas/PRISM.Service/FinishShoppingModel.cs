using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheFinishScheduleShoppingReply         0001865127B0 ModelClassType IFinishScheduleShoppingReply IFinishScheduleShoppingReply IFinishScheduleShoppingReply Pointer
    public partial class FinishShoppingModel
    {
        public IFinishScheduleShoppingReply?            CacheFinishScheduleShoppingReply        { get; set; }

        public static FinishShoppingModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishShoppingModel();

            value.CacheFinishScheduleShoppingReply          = GetObject<IFinishScheduleShoppingReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFinishScheduleShoppingReply.FromPointer); // 0270D65BB348 0x10 CacheFinishScheduleShoppingReply ( 0001865127B0 ModelClassType IFinishScheduleShoppingReply IFinishScheduleShoppingReply IFinishScheduleShoppingReply Pointer )

            return value;
        }
    }
}
