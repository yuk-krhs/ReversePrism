using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IProduceAutoModeView IProduceAutoModeView IProduceAutoModeView Pointer
    // 018 Argument                                 ModelClassType ProduceAutoModeArgument ProduceAutoModeArgument ProduceAutoModeArgument Pointer
    // 020 autoSettingPackage                       SavableJsonObject`1<ProduceAutoSettingModel> IL2CPP_TYPE_GENERICINST
    // 028 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 030 TokenSource                              ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer
    // 038 FailureResultParam                       ModelClassType LegacyProduceFailureResultParameter LegacyProduceFailureResultParameter LegacyProduceFailureResultParameter Pointer
    // 040 IsShowPopup                              ModelPrimitiveType bool bool bool Bool
    public partial class ProduceAutoModePresenter : DataModel
    {
        public IProduceAutoModeView?                    View                                    { get; set; }
        public ProduceAutoModeArgument?                 Argument                                { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }
        public CancellationTokenSource?                 TokenSource                             { get; set; }
        public LegacyProduceFailureResultParameter?     FailureResultParam                      { get; set; }
        public bool                                     IsShowPopup                             { get; set; }

        public static ProduceAutoModePresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoModePresenter() { Pointer= p0 };

            value.View                                      = GetObject<IProduceAutoModeView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceAutoModeView.FromPointer); // 0x10 View                        ( ModelClassType IProduceAutoModeView IProduceAutoModeView IProduceAutoModeView Pointer )
            value.Argument                                  = GetObject<ProduceAutoModeArgument>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceAutoModeArgument.FromPointer); // 0x18 Argument                    ( ModelClassType ProduceAutoModeArgument ProduceAutoModeArgument ProduceAutoModeArgument Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x28 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.TokenSource                               = GetObject<CancellationTokenSource>(new IntPtr(p + 0x030), ReversePrism.DataModels.CancellationTokenSource.FromPointer); // 0x30 TokenSource                 ( ModelClassType CancellationTokenSource CancellationTokenSource CancellationTokenSource Pointer )
            value.FailureResultParam                        = GetObject<LegacyProduceFailureResultParameter>(new IntPtr(p + 0x038), ReversePrism.DataModels.LegacyProduceFailureResultParameter.FromPointer); // 0x38 FailureResultParam          ( ModelClassType LegacyProduceFailureResultParameter LegacyProduceFailureResultParameter LegacyProduceFailureResultParameter Pointer )
            value.IsShowPopup                               = GetBool(new IntPtr(p + 0x040)); // 0x40 IsShowPopup                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
