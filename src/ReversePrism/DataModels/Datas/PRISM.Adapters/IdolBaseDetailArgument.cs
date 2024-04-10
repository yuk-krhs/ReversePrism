using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 JumpParam                                0001866ABAB0 ModelClassType IdolBaseDetailViewParameter IdolBaseDetailViewParameter IdolBaseDetailViewParameter Pointer
    public partial class IdolBaseDetailArgument : DataModel
    {
        public IdolBaseDetailViewParameter?             JumpParam                               { get; set; }

        public static IdolBaseDetailArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolBaseDetailArgument() { Pointer= p0 };

            value.JumpParam                                 = GetObject<IdolBaseDetailViewParameter>(new IntPtr(p + 0x010), ReversePrism.DataModels.IdolBaseDetailViewParameter.FromPointer); // 024665F0EC00 0x10 JumpParam                   ( 0001866ABAB0 ModelClassType IdolBaseDetailViewParameter IdolBaseDetailViewParameter IdolBaseDetailViewParameter Pointer )

            return value;
        }
    }
}
