using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 BaseIcon                                 000186599240 ModelClassType CharacterBaseIcon CharacterBaseIcon CharacterBaseIcon Pointer
    public partial class IntroductionCharacterSelectGridViewCell
    {
        public CharacterBaseIcon?                       BaseIcon                                { get; set; }

        public static IntroductionCharacterSelectGridViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntroductionCharacterSelectGridViewCell();

            value.BaseIcon                                  = GetObject<CharacterBaseIcon>(new IntPtr(p + 0x030), ReversePrism.DataModels.CharacterBaseIcon.FromPointer); // 0270DBC43AD8 0x30 BaseIcon                    ( 000186599240 ModelClassType CharacterBaseIcon CharacterBaseIcon CharacterBaseIcon Pointer )

            return value;
        }
    }
}
