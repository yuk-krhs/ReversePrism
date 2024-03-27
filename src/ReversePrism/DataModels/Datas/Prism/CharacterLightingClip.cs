using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                00018659FC40 ModelClassType CharacterLightingBehaviour CharacterLightingBehaviour CharacterLightingBehaviour Pointer
    public partial class CharacterLightingClip
    {
        public CharacterLightingBehaviour?              Behaviour                               { get; set; }

        public static CharacterLightingClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterLightingClip();

            value.Behaviour                                 = GetObject<CharacterLightingBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.CharacterLightingBehaviour.FromPointer); // 0270D4DFE1D0 0x18 Behaviour                   ( 00018659FC40 ModelClassType CharacterLightingBehaviour CharacterLightingBehaviour CharacterLightingBehaviour Pointer )

            return value;
        }
    }
}
