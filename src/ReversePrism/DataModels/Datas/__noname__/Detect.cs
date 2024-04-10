using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DETECT_RUNNING_BAD_APPLICATION           int IL2CPP_TYPE_I4
    public partial class Detect : DataModel
    {

        public static Detect? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Detect() { Pointer= p0 };


            return value;
        }
    }
}
