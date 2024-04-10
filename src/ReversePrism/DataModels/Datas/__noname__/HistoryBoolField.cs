using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 <historyGetter>k__BackingField           Func`1<bool>[] IL2CPP_TYPE_SZARRAY
    public partial class HistoryBoolField : DataModel
    {

        public static HistoryBoolField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HistoryBoolField() { Pointer= p0 };


            return value;
        }
    }
}
