using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 IsLittleEndian                           bool IL2CPP_TYPE_BOOLEAN
    public partial class BitConverter : DataModel
    {

        public static BitConverter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BitConverter() { Pointer= p0 };


            return value;
        }
    }
}
