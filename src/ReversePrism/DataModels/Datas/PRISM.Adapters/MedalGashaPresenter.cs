using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001865ACCB0 ModelClassType IMedalGashaView IMedalGashaView IMedalGashaView Pointer
    // 018 rankingFactory                           IOverlayViewFactory`1<ILiveEventRankingOverlayView> IL2CPP_TYPE_GENERICINST
    // 020 resultFactory                            IOverlayViewFactory`1<IMedalGashaResultView> IL2CPP_TYPE_GENERICINST
    // 028 Disposables                              0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 030 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 038 saveData                                 SavableJsonObject`1<MedalGashaSaveData> IL2CPP_TYPE_GENERICINST
    // 040 Cts                                      0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 048 CurrentGashaId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 04C CurrentEventId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class MedalGashaPresenter
    {
        public IMedalGashaView?                         View                                    { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public int                                      CurrentGashaId                          { get; set; }
        public int                                      CurrentEventId                          { get; set; }

        public static MedalGashaPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaPresenter();

            value.View                                      = GetObject<IMedalGashaView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMedalGashaView.FromPointer); // 0270D6295000 0x10 View                        ( 0001865ACCB0 ModelClassType IMedalGashaView IMedalGashaView IMedalGashaView Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D6295060 0x28 Disposables                 ( 0001865F38F0 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x030), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270D6295080 0x30 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x040), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0270D62950C0 0x40 Cts                         ( 0001865A4380 ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.CurrentGashaId                            = GetInt32(new IntPtr(p + 0x048)); // 0270D62950E0 0x48 CurrentGashaId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentEventId                            = GetInt32(new IntPtr(p + 0x04C)); // 0270D6295100 0x4C CurrentEventId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
