using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IProducePreparationEpisodeSelectBannerView IProducePreparationEpisodeSelectBannerView IProducePreparationEpisodeSelectBannerView Pointer
    // 018 Model                                    ModelClassType ProducePreparationEpisodeSelectBannerModel ProducePreparationEpisodeSelectBannerModel ProducePreparationEpisodeSelectBannerModel Pointer
    // 020 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class ProducePreparationEpisodeSelectBannerPresenter : DataModel
    {
        public IProducePreparationEpisodeSelectBannerView? View                                    { get; set; }
        public ProducePreparationEpisodeSelectBannerModel? Model                                   { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }

        public static ProducePreparationEpisodeSelectBannerPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProducePreparationEpisodeSelectBannerPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IProducePreparationEpisodeSelectBannerView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProducePreparationEpisodeSelectBannerView.FromPointer); // 0x10 View                        ( ModelClassType IProducePreparationEpisodeSelectBannerView IProducePreparationEpisodeSelectBannerView IProducePreparationEpisodeSelectBannerView Pointer )
            value.Model                                     = GetObject<ProducePreparationEpisodeSelectBannerModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProducePreparationEpisodeSelectBannerModel.FromPointer); // 0x18 Model                       ( ModelClassType ProducePreparationEpisodeSelectBannerModel ProducePreparationEpisodeSelectBannerModel ProducePreparationEpisodeSelectBannerModel Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x20 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
