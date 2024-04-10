using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reward                                   00018661FCC0 ModelClassType IRewardProductStatus IRewardProductStatus IRewardProductStatus Pointer
    // 018 IsFeatured                               0001865965D0 ModelPrimitiveType bool bool bool Bool
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

            value.Reward                                    = GetObject<IRewardProductStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IRewardProductStatus.FromPointer); // 02466B9ADE68 0x10 Reward                      ( 00018661FCC0 ModelClassType IRewardProductStatus IRewardProductStatus IRewardProductStatus Pointer )
            value.IsFeatured                                = GetBool(new IntPtr(p + 0x018)); // 02466B9ADE88 0x18 IsFeatured                  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
