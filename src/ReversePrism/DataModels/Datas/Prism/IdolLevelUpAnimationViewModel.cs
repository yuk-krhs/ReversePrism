using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Idols                                    000185D10038 ModelClassListType IReadOnlyList`1<IdolLevelUpIdolViewModel> IReadOnlyList`1<IdolLevelUpIdolViewModel> List<IdolLevelUpIdolViewModel> Pointer
    // 018 ProductRewards                           000185CE7D98 ModelClassListType List`1<IProductWithAmountStatus> List`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    // 020 idolStoryRewards                         HashSet`1<int> IL2CPP_TYPE_GENERICINST
    public partial class IdolLevelUpAnimationViewModel : DataModel
    {
        public List<IdolLevelUpIdolViewModel>?          Idols                                   { get; set; }
        public List<IProductWithAmountStatus>?          ProductRewards                          { get; set; }

        public static IdolLevelUpAnimationViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolLevelUpAnimationViewModel() { Pointer= p0 };

            value.Idols                                     = GetObjectList<IdolLevelUpIdolViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.IdolLevelUpIdolViewModel.FromPointer); // 024664CACE80 0x10 Idols                       ( 000185D10038 ModelClassListType IReadOnlyList`1<IdolLevelUpIdolViewModel> IReadOnlyList`1<IdolLevelUpIdolViewModel> List<IdolLevelUpIdolViewModel> Pointer )
            value.ProductRewards                            = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 024664CACEA0 0x18 ProductRewards              ( 000185CE7D98 ModelClassListType List`1<IProductWithAmountStatus> List`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )

            return value;
        }
    }
}
