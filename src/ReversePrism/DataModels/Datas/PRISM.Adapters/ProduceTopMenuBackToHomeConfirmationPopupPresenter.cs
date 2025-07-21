using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IProduceTopMenuBackToHomeConfirmationPopupView IProduceTopMenuBackToHomeConfirmationPopupView IProduceTopMenuBackToHomeConfirmationPopupView Pointer
    // 018 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 020 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 028 IsBackTohome                             ModelPrimitiveType bool bool bool Bool
    public partial class ProduceTopMenuBackToHomeConfirmationPopupPresenter : DataModel
    {
        public IProduceTopMenuBackToHomeConfirmationPopupView? View                                    { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public bool                                     IsBackTohome                            { get; set; }

        public static ProduceTopMenuBackToHomeConfirmationPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTopMenuBackToHomeConfirmationPopupPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IProduceTopMenuBackToHomeConfirmationPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceTopMenuBackToHomeConfirmationPopupView.FromPointer); // 0x10 View                        ( ModelClassType IProduceTopMenuBackToHomeConfirmationPopupView IProduceTopMenuBackToHomeConfirmationPopupView IProduceTopMenuBackToHomeConfirmationPopupView Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x018)); // 0x18 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x20 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IsBackTohome                              = GetBool(new IntPtr(p + 0x028)); // 0x28 IsBackTohome                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
