using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TargetsAtLeast_Desktop_V4_5              bool IL2CPP_TYPE_BOOLEAN
    // 001 TargetsAtLeast_Desktop_V4_5_1            bool IL2CPP_TYPE_BOOLEAN
    public partial class BinaryCompatibility : DataModel
    {

        public static BinaryCompatibility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinaryCompatibility() { Pointer= p0 };


            return value;
        }
    }
}
