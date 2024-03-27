using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <Response>k__BackingField                <var> IL2CPP_TYPE_VAR
    // 000 <WriteFlags>k__BackingField              WriteFlags IL2CPP_TYPE_VALUETYPE
    public partial class ResponseWithFlags
    {

        public static ResponseWithFlags? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResponseWithFlags();


            return value;
        }
    }
}
