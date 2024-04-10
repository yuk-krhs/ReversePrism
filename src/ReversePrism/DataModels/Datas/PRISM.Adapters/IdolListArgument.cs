using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 JumpParam                                0001866B5250 ModelClassType IdolListViewParameter IdolListViewParameter IdolListViewParameter Pointer
    public partial class IdolListArgument : DataModel
    {
        public IdolListViewParameter?                   JumpParam                               { get; set; }

        public static IdolListArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolListArgument() { Pointer= p0 };

            value.JumpParam                                 = GetObject<IdolListViewParameter>(new IntPtr(p + 0x010), ReversePrism.DataModels.IdolListViewParameter.FromPointer); // 024665F352F8 0x10 JumpParam                   ( 0001866B5250 ModelClassType IdolListViewParameter IdolListViewParameter IdolListViewParameter Pointer )

            return value;
        }
    }
}
