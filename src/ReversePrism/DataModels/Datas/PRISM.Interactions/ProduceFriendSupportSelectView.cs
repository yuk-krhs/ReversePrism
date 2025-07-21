using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ReloadButton                             ModelClassType UIButton UIButton UIButton Pointer
    // 028 ReloadButtonAnimator                     ModelClassType Animator Animator Animator Pointer
    // 030 ListView                                 ModelClassType ProduceFriendSupportListView ProduceFriendSupportListView ProduceFriendSupportListView Pointer
    // 038 onClickFriendSupportCell                 Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 040 onClickReloadButton                      Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ProduceFriendSupportSelectView : DataModel
    {
        public UIButton?                                ReloadButton                            { get; set; }
        public Animator?                                ReloadButtonAnimator                    { get; set; }
        public ProduceFriendSupportListView?            ListView                                { get; set; }

        public static ProduceFriendSupportSelectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceFriendSupportSelectView() { Pointer= p0 };

            value.ReloadButton                              = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 ReloadButton                ( ModelClassType UIButton UIButton UIButton Pointer )
            value.ReloadButtonAnimator                      = GetObject<Animator>(new IntPtr(p + 0x028), ReversePrism.DataModels.Animator.FromPointer); // 0x28 ReloadButtonAnimator        ( ModelClassType Animator Animator Animator Pointer )
            value.ListView                                  = GetObject<ProduceFriendSupportListView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceFriendSupportListView.FromPointer); // 0x30 ListView                    ( ModelClassType ProduceFriendSupportListView ProduceFriendSupportListView ProduceFriendSupportListView Pointer )

            return value;
        }
    }
}
