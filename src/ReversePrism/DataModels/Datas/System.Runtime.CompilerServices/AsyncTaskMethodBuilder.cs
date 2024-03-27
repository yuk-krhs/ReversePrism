using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_cachedCompleted                        Task`1<VoidTaskResult> IL2CPP_TYPE_GENERICINST
    // 010 m_builder                                AsyncTaskMethodBuilder`1<VoidTaskResult> IL2CPP_TYPE_GENERICINST
    public partial class AsyncTaskMethodBuilder
    {

        public static AsyncTaskMethodBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AsyncTaskMethodBuilder();


            return value;
        }
    }
}
