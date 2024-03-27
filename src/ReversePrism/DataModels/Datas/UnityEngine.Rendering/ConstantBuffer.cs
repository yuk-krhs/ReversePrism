using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_RegisteredConstantBuffers              List`1<ConstantBufferBase> IL2CPP_TYPE_GENERICINST
    public partial class ConstantBuffer
    {

        public static ConstantBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConstantBuffer();


            return value;
        }
    }
}
