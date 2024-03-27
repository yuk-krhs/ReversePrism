using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     00018656BEC0 ModelClassType IHomeSettingsPopupView IHomeSettingsPopupView IHomeSettingsPopupView Pointer
    // 018 ViewModel                                0001866D0370 ModelClassType HomeSettingsViewModel HomeSettingsViewModel HomeSettingsViewModel Pointer
    // 020 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 028 IdolSelectDisposables                    0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 030 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 pupupFactory                             IPopupViewFactory`1<IHomeSettingsIdolSelectPopupView> IL2CPP_TYPE_GENERICINST
    // 040 onReloadHome                             Func`1<UniTask> IL2CPP_TYPE_GENERICINST
    public partial class HomeSettingsPopupPresenter
    {
        public IHomeSettingsPopupView?                  View                                    { get; set; }
        public HomeSettingsViewModel?                   ViewModel                               { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CompositeDisposable?                     IdolSelectDisposables                   { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }

        public static HomeSettingsPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeSettingsPopupPresenter();

            value.View                                      = GetObject<IHomeSettingsPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IHomeSettingsPopupView.FromPointer); // 0270D63A4028 0x10 View                        ( 00018656BEC0 ModelClassType IHomeSettingsPopupView IHomeSettingsPopupView IHomeSettingsPopupView Pointer )
            value.ViewModel                                 = GetObject<HomeSettingsViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.HomeSettingsViewModel.FromPointer); // 0270D63A4048 0x18 ViewModel                   ( 0001866D0370 ModelClassType HomeSettingsViewModel HomeSettingsViewModel HomeSettingsViewModel Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D63A4068 0x20 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IdolSelectDisposables                     = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D63A4088 0x28 IdolSelectDisposables       ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D63A40A8 0x30 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
