using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 <getObjects>k__BackingField              Func`1<IEnumerable`1<Object>> IL2CPP_TYPE_GENERICINST
    public partial class ObjectPopupField
    {

        public static ObjectPopupField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectPopupField();


            return value;
        }
    }
}
