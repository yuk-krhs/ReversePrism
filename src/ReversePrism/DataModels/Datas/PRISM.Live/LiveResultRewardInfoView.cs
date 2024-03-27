using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LBMoneyView                              000186576340 ModelClassType LiveRewardLBMoneyView LiveRewardLBMoneyView LiveRewardLBMoneyView Pointer
    // 028 RewardItemPrefab                         000186573C40 ModelClassType LiveResultRewardItem LiveResultRewardItem LiveResultRewardItem Pointer
    // 030 RewardScrollRects                        000185CA2DF8 ModelClassListType ScrollRect[] ScrollRect[] List<ScrollRect> Pointer
    // 038 RewardEmptyObjects                       000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 040 rewardItemDic                            Dictionary`2<LiveResultRewardCategory, List`1<LiveResultRewardItem>> IL2CPP_TYPE_GENERICINST
    public partial class LiveResultRewardInfoView
    {
        public LiveRewardLBMoneyView?                   LBMoneyView                             { get; set; }
        public LiveResultRewardItem?                    RewardItemPrefab                        { get; set; }
        public List<ScrollRect>?                        RewardScrollRects                       { get; set; }
        public List<GameObject>?                        RewardEmptyObjects                      { get; set; }

        public static LiveResultRewardInfoView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultRewardInfoView();

            value.LBMoneyView                               = GetObject<LiveRewardLBMoneyView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveRewardLBMoneyView.FromPointer); // 0270D5252E50 0x20 LBMoneyView                 ( 000186576340 ModelClassType LiveRewardLBMoneyView LiveRewardLBMoneyView LiveRewardLBMoneyView Pointer )
            value.RewardItemPrefab                          = GetObject<LiveResultRewardItem>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveResultRewardItem.FromPointer); // 0270D5252E70 0x28 RewardItemPrefab            ( 000186573C40 ModelClassType LiveResultRewardItem LiveResultRewardItem LiveResultRewardItem Pointer )
            value.RewardScrollRects                         = GetObjectList<ScrollRect>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScrollRect.FromPointer); // 0270D5252E90 0x30 RewardScrollRects           ( 000185CA2DF8 ModelClassListType ScrollRect[] ScrollRect[] List<ScrollRect> Pointer )
            value.RewardEmptyObjects                        = GetObjectList<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5252EB0 0x38 RewardEmptyObjects          ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )

            return value;
        }
    }
}
