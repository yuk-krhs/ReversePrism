using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 <Key>k__BackingField                     <var> IL2CPP_TYPE_VAR
    public partial class KeyValuePairProperty : DataModel
    {

        public static KeyValuePairProperty? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KeyValuePairProperty() { Pointer= p0 };


            return value;
        }
    }
}
