using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186723D30 ModelClassType IChallengeTourPIdolSelectPopupView IChallengeTourPIdolSelectPopupView IChallengeTourPIdolSelectPopupView Pointer
    // 018 PIdols                                   000185B88FB0 ModelClassListType IProduceIdolStatus[] IProduceIdolStatus[] List<IProduceIdolStatus> Pointer
    // 020 PIdolIcons                               000185B99FA0 ModelClassListType PIdolIcon[] PIdolIcon[] List<PIdolIcon> Pointer
    // 028 OverlayManager                           0001866FECB0 ModelClassType OverlayManager OverlayManager OverlayManager Pointer
    // 030 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 038 TokenSource                              0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 040 onClose                                  Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ChallengeTourPIdolSelectPopupPresenter
    {
        public IChallengeTourPIdolSelectPopupView?      View                                    { get; set; }
        public List<IProduceIdolStatus>?                PIdols                                  { get; set; }
        public List<PIdolIcon>?                         PIdolIcons                              { get; set; }
        public OverlayManager?                          OverlayManager                          { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }

        public static ChallengeTourPIdolSelectPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChallengeTourPIdolSelectPopupPresenter();

            value.View                                      = GetObject<IChallengeTourPIdolSelectPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IChallengeTourPIdolSelectPopupView.FromPointer); // 0270D649E9F0 0x10 View                        ( 000186723D30 ModelClassType IChallengeTourPIdolSelectPopupView IChallengeTourPIdolSelectPopupView IChallengeTourPIdolSelectPopupView Pointer )
            value.PIdols                                    = GetObjectList<IProduceIdolStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProduceIdolStatus.FromPointer); // 0270D649EA10 0x18 PIdols                      ( 000185B88FB0 ModelClassListType IProduceIdolStatus[] IProduceIdolStatus[] List<IProduceIdolStatus> Pointer )
            value.PIdolIcons                                = GetObjectList<PIdolIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.PIdolIcon.FromPointer); // 0270D649EA30 0x20 PIdolIcons                  ( 000185B99FA0 ModelClassListType PIdolIcon[] PIdolIcon[] List<PIdolIcon> Pointer )
            value.OverlayManager                            = GetObject<OverlayManager>(new IntPtr(p + 0x028), ReversePrism.DataModels.OverlayManager.FromPointer); // 0270D649EA50 0x28 OverlayManager              ( 0001866FECB0 ModelClassType OverlayManager OverlayManager OverlayManager Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x030), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D649EA70 0x30 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x038), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D649EA90 0x38 TokenSource                 ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
