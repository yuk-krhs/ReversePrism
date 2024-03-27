using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 particle1                                <object> IL2CPP_TYPE_OBJECT
    // 098 particle2                                <object> IL2CPP_TYPE_OBJECT
    public partial class UpaException
    {

        public static UpaException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UpaException();


            return value;
        }
    }
}
