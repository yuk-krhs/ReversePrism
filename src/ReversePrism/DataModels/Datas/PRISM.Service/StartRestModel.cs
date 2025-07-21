using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheStartScheduleRestReply              ModelClassType IStartScheduleRestReply IStartScheduleRestReply IStartScheduleRestReply Pointer
    public partial class StartRestModel : DataModel
    {
        public IStartScheduleRestReply?                 CacheStartScheduleRestReply             { get; set; }

        public static StartRestModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartRestModel() { Pointer= p0 };

            value.CacheStartScheduleRestReply               = GetObject<IStartScheduleRestReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStartScheduleRestReply.FromPointer); // 0x10 CacheStartScheduleRestReply ( ModelClassType IStartScheduleRestReply IStartScheduleRestReply IStartScheduleRestReply Pointer )

            return value;
        }
    }
}
