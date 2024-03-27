using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_Instance                               IAdaptivePerformance IL2CPP_TYPE_CLASS
    // 008 LifecycleEventHandler                    LifecycleEventHandler IL2CPP_TYPE_CLASS
    public partial class Holder
    {

        public static Holder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Holder();


            return value;
        }
    }
}
