using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ViewModel                                00018667E9E0 ModelClassType GlobalMenuViewModel GlobalMenuViewModel GlobalMenuViewModel Pointer
    // 018 View                                     00018655AA90 ModelClassType IGlobalMenuView IGlobalMenuView IGlobalMenuView Pointer
    // 020 EventListButton                          00018675BE10 ModelClassType EventListButtonPresenter EventListButtonPresenter EventListButtonPresenter Pointer
    // 028 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 Disposable                               0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 ItemJumpDisposable                       0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 040 onCloseEvent                             Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 048 Service                                  0001865EBFB0 ModelClassType GameService GameService GameService Pointer
    // 050 IsJumpView                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class GlobalMenuPresenter : DataModel
    {
        public GlobalMenuViewModel?                     ViewModel                               { get; set; }
        public IGlobalMenuView?                         View                                    { get; set; }
        public EventListButtonPresenter?                EventListButton                         { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public IDisposable?                             ItemJumpDisposable                      { get; set; }
        public GameService?                             Service                                 { get; set; }
        public bool                                     IsJumpView                              { get; set; }

        public static GlobalMenuPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlobalMenuPresenter() { Pointer= p0 };

            value.ViewModel                                 = GetObject<GlobalMenuViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.GlobalMenuViewModel.FromPointer); // 0246663C0EA8 0x10 ViewModel                   ( 00018667E9E0 ModelClassType GlobalMenuViewModel GlobalMenuViewModel GlobalMenuViewModel Pointer )
            value.View                                      = GetObject<IGlobalMenuView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IGlobalMenuView.FromPointer); // 0246663C0EC8 0x18 View                        ( 00018655AA90 ModelClassType IGlobalMenuView IGlobalMenuView IGlobalMenuView Pointer )
            value.EventListButton                           = GetObject<EventListButtonPresenter>(new IntPtr(p + 0x020), ReversePrism.DataModels.EventListButtonPresenter.FromPointer); // 0246663C0EE8 0x20 EventListButton             ( 00018675BE10 ModelClassType EventListButtonPresenter EventListButtonPresenter EventListButtonPresenter Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0246663C0F08 0x28 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0246663C0F28 0x30 Disposable                  ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ItemJumpDisposable                        = GetObject<IDisposable>(new IntPtr(p + 0x038), ReversePrism.DataModels.IDisposable.FromPointer); // 0246663C0F48 0x38 ItemJumpDisposable          ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.Service                                   = GetObject<GameService>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameService.FromPointer); // 0246663C0F88 0x48 Service                     ( 0001865EBFB0 ModelClassType GameService GameService GameService Pointer )
            value.IsJumpView                                = GetBool(new IntPtr(p + 0x050)); // 0246663C0FA8 0x50 IsJumpView                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
