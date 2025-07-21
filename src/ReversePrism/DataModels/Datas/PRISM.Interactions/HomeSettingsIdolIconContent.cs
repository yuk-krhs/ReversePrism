using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IdolIcon                                 ModelClassType HomeSettingsIdolIcon HomeSettingsIdolIcon HomeSettingsIdolIcon Pointer
    // 028 RemoveButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 030 SelectClothesButton                      ModelClassType UIButton UIButton UIButton Pointer
    // 038 onClickCharacterIcon                     Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 onClickRemoveButton                      Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 onClickClothesButton                     Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class HomeSettingsIdolIconContent : DataModel
    {
        public HomeSettingsIdolIcon?                    IdolIcon                                { get; set; }
        public UIButton?                                RemoveButton                            { get; set; }
        public UIButton?                                SelectClothesButton                     { get; set; }

        public static HomeSettingsIdolIconContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeSettingsIdolIconContent() { Pointer= p0 };

            value.IdolIcon                                  = GetObject<HomeSettingsIdolIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.HomeSettingsIdolIcon.FromPointer); // 0x20 IdolIcon                    ( ModelClassType HomeSettingsIdolIcon HomeSettingsIdolIcon HomeSettingsIdolIcon Pointer )
            value.RemoveButton                              = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 RemoveButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.SelectClothesButton                       = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 SelectClothesButton         ( ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
