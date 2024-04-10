using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 queue                                    ConcurrentQueue`1<MemoryPackWriterOptionalState> IL2CPP_TYPE_GENERICINST
    public partial class MemoryPackWriterOptionalStatePool : DataModel
    {

        public static MemoryPackWriterOptionalStatePool? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemoryPackWriterOptionalStatePool() { Pointer= p0 };


            return value;
        }
    }
}
