using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SpecialMissionListView                   0001865451D0 ModelClassType SpecialMissionListView SpecialMissionListView SpecialMissionListView Pointer
    // 028 SpecialMissionCompleteRewardView         000186543840 ModelClassType SpecialMissionCompleteRewardView SpecialMissionCompleteRewardView SpecialMissionCompleteRewardView Pointer
    // 030 SpecialMissionTabGroupView               00018654A450 ModelClassType SpecialMissionTabGroupView SpecialMissionTabGroupView SpecialMissionTabGroupView Pointer
    // 038 customPopup                              AssetCollection`1<PopupContentBase> IL2CPP_TYPE_GENERICINST
    // 040 specialMissionHintPopupViewFactory       PopupViewFactory`1<ISpecialMissionHintPopupView> IL2CPP_TYPE_GENERICINST
    // 048 specialMissionCompleteRewardPopupViewFactory PopupViewFactory`1<ISpecialMissionCompleteRewardPopupView> IL2CPP_TYPE_GENERICINST
    // 050 specialMissionAllCompletePopupViewFactory PopupViewFactory`1<ISpecialMissionAllCompletePopupView> IL2CPP_TYPE_GENERICINST
    // 058 AllGetButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 060 CloseButton                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 068 AllGetButtonPositiveObject               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 AllGetButtonBlockObject                  0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 ViewModel                                000186547320 ModelClassType SpecialMissionPopupViewModel SpecialMissionPopupViewModel SpecialMissionPopupViewModel Pointer
    // 080 ResourceLoader                           00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 088 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class SpecialMissionPopupView : DataModel
    {
        public SpecialMissionListView?                  SpecialMissionListView                  { get; set; }
        public SpecialMissionCompleteRewardView?        SpecialMissionCompleteRewardView        { get; set; }
        public SpecialMissionTabGroupView?              SpecialMissionTabGroupView              { get; set; }
        public UIButton?                                AllGetButton                            { get; set; }
        public UIButton?                                CloseButton                             { get; set; }
        public GameObject?                              AllGetButtonPositiveObject              { get; set; }
        public GameObject?                              AllGetButtonBlockObject                 { get; set; }
        public SpecialMissionPopupViewModel?            ViewModel                               { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static SpecialMissionPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialMissionPopupView() { Pointer= p0 };

            value.SpecialMissionListView                    = GetObject<SpecialMissionListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SpecialMissionListView.FromPointer); // 02466BE00090 0x20 SpecialMissionListView      ( 0001865451D0 ModelClassType SpecialMissionListView SpecialMissionListView SpecialMissionListView Pointer )
            value.SpecialMissionCompleteRewardView          = GetObject<SpecialMissionCompleteRewardView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SpecialMissionCompleteRewardView.FromPointer); // 02466BE000B0 0x28 SpecialMissionCompleteRewardView ( 000186543840 ModelClassType SpecialMissionCompleteRewardView SpecialMissionCompleteRewardView SpecialMissionCompleteRewardView Pointer )
            value.SpecialMissionTabGroupView                = GetObject<SpecialMissionTabGroupView>(new IntPtr(p + 0x030), ReversePrism.DataModels.SpecialMissionTabGroupView.FromPointer); // 02466BE000D0 0x30 SpecialMissionTabGroupView  ( 00018654A450 ModelClassType SpecialMissionTabGroupView SpecialMissionTabGroupView SpecialMissionTabGroupView Pointer )
            value.AllGetButton                              = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 02466BE00170 0x58 AllGetButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.CloseButton                               = GetObject<UIButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIButton.FromPointer); // 02466BE00190 0x60 CloseButton                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.AllGetButtonPositiveObject                = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 02466BE001B0 0x68 AllGetButtonPositiveObject  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.AllGetButtonBlockObject                   = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 02466BE001D0 0x70 AllGetButtonBlockObject     ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ViewModel                                 = GetObject<SpecialMissionPopupViewModel>(new IntPtr(p + 0x078), ReversePrism.DataModels.SpecialMissionPopupViewModel.FromPointer); // 02466BE001F0 0x78 ViewModel                   ( 000186547320 ModelClassType SpecialMissionPopupViewModel SpecialMissionPopupViewModel SpecialMissionPopupViewModel Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x080), ReversePrism.DataModels.IResourceLoader.FromPointer); // 02466BE00210 0x80 ResourceLoader              ( 00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x088), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466BE00230 0x88 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
