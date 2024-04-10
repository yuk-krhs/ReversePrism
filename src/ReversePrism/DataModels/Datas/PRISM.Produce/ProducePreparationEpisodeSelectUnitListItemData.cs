using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EpisodeSelectModel                       000186520270 ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer
    // 018 ListItemModel                            00018656BEE0 ModelClassType ProducePreparationEpisodeSelectUnitEpisodeModel ProducePreparationEpisodeSelectUnitEpisodeModel ProducePreparationEpisodeSelectUnitEpisodeModel Pointer
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

            value.EpisodeSelectModel                        = GetObject<ViewProducePreparationEpisodeSelectModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ViewProducePreparationEpisodeSelectModel.FromPointer); // 024665A56810 0x10 EpisodeSelectModel          ( 000186520270 ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer )
            value.ListItemModel                             = GetObject<ProducePreparationEpisodeSelectUnitEpisodeModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProducePreparationEpisodeSelectUnitEpisodeModel.FromPointer); // 024665A56830 0x18 ListItemModel               ( 00018656BEE0 ModelClassType ProducePreparationEpisodeSelectUnitEpisodeModel ProducePreparationEpisodeSelectUnitEpisodeModel ProducePreparationEpisodeSelectUnitEpisodeModel Pointer )

            return value;
        }
    }
}
