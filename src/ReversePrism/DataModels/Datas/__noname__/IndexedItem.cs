using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Value                                    <var> IL2CPP_TYPE_VAR
    // 000 Id                                       long IL2CPP_TYPE_I8
    public partial class IndexedItem
    {

        public static IndexedItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IndexedItem();


            return value;
        }
    }
}
