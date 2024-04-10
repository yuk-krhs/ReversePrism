using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001865B6A90 ModelClassType IMobileOverlayView IMobileOverlayView IMobileOverlayView Pointer
    // 018 Model                                    000186631740 ModelClassType MobileOverlayModel MobileOverlayModel MobileOverlayModel Pointer
    // 020 InitScreenParameter                      0001865B8930 ModelClassType IMobileScreenParameter IMobileScreenParameter IMobileScreenParameter Pointer
    // 028 pastScreenParameters                     IEnumerable`1<IMobileScreenParameter> IL2CPP_TYPE_GENERICINST
    // 030 ScreenConnector                          000186634060 ModelClassType MobileScreenConnectorPresenter MobileScreenConnectorPresenter MobileScreenConnectorPresenter Pointer
    // 038 CommonInfoContainer                      0001866336C0 ModelClassType MobileScreenCommonInfoContainer MobileScreenCommonInfoContainer MobileScreenCommonInfoContainer Pointer
    // 040 TokenSource                              0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 048 Disposable                               0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 050 onClose                                  Subject`1<MobileOverlayResult> IL2CPP_TYPE_GENERICINST
    // 058 NeedAnimationOnAppear                    000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.View                                      = GetObject<IMobileOverlayView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMobileOverlayView.FromPointer); // 02466625CFE8 0x10 View                        ( 0001865B6A90 ModelClassType IMobileOverlayView IMobileOverlayView IMobileOverlayView Pointer )
            value.Model                                     = GetObject<MobileOverlayModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.MobileOverlayModel.FromPointer); // 02466625D008 0x18 Model                       ( 000186631740 ModelClassType MobileOverlayModel MobileOverlayModel MobileOverlayModel Pointer )
            value.InitScreenParameter                       = GetObject<IMobileScreenParameter>(new IntPtr(p + 0x020), ReversePrism.DataModels.IMobileScreenParameter.FromPointer); // 02466625D028 0x20 InitScreenParameter         ( 0001865B8930 ModelClassType IMobileScreenParameter IMobileScreenParameter IMobileScreenParameter Pointer )
            value.ScreenConnector                           = GetObject<MobileScreenConnectorPresenter>(new IntPtr(p + 0x030), ReversePrism.DataModels.MobileScreenConnectorPresenter.FromPointer); // 02466625D068 0x30 ScreenConnector             ( 000186634060 ModelClassType MobileScreenConnectorPresenter MobileScreenConnectorPresenter MobileScreenConnectorPresenter Pointer )
            value.CommonInfoContainer                       = GetObject<MobileScreenCommonInfoContainer>(new IntPtr(p + 0x038), ReversePrism.DataModels.MobileScreenCommonInfoContainer.FromPointer); // 02466625D088 0x38 CommonInfoContainer         ( 0001866336C0 ModelClassType MobileScreenCommonInfoContainer MobileScreenCommonInfoContainer MobileScreenCommonInfoContainer Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x040), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 02466625D0A8 0x40 TokenSource                 ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x048), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 02466625D0C8 0x48 Disposable                  ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.NeedAnimationOnAppear                     = GetBool(new IntPtr(p + 0x058)); // 02466625D108 0x58 NeedAnimationOnAppear       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
