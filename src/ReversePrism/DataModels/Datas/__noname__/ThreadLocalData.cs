using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <Queue>k__BackingField                   Queue`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 <CreateBudget>k__BackingField            int IL2CPP_TYPE_I4
    // 000 <DisposeBudget>k__BackingField           int IL2CPP_TYPE_I4
    public partial class ThreadLocalData : DataModel
    {

        public static ThreadLocalData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ThreadLocalData() { Pointer= p0 };


            return value;
        }
    }
}
