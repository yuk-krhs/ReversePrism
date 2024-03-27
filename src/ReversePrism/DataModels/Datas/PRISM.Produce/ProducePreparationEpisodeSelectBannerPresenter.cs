using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001865F0820 ModelClassType IProducePreparationEpisodeSelectBannerView IProducePreparationEpisodeSelectBannerView IProducePreparationEpisodeSelectBannerView Pointer
    // 018 Model                                    000186568790 ModelClassType ProducePreparationEpisodeSelectBannerModel ProducePreparationEpisodeSelectBannerModel ProducePreparationEpisodeSelectBannerModel Pointer
    // 020 Disposable                               0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class ProducePreparationEpisodeSelectBannerPresenter
    {
        public IProducePreparationEpisodeSelectBannerView? View                                    { get; set; }
        public ProducePreparationEpisodeSelectBannerModel? Model                                   { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }

        public static ProducePreparationEpisodeSelectBannerPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationEpisodeSelectBannerPresenter();

            value.View                                      = GetObject<IProducePreparationEpisodeSelectBannerView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProducePreparationEpisodeSelectBannerView.FromPointer); // 0270D59DB740 0x10 View                        ( 0001865F0820 ModelClassType IProducePreparationEpisodeSelectBannerView IProducePreparationEpisodeSelectBannerView IProducePreparationEpisodeSelectBannerView Pointer )
            value.Model                                     = GetObject<ProducePreparationEpisodeSelectBannerModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProducePreparationEpisodeSelectBannerModel.FromPointer); // 0270D59DB760 0x18 Model                       ( 000186568790 ModelClassType ProducePreparationEpisodeSelectBannerModel ProducePreparationEpisodeSelectBannerModel ProducePreparationEpisodeSelectBannerModel Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D59DB780 0x20 Disposable                  ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
