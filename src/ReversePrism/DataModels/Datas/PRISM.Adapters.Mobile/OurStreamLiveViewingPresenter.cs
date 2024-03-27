using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 RewindValue                              float IL2CPP_TYPE_R4
    // 000 FastforwardValue                         float IL2CPP_TYPE_R4
    // 010 Argument                                 0001866FACE0 ModelClassType OurstreamLiveViewingArgument OurstreamLiveViewingArgument OurstreamLiveViewingArgument Pointer
    // 018 View                                     0001865CB8C0 ModelClassType IOurStreamLiveViewingView IOurStreamLiveViewingView IOurStreamLiveViewingView Pointer
    // 020 reconnectingPopupViewFactory             IPopupViewFactory`1<IOurStreamLiveReconnectingPopupView> IL2CPP_TYPE_GENERICINST
    // 028 Disposable                               0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 030 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 ReconnectPopupPresenter                  0001866F4F60 ModelClassType OurStreamLiveReconnectingPopupPresenter OurStreamLiveReconnectingPopupPresenter OurStreamLiveReconnectingPopupPresenter Pointer
    // 040 IsShowErrorPopup                         000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class OurStreamLiveViewingPresenter
    {
        public OurstreamLiveViewingArgument?            Argument                                { get; set; }
        public IOurStreamLiveViewingView?               View                                    { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public OurStreamLiveReconnectingPopupPresenter? ReconnectPopupPresenter                 { get; set; }
        public bool                                     IsShowErrorPopup                        { get; set; }

        public static OurStreamLiveViewingPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OurStreamLiveViewingPresenter();

            value.Argument                                  = GetObject<OurstreamLiveViewingArgument>(new IntPtr(p + 0x010), ReversePrism.DataModels.OurstreamLiveViewingArgument.FromPointer); // 0270D68A28C8 0x10 Argument                    ( 0001866FACE0 ModelClassType OurstreamLiveViewingArgument OurstreamLiveViewingArgument OurstreamLiveViewingArgument Pointer )
            value.View                                      = GetObject<IOurStreamLiveViewingView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IOurStreamLiveViewingView.FromPointer); // 0270D68A28E8 0x18 View                        ( 0001865CB8C0 ModelClassType IOurStreamLiveViewingView IOurStreamLiveViewingView IOurStreamLiveViewingView Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D68A2928 0x28 Disposable                  ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D68A2948 0x30 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.ReconnectPopupPresenter                   = GetObject<OurStreamLiveReconnectingPopupPresenter>(new IntPtr(p + 0x038), ReversePrism.DataModels.OurStreamLiveReconnectingPopupPresenter.FromPointer); // 0270D68A2968 0x38 ReconnectPopupPresenter     ( 0001866F4F60 ModelClassType OurStreamLiveReconnectingPopupPresenter OurStreamLiveReconnectingPopupPresenter OurStreamLiveReconnectingPopupPresenter Pointer )
            value.IsShowErrorPopup                          = GetBool(new IntPtr(p + 0x040)); // 0270D68A2988 0x40 IsShowErrorPopup            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
