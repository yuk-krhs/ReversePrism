using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 onTriggerEnter2D                         Subject`1<Collider2D> IL2CPP_TYPE_GENERICINST
    // 058 onTriggerExit2D                          Subject`1<Collider2D> IL2CPP_TYPE_GENERICINST
    // 060 onTriggerStay2D                          Subject`1<Collider2D> IL2CPP_TYPE_GENERICINST
    public partial class ObservableTrigger2DTrigger
    {

        public static ObservableTrigger2DTrigger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObservableTrigger2DTrigger();


            return value;
        }
    }
}
