using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StepNumImageList                         000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer
    // 028 StepNumImage                             0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 030 CompleteText                             0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer
    // 038 CompleteRewardListView                   000186542630 ModelClassType SpecialMissionCompleteRewardListView SpecialMissionCompleteRewardListView SpecialMissionCompleteRewardListView Pointer
    // 040 RewardViewCell                           000186542B70 ModelClassType SpecialMissionCompleteRewardListViewCell SpecialMissionCompleteRewardListViewCell SpecialMissionCompleteRewardListViewCell Pointer
    // 048 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 PopupSize                                00018658C440 ModelEnumType PopupSizeType PopupSizeType PopupSizeType Int32
    // 058 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class SpecialMissionCompleteRewardPopupView
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
            var value   = new SpecialMissionCompleteRewardPopupView();

            value.StepNumImageList                          = GetObjectList<Sprite>(new IntPtr(p + 0x020), ReversePrism.DataModels.Sprite.FromPointer); // 0270DBD624E8 0x20 StepNumImageList            ( 000185CA4898 ModelClassListType Sprite[] Sprite[] List<Sprite> Pointer )
            value.StepNumImage                              = GetObject<UIImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIImage.FromPointer); // 0270DBD62508 0x28 StepNumImage                ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.CompleteText                              = GetObject<TextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.TextMeshProUGUI.FromPointer); // 0270DBD62528 0x30 CompleteText                ( 0001866409F0 ModelClassType TextMeshProUGUI TextMeshProUGUI TextMeshProUGUI Pointer )
            value.CompleteRewardListView                    = GetObject<SpecialMissionCompleteRewardListView>(new IntPtr(p + 0x038), ReversePrism.DataModels.SpecialMissionCompleteRewardListView.FromPointer); // 0270DBD62548 0x38 CompleteRewardListView      ( 000186542630 ModelClassType SpecialMissionCompleteRewardListView SpecialMissionCompleteRewardListView SpecialMissionCompleteRewardListView Pointer )
            value.RewardViewCell                            = GetObject<SpecialMissionCompleteRewardListViewCell>(new IntPtr(p + 0x040), ReversePrism.DataModels.SpecialMissionCompleteRewardListViewCell.FromPointer); // 0270DBD62568 0x40 RewardViewCell              ( 000186542B70 ModelClassType SpecialMissionCompleteRewardListViewCell SpecialMissionCompleteRewardListViewCell SpecialMissionCompleteRewardListViewCell Pointer )
            value.PopupSize                                 = (PopupSizeType)GetInt32(new IntPtr(p + 0x050)); // 0270DBD625A8 0x50 PopupSize                   ( 00018658C440 ModelEnumType PopupSizeType PopupSizeType PopupSizeType Int32 )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DBD625C8 0x58 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
