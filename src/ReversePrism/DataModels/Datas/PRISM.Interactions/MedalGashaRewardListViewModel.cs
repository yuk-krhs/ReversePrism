using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MedalGashaData                           ModelClassType IFeaturedMedalGashaBoxStatus IFeaturedMedalGashaBoxStatus IFeaturedMedalGashaBoxStatus Pointer
    // 018 IsLoop                                   ModelPrimitiveType bool bool bool Bool
    public partial class MedalGashaRewardListViewModel : DataModel
    {
        public IFeaturedMedalGashaBoxStatus?            MedalGashaData                          { get; set; }
        public bool                                     IsLoop                                  { get; set; }

        public static MedalGashaRewardListViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaRewardListViewModel() { Pointer= p0 };

            value.MedalGashaData                            = GetObject<IFeaturedMedalGashaBoxStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFeaturedMedalGashaBoxStatus.FromPointer); // 0x10 MedalGashaData              ( ModelClassType IFeaturedMedalGashaBoxStatus IFeaturedMedalGashaBoxStatus IFeaturedMedalGashaBoxStatus Pointer )
            value.IsLoop                                    = GetBool(new IntPtr(p + 0x018)); // 0x18 IsLoop                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
