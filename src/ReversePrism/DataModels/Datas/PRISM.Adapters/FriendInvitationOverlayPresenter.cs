using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IFriendInvitationOverlayView IFriendInvitationOverlayView IFriendInvitationOverlayView Pointer
    // 018 ViewModel                                ModelClassType FriendInvitationOverlayViewModel FriendInvitationOverlayViewModel FriendInvitationOverlayViewModel Pointer
    // 020 CancellationTokenSource                  ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 028 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
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

            value.View                                      = GetObject<IFriendInvitationOverlayView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IFriendInvitationOverlayView.FromPointer); // 0x10 View                        ( ModelClassType IFriendInvitationOverlayView IFriendInvitationOverlayView IFriendInvitationOverlayView Pointer )
            value.ViewModel                                 = GetObject<FriendInvitationOverlayViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.FriendInvitationOverlayViewModel.FromPointer); // 0x18 ViewModel                   ( ModelClassType FriendInvitationOverlayViewModel FriendInvitationOverlayViewModel FriendInvitationOverlayViewModel Pointer )
            value.CancellationTokenSource                   = GetObject<CancellationTokenSource>(new IntPtr(p + 0x020), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x20 CancellationTokenSource     ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x28 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
