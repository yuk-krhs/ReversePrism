using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 uniqueCount                              int IL2CPP_TYPE_I4
    // 000 unfoundCount                             int IL2CPP_TYPE_I4
    public partial class ElementCount : DataModel
    {

        public static ElementCount? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ElementCount() { Pointer= p0 };


            return value;
        }
    }
}
