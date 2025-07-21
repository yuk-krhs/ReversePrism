using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 SortFilterTabGroup                       ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer
    // 068 SortView                                 ModelClassType GameObject GameObject GameObject Pointer
    // 070 DisplayOrderToggleButtonGroup            ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 078 FilterView                               ModelClassType GameObject GameObject GameObject Pointer
    // 080 FavoriteToggleButtonGroup                ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 088 FavoriteGroupNames                       ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer
    // 090 ClearStatusToggleButtonGroup             ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 098 RecordVersionToggleButtons               ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 0A0 BackgroundModeToggleButtons              ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer
    // 0A8 FilterResetButton                        ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 0B0 ShinyLockedButton                        ModelClassType UIButton UIButton UIButton Pointer
    public partial class MusicSearchPopupContent : DataModel
    {
        public UITabGroupEx?                            SortFilterTabGroup                      { get; set; }
        public GameObject?                              SortView                                { get; set; }
        public ToggleButtonGroup?                       DisplayOrderToggleButtonGroup           { get; set; }
        public GameObject?                              FilterView                              { get; set; }
        public ToggleButtonGroup?                       FavoriteToggleButtonGroup               { get; set; }
        public List<UITextMeshProUGUI>?                 FavoriteGroupNames                      { get; set; }
        public ToggleButtonGroup?                       ClearStatusToggleButtonGroup            { get; set; }
        public List<ToggleButton>?                      RecordVersionToggleButtons              { get; set; }
        public List<ToggleButton>?                      BackgroundModeToggleButtons             { get; set; }
        public ButtonBase?                              FilterResetButton                       { get; set; }
        public UIButton?                                ShinyLockedButton                       { get; set; }

        public static MusicSearchPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicSearchPopupContent() { Pointer= p0 };

            value.SortFilterTabGroup                        = GetObject<UITabGroupEx>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITabGroupEx.FromPointer); // 0x60 SortFilterTabGroup          ( ModelClassType UITabGroupEx UITabGroupEx UITabGroupEx Pointer )
            value.SortView                                  = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 SortView                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.DisplayOrderToggleButtonGroup             = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x70 DisplayOrderToggleButtonGroup ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.FilterView                                = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 FilterView                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.FavoriteToggleButtonGroup                 = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x080), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x80 FavoriteToggleButtonGroup   ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.FavoriteGroupNames                        = GetObjectList<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 FavoriteGroupNames          ( ModelClassListType UITextMeshProUGUI[] UITextMeshProUGUI[] List<UITextMeshProUGUI> Pointer )
            value.ClearStatusToggleButtonGroup              = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x090), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x90 ClearStatusToggleButtonGroup ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.RecordVersionToggleButtons                = GetObjectList<ToggleButton>(new IntPtr(p + 0x098), ReversePrism.DataModels.ToggleButton.FromPointer); // 0x98 RecordVersionToggleButtons  ( ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.BackgroundModeToggleButtons               = GetObjectList<ToggleButton>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.ToggleButton.FromPointer); // 0xA0 BackgroundModeToggleButtons ( ModelClassListType ToggleButton[] ToggleButton[] List<ToggleButton> Pointer )
            value.FilterResetButton                         = GetObject<ButtonBase>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ButtonBase.FromPointer); // 0xA8 FilterResetButton           ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.ShinyLockedButton                         = GetObject<UIButton>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.UIButton.FromPointer); // 0xB0 ShinyLockedButton           ( ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
