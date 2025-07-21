using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CacheStartScheduleTrainingReply          ModelClassType IStartScheduleTrainingReply IStartScheduleTrainingReply IStartScheduleTrainingReply Pointer
    public partial class StartTraningModel : DataModel
    {
        public IStartScheduleTrainingReply?             CacheStartScheduleTrainingReply         { get; set; }

        public static StartTraningModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartTraningModel() { Pointer= p0 };

            value.CacheStartScheduleTrainingReply           = GetObject<IStartScheduleTrainingReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.IStartScheduleTrainingReply.FromPointer); // 0x10 CacheStartScheduleTrainingReply ( ModelClassType IStartScheduleTrainingReply IStartScheduleTrainingReply IStartScheduleTrainingReply Pointer )

            return value;
        }
    }
}
