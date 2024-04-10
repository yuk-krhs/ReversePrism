using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheStartSupportCooperationEventReply   000186656CD0 ModelClassType IStartSupportCooperationEventReply IStartSupportCooperationEventReply IStartSupportCooperationEventReply Pointer
    public partial class StartSupportCooperationEventModel : DataModel
    {
        public IStartSupportCooperationEventReply?      CacheStartSupportCooperationEventReply  { get; set; }

        public static StartSupportCooperationEventModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartSupportCooperationEventModel() { Pointer= p0 };

            value.CacheStartSupportCooperationEventReply    = GetObject<IStartSupportCooperationEventReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStartSupportCooperationEventReply.FromPointer); // 024666631C58 0x10 CacheStartSupportCooperationEventReply ( 000186656CD0 ModelClassType IStartSupportCooperationEventReply IStartSupportCooperationEventReply IStartSupportCooperationEventReply Pointer )

            return value;
        }
    }
}
