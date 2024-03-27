using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Zero                                     <uint> IL2CPP_TYPE_U
    // 010 _pointer                                 IntPtr IL2CPP_TYPE_PTR
    public partial class UIntPtr
    {

        public static UIntPtr? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIntPtr();


            return value;
        }
    }
}
