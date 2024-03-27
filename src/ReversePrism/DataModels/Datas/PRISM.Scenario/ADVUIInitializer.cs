using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AdvChoiceButtonGroupViewModel            000186694710 ModelClassType AdvChoiceButtonGroupViewModel AdvChoiceButtonGroupViewModel AdvChoiceButtonGroupViewModel Pointer
    // 018 AdvScenarioInfo                          0001866EF790 ModelClassType IAdvScenarioInfo IAdvScenarioInfo IAdvScenarioInfo Pointer
    // 020 FavoriteInfo                             0001866957E0 ModelClassType AdvFavoriteInfo AdvFavoriteInfo AdvFavoriteInfo Pointer
    // 028 AdvUI                                    000186669720 ModelClassType ADVUI ADVUI ADVUI Pointer
    public partial class ADVUIInitializer
    {
        public AdvChoiceButtonGroupViewModel?           AdvChoiceButtonGroupViewModel           { get; set; }
        public IAdvScenarioInfo?                        AdvScenarioInfo                         { get; set; }
        public AdvFavoriteInfo?                         FavoriteInfo                            { get; set; }
        public ADVUI?                                   AdvUI                                   { get; set; }

        public static ADVUIInitializer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVUIInitializer();

            value.AdvChoiceButtonGroupViewModel             = GetObject<AdvChoiceButtonGroupViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.AdvChoiceButtonGroupViewModel.FromPointer); // 0270D5DDEA38 0x10 AdvChoiceButtonGroupViewModel ( 000186694710 ModelClassType AdvChoiceButtonGroupViewModel AdvChoiceButtonGroupViewModel AdvChoiceButtonGroupViewModel Pointer )
            value.AdvScenarioInfo                           = GetObject<IAdvScenarioInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.IAdvScenarioInfo.FromPointer); // 0270D5DDEA58 0x18 AdvScenarioInfo             ( 0001866EF790 ModelClassType IAdvScenarioInfo IAdvScenarioInfo IAdvScenarioInfo Pointer )
            value.FavoriteInfo                              = GetObject<AdvFavoriteInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.AdvFavoriteInfo.FromPointer); // 0270D5DDEA78 0x20 FavoriteInfo                ( 0001866957E0 ModelClassType AdvFavoriteInfo AdvFavoriteInfo AdvFavoriteInfo Pointer )
            value.AdvUI                                     = GetObject<ADVUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.ADVUI.FromPointer); // 0270D5DDEA98 0x28 AdvUI                       ( 000186669720 ModelClassType ADVUI ADVUI ADVUI Pointer )

            return value;
        }
    }
}
