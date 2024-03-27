using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 onMouseDown                              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 onMouseDrag                              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 onMouseEnter                             Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 068 onMouseExit                              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 070 onMouseOver                              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 078 onMouseUp                                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 080 onMouseUpAsButton                        Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ObservableMouseTrigger
    {

        public static ObservableMouseTrigger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObservableMouseTrigger();


            return value;
        }
    }
}
