using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 atomicValueType                          Type IL2CPP_TYPE_CLASS
    // 008 listValueType                            Type IL2CPP_TYPE_CLASS
    public partial class Datatype_float
    {

        public static Datatype_float? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Datatype_float();


            return value;
        }
    }
}
