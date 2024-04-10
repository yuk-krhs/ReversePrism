using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_UnityThreadId                          int IL2CPP_TYPE_I4
    // 008 <UnityThreadScheduler>k__BackingField    TaskScheduler IL2CPP_TYPE_CLASS
    public partial class UnityThreadUtils : DataModel
    {

        public static UnityThreadUtils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnityThreadUtils() { Pointer= p0 };


            return value;
        }
    }
}
