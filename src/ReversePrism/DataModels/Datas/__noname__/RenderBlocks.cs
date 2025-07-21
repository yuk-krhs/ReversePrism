using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_BlockEventLimits                       NativeArray`1<RenderPassEvent> IL2CPP_TYPE_GENERICINST
    // 020 m_BlockRanges                            NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    // 030 m_BlockRangeLengths                      NativeArray`1<int> IL2CPP_TYPE_GENERICINST
    public partial class RenderBlocks : DataModel
    {

        public static RenderBlocks? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RenderBlocks() { Pointer= p0 };


            return value;
        }
    }
}
