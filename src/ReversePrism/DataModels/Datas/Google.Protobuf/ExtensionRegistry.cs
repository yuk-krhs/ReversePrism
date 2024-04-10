using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 extensions                               IDictionary`2<ObjectIntPair`1<Type>, Extension> IL2CPP_TYPE_GENERICINST
    public partial class ExtensionRegistry : DataModel
    {

        public static ExtensionRegistry? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtensionRegistry() { Pointer= p0 };


            return value;
        }
    }
}
