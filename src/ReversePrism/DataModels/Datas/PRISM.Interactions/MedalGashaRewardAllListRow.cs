using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 FeaturedObject                           0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 CellPrefab                               0001865EA790 ModelClassType MedalGashaRewardAllListCell MedalGashaRewardAllListCell MedalGashaRewardAllListCell Pointer
    // 070 IconArea                                 0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class MedalGashaRewardAllListRow
    {
        public GameObject?                              FeaturedObject                          { get; set; }
        public MedalGashaRewardAllListCell?             CellPrefab                              { get; set; }
        public Transform?                               IconArea                                { get; set; }

        public static MedalGashaRewardAllListRow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaRewardAllListRow();

            value.FeaturedObject                            = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB9346C0 0x60 FeaturedObject              ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CellPrefab                                = GetObject<MedalGashaRewardAllListCell>(new IntPtr(p + 0x068), ReversePrism.DataModels.MedalGashaRewardAllListCell.FromPointer); // 0270DB9346E0 0x68 CellPrefab                  ( 0001865EA790 ModelClassType MedalGashaRewardAllListCell MedalGashaRewardAllListCell MedalGashaRewardAllListCell Pointer )
            value.IconArea                                  = GetObject<Transform>(new IntPtr(p + 0x070), ReversePrism.DataModels.Transform.FromPointer); // 0270DB934700 0x70 IconArea                    ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
