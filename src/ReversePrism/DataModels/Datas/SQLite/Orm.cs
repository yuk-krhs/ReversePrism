using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultMaxStringLength                   int IL2CPP_TYPE_I4
    // 000 ImplicitPkName                           string IL2CPP_TYPE_STRING
    // 000 ImplicitIndexSuffix                      string IL2CPP_TYPE_STRING
    public partial class Orm : DataModel
    {

        public static Orm? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Orm() { Pointer= p0 };


            return value;
        }
    }
}
