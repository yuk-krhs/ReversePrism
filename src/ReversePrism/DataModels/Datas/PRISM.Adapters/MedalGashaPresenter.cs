using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IMedalGashaView IMedalGashaView IMedalGashaView Pointer
    // 018 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 020 saveData                                 SavableJsonObject`1<MedalGashaSaveData> IL2CPP_TYPE_GENERICINST
    // 028 Cts                                      ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 030 CurrentGashaId                           ModelPrimitiveType int int int Int32
    // 034 CurrentEventId                           ModelPrimitiveType int int int Int32
    public partial class MedalGashaPresenter : DataModel
    {
        public IMedalGashaView?                         View                                    { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public CancellationTokenSource?                 Cts                                     { get; set; }
        public int                                      CurrentGashaId                          { get; set; }
        public int                                      CurrentEventId                          { get; set; }

        public static MedalGashaPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IMedalGashaView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMedalGashaView.FromPointer); // 0x10 View                        ( ModelClassType IMedalGashaView IMedalGashaView IMedalGashaView Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x18 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.Cts                                       = GetObject<CancellationTokenSource>(new IntPtr(p + 0x028), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x28 Cts                         ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.CurrentGashaId                            = GetInt32(new IntPtr(p + 0x030)); // 0x30 CurrentGashaId              ( ModelPrimitiveType int int int Int32 )
            value.CurrentEventId                            = GetInt32(new IntPtr(p + 0x034)); // 0x34 CurrentEventId              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
