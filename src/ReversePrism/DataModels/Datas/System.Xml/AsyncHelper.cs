using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DoneTask                                 Task IL2CPP_TYPE_CLASS
    // 008 DoneTaskTrue                             Task`1<bool> IL2CPP_TYPE_GENERICINST
    // 010 DoneTaskFalse                            Task`1<bool> IL2CPP_TYPE_GENERICINST
    // 018 DoneTaskZero                             Task`1<int> IL2CPP_TYPE_GENERICINST
    public partial class AsyncHelper
    {

        public static AsyncHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncHelper();


            return value;
        }
    }
}
