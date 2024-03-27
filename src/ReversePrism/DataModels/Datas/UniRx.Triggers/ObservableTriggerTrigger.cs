using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 onTriggerEnter                           Subject`1<Collider> IL2CPP_TYPE_GENERICINST
    // 058 onTriggerExit                            Subject`1<Collider> IL2CPP_TYPE_GENERICINST
    // 060 onTriggerStay                            Subject`1<Collider> IL2CPP_TYPE_GENERICINST
    public partial class ObservableTriggerTrigger
    {

        public static ObservableTriggerTrigger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObservableTriggerTrigger();


            return value;
        }
    }
}
