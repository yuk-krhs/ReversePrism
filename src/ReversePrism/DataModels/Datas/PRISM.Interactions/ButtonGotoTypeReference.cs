using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 exchangeTopOverlayViewFactory            OverlayViewFactory`1<IExchangeTopOverlayView> IL2CPP_TYPE_GENERICINST
    // 028 shopOverlayViewFactory                   OverlayViewFactory`1<IShopView> IL2CPP_TYPE_GENERICINST
    // 030 seasonMissionOverlayViewFactory          OverlayViewFactory`1<ISeasonMissionView> IL2CPP_TYPE_GENERICINST
    // 038 mobileOverlayViewFactory                 OverlayViewFactory`1<IMobileOverlayView> IL2CPP_TYPE_GENERICINST
    // 040 friendInvitationOverlayViewFactory       OverlayViewFactory`1<IFriendInvitationOverlayView> IL2CPP_TYPE_GENERICINST
    // 048 presentBoxPopupViewFactory               PopupViewFactory`1<IPresentBoxPopupView> IL2CPP_TYPE_GENERICINST
    // 050 friendIDSearchPopupViewFactory           PopupViewFactory`1<IFriendIDSearchPopupView> IL2CPP_TYPE_GENERICINST
    // 058 profileOverlayFactory                    OverlayViewFactory`1<IProfileUserSelfOverlayView> IL2CPP_TYPE_GENERICINST
    // 060 friendOverlayFactory                     OverlayViewFactory`1<IFriendOverlayView> IL2CPP_TYPE_GENERICINST
    // 068 TransferAccount                          000186671910 ModelPrimitiveType string string string String
    // 070 UserSelfProfilePopup                     000186671910 ModelPrimitiveType string string string String
    // 078 ProduceResumePopup                       000186671910 ModelPrimitiveType string string string String
    // 080 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class ButtonGotoTypeReference : DataModel
    {
        public string                                   TransferAccount                         { get; set; }
        public string                                   UserSelfProfilePopup                    { get; set; }
        public string                                   ProduceResumePopup                      { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static ButtonGotoTypeReference? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ButtonGotoTypeReference() { Pointer= p0 };

            value.TransferAccount                           = GetString(new IntPtr(p + 0x068)); // 0245A39733E8 0x68 TransferAccount             ( 000186671910 ModelPrimitiveType string string string String )
            value.UserSelfProfilePopup                      = GetString(new IntPtr(p + 0x070)); // 0245A3973408 0x70 UserSelfProfilePopup        ( 000186671910 ModelPrimitiveType string string string String )
            value.ProduceResumePopup                        = GetString(new IntPtr(p + 0x078)); // 0245A3973428 0x78 ProduceResumePopup          ( 000186671910 ModelPrimitiveType string string string String )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x080), ReversePrism.DataModels.IResourceTag.FromPointer); // 0245A3973448 0x80 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
