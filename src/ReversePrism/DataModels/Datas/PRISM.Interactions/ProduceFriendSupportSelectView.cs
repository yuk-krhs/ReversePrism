using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ReloadButton                             0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 ReloadButtonAnimator                     0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 030 ListView                                 000186542770 ModelClassType ProduceFriendSupportListView ProduceFriendSupportListView ProduceFriendSupportListView Pointer
    // 038 sCharaDetailPopupViewFactory             SerializableInterface`1<ISCharaDetailPopupViewFactory> IL2CPP_TYPE_GENERICINST
    // 040 profileFriendUserProfilePopupViewFactory PopupViewFactory`1<IProfileFriendUserProfilePopupView> IL2CPP_TYPE_GENERICINST
    // 048 sCharaEditConfirmPopupViewFactory        PopupViewFactory`1<IProduceSCharaEditConfirmPopupView> IL2CPP_TYPE_GENERICINST
    // 050 onClickFriendSupportCell                 Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 058 onClickReloadButton                      Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ProduceFriendSupportSelectView
    {
        public UIButton?                                ReloadButton                            { get; set; }
        public Animator?                                ReloadButtonAnimator                    { get; set; }
        public ProduceFriendSupportListView?            ListView                                { get; set; }

        public static ProduceFriendSupportSelectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceFriendSupportSelectView();

            value.ReloadButton                              = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0270DA0DCD00 0x20 ReloadButton                ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.ReloadButtonAnimator                      = GetObject<Animator>(new IntPtr(p + 0x028), ReversePrism.DataModels.Animator.FromPointer); // 0270DA0DCD20 0x28 ReloadButtonAnimator        ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.ListView                                  = GetObject<ProduceFriendSupportListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceFriendSupportListView.FromPointer); // 0270DA0DCD40 0x30 ListView                    ( 000186542770 ModelClassType ProduceFriendSupportListView ProduceFriendSupportListView ProduceFriendSupportListView Pointer )

            return value;
        }
    }
}
