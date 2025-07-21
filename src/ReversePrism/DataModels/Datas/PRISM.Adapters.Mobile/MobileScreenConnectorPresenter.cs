using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 View                                     ModelClassType IMobileScreenConnectorView IMobileScreenConnectorView IMobileScreenConnectorView Pointer
    // 018 Container                                ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer
    // 020 parameterStack                           Stack`1<IMobileScreenParameter> IL2CPP_TYPE_GENERICINST
    // 028 screenPresenters                         Dictionary`2<int, IMobileScreenPresenter> IL2CPP_TYPE_GENERICINST
    // 030 onScreenJumpFinishedSubject              Subject`1<ScreenType> IL2CPP_TYPE_GENERICINST
    // 038 onFinishMobileToJumpView                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 overlayCloser                            Action`1<Action> IL2CPP_TYPE_GENERICINST
    public partial class MobileScreenConnectorPresenter : DataModel
    {
        public IMobileScreenConnectorView?              View                                    { get; set; }
        public IMobileScreenCommonInfoContainer?        Container                               { get; set; }

        public static MobileScreenConnectorPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileScreenConnectorPresenter() { Pointer= p0 };

            value.View                                      = GetObject<IMobileScreenConnectorView>(new IntPtr(p + 0x010), ReversePrism.DataModels.IMobileScreenConnectorView.FromPointer); // 0x10 View                        ( ModelClassType IMobileScreenConnectorView IMobileScreenConnectorView IMobileScreenConnectorView Pointer )
            value.Container                                 = GetObject<IMobileScreenCommonInfoContainer>(new IntPtr(p + 0x018), ReversePrism.DataModels.IMobileScreenCommonInfoContainer.FromPointer); // 0x18 Container                   ( ModelClassType IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer IMobileScreenCommonInfoContainer Pointer )

            return value;
        }
    }
}
