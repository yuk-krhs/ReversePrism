using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseViewModel                            0001866985C0 ModelClassType AdvTitleViewModel AdvTitleViewModel AdvTitleViewModel Pointer
    // 018 CharacterBaseIconViewModel               000186599E70 ModelClassType CharacterBaseIconViewModel CharacterBaseIconViewModel CharacterBaseIconViewModel Pointer
    public partial class CharaBaseIconDisplayableAdvTitleViewModel
    {
        public AdvTitleViewModel?                       BaseViewModel                           { get; set; }
        public CharacterBaseIconViewModel?              CharacterBaseIconViewModel              { get; set; }

        public static CharaBaseIconDisplayableAdvTitleViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharaBaseIconDisplayableAdvTitleViewModel();

            value.BaseViewModel                             = GetObject<AdvTitleViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.AdvTitleViewModel.FromPointer); // 0270D5DD2C68 0x10 BaseViewModel               ( 0001866985C0 ModelClassType AdvTitleViewModel AdvTitleViewModel AdvTitleViewModel Pointer )
            value.CharacterBaseIconViewModel                = GetObject<CharacterBaseIconViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.CharacterBaseIconViewModel.FromPointer); // 0270D5DD2C88 0x18 CharacterBaseIconViewModel  ( 000186599E70 ModelClassType CharacterBaseIconViewModel CharacterBaseIconViewModel CharacterBaseIconViewModel Pointer )

            return value;
        }
    }
}
