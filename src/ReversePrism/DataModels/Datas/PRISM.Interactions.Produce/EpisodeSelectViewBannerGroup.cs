using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 Shifter                                  ModelClassType UIShifter UIShifter UIShifter Pointer
    // 060 ShifterCells                             ModelClassListType EpisodeSelectViewBannerCell[] EpisodeSelectViewBannerCell[] List<EpisodeSelectViewBannerCell> Pointer
    // 068 Indicator                                ModelClassType CarouselIndicator CarouselIndicator CarouselIndicator Pointer
    // 070 onClickCell                              Subject`1<IEpisodeSelectViewBannerCellData> IL2CPP_TYPE_GENERICINST
    public partial class EpisodeSelectViewBannerGroup : DataModel
    {
        public UIShifter?                               Shifter                                 { get; set; }
        public List<EpisodeSelectViewBannerCell>?       ShifterCells                            { get; set; }
        public CarouselIndicator?                       Indicator                               { get; set; }

        public static EpisodeSelectViewBannerGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EpisodeSelectViewBannerGroup() { Pointer= p0 };

            value.Shifter                                   = GetObject<UIShifter>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIShifter.FromPointer); // 0x58 Shifter                     ( ModelClassType UIShifter UIShifter UIShifter Pointer )
            value.ShifterCells                              = GetObjectList<EpisodeSelectViewBannerCell>(new IntPtr(p + 0x060), ReversePrism.DataModels.EpisodeSelectViewBannerCell.FromPointer); // 0x60 ShifterCells                ( ModelClassListType EpisodeSelectViewBannerCell[] EpisodeSelectViewBannerCell[] List<EpisodeSelectViewBannerCell> Pointer )
            value.Indicator                                 = GetObject<CarouselIndicator>(new IntPtr(p + 0x068), ReversePrism.DataModels.CarouselIndicator.FromPointer); // 0x68 Indicator                   ( ModelClassType CarouselIndicator CarouselIndicator CarouselIndicator Pointer )

            return value;
        }
    }
}
