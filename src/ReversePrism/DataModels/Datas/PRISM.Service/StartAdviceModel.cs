using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheStartScheduleAdviceReply            000186652100 ModelClassType IStartScheduleAdviceReply IStartScheduleAdviceReply IStartScheduleAdviceReply Pointer
    public partial class StartAdviceModel : DataModel
    {
        public IStartScheduleAdviceReply?               CacheStartScheduleAdviceReply           { get; set; }

        public static StartAdviceModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartAdviceModel() { Pointer= p0 };

            value.CacheStartScheduleAdviceReply             = GetObject<IStartScheduleAdviceReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStartScheduleAdviceReply.FromPointer); // 024666634B70 0x10 CacheStartScheduleAdviceReply ( 000186652100 ModelClassType IStartScheduleAdviceReply IStartScheduleAdviceReply IStartScheduleAdviceReply Pointer )

            return value;
        }
    }
}
