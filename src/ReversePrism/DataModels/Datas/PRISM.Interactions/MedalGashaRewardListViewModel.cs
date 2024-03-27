using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MedalGashaData                           000186776BB0 ModelClassType IFeaturedMedalGashaBoxStatus IFeaturedMedalGashaBoxStatus IFeaturedMedalGashaBoxStatus Pointer
    // 018 IsLoop                                   0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 020 ResourceLoader                           00018661AD70 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class MedalGashaRewardListViewModel
    {
        public IFeaturedMedalGashaBoxStatus?            MedalGashaData                          { get; set; }
        public bool                                     IsLoop                                  { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static MedalGashaRewardListViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaRewardListViewModel();

            value.MedalGashaData                            = GetObject<IFeaturedMedalGashaBoxStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFeaturedMedalGashaBoxStatus.FromPointer); // 0270DB934E08 0x10 MedalGashaData              ( 000186776BB0 ModelClassType IFeaturedMedalGashaBoxStatus IFeaturedMedalGashaBoxStatus IFeaturedMedalGashaBoxStatus Pointer )
            value.IsLoop                                    = GetBool(new IntPtr(p + 0x018)); // 0270DB934E28 0x18 IsLoop                      ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x020), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0270DB934E48 0x20 ResourceLoader              ( 00018661AD70 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
