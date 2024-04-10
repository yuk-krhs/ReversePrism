using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _primitiveConversions                    Primitives[] IL2CPP_TYPE_SZARRAY
    public partial class DefaultBinder : DataModel
    {

        public static DefaultBinder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultBinder() { Pointer= p0 };


            return value;
        }
    }
}
