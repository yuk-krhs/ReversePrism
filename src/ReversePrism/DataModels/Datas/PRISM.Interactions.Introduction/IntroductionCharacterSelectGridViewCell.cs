using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 BaseIcon                                 ModelClassType CharacterBaseIcon CharacterBaseIcon CharacterBaseIcon Pointer
    public partial class IntroductionCharacterSelectGridViewCell : DataModel
    {
        public CharacterBaseIcon?                       BaseIcon                                { get; set; }

        public static IntroductionCharacterSelectGridViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionCharacterSelectGridViewCell() { Pointer= p0 };

            value.BaseIcon                                  = GetObject<CharacterBaseIcon>(new IntPtr(p + 0x030), ReversePrism.DataModels.CharacterBaseIcon.FromPointer); // 0x30 BaseIcon                    ( ModelClassType CharacterBaseIcon CharacterBaseIcon CharacterBaseIcon Pointer )

            return value;
        }
    }
}
