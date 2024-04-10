using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 table                                    Dictionary`2<InternedString, Type> IL2CPP_TYPE_GENERICINST
    public partial class TypeTable : DataModel
    {

        public static TypeTable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeTable() { Pointer= p0 };


            return value;
        }
    }
}
