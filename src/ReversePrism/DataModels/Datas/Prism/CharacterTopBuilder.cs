using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TitleView                                ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    // 028 TopView                                  ModelClassType CharacterTopView CharacterTopView CharacterTopView Pointer
    // 030 UiCharacterView                          ModelClassType CharacterTopUICharacterView CharacterTopUICharacterView CharacterTopUICharacterView Pointer
    public partial class CharacterTopBuilder : DataModel
    {
        public CommonTitleView?                         TitleView                               { get; set; }
        public CharacterTopView?                        TopView                                 { get; set; }
        public CharacterTopUICharacterView?             UiCharacterView                         { get; set; }

        public static CharacterTopBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterTopBuilder() { Pointer= p0 };

            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CommonTitleView.FromPointer); // 0x20 TitleView                   ( ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )
            value.TopView                                   = GetObject<CharacterTopView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CharacterTopView.FromPointer); // 0x28 TopView                     ( ModelClassType CharacterTopView CharacterTopView CharacterTopView Pointer )
            value.UiCharacterView                           = GetObject<CharacterTopUICharacterView>(new IntPtr(p + 0x030), ReversePrism.DataModels.CharacterTopUICharacterView.FromPointer); // 0x30 UiCharacterView             ( ModelClassType CharacterTopUICharacterView CharacterTopUICharacterView CharacterTopUICharacterView Pointer )

            return value;
        }
    }
}
