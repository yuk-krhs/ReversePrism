using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StepNumImageList                         ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 028 StepNumImage                             ModelClassType UIImage UIImage UIImage Pointer
    // 030 CompleteText                             ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 038 CompleteRewardListView                   ModelClassType SpecialMissionCompleteRewardListView SpecialMissionCompleteRewardListView SpecialMissionCompleteRewardListView Pointer
    // 040 RewardViewCell                           ModelClassType SpecialMissionCompleteRewardListViewCell SpecialMissionCompleteRewardListViewCell SpecialMissionCompleteRewardListViewCell Pointer
    // 048 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 PopupSize                                ModelEnumType PopupSizeType PopupSizeType PopupSizeType Int32
    // 058 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class SpecialMissionCompleteRewardPopupView : DataModel
    {
        public List<Sprite>?                            StepNumImageList                        { get; set; }
        public UIImage?                                 StepNumImage                            { get; set; }
        public TextMeshProUGUI?                         CompleteText                            { get; set; }
        public SpecialMissionCompleteRewardListView?    CompleteRewardListView                  { get; set; }
        public SpecialMissionCompleteRewardListViewCell? RewardViewCell                          { get; set; }
        public PopupSizeType                            PopupSize                               { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static SpecialMissionCompleteRewardPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialMissionCompleteRewardPopupView() { Pointer= p0 };

            value.StepNumImageList                          = GetObjectList<Sprite>(new IntPtr(p + 0x020), ReversePrism.DataModels.Sprite.FromPointer); // 0x20 StepNumImageList            ( ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.StepNumImage                              = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0x28 StepNumImage                ( ModelClassType UIImage UIImage UIImage Pointer )
            value.CompleteText                              = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0x30 CompleteText                ( ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.CompleteRewardListView                    = GetObject<SpecialMissionCompleteRewardListView>(new IntPtr(p + 0x038), ReversePrism.DataModels.SpecialMissionCompleteRewardListView.FromPointer); // 0x38 CompleteRewardListView      ( ModelClassType SpecialMissionCompleteRewardListView SpecialMissionCompleteRewardListView SpecialMissionCompleteRewardListView Pointer )
            value.RewardViewCell                            = GetObject<SpecialMissionCompleteRewardListViewCell>(new IntPtr(p + 0x040), ReversePrism.DataModels.SpecialMissionCompleteRewardListViewCell.FromPointer); // 0x40 RewardViewCell              ( ModelClassType SpecialMissionCompleteRewardListViewCell SpecialMissionCompleteRewardListViewCell SpecialMissionCompleteRewardListViewCell Pointer )
            value.PopupSize                                 = (PopupSizeType)GetInt32(new IntPtr(p + 0x050)); // 0x50 PopupSize                   ( ModelEnumType PopupSizeType PopupSizeType PopupSizeType Int32 )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x58 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
