using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ViewModel                                00018653AA70 ModelClassType ProduceConfirmViewModel ProduceConfirmViewModel ProduceConfirmViewModel Pointer
    // 018 EpisodeSelectModel                       00018651FD70 ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer
    // 020 SubSeasonDetailViewModel                 0001865D4BF0 ModelClassType SubSeasonDetailContentViewModel SubSeasonDetailContentViewModel SubSeasonDetailContentViewModel Pointer
    // 028 ViewIdolSelectModel                      000186521780 ModelClassType ViewProducePreparationIdolSelectModel ViewProducePreparationIdolSelectModel ViewProducePreparationIdolSelectModel Pointer
    // 030 View                                     0001865E56B0 ModelClassType IProduceConfirmView IProduceConfirmView IProduceConfirmView Pointer
    // 038 ResourceLoader                           00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    // 040 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 048 CancellationTokenSource                  0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class ProduceConfirmPresenter : DataModel
    {
        public ProduceConfirmViewModel?                 ViewModel                               { get; set; }
        public ViewProducePreparationEpisodeSelectModel? EpisodeSelectModel                      { get; set; }
        public SubSeasonDetailContentViewModel?         SubSeasonDetailViewModel                { get; set; }
        public ViewProducePreparationIdolSelectModel?   ViewIdolSelectModel                     { get; set; }
        public IProduceConfirmView?                     View                                    { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CancellationTokenSource?                 CancellationTokenSource                 { get; set; }

        public static ProduceConfirmPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceConfirmPresenter() { Pointer= p0 };

            value.ViewModel                                 = GetObject<ProduceConfirmViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceConfirmViewModel.FromPointer); // 0246665CA048 0x10 ViewModel                   ( 00018653AA70 ModelClassType ProduceConfirmViewModel ProduceConfirmViewModel ProduceConfirmViewModel Pointer )
            value.EpisodeSelectModel                        = GetObject<ViewProducePreparationEpisodeSelectModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ViewProducePreparationEpisodeSelectModel.FromPointer); // 0246665CA068 0x18 EpisodeSelectModel          ( 00018651FD70 ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer )
            value.SubSeasonDetailViewModel                  = GetObject<SubSeasonDetailContentViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.SubSeasonDetailContentViewModel.FromPointer); // 0246665CA088 0x20 SubSeasonDetailViewModel    ( 0001865D4BF0 ModelClassType SubSeasonDetailContentViewModel SubSeasonDetailContentViewModel SubSeasonDetailContentViewModel Pointer )
            value.ViewIdolSelectModel                       = GetObject<ViewProducePreparationIdolSelectModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ViewProducePreparationIdolSelectModel.FromPointer); // 0246665CA0A8 0x28 ViewIdolSelectModel         ( 000186521780 ModelClassType ViewProducePreparationIdolSelectModel ViewProducePreparationIdolSelectModel ViewProducePreparationIdolSelectModel Pointer )
            value.View                                      = GetObject<IProduceConfirmView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProduceConfirmView.FromPointer); // 0246665CA0C8 0x30 View                        ( 0001865E56B0 ModelClassType IProduceConfirmView IProduceConfirmView IProduceConfirmView Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x038), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0246665CA0E8 0x38 ResourceLoader              ( 00018661A8D0 ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x040), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0246665CA108 0x40 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.CancellationTokenSource                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x048), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0246665CA128 0x48 CancellationTokenSource     ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
