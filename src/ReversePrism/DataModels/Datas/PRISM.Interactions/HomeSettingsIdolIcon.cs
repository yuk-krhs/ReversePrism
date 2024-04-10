using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 BaseIcon                                 000186599240 ModelClassType CharacterBaseIcon CharacterBaseIcon CharacterBaseIcon Pointer
    // 028 SelectedCursorObject                     0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 SettingsPanelObject                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class HomeSettingsIdolIcon : DataModel
    {
        public CharacterBaseIcon?                       BaseIcon                                { get; set; }
        public GameObject?                              SelectedCursorObject                    { get; set; }
        public GameObject?                              SettingsPanelObject                     { get; set; }

        public static HomeSettingsIdolIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeSettingsIdolIcon() { Pointer= p0 };

            value.BaseIcon                                  = GetObject<CharacterBaseIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.CharacterBaseIcon.FromPointer); // 02466B59F8F0 0x20 BaseIcon                    ( 000186599240 ModelClassType CharacterBaseIcon CharacterBaseIcon CharacterBaseIcon Pointer )
            value.SelectedCursorObject                      = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 02466B59F910 0x28 SelectedCursorObject        ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SettingsPanelObject                       = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466B59F930 0x30 SettingsPanelObject         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
