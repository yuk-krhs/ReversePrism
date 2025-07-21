using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 FeaturedObject                           ModelClassType GameObject GameObject GameObject Pointer
    // 068 CellPrefab                               ModelClassType MedalGashaRewardAllListCell MedalGashaRewardAllListCell MedalGashaRewardAllListCell Pointer
    // 070 IconArea                                 ModelClassType Transform Transform Transform Pointer
    public partial class MedalGashaRewardAllListRow : DataModel
    {
        public GameObject?                              FeaturedObject                          { get; set; }
        public MedalGashaRewardAllListCell?             CellPrefab                              { get; set; }
        public Transform?                               IconArea                                { get; set; }

        public static MedalGashaRewardAllListRow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaRewardAllListRow() { Pointer= p0 };

            value.FeaturedObject                            = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 FeaturedObject              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CellPrefab                                = GetObject<MedalGashaRewardAllListCell>(new IntPtr(p + 0x068), ReversePrism.DataModels.MedalGashaRewardAllListCell.FromPointer); // 0x68 CellPrefab                  ( ModelClassType MedalGashaRewardAllListCell MedalGashaRewardAllListCell MedalGashaRewardAllListCell Pointer )
            value.IconArea                                  = GetObject<Transform>(new IntPtr(p + 0x070), ReversePrism.DataModels.Transform.FromPointer); // 0x70 IconArea                    ( ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
