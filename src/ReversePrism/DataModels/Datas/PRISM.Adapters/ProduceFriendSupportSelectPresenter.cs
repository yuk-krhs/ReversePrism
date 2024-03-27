using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001865E7C30 ModelClassType IProduceFriendSupportSelectView IProduceFriendSupportSelectView IProduceFriendSupportSelectView Pointer
    // 018 Argument                                 0001865431B0 ModelClassType ProduceFriendSupportSelectArgument ProduceFriendSupportSelectArgument ProduceFriendSupportSelectArgument Pointer
    // 020 Disposable                               0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 028 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 FriendSupportViewModels                  000185B9CCF0 ModelClassListType ProduceFriendSupportViewModel[] ProduceFriendSupportViewModel[] List<ProduceFriendSupportViewModel> Pointer
    public partial class ProduceFriendSupportSelectPresenter
    {
        public IProduceFriendSupportSelectView?         View                                    { get; set; }
        public ProduceFriendSupportSelectArgument?      Argument                                { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public List<ProduceFriendSupportViewModel>?     FriendSupportViewModels                 { get; set; }

        public static ProduceFriendSupportSelectPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceFriendSupportSelectPresenter();

            value.View                                      = GetObject<IProduceFriendSupportSelectView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceFriendSupportSelectView.FromPointer); // 0270D64D0D58 0x10 View                        ( 0001865E7C30 ModelClassType IProduceFriendSupportSelectView IProduceFriendSupportSelectView IProduceFriendSupportSelectView Pointer )
            value.Argument                                  = GetObject<ProduceFriendSupportSelectArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceFriendSupportSelectArgument.FromPointer); // 0270D64D0D78 0x18 Argument                    ( 0001865431B0 ModelClassType ProduceFriendSupportSelectArgument ProduceFriendSupportSelectArgument ProduceFriendSupportSelectArgument Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D64D0D98 0x20 Disposable                  ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D64D0DB8 0x28 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.FriendSupportViewModels                   = GetObjectList<ProduceFriendSupportViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceFriendSupportViewModel.FromPointer); // 0270D64D0DD8 0x30 FriendSupportViewModels     ( 000185B9CCF0 ModelClassListType ProduceFriendSupportViewModel[] ProduceFriendSupportViewModel[] List<ProduceFriendSupportViewModel> Pointer )

            return value;
        }
    }
}
