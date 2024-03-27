using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     0001865E2A50 ModelClassType IProduceAutoSettingPopupView IProduceAutoSettingPopupView IProduceAutoSettingPopupView Pointer
    // 018 autoSettingPackage                       SavableJsonObject`1<ProduceAutoSettingModel> IL2CPP_TYPE_GENERICINST
    // 020 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class ProduceAutoSettingPopupPresenter
    {
        public IProduceAutoSettingPopupView?            View                                    { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }

        public static ProduceAutoSettingPopupPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoSettingPopupPresenter();

            value.View                                      = GetObject<IProduceAutoSettingPopupView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceAutoSettingPopupView.FromPointer); // 0270D6450DE8 0x10 View                        ( 0001865E2A50 ModelClassType IProduceAutoSettingPopupView IProduceAutoSettingPopupView IProduceAutoSettingPopupView Pointer )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x020), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0270D6450E28 0x20 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
