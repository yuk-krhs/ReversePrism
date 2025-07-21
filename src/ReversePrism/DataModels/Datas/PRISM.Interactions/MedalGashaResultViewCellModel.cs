using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reward                                   ModelClassType IRewardProductStatus IRewardProductStatus IRewardProductStatus Pointer
    // 018 IsFeatured                               ModelPrimitiveType bool bool bool Bool
    public partial class MedalGashaResultViewCellModel : DataModel
    {
        public IRewardProductStatus?                    Reward                                  { get; set; }
        public bool                                     IsFeatured                              { get; set; }

        public static MedalGashaResultViewCellModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaResultViewCellModel() { Pointer= p0 };

            value.Reward                                    = GetObject<IRewardProductStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IRewardProductStatus.FromPointer); // 0x10 Reward                      ( ModelClassType IRewardProductStatus IRewardProductStatus IRewardProductStatus Pointer )
            value.IsFeatured                                = GetBool(new IntPtr(p + 0x018)); // 0x18 IsFeatured                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
