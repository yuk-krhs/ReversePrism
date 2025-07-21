using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Carousel                                 ModelClassType ProducePreparationEpisodeListCarousel ProducePreparationEpisodeListCarousel ProducePreparationEpisodeListCarousel Pointer
    // 028 NextButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 030 PrevButton                               ModelClassType UIButton UIButton UIButton Pointer
    public partial class ProducePreparationEpisodeSelectListView : DataModel
    {
        public ProducePreparationEpisodeListCarousel?   Carousel                                { get; set; }
        public UIButton?                                NextButton                              { get; set; }
        public UIButton?                                PrevButton                              { get; set; }

        public static ProducePreparationEpisodeSelectListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationEpisodeSelectListView() { Pointer= p0 };

            value.Carousel                                  = GetObject<ProducePreparationEpisodeListCarousel>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProducePreparationEpisodeListCarousel.FromPointer); // 0x20 Carousel                    ( ModelClassType ProducePreparationEpisodeListCarousel ProducePreparationEpisodeListCarousel ProducePreparationEpisodeListCarousel Pointer )
            value.NextButton                                = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 NextButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.PrevButton                                = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 PrevButton                  ( ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
