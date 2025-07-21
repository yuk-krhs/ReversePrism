using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IDressUpRoomView IDressUpRoomView IDressUpRoomView Pointer
    // 018 CommonUIView                             ModelClassType IDressUpRoomCommonUIView IDressUpRoomCommonUIView IDressUpRoomCommonUIView Pointer
    // 020 DressUpRoom3DViewer                      ModelClassType IDressUpRoom3DViewer IDressUpRoom3DViewer IDressUpRoom3DViewer Pointer
    // 028 Argument                                 ModelClassType DressUpRoomArgument DressUpRoomArgument DressUpRoomArgument Pointer
    // 030 isOverlayShowFunc                        Func`1<bool> IL2CPP_TYPE_GENERICINST
    // 038 saveData                                 SavableJsonObject`1<DressUpRoomSaveData> IL2CPP_TYPE_GENERICINST
    // 040 TopView                                  ModelClassType IDressUpRoomTopView IDressUpRoomTopView IDressUpRoomTopView Pointer
    // 048 CostumeChangeView                        ModelClassType IDressUpRoomCostumeChangeView IDressUpRoomCostumeChangeView IDressUpRoomCostumeChangeView Pointer
    // 050 Model                                    ModelClassType DressUpRoomViewModel DressUpRoomViewModel DressUpRoomViewModel Pointer
    // 058 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 060 MainViewType                             ModelEnumType MainViewType MainViewType MainViewType Int32
    // 068 CostumeChangePresenter                   ModelClassType DressUpRoomCostumeChangePresenter DressUpRoomCostumeChangePresenter DressUpRoomCostumeChangePresenter Pointer
    // 070 IntervalType                             ModelEnumType IntervalType IntervalType IntervalType Int32
    // 078 TopViewCts                               ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 080 AbandonIntervalCts                       ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 088 AutoActionCts                            ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    public partial class DressUpRoomPresenter : DataModel
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
        public IntervalType                             IntervalType                            { get; set; }
        public CancellationTokenSource?                 TopViewCts                              { get; set; }
        public CancellationTokenSource?                 AbandonIntervalCts                      { get; set; }
        public CancellationTokenSource?                 AutoActionCts                           { get; set; }

        public static DressUpRoomPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressUpRoomPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IDressUpRoomView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IDressUpRoomView.FromPointer); // 0x10 View                        ( ModelClassType IDressUpRoomView IDressUpRoomView IDressUpRoomView Pointer )
            value.CommonUIView                              = GetObject<IDressUpRoomCommonUIView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDressUpRoomCommonUIView.FromPointer); // 0x18 CommonUIView                ( ModelClassType IDressUpRoomCommonUIView IDressUpRoomCommonUIView IDressUpRoomCommonUIView Pointer )
            value.DressUpRoom3DViewer                       = GetObject<IDressUpRoom3DViewer>(new IntPtr(p + 0x020), ReversePrism.DataModels.IDressUpRoom3DViewer.FromPointer); // 0x20 DressUpRoom3DViewer         ( ModelClassType IDressUpRoom3DViewer IDressUpRoom3DViewer IDressUpRoom3DViewer Pointer )
            value.Argument                                  = GetObject<DressUpRoomArgument>(new IntPtr(p + 0x028), ReversePrism.DataModels.DressUpRoomArgument.FromPointer); // 0x28 Argument                    ( ModelClassType DressUpRoomArgument DressUpRoomArgument DressUpRoomArgument Pointer )
            value.TopView                                   = GetObject<IDressUpRoomTopView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IDressUpRoomTopView.FromPointer); // 0x40 TopView                     ( ModelClassType IDressUpRoomTopView IDressUpRoomTopView IDressUpRoomTopView Pointer )
            value.CostumeChangeView                         = GetObject<IDressUpRoomCostumeChangeView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IDressUpRoomCostumeChangeView.FromPointer); // 0x48 CostumeChangeView           ( ModelClassType IDressUpRoomCostumeChangeView IDressUpRoomCostumeChangeView IDressUpRoomCostumeChangeView Pointer )
            value.Model                                     = GetObject<DressUpRoomViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.DressUpRoomViewModel.FromPointer); // 0x50 Model                       ( ModelClassType DressUpRoomViewModel DressUpRoomViewModel DressUpRoomViewModel Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x058), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x58 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.MainViewType                              = (MainViewType)GetInt32(new IntPtr(p + 0x060)); // 0x60 MainViewType                ( ModelEnumType MainViewType MainViewType MainViewType Int32 )
            value.CostumeChangePresenter                    = GetObject<DressUpRoomCostumeChangePresenter>(new IntPtr(p + 0x068), ReversePrism.DataModels.DressUpRoomCostumeChangePresenter.FromPointer); // 0x68 CostumeChangePresenter      ( ModelClassType DressUpRoomCostumeChangePresenter DressUpRoomCostumeChangePresenter DressUpRoomCostumeChangePresenter Pointer )
            value.IntervalType                              = (IntervalType)GetInt32(new IntPtr(p + 0x070)); // 0x70 IntervalType                ( ModelEnumType IntervalType IntervalType IntervalType Int32 )
            value.TopViewCts                                = GetObject<CancellationTokenSource>(new IntPtr(p + 0x078), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x78 TopViewCts                  ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.AbandonIntervalCts                        = GetObject<CancellationTokenSource>(new IntPtr(p + 0x080), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x80 AbandonIntervalCts          ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.AutoActionCts                             = GetObject<CancellationTokenSource>(new IntPtr(p + 0x088), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x88 AutoActionCts               ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )

            return value;
        }
    }
}
