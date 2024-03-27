using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 JumpParam                                0001866ABAB0 ModelClassType IdolBaseDetailViewParameter IdolBaseDetailViewParameter IdolBaseDetailViewParameter Pointer
    public partial class CharacterBaseDetailArgument
    {
        public IdolBaseDetailViewParameter?             JumpParam                               { get; set; }

        public static CharacterBaseDetailArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterBaseDetailArgument();

            value.JumpParam                                 = GetObject<IdolBaseDetailViewParameter>(new IntPtr(p + 0x010), ReversePrism.DataModels.IdolBaseDetailViewParameter.FromPointer); // 0270D5E6AA98 0x10 JumpParam                   ( 0001866ABAB0 ModelClassType IdolBaseDetailViewParameter IdolBaseDetailViewParameter IdolBaseDetailViewParameter Pointer )

            return value;
        }
    }
}
