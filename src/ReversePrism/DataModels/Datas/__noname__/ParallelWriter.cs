using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_Buffer                                 IntPtr IL2CPP_TYPE_PTR
    // 000 m_ThreadIndex                            int IL2CPP_TYPE_I4
    public partial class ParallelWriter : DataModel
    {

        public static ParallelWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParallelWriter() { Pointer= p0 };


            return value;
        }
    }
}
