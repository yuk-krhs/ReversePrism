using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _busyCount                               int IL2CPP_TYPE_I4
    // 000 _collection                              ObservableCollection`1<<var>> IL2CPP_TYPE_GENERICINST
    public partial class SimpleMonitor : DataModel
    {

        public static SimpleMonitor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SimpleMonitor() { Pointer= p0 };


            return value;
        }
    }
}
