using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DeclaredOnlyLookup                       BindingFlags IL2CPP_TYPE_VALUETYPE
    public partial class TypeInfo : DataModel
    {

        public static TypeInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeInfo() { Pointer= p0 };


            return value;
        }
    }
}
