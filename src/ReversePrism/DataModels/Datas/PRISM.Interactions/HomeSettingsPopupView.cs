using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IdolCheckButtonGroup                     000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 028 IdolIconContents                         000185B851B0 ModelClassListType HomeSettingsIdolIconContent[] HomeSettingsIdolIconContent[] List<HomeSettingsIdolIconContent> Pointer
    // 030 ButtonSave                               0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 038 ButtonClose                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 PopupFrame                               0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    // 048 ViewModel                                0001866D0370 ModelClassType HomeSettingsViewModel HomeSettingsViewModel HomeSettingsViewModel Pointer
    // 050 onCloseButton                            Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 onSaveButton                             Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 onSaveError                              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 068 onChangeCharacter                        Subject`1<ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 070 onChangeDrawType                         Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 078 onSelectClothesConfirmPopup              Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 080 onSelectIdolButton                       Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 088 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class HomeSettingsPopupView
    {
        public ToggleButtonGroup?                       IdolCheckButtonGroup                    { get; set; }
        public List<HomeSettingsIdolIconContent>?       IdolIconContents                        { get; set; }
        public UIButton?                                ButtonSave                              { get; set; }
        public UIButton?                                ButtonClose                             { get; set; }
        public IPopupFrameView?                         PopupFrame                              { get; set; }
        public HomeSettingsViewModel?                   ViewModel                               { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static HomeSettingsPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeSettingsPopupView();

            value.IdolCheckButtonGroup                      = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0270DB5326B8 0x20 IdolCheckButtonGroup        ( 000186684350 ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.IdolIconContents                          = GetObjectList<HomeSettingsIdolIconContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.HomeSettingsIdolIconContent.FromPointer); // 0270DB5326D8 0x28 IdolIconContents            ( 000185B851B0 ModelClassListType HomeSettingsIdolIconContent[] HomeSettingsIdolIconContent[] List<HomeSettingsIdolIconContent> Pointer )
            value.ButtonSave                                = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB5326F8 0x30 ButtonSave                  ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ButtonClose                               = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270DB532718 0x38 ButtonClose                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.PopupFrame                                = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB532738 0x40 PopupFrame                  ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )
            value.ViewModel                                 = GetObject<HomeSettingsViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.HomeSettingsViewModel.FromPointer); // 0270DB532758 0x48 ViewModel                   ( 0001866D0370 ModelClassType HomeSettingsViewModel HomeSettingsViewModel HomeSettingsViewModel Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x088), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270DB532858 0x88 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
