using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 IdolCheckButtonGroup                     ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 028 IdolIconContents                         ModelClassListType HomeSettingsIdolIconContent[] HomeSettingsIdolIconContent[] List<HomeSettingsIdolIconContent> Pointer
    // 030 ButtonSave                               ModelClassType UIButton UIButton UIButton Pointer
    // 038 ButtonClose                              ModelClassType UIButton UIButton UIButton Pointer
    // 040 ViewModel                                ModelClassType HomeSettingsViewModel HomeSettingsViewModel HomeSettingsViewModel Pointer
    // 048 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 050 onClosed                                 Subject`1<ValueTuple`2<bool, Nullable`1<int>>> IL2CPP_TYPE_GENERICINST
    // 058 onSaveError                              Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 onChangeCharacter                        Subject`1<ValueTuple`2<int, int>> IL2CPP_TYPE_GENERICINST
    // 068 onChangeDrawType                         Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 070 onSelectIdolButton                       Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 078 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class HomeSettingsPopupView : DataModel
    {
        public ToggleButtonGroup?                       IdolCheckButtonGroup                    { get; set; }
        public List<HomeSettingsIdolIconContent>?       IdolIconContents                        { get; set; }
        public UIButton?                                ButtonSave                              { get; set; }
        public UIButton?                                ButtonClose                             { get; set; }
        public HomeSettingsViewModel?                   ViewModel                               { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static HomeSettingsPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeSettingsPopupView() { Pointer= p0 };

            value.IdolCheckButtonGroup                      = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x20 IdolCheckButtonGroup        ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.IdolIconContents                          = GetObjectList<HomeSettingsIdolIconContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.HomeSettingsIdolIconContent.FromPointer); // 0x28 IdolIconContents            ( ModelClassListType HomeSettingsIdolIconContent[] HomeSettingsIdolIconContent[] List<HomeSettingsIdolIconContent> Pointer )
            value.ButtonSave                                = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 ButtonSave                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ButtonClose                               = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 ButtonClose                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ViewModel                                 = GetObject<HomeSettingsViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.HomeSettingsViewModel.FromPointer); // 0x40 ViewModel                   ( ModelClassType HomeSettingsViewModel HomeSettingsViewModel HomeSettingsViewModel Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x048), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x48 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x078), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x78 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
