using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 empty                                    ByteString IL2CPP_TYPE_CLASS
    // 010 bytes                                    ReadOnlyMemory`1<sbyte> IL2CPP_TYPE_GENERICINST
    public partial class ByteString
    {

        public static ByteString? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ByteString();


            return value;
        }
    }
}
