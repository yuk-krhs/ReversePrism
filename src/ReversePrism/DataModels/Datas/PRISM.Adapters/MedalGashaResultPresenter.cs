using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    0001865E8B60 ModelClassType MedalGashaResultModel MedalGashaResultModel MedalGashaResultModel Pointer
    // 018 View                                     0001865AB6D0 ModelClassType IMedalGashaResultView IMedalGashaResultView IMedalGashaResultView Pointer
    // 020 Disposable                               0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 028 IsSkip                                   000186595480 ModelPrimitiveType bool bool bool Bool
    // 030 AnimationCanceller                       000186724700 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32
    public partial class MedalGashaResultPresenter
    {
        public MedalGashaResultModel?                   Model                                   { get; set; }
        public IMedalGashaResultView?                   View                                    { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public bool                                     IsSkip                                  { get; set; }
        public AutoCancellationTokenSource              AnimationCanceller                      { get; set; }

        public static MedalGashaResultPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaResultPresenter();

            value.Model                                     = GetObject<MedalGashaResultModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.MedalGashaResultModel.FromPointer); // 0270D629F410 0x10 Model                       ( 0001865E8B60 ModelClassType MedalGashaResultModel MedalGashaResultModel MedalGashaResultModel Pointer )
            value.View                                      = GetObject<IMedalGashaResultView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IMedalGashaResultView.FromPointer); // 0270D629F430 0x18 View                        ( 0001865AB6D0 ModelClassType IMedalGashaResultView IMedalGashaResultView IMedalGashaResultView Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D629F450 0x20 Disposable                  ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IsSkip                                    = GetBool(new IntPtr(p + 0x028)); // 0270D629F470 0x28 IsSkip                      ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.AnimationCanceller                        = (AutoCancellationTokenSource)GetInt32(new IntPtr(p + 0x030)); // 0270D629F490 0x30 AnimationCanceller          ( 000186724700 ModelEnumType AutoCancellationTokenSource AutoCancellationTokenSource AutoCancellationTokenSource Int32 )

            return value;
        }
    }
}
