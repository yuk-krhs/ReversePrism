using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 FilterTypeName                           TypeFilter IL2CPP_TYPE_CLASS
    // 008 FilterTypeNameIgnoreCase                 TypeFilter IL2CPP_TYPE_CLASS
    // 000 DefaultLookup                            BindingFlags IL2CPP_TYPE_VALUETYPE
    public partial class Module
    {

        public static Module? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Module();


            return value;
        }
    }
}
