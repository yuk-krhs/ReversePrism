using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Next                                     LinkedSlot<<var>> IL2CPP_TYPE_GENERICINST
    // 000 Previous                                 LinkedSlot<<var>> IL2CPP_TYPE_GENERICINST
    // 000 SlotArray                                LinkedSlotVolatile<<var>>[] IL2CPP_TYPE_SZARRAY
    // 000 Value                                    <var> IL2CPP_TYPE_VAR
    public partial class LinkedSlot : DataModel
    {

        public static LinkedSlot? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LinkedSlot() { Pointer= p0 };


            return value;
        }
    }
}
