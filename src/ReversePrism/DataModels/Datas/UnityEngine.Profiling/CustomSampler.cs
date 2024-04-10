using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_InvalidCustomSampler                   CustomSampler IL2CPP_TYPE_CLASS
    public partial class CustomSampler : DataModel
    {

        public static CustomSampler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CustomSampler() { Pointer= p0 };


            return value;
        }
    }
}
