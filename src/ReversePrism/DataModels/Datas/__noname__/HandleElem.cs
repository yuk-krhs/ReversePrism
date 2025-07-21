using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _key                                     <var> IL2CPP_TYPE_VAR
    // 000 _node                                    int IL2CPP_TYPE_I4
    public partial class HandleElem : DataModel
    {

        public static HandleElem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HandleElem() { Pointer= p0 };


            return value;
        }
    }
}
