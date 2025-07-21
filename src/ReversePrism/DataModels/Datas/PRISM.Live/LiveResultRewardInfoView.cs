using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 LBMoneyView                              ModelClassType LiveRewardLBMoneyView LiveRewardLBMoneyView LiveRewardLBMoneyView Pointer
    // 028 RewardItemPrefab                         ModelClassType LiveResultRewardItem LiveResultRewardItem LiveResultRewardItem Pointer
    // 030 RewardScrollRects                        ModelClassListType ScrollRect[] ScrollRect[] List<ScrollRect> Pointer
    // 038 RewardEmptyObjects                       ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 040 rewardItemDic                            Dictionary`2<LiveResultRewardCategory, List`1<LiveResultRewardItem>> IL2CPP_TYPE_GENERICINST
    public partial class LiveResultRewardInfoView : DataModel
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
            var value   = new LiveResultRewardInfoView() { Pointer= p0 };

            value.LBMoneyView                               = GetObject<LiveRewardLBMoneyView>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveRewardLBMoneyView.FromPointer); // 0x20 LBMoneyView                 ( ModelClassType LiveRewardLBMoneyView LiveRewardLBMoneyView LiveRewardLBMoneyView Pointer )
            value.RewardItemPrefab                          = GetObject<LiveResultRewardItem>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveResultRewardItem.FromPointer); // 0x28 RewardItemPrefab            ( ModelClassType LiveResultRewardItem LiveResultRewardItem LiveResultRewardItem Pointer )
            value.RewardScrollRects                         = GetObjectList<ScrollRect>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScrollRect.FromPointer); // 0x30 RewardScrollRects           ( ModelClassListType ScrollRect[] ScrollRect[] List<ScrollRect> Pointer )
            value.RewardEmptyObjects                        = GetObjectList<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 RewardEmptyObjects          ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )

            return value;
        }
    }
}
