using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _initialized                             bool IL2CPP_TYPE_BOOLEAN
    public partial class DOTweenModuleUtils : DataModel
    {

        public static DOTweenModuleUtils? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DOTweenModuleUtils() { Pointer= p0 };


            return value;
        }
    }
}
