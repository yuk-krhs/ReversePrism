using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 numeric10FacetsChecker                   FacetsChecker IL2CPP_TYPE_CLASS
    public partial class Datatype_negativeInteger
    {

        public static Datatype_negativeInteger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Datatype_negativeInteger();


            return value;
        }
    }
}
