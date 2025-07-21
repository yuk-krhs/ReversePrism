using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IProduceFriendSupportSelectView IProduceFriendSupportSelectView IProduceFriendSupportSelectView Pointer
    // 018 Argument                                 ModelClassType ProduceFriendSupportSelectArgument ProduceFriendSupportSelectArgument ProduceFriendSupportSelectArgument Pointer
    // 020 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 028 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 FriendSupportViewModels                  ModelClassListType ProduceFriendSupportViewModel[] ProduceFriendSupportViewModel[] List<ProduceFriendSupportViewModel> Pointer
    // 038 ResourceLoader                           ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer
    public partial class ProduceFriendSupportSelectPresenter : DataModel
    {
        public IProduceFriendSupportSelectView?         View                                    { get; set; }
        public ProduceFriendSupportSelectArgument?      Argument                                { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public List<ProduceFriendSupportViewModel>?     FriendSupportViewModels                 { get; set; }
        public IResourceLoader?                         ResourceLoader                          { get; set; }

        public static ProduceFriendSupportSelectPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceFriendSupportSelectPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IProduceFriendSupportSelectView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceFriendSupportSelectView.FromPointer); // 0x10 View                        ( ModelClassType IProduceFriendSupportSelectView IProduceFriendSupportSelectView IProduceFriendSupportSelectView Pointer )
            value.Argument                                  = GetObject<ProduceFriendSupportSelectArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceFriendSupportSelectArgument.FromPointer); // 0x18 Argument                    ( ModelClassType ProduceFriendSupportSelectArgument ProduceFriendSupportSelectArgument ProduceFriendSupportSelectArgument Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x20 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x28 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.FriendSupportViewModels                   = GetObjectList<ProduceFriendSupportViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceFriendSupportViewModel.FromPointer); // 0x30 FriendSupportViewModels     ( ModelClassListType ProduceFriendSupportViewModel[] ProduceFriendSupportViewModel[] List<ProduceFriendSupportViewModel> Pointer )
            value.ResourceLoader                            = GetObject<IResourceLoader>(new IntPtr(p + 0x038), ReversePrism.DataModels.IResourceLoader.FromPointer); // 0x38 ResourceLoader              ( ModelClassType IResourceLoader IResourceLoader IResourceLoader Pointer )

            return value;
        }
    }
}
