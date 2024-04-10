using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 enabled                                  bool IL2CPP_TYPE_BOOLEAN
    public partial class APLog : DataModel
    {

        public static APLog? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new APLog() { Pointer= p0 };


            return value;
        }
    }
}
