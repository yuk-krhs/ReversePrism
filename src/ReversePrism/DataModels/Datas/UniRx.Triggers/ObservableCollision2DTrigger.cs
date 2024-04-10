using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 onCollisionEnter2D                       Subject`1<Collision2D> IL2CPP_TYPE_GENERICINST
    // 058 onCollisionExit2D                        Subject`1<Collision2D> IL2CPP_TYPE_GENERICINST
    // 060 onCollisionStay2D                        Subject`1<Collision2D> IL2CPP_TYPE_GENERICINST
    public partial class ObservableCollision2DTrigger : DataModel
    {

        public static ObservableCollision2DTrigger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObservableCollision2DTrigger() { Pointer= p0 };


            return value;
        }
    }
}
