using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     00018651A920 ModelClassType IFriendInvitationOverlayView IFriendInvitationOverlayView IFriendInvitationOverlayView Pointer
    // 018 ViewModel                                0001865C5770 ModelClassType FriendInvitationOverlayViewModel FriendInvitationOverlayViewModel FriendInvitationOverlayViewModel Pointer
    // 020 CancellationTokenSource                  0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 028 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class FriendInvitationOverlayPresenter : DataModel
    {
        public IFriendInvitationOverlayView?            View                                    { get; set; }
        public FriendInvitationOverlayViewModel?        ViewModel                               { get; set; }
        public CancellationTokenSource?                 CancellationTokenSource                 { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static FriendInvitationOverlayPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FriendInvitationOverlayPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IFriendInvitationOverlayView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFriendInvitationOverlayView.FromPointer); // 0246663AA9B8 0x10 View                        ( 00018651A920 ModelClassType IFriendInvitationOverlayView IFriendInvitationOverlayView IFriendInvitationOverlayView Pointer )
            value.ViewModel                                 = GetObject<FriendInvitationOverlayViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.FriendInvitationOverlayViewModel.FromPointer); // 0246663AA9D8 0x18 ViewModel                   ( 0001865C5770 ModelClassType FriendInvitationOverlayViewModel FriendInvitationOverlayViewModel FriendInvitationOverlayViewModel Pointer )
            value.CancellationTokenSource                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0246663AA9F8 0x20 CancellationTokenSource     ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0246663AAA18 0x28 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
