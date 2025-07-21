using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ViewModel                                ModelClassType GlobalMenuViewModel GlobalMenuViewModel GlobalMenuViewModel Pointer
    // 018 View                                     ModelClassType IGlobalMenuView IGlobalMenuView IGlobalMenuView Pointer
    // 020 EventListButton                          ModelClassType EventListButtonPresenter EventListButtonPresenter EventListButtonPresenter Pointer
    // 028 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 onCloseEvent                             Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 Service                                  ModelClassType GameService GameService GameService Pointer
    // 048 IsJumpView                               ModelPrimitiveType bool bool bool Bool
    public partial class GlobalMenuPresenter : DataModel
    {
        public GlobalMenuViewModel?                     ViewModel                               { get; set; }
        public IGlobalMenuView?                         View                                    { get; set; }
        public EventListButtonPresenter?                EventListButton                         { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public GameService?                             Service                                 { get; set; }
        public bool                                     IsJumpView                              { get; set; }

        public static GlobalMenuPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlobalMenuPresenter() { Pointer= p0 };

            value.ViewModel                                 = GetObject<GlobalMenuViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.GlobalMenuViewModel.FromPointer); // 0x10 ViewModel                   ( ModelClassType GlobalMenuViewModel GlobalMenuViewModel GlobalMenuViewModel Pointer )
            value.View                                      = GetObject<IGlobalMenuView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IGlobalMenuView.FromPointer); // 0x18 View                        ( ModelClassType IGlobalMenuView IGlobalMenuView IGlobalMenuView Pointer )
            value.EventListButton                           = GetObject<EventListButtonPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.EventListButtonPresenter.FromPointer); // 0x20 EventListButton             ( ModelClassType EventListButtonPresenter EventListButtonPresenter EventListButtonPresenter Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x28 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x30 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Service                                   = GetObject<GameService>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameService.FromPointer); // 0x40 Service                     ( ModelClassType GameService GameService GameService Pointer )
            value.IsJumpView                                = GetBool(new IntPtr(p + 0x048)); // 0x48 IsJumpView                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
