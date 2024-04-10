using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 View                                     00018659B460 ModelClassType CharacterBaseSelectView CharacterBaseSelectView CharacterBaseSelectView Pointer
    // 028 TitleView                                0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer
    public partial class CharacterBaseSelectBuilder : DataModel
    {
        public CharacterBaseSelectView?                 View                                    { get; set; }
        public CommonTitleView?                         TitleView                               { get; set; }

        public static CharacterBaseSelectBuilder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterBaseSelectBuilder() { Pointer= p0 };

            value.View                                      = GetObject<CharacterBaseSelectView>(new IntPtr(p + 0x020), ReversePrism.DataModels.CharacterBaseSelectView.FromPointer); // 02466B66B750 0x20 View                        ( 00018659B460 ModelClassType CharacterBaseSelectView CharacterBaseSelectView CharacterBaseSelectView Pointer )
            value.TitleView                                 = GetObject<CommonTitleView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommonTitleView.FromPointer); // 02466B66B770 0x28 TitleView                   ( 0001865E9D00 ModelClassType CommonTitleView CommonTitleView CommonTitleView Pointer )

            return value;
        }
    }
}
