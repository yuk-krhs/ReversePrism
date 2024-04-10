using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001865F6100 ModelClassType IProduceTopMenuBackToHomeConfirmationPopupView IProduceTopMenuBackToHomeConfirmationPopupView IProduceTopMenuBackToHomeConfirmationPopupView Pointer
    // 018 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 020 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 028 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 030 IsBackTohome                             000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ProduceTopMenuBackToHomeConfirmationPopupPresenter : DataModel
    {
        public IProduceTopMenuBackToHomeConfirmationPopupView? View                                    { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public bool                                     IsBackTohome                            { get; set; }

        public static ProduceTopMenuBackToHomeConfirmationPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTopMenuBackToHomeConfirmationPopupPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IProduceTopMenuBackToHomeConfirmationPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceTopMenuBackToHomeConfirmationPopupView.FromPointer); // 024666597370 0x10 View                        ( 0001865F6100 ModelClassType IProduceTopMenuBackToHomeConfirmationPopupView IProduceTopMenuBackToHomeConfirmationPopupView IProduceTopMenuBackToHomeConfirmationPopupView Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x018), ReversePrism.DataModels.IResourceTag.FromPointer); // 024666597390 0x18 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x020)); // 0246665973B0 0x20 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0246665973D0 0x28 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IsBackTohome                              = GetBool(new IntPtr(p + 0x030)); // 0246665973F0 0x30 IsBackTohome                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
