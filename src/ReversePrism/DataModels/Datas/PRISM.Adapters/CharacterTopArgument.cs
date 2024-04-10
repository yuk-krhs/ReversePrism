using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 JumpParam                                0001865A5D50 ModelClassType CharacterTopParameter CharacterTopParameter CharacterTopParameter Pointer
    public partial class CharacterTopArgument : DataModel
    {
        public CharacterTopParameter?                   JumpParam                               { get; set; }

        public static CharacterTopArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterTopArgument() { Pointer= p0 };

            value.JumpParam                                 = GetObject<CharacterTopParameter>(new IntPtr(p + 0x010), ReversePrism.DataModels.CharacterTopParameter.FromPointer); // 0246660E3DD0 0x10 JumpParam                   ( 0001865A5D50 ModelClassType CharacterTopParameter CharacterTopParameter CharacterTopParameter Pointer )

            return value;
        }
    }
}
