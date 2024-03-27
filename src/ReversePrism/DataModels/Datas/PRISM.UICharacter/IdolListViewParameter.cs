using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DefaultTab                               0001866B43B0 ModelEnumType IdolListTabType IdolListTabType IdolListTabType Int32
    public partial class IdolListViewParameter
    {
        public IdolListTabType                          DefaultTab                              { get; set; }

        public static IdolListViewParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolListViewParameter();

            value.DefaultTab                                = (IdolListTabType)GetInt32(new IntPtr(p + 0x010)); // 0270D5DB0CC8 0x10 DefaultTab                  ( 0001866B43B0 ModelEnumType IdolListTabType IdolListTabType IdolListTabType Int32 )

            return value;
        }
    }
}
