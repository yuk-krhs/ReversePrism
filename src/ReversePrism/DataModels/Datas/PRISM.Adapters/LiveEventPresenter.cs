using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 018 View                                     000186595FC0 ModelClassType ILiveEventView ILiveEventView ILiveEventView Pointer
    // 020 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 028 rankingFactory                           IOverlayViewFactory`1<ILiveEventRankingOverlayView> IL2CPP_TYPE_GENERICINST
    // 030 bonusFactory                             IOverlayViewFactory`1<ILiveEventBonusOverlayView> IL2CPP_TYPE_GENERICINST
    // 038 shopFactory                              IOverlayViewFactory`1<IShopView> IL2CPP_TYPE_GENERICINST
    // 040 resultFactory                            IPopupViewFactory`1<ILiveEventResultPopupView> IL2CPP_TYPE_GENERICINST
    // 048 saveData                                 SavableJsonObject`1<LiveEventSaveData> IL2CPP_TYPE_GENERICINST
    // 050 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 058 CurrentEventId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 LiveEventModel                           0001865555B0 ModelClassType LiveEventViewModel LiveEventViewModel LiveEventViewModel Pointer
    public partial class LiveEventPresenter
    {
        public CompositeDisposable?                     Disposables                             { get; set; }
        public ILiveEventView?                          View                                    { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public int                                      CurrentEventId                          { get; set; }
        public LiveEventViewModel?                      LiveEventModel                          { get; set; }

        public static LiveEventPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveEventPresenter();

            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x010), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D627EF28 0x10 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.View                                      = GetObject<ILiveEventView>(new IntPtr(p + 0x018), ReversePrism.DataModels.ILiveEventView.FromPointer); // 0270D627EF48 0x18 View                        ( 000186595FC0 ModelClassType ILiveEventView ILiveEventView ILiveEventView Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x020), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270D627EF68 0x20 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x050), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D627F028 0x50 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.CurrentEventId                            = GetInt32(new IntPtr(p + 0x058)); // 0270D627F048 0x58 CurrentEventId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LiveEventModel                            = GetObject<LiveEventViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.LiveEventViewModel.FromPointer); // 0270D627F068 0x60 LiveEventModel              ( 0001865555B0 ModelClassType LiveEventViewModel LiveEventViewModel LiveEventViewModel Pointer )

            return value;
        }
    }
}
