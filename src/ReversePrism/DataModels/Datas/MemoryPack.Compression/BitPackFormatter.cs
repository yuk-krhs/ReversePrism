using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Default                                  BitPackFormatter IL2CPP_TYPE_CLASS
    public partial class BitPackFormatter : DataModel
    {

        public static BitPackFormatter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BitPackFormatter() { Pointer= p0 };


            return value;
        }
    }
}
