using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IAdvMenuView IAdvMenuView IAdvMenuView Pointer
    // 018 AdvScenarioInfo                          ModelClassType IAdvScenarioInfo IAdvScenarioInfo IAdvScenarioInfo Pointer
    // 020 AdvFavoriteStatus                        ModelClassType AdvFavoriteStatus AdvFavoriteStatus AdvFavoriteStatus Pointer
    // 028 OptionButtonContainerViewModel           ModelClassType AdvMenuOptionButtonContainerViewModel AdvMenuOptionButtonContainerViewModel AdvMenuOptionButtonContainerViewModel Pointer
    // 030 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class AdvMenuPresenter : DataModel
    {
        public IAdvMenuView?                            View                                    { get; set; }
        public IAdvScenarioInfo?                        AdvScenarioInfo                         { get; set; }
        public AdvFavoriteStatus?                       AdvFavoriteStatus                       { get; set; }
        public AdvMenuOptionButtonContainerViewModel?   OptionButtonContainerViewModel          { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static AdvMenuPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvMenuPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IAdvMenuView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IAdvMenuView.FromPointer); // 0x10 View                        ( ModelClassType IAdvMenuView IAdvMenuView IAdvMenuView Pointer )
            value.AdvScenarioInfo                           = GetObject<IAdvScenarioInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.IAdvScenarioInfo.FromPointer); // 0x18 AdvScenarioInfo             ( ModelClassType IAdvScenarioInfo IAdvScenarioInfo IAdvScenarioInfo Pointer )
            value.AdvFavoriteStatus                         = GetObject<AdvFavoriteStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.AdvFavoriteStatus.FromPointer); // 0x20 AdvFavoriteStatus           ( ModelClassType AdvFavoriteStatus AdvFavoriteStatus AdvFavoriteStatus Pointer )
            value.OptionButtonContainerViewModel            = GetObject<AdvMenuOptionButtonContainerViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.AdvMenuOptionButtonContainerViewModel.FromPointer); // 0x28 OptionButtonContainerViewModel ( ModelClassType AdvMenuOptionButtonContainerViewModel AdvMenuOptionButtonContainerViewModel AdvMenuOptionButtonContainerViewModel Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x30 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x38 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
