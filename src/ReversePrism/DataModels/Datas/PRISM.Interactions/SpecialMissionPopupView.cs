using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SpecialMissionListView                   ModelClassType SpecialMissionListView SpecialMissionListView SpecialMissionListView Pointer
    // 028 SpecialMissionCompleteRewardView         ModelClassType SpecialMissionCompleteRewardView SpecialMissionCompleteRewardView SpecialMissionCompleteRewardView Pointer
    // 030 SpecialMissionTabGroupView               ModelClassType SpecialMissionTabGroupView SpecialMissionTabGroupView SpecialMissionTabGroupView Pointer
    // 038 AllGetButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 040 CloseButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 048 AllGetButtonPositiveObject               ModelClassType GameObject GameObject GameObject Pointer
    // 050 AllGetButtonBlockObject                  ModelClassType GameObject GameObject GameObject Pointer
    // 058 ViewModel                                ModelClassType SpecialMissionPopupViewModel SpecialMissionPopupViewModel SpecialMissionPopupViewModel Pointer
    // 060 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 068 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
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

            value.SpecialMissionListView                    = GetObject<SpecialMissionListView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SpecialMissionListView.FromPointer); // 0x20 SpecialMissionListView      ( ModelClassType SpecialMissionListView SpecialMissionListView SpecialMissionListView Pointer )
            value.SpecialMissionCompleteRewardView          = GetObject<SpecialMissionCompleteRewardView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SpecialMissionCompleteRewardView.FromPointer); // 0x28 SpecialMissionCompleteRewardView ( ModelClassType SpecialMissionCompleteRewardView SpecialMissionCompleteRewardView SpecialMissionCompleteRewardView Pointer )
            value.SpecialMissionTabGroupView                = GetObject<SpecialMissionTabGroupView>(new IntPtr(p + 0x030), ReversePrism.DataModels.SpecialMissionTabGroupView.FromPointer); // 0x30 SpecialMissionTabGroupView  ( ModelClassType SpecialMissionTabGroupView SpecialMissionTabGroupView SpecialMissionTabGroupView Pointer )
            value.AllGetButton                              = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0x38 AllGetButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.CloseButton                               = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 CloseButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.AllGetButtonPositiveObject                = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 AllGetButtonPositiveObject  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.AllGetButtonBlockObject                   = GetObject<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0x50 AllGetButtonBlockObject     ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ViewModel                                 = GetObject<SpecialMissionPopupViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.SpecialMissionPopupViewModel.FromPointer); // 0x58 ViewModel                   ( ModelClassType SpecialMissionPopupViewModel SpecialMissionPopupViewModel SpecialMissionPopupViewModel Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x060), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x60 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x068), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x68 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
