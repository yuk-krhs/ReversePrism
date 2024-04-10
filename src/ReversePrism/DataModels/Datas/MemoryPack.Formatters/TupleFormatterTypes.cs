using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 TupleFormatters                          Dictionary`2<Type, Type> IL2CPP_TYPE_GENERICINST
    public partial class TupleFormatterTypes : DataModel
    {

        public static TupleFormatterTypes? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TupleFormatterTypes() { Pointer= p0 };


            return value;
        }
    }
}
