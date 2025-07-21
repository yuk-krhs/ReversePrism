using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IMobileOverlayView IMobileOverlayView IMobileOverlayView Pointer
    // 018 Model                                    ModelClassType MobileOverlayModel MobileOverlayModel MobileOverlayModel Pointer
    // 020 InitScreenParameter                      ModelClassType IMobileScreenParameter IMobileScreenParameter IMobileScreenParameter Pointer
    // 028 pastScreenParameters                     IEnumerable`1<IMobileScreenParameter> IL2CPP_TYPE_GENERICINST
    // 030 ScreenConnector                          ModelClassType MobileScreenConnectorPresenter MobileScreenConnectorPresenter MobileScreenConnectorPresenter Pointer
    // 038 CommonInfoContainer                      ModelClassType MobileScreenCommonInfoContainer MobileScreenCommonInfoContainer MobileScreenCommonInfoContainer Pointer
    // 040 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 048 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 050 onClose                                  Subject`1<MobileOverlayResult> IL2CPP_TYPE_GENERICINST
    // 058 NeedAnimationOnAppear                    ModelPrimitiveType bool bool bool Bool
    public partial class MobileOverlayPresenter : DataModel
    {
        public IMobileOverlayView?                      View                                    { get; set; }
        public MobileOverlayModel?                      Model                                   { get; set; }
        public IMobileScreenParameter?                  InitScreenParameter                     { get; set; }
        public MobileScreenConnectorPresenter?          ScreenConnector                         { get; set; }
        public MobileScreenCommonInfoContainer?         CommonInfoContainer                     { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public bool                                     NeedAnimationOnAppear                   { get; set; }

        public static MobileOverlayPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileOverlayPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IMobileOverlayView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMobileOverlayView.FromPointer); // 0x10 View                        ( ModelClassType IMobileOverlayView IMobileOverlayView IMobileOverlayView Pointer )
            value.Model                                     = GetObject<MobileOverlayModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.MobileOverlayModel.FromPointer); // 0x18 Model                       ( ModelClassType MobileOverlayModel MobileOverlayModel MobileOverlayModel Pointer )
            value.InitScreenParameter                       = GetObject<IMobileScreenParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.IMobileScreenParameter.FromPointer); // 0x20 InitScreenParameter         ( ModelClassType IMobileScreenParameter IMobileScreenParameter IMobileScreenParameter Pointer )
            value.ScreenConnector                           = GetObject<MobileScreenConnectorPresenter>(new IntPtr(p + 0x030), ReversePrism.DataModels.MobileScreenConnectorPresenter.FromPointer); // 0x30 ScreenConnector             ( ModelClassType MobileScreenConnectorPresenter MobileScreenConnectorPresenter MobileScreenConnectorPresenter Pointer )
            value.CommonInfoContainer                       = GetObject<MobileScreenCommonInfoContainer>(new IntPtr(p + 0x038), ReversePrism.DataModels.MobileScreenCommonInfoContainer.FromPointer); // 0x38 CommonInfoContainer         ( ModelClassType MobileScreenCommonInfoContainer MobileScreenCommonInfoContainer MobileScreenCommonInfoContainer Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x040), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x40 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x48 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.NeedAnimationOnAppear                     = GetBool(new IntPtr(p + 0x058)); // 0x58 NeedAnimationOnAppear       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
