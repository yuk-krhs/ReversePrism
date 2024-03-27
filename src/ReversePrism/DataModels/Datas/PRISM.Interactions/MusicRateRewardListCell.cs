using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 BehindBackground                         0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 048 Backgrounds                              000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 050 BeforeBackground                         0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 058 RateView                                 0001866716D0 ModelClassType MusicRateView MusicRateView MusicRateView Pointer
    // 060 RewardIconContainer                      0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 068 RewardIconBase                           00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer
    public partial class MusicRateRewardListCell
    {
        public Transform?                               BehindBackground                        { get; set; }
        public List<GameObject>?                        Backgrounds                             { get; set; }
        public Transform?                               BeforeBackground                        { get; set; }
        public MusicRateView?                           RateView                                { get; set; }
        public Transform?                               RewardIconContainer                     { get; set; }
        public RewardItem?                              RewardIconBase                          { get; set; }

        public static MusicRateRewardListCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRateRewardListCell();

            value.BehindBackground                          = GetObject<Transform>(new IntPtr(p + 0x040), ReversePrism.DataModels.Transform.FromPointer); // 0270DB3F6768 0x40 BehindBackground            ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.Backgrounds                               = GetObjectList<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB3F6788 0x48 Backgrounds                 ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.BeforeBackground                          = GetObject<Transform>(new IntPtr(p + 0x050), ReversePrism.DataModels.Transform.FromPointer); // 0270DB3F67A8 0x50 BeforeBackground            ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.RateView                                  = GetObject<MusicRateView>(new IntPtr(p + 0x058), ReversePrism.DataModels.MusicRateView.FromPointer); // 0270DB3F67C8 0x58 RateView                    ( 0001866716D0 ModelClassType MusicRateView MusicRateView MusicRateView Pointer )
            value.RewardIconContainer                       = GetObject<Transform>(new IntPtr(p + 0x060), ReversePrism.DataModels.Transform.FromPointer); // 0270DB3F67E8 0x60 RewardIconContainer         ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.RewardIconBase                            = GetObject<RewardItem>(new IntPtr(p + 0x068), ReversePrism.DataModels.RewardItem.FromPointer); // 0270DB3F6808 0x68 RewardIconBase              ( 00018667EAE0 ModelClassType RewardItem RewardItem RewardItem Pointer )

            return value;
        }
    }
}
