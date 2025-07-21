using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 BehindBackground                         ModelClassType Transform Transform Transform Pointer
    // 068 Backgrounds                              ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 070 BeforeBackground                         ModelClassType Transform Transform Transform Pointer
    // 078 RateView                                 ModelClassType MusicRateView MusicRateView MusicRateView Pointer
    // 080 RewardIconContainer                      ModelClassType Transform Transform Transform Pointer
    // 088 RewardIconBase                           ModelClassType RewardItem RewardItem RewardItem Pointer
    // 090 PostUnlockShinyBackground                ModelClassType GameObject GameObject GameObject Pointer
    public partial class MusicRateRewardListCell : DataModel
    {
        public Transform?                               BehindBackground                        { get; set; }
        public List<GameObject>?                        Backgrounds                             { get; set; }
        public Transform?                               BeforeBackground                        { get; set; }
        public MusicRateView?                           RateView                                { get; set; }
        public Transform?                               RewardIconContainer                     { get; set; }
        public RewardItem?                              RewardIconBase                          { get; set; }
        public GameObject?                              PostUnlockShinyBackground               { get; set; }

        public static MusicRateRewardListCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRateRewardListCell() { Pointer= p0 };

            value.BehindBackground                          = GetObject<Transform>(new IntPtr(p + 0x060), ReversePrism.DataModels.Transform.FromPointer); // 0x60 BehindBackground            ( ModelClassType Transform Transform Transform Pointer )
            value.Backgrounds                               = GetObjectList<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 Backgrounds                 ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.BeforeBackground                          = GetObject<Transform>(new IntPtr(p + 0x070), ReversePrism.DataModels.Transform.FromPointer); // 0x70 BeforeBackground            ( ModelClassType Transform Transform Transform Pointer )
            value.RateView                                  = GetObject<MusicRateView>(new IntPtr(p + 0x078), ReversePrism.DataModels.MusicRateView.FromPointer); // 0x78 RateView                    ( ModelClassType MusicRateView MusicRateView MusicRateView Pointer )
            value.RewardIconContainer                       = GetObject<Transform>(new IntPtr(p + 0x080), ReversePrism.DataModels.Transform.FromPointer); // 0x80 RewardIconContainer         ( ModelClassType Transform Transform Transform Pointer )
            value.RewardIconBase                            = GetObject<RewardItem>(new IntPtr(p + 0x088), ReversePrism.DataModels.RewardItem.FromPointer); // 0x88 RewardIconBase              ( ModelClassType RewardItem RewardItem RewardItem Pointer )
            value.PostUnlockShinyBackground                 = GetObject<GameObject>(new IntPtr(p + 0x090), ReversePrism.DataModels.GameObject.FromPointer); // 0x90 PostUnlockShinyBackground   ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
