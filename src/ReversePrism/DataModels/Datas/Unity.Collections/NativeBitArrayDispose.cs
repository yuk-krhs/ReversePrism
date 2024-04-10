using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_BitArrayData                           IntPtr IL2CPP_TYPE_PTR
    public partial class NativeBitArrayDispose : DataModel
    {

        public static NativeBitArrayDispose? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeBitArrayDispose() { Pointer= p0 };


            return value;
        }
    }
}
