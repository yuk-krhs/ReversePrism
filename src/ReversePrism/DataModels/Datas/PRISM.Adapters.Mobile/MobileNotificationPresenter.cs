using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    ModelClassType MobileNotificationModel MobileNotificationModel MobileNotificationModel Pointer
    // 018 View                                     ModelClassType IMobileNotificationView IMobileNotificationView IMobileNotificationView Pointer
    // 020 dataPackage                              SavableJsonObject`1<MobileNotificationPermanentData> IL2CPP_TYPE_GENERICINST
    // 028 Disposable                               ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    public partial class MobileNotificationPresenter : DataModel
    {
        public MobileNotificationModel?                 Model                                   { get; set; }
        public IMobileNotificationView?                 View                                    { get; set; }
        public CompositeDisposable?                     Disposable                              { get; set; }

        public static MobileNotificationPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileNotificationPresenter() { Pointer= p0 };

            value.Model                                     = GetObject<MobileNotificationModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.MobileNotificationModel.FromPointer); // 0x10 Model                       ( ModelClassType MobileNotificationModel MobileNotificationModel MobileNotificationModel Pointer )
            value.View                                      = GetObject<IMobileNotificationView>(new IntPtr(p + 0x018), ReversePrism.DataModels.IMobileNotificationView.FromPointer); // 0x18 View                        ( ModelClassType IMobileNotificationView IMobileNotificationView IMobileNotificationView Pointer )
            value.Disposable                                = GetObject<CompositeDisposable>(new IntPtr(p + 0x028), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x28 Disposable                  ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )

            return value;
        }
    }
}
