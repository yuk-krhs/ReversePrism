using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IProduceGiveUpConfirmationPopupView IProduceGiveUpConfirmationPopupView IProduceGiveUpConfirmationPopupView Pointer
    // 018 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 020 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 028 IsGiveup                                 ModelPrimitiveType bool bool bool Bool
    // 029 IsIngame                                 ModelPrimitiveType bool bool bool Bool
    // 02A IsEnd                                    ModelPrimitiveType bool bool bool Bool
    // 030 onGiveupResult                           Action`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class ProduceGiveUpConfirmationPopupPresenter : DataModel
    {
        public IProduceGiveUpConfirmationPopupView?     View                                    { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public bool                                     IsGiveup                                { get; set; }
        public bool                                     IsIngame                                { get; set; }
        public bool                                     IsEnd                                   { get; set; }

        public static ProduceGiveUpConfirmationPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceGiveUpConfirmationPopupPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IProduceGiveUpConfirmationPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceGiveUpConfirmationPopupView.FromPointer); // 0x10 View                        ( ModelClassType IProduceGiveUpConfirmationPopupView IProduceGiveUpConfirmationPopupView IProduceGiveUpConfirmationPopupView Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x018)); // 0x18 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x20 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IsGiveup                                  = GetBool(new IntPtr(p + 0x028)); // 0x28 IsGiveup                    ( ModelPrimitiveType bool bool bool Bool )
            value.IsIngame                                  = GetBool(new IntPtr(p + 0x029)); // 0x29 IsIngame                    ( ModelPrimitiveType bool bool bool Bool )
            value.IsEnd                                     = GetBool(new IntPtr(p + 0x02A)); // 0x2A IsEnd                       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
