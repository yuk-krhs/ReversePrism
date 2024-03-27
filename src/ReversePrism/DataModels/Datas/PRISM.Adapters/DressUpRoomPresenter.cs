using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     000186759C70 ModelClassType IDressUpRoomView IDressUpRoomView IDressUpRoomView Pointer
    // 018 CommonUIView                             0001867581E0 ModelClassType IDressUpRoomCommonUIView IDressUpRoomCommonUIView IDressUpRoomCommonUIView Pointer
    // 020 DressUpRoom3DViewer                      000186757CE0 ModelClassType IDressUpRoom3DViewer IDressUpRoom3DViewer IDressUpRoom3DViewer Pointer
    // 028 Argument                                 0001866FD3E0 ModelClassType DressUpRoomArgument DressUpRoomArgument DressUpRoomArgument Pointer
    // 030 homeSettingIdolSelectPopupViewFactory    IPopupViewFactory`1<IHomeSettingsIdolSelectPopupView> IL2CPP_TYPE_GENERICINST
    // 038 costumeDetailPopupViewFactory            IPopupViewFactory`1<ICostumeDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 040 isOverlayShowFunc                        Func`1<bool> IL2CPP_TYPE_GENERICINST
    // 048 saveData                                 SavableJsonObject`1<DressUpRoomSaveData> IL2CPP_TYPE_GENERICINST
    // 050 TopView                                  000186759790 ModelClassType IDressUpRoomTopView IDressUpRoomTopView IDressUpRoomTopView Pointer
    // 058 CostumeChangeView                        0001867588F0 ModelClassType IDressUpRoomCostumeChangeView IDressUpRoomCostumeChangeView IDressUpRoomCostumeChangeView Pointer
    // 060 Model                                    000186704750 ModelClassType DressUpRoomViewModel DressUpRoomViewModel DressUpRoomViewModel Pointer
    // 068 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 070 MainViewType                             0001865CD6F0 ModelEnumType MainViewType MainViewType MainViewType Int32
    // 078 CostumeChangePresenter                   0001866FE2B0 ModelClassType DressUpRoomCostumeChangePresenter DressUpRoomCostumeChangePresenter DressUpRoomCostumeChangePresenter Pointer
    // 080 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 088 IntervalType                             000186722EA0 ModelEnumType IntervalType IntervalType IntervalType Int32
    // 090 AbandonIntervalCts                       0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 098 AutoActionCts                            0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class DressUpRoomPresenter
    {
        public IDressUpRoomView?                        View                                    { get; set; }
        public IDressUpRoomCommonUIView?                CommonUIView                            { get; set; }
        public IDressUpRoom3DViewer?                    DressUpRoom3DViewer                     { get; set; }
        public DressUpRoomArgument?                     Argument                                { get; set; }
        public IDressUpRoomTopView?                     TopView                                 { get; set; }
        public IDressUpRoomCostumeChangeView?           CostumeChangeView                       { get; set; }
        public DressUpRoomViewModel?                    Model                                   { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public MainViewType                             MainViewType                            { get; set; }
        public DressUpRoomCostumeChangePresenter?       CostumeChangePresenter                  { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public IntervalType                             IntervalType                            { get; set; }
        public CancellationTokenSource?                 AbandonIntervalCts                      { get; set; }
        public CancellationTokenSource?                 AutoActionCts                           { get; set; }

        public static DressUpRoomPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressUpRoomPresenter();

            value.View                                      = GetObject<IDressUpRoomView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IDressUpRoomView.FromPointer); // 0270D622BB10 0x10 View                        ( 000186759C70 ModelClassType IDressUpRoomView IDressUpRoomView IDressUpRoomView Pointer )
            value.CommonUIView                              = GetObject<IDressUpRoomCommonUIView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDressUpRoomCommonUIView.FromPointer); // 0270D622BB30 0x18 CommonUIView                ( 0001867581E0 ModelClassType IDressUpRoomCommonUIView IDressUpRoomCommonUIView IDressUpRoomCommonUIView Pointer )
            value.DressUpRoom3DViewer                       = GetObject<IDressUpRoom3DViewer>(new IntPtr(p + 0x020), ReversePrism.DataModels.IDressUpRoom3DViewer.FromPointer); // 0270D622BB50 0x20 DressUpRoom3DViewer         ( 000186757CE0 ModelClassType IDressUpRoom3DViewer IDressUpRoom3DViewer IDressUpRoom3DViewer Pointer )
            value.Argument                                  = GetObject<DressUpRoomArgument>(new IntPtr(p + 0x028), ReversePrism.DataModels.DressUpRoomArgument.FromPointer); // 0270D622BB70 0x28 Argument                    ( 0001866FD3E0 ModelClassType DressUpRoomArgument DressUpRoomArgument DressUpRoomArgument Pointer )
            value.TopView                                   = GetObject<IDressUpRoomTopView>(new IntPtr(p + 0x050), ReversePrism.DataModels.IDressUpRoomTopView.FromPointer); // 0270D622BC10 0x50 TopView                     ( 000186759790 ModelClassType IDressUpRoomTopView IDressUpRoomTopView IDressUpRoomTopView Pointer )
            value.CostumeChangeView                         = GetObject<IDressUpRoomCostumeChangeView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IDressUpRoomCostumeChangeView.FromPointer); // 0270D622BC30 0x58 CostumeChangeView           ( 0001867588F0 ModelClassType IDressUpRoomCostumeChangeView IDressUpRoomCostumeChangeView IDressUpRoomCostumeChangeView Pointer )
            value.Model                                     = GetObject<DressUpRoomViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.DressUpRoomViewModel.FromPointer); // 0270D622BC50 0x60 Model                       ( 000186704750 ModelClassType DressUpRoomViewModel DressUpRoomViewModel DressUpRoomViewModel Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x068), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D622BC70 0x68 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.MainViewType                              = (MainViewType)GetInt32(new IntPtr(p + 0x070)); // 0270D622BC90 0x70 MainViewType                ( 0001865CD6F0 ModelEnumType MainViewType MainViewType MainViewType Int32 )
            value.CostumeChangePresenter                    = GetObject<DressUpRoomCostumeChangePresenter>(new IntPtr(p + 0x078), ReversePrism.DataModels.DressUpRoomCostumeChangePresenter.FromPointer); // 0270D622BCB0 0x78 CostumeChangePresenter      ( 0001866FE2B0 ModelClassType DressUpRoomCostumeChangePresenter DressUpRoomCostumeChangePresenter DressUpRoomCostumeChangePresenter Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x080), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D622BCD0 0x80 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.IntervalType                              = (IntervalType)GetInt32(new IntPtr(p + 0x088)); // 0270D622BCF0 0x88 IntervalType                ( 000186722EA0 ModelEnumType IntervalType IntervalType IntervalType Int32 )
            value.AbandonIntervalCts                        = GetObject<CancellationTokenSource>(new IntPtr(p + 0x090), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D622BD10 0x90 AbandonIntervalCts          ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.AutoActionCts                             = GetObject<CancellationTokenSource>(new IntPtr(p + 0x098), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D622BD30 0x98 AutoActionCts               ( 0001865A39A0 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
