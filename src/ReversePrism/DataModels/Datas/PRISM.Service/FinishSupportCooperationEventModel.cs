using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheFinishSupportCooperationEventReply  0001865152A0 ModelClassType IFinishSupportCooperationEventReply IFinishSupportCooperationEventReply IFinishSupportCooperationEventReply Pointer
    public partial class FinishSupportCooperationEventModel : DataModel
    {
        public IFinishSupportCooperationEventReply?     CacheFinishSupportCooperationEventReply { get; set; }

        public static FinishSupportCooperationEventModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FinishSupportCooperationEventModel() { Pointer= p0 };

            value.CacheFinishSupportCooperationEventReply   = GetObject<IFinishSupportCooperationEventReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFinishSupportCooperationEventReply.FromPointer); // 02466661DCA8 0x10 CacheFinishSupportCooperationEventReply ( 0001865152A0 ModelClassType IFinishSupportCooperationEventReply IFinishSupportCooperationEventReply IFinishSupportCooperationEventReply Pointer )

            return value;
        }
    }
}
