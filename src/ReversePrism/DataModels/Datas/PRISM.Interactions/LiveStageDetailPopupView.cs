using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MusicTypeIcon                            0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 028 UnitBonusMessage                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 UnitBonusDetail                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 UnitBonusEachCharacterText               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 UnitBonusTargetNumberText                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 UnitBonusDetailSolo                      0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 050 FeaturedRewardScrollRect                 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 058 RareRewardScrollRect                     0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 060 RewardItemBase                           00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    // 068 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 070 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class LiveStageDetailPopupView : DataModel
    {
        public UIRawImage?                              MusicTypeIcon                           { get; set; }
        public UITextMeshProUGUI?                       UnitBonusMessage                        { get; set; }
        public GameObject?                              UnitBonusDetail                         { get; set; }
        public UITextMeshProUGUI?                       UnitBonusEachCharacterText              { get; set; }
        public UITextMeshProUGUI?                       UnitBonusTargetNumberText               { get; set; }
        public GameObject?                              UnitBonusDetailSolo                     { get; set; }
        public ScrollRect?                              FeaturedRewardScrollRect                { get; set; }
        public ScrollRect?                              RareRewardScrollRect                    { get; set; }
        public RewardItem?                              RewardItemBase                          { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static LiveStageDetailPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveStageDetailPopupView() { Pointer= p0 };

            value.MusicTypeIcon                             = GetObject<UIRawImage>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466B48FEE0 0x20 MusicTypeIcon               ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.UnitBonusMessage                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B48FF00 0x28 UnitBonusMessage            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UnitBonusDetail                           = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466B48FF20 0x30 UnitBonusDetail             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.UnitBonusEachCharacterText                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B48FF40 0x38 UnitBonusEachCharacterText  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UnitBonusTargetNumberText                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B48FF60 0x40 UnitBonusTargetNumberText   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.UnitBonusDetailSolo                       = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 02466B48FF80 0x48 UnitBonusDetailSolo         ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.FeaturedRewardScrollRect                  = GetObject<ScrollRect>(new IntPtr(p + 0x050), ReversePrism.DataModels.ScrollRect.FromPointer); // 02466B48FFA0 0x50 FeaturedRewardScrollRect    ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.RareRewardScrollRect                      = GetObject<ScrollRect>(new IntPtr(p + 0x058), ReversePrism.DataModels.ScrollRect.FromPointer); // 02466B48FFC0 0x58 RareRewardScrollRect        ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.RewardItemBase                            = GetObject<RewardItem>(new IntPtr(p + 0x060), ReversePrism.DataModels.RewardItem.FromPointer); // 02466B48FFE0 0x60 RewardItemBase              ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x070), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466B490020 0x70 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
