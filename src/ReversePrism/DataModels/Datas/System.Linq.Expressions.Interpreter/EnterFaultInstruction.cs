using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_cache                                  EnterFaultInstruction[] IL2CPP_TYPE_SZARRAY
    public partial class EnterFaultInstruction
    {

        public static EnterFaultInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EnterFaultInstruction();


            return value;
        }
    }
}
