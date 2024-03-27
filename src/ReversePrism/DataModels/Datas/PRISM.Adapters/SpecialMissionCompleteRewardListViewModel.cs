using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Reward                                   0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer
    // 018 ResourceLoader                           00018661AD70 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class SpecialMissionCompleteRewardListViewModel
    {
        public IProductWithAmountStatus?                Reward                                  { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static SpecialMissionCompleteRewardListViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialMissionCompleteRewardListViewModel();

            value.Reward                                    = GetObject<IProductWithAmountStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0270D6746E10 0x10 Reward                      ( 0001865FA400 ModelClassType IProductWithAmountStatus IProductWithAmountStatus IProductWithAmountStatus Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x018), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0270D6746E30 0x18 ResourceLoader              ( 00018661AD70 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
