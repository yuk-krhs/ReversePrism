using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TrueTask                                 Task`1<bool> IL2CPP_TYPE_GENERICINST
    // 008 FalseTask                                Task`1<bool> IL2CPP_TYPE_GENERICINST
    // 010 Int32Tasks                               Task`1<int>[] IL2CPP_TYPE_SZARRAY
    public partial class AsyncTaskCache : DataModel
    {

        public static AsyncTaskCache? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncTaskCache() { Pointer= p0 };


            return value;
        }
    }
}
