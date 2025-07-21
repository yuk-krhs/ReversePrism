using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EpisodeSelectModel                       ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer
    // 018 ListItemModel                            ModelClassType ProducePreparationEpisodeSelectUnitEpisodeModel ProducePreparationEpisodeSelectUnitEpisodeModel ProducePreparationEpisodeSelectUnitEpisodeModel Pointer
    public partial class ProducePreparationEpisodeSelectUnitListItemData : DataModel
    {
        public ViewProducePreparationEpisodeSelectModel? EpisodeSelectModel                      { get; set; }
        public ProducePreparationEpisodeSelectUnitEpisodeModel? ListItemModel                           { get; set; }

        public static ProducePreparationEpisodeSelectUnitListItemData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationEpisodeSelectUnitListItemData() { Pointer= p0 };

            value.EpisodeSelectModel                        = GetObject<ViewProducePreparationEpisodeSelectModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ViewProducePreparationEpisodeSelectModel.FromPointer); // 0x10 EpisodeSelectModel          ( ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer )
            value.ListItemModel                             = GetObject<ProducePreparationEpisodeSelectUnitEpisodeModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProducePreparationEpisodeSelectUnitEpisodeModel.FromPointer); // 0x18 ListItemModel               ( ModelClassType ProducePreparationEpisodeSelectUnitEpisodeModel ProducePreparationEpisodeSelectUnitEpisodeModel ProducePreparationEpisodeSelectUnitEpisodeModel Pointer )

            return value;
        }
    }
}
