using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 JumpParam                                0001865A3840 ModelClassType CharacterSelectViewParameter CharacterSelectViewParameter CharacterSelectViewParameter Pointer
    public partial class CharacterSelectArgument : DataModel
    {
        public CharacterSelectViewParameter?            JumpParam                               { get; set; }

        public static CharacterSelectArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterSelectArgument() { Pointer= p0 };

            value.JumpParam                                 = GetObject<CharacterSelectViewParameter>(new IntPtr(p + 0x010), ReversePrism.DataModels.CharacterSelectViewParameter.FromPointer); // 024665F02B20 0x10 JumpParam                   ( 0001865A3840 ModelClassType CharacterSelectViewParameter CharacterSelectViewParameter CharacterSelectViewParameter Pointer )

            return value;
        }
    }
}
