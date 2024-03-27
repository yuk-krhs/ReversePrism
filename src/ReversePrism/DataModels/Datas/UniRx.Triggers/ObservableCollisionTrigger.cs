using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 onCollisionEnter                         Subject`1<Collision> IL2CPP_TYPE_GENERICINST
    // 058 onCollisionExit                          Subject`1<Collision> IL2CPP_TYPE_GENERICINST
    // 060 onCollisionStay                          Subject`1<Collision> IL2CPP_TYPE_GENERICINST
    public partial class ObservableCollisionTrigger
    {

        public static ObservableCollisionTrigger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObservableCollisionTrigger();


            return value;
        }
    }
}
