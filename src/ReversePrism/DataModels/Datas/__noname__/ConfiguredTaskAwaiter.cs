using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_task                                   Task`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 m_continueOnCapturedContext              bool IL2CPP_TYPE_BOOLEAN
    public partial class ConfiguredTaskAwaiter
    {

        public static ConfiguredTaskAwaiter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConfiguredTaskAwaiter();


            return value;
        }
    }
}
