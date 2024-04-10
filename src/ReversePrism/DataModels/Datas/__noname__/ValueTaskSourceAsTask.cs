using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_completionAction                       Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 000 _source                                  IValueTaskSource`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 _token                                   short IL2CPP_TYPE_I2
    public partial class ValueTaskSourceAsTask : DataModel
    {

        public static ValueTaskSourceAsTask? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ValueTaskSourceAsTask() { Pointer= p0 };


            return value;
        }
    }
}
