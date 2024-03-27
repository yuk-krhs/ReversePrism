using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Behaviour                                000186737050 ModelClassType PersonalLightBehaviour PersonalLightBehaviour PersonalLightBehaviour Pointer
    public partial class PersonalLightClip
    {
        public PersonalLightBehaviour?                  Behaviour                               { get; set; }

        public static PersonalLightClip? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PersonalLightClip();

            value.Behaviour                                 = GetObject<PersonalLightBehaviour>(new IntPtr(p + 0x018), ReversePrism.DataModels.PersonalLightBehaviour.FromPointer); // 0270D4DFDF00 0x18 Behaviour                   ( 000186737050 ModelClassType PersonalLightBehaviour PersonalLightBehaviour PersonalLightBehaviour Pointer )

            return value;
        }
    }
}
