using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // FFFFFFFF threadStaticReaderOptionalState          MemoryPackReaderOptionalState IL2CPP_TYPE_CLASS
    // FFFFFFFF threadStaticState                        SerializerWriterThreadStaticState IL2CPP_TYPE_CLASS
    // FFFFFFFF threadStaticWriterOptionalState          MemoryPackWriterOptionalState IL2CPP_TYPE_CLASS
    public partial class MemoryPackSerializer
    {

        public static MemoryPackSerializer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemoryPackSerializer();


            return value;
        }
    }
}
