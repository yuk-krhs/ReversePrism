using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    public partial class StartScheduleTrainingReplyTranslator : DataModel
    {

        public static StartScheduleTrainingReplyTranslator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartScheduleTrainingReplyTranslator() { Pointer= p0 };


            return value;
        }
    }
}
