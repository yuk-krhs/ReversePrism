using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DefaultTab                               ModelEnumType IdolListTabType IdolListTabType IdolListTabType Int32
    public partial class IdolListViewParameter : DataModel
    {
        public IdolListTabType                          DefaultTab                              { get; set; }

        public static IdolListViewParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolListViewParameter() { Pointer= p0 };

            value.DefaultTab                                = (IdolListTabType)GetInt32(new IntPtr(p + 0x010)); // 0x10 DefaultTab                  ( ModelEnumType IdolListTabType IdolListTabType IdolListTabType Int32 )

            return value;
        }
    }
}
