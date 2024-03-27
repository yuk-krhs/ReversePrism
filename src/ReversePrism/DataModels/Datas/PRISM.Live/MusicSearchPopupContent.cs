using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 SortFilterTabGroup                       0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 068 SortView                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 DisplayOrderToggleButtonGroup            000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 078 FilterView                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 080 FavoriteToggleButtonGroup                000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 088 FavoriteGroupNames                       000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 090 ClearStatusToggleButtonGroup             000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 098 RecordVersionToggleButtons               000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 0A0 FilterResetButton                        000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    public partial class MusicSearchPopupContent
    {
        public UITabGroupEx?                            SortFilterTabGroup                      { get; set; }
        public GameObject?                              SortView                                { get; set; }
        public ToggleButtonGroup?                       DisplayOrderToggleButtonGroup           { get; set; }
        public GameObject?                              FilterView                              { get; set; }
        public ToggleButtonGroup?                       FavoriteToggleButtonGroup               { get; set; }
        public List<UITextMeshProUGUI>?                 FavoriteGroupNames                      { get; set; }
        public ToggleButtonGroup?                       ClearStatusToggleButtonGroup            { get; set; }
        public List<ToggleButton>?                      RecordVersionToggleButtons              { get; set; }
        public ButtonBase?                              FilterResetButton                       { get; set; }

        public static MusicSearchPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicSearchPopupContent();

            value.SortFilterTabGroup                        = GetObject<UITabGroupEx>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0270D515D8D0 0x60 SortFilterTabGroup          ( 0001866F5B90 ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.SortView                                  = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0270D515D8F0 0x68 SortView                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.DisplayOrderToggleButtonGroup             = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0270D515D910 0x70 DisplayOrderToggleButtonGroup ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.FilterView                                = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0270D515D930 0x78 FilterView                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.FavoriteToggleButtonGroup                 = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x080), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0270D515D950 0x80 FavoriteToggleButtonGroup   ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.FavoriteGroupNames                        = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D515D970 0x88 FavoriteGroupNames          ( 000185CAE588 ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.ClearStatusToggleButtonGroup              = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x090), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0270D515D990 0x90 ClearStatusToggleButtonGroup ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.RecordVersionToggleButtons                = GetObjectList<ToggleButton>(new IntPtr(p + 0x098), ReversePrism.DataModels.ToggleButton.FromPointer); // 0270D515D9B0 0x98 RecordVersionToggleButtons  ( 000185CAC208 ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.FilterResetButton                         = GetObject<ButtonBase>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ButtonBase.FromPointer); // 0270D515D9D0 0xA0 FilterResetButton           ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )

            return value;
        }
    }
}
