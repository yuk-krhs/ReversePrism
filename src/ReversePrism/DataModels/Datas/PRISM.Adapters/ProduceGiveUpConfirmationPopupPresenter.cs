using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001865E8310 ModelClassType IProduceGiveUpConfirmationPopupView IProduceGiveUpConfirmationPopupView IProduceGiveUpConfirmationPopupView Pointer
    // 018 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 020 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 028 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 030 IsGiveup                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 IsIngame                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 032 IsEnd                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 onGiveupResult                           Action`1<bool> IL2CPP_TYPE_GENERICINST
    public partial class ProduceGiveUpConfirmationPopupPresenter
    {
        public IProduceGiveUpConfirmationPopupView?     View                                    { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
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
            var value   = new ProduceGiveUpConfirmationPopupPresenter();

            value.View                                      = GetObject<IProduceGiveUpConfirmationPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceGiveUpConfirmationPopupView.FromPointer); // 0270D6526B80 0x10 View                        ( 0001865E8310 ModelClassType IProduceGiveUpConfirmationPopupView IProduceGiveUpConfirmationPopupView IProduceGiveUpConfirmationPopupView Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x018), ReversePrism.DataModels.IResourceTag.FromPointer); // 0270D6526BA0 0x18 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x020)); // 0270D6526BC0 0x20 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D6526BE0 0x28 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.IsGiveup                                  = GetBool(new IntPtr(p + 0x030)); // 0270D6526C00 0x30 IsGiveup                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsIngame                                  = GetBool(new IntPtr(p + 0x031)); // 0270D6526C20 0x31 IsIngame                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsEnd                                     = GetBool(new IntPtr(p + 0x032)); // 0270D6526C40 0x32 IsEnd                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
