using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Pointer                                  <int> IL2CPP_TYPE_I
    // 008 DeferredCompilation                      <int> IL2CPP_TYPE_I
    public partial class Try_000000DF$BurstDirectCall
    {

        public static Try_000000DF$BurstDirectCall? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Try_000000DF$BurstDirectCall();


            return value;
        }
    }
}
