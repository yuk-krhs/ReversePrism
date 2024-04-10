using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 processorCount                           int IL2CPP_TYPE_I4
    // 004 vmTpInitialized                          bool IL2CPP_TYPE_BOOLEAN
    // 005 enableWorkerTracking                     bool IL2CPP_TYPE_BOOLEAN
    // 008 workQueue                                ThreadPoolWorkQueue IL2CPP_TYPE_CLASS
    public partial class ThreadPoolGlobals : DataModel
    {

        public static ThreadPoolGlobals? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ThreadPoolGlobals() { Pointer= p0 };


            return value;
        }
    }
}
