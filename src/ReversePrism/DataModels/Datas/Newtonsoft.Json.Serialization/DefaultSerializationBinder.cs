using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Instance                                 DefaultSerializationBinder IL2CPP_TYPE_CLASS
    // 010 _typeCache                               ThreadSafeStore`2<StructMultiKey`2<string, string>, Type> IL2CPP_TYPE_GENERICINST
    public partial class DefaultSerializationBinder
    {

        public static DefaultSerializationBinder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultSerializationBinder();


            return value;
        }
    }
}
