using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 SCharaIcon                               0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 048 FriendNameText                           0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 LoginTimeText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 NickNameText                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 CharaNameText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 FollowSignObjects                        000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 070 SkillSlots                               000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 078 SkillSlotLocks                           000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 080 GoodScheduleTypeText                     0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 Disposable                               0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ProduceFriendSupportListViewCell
    {
        public SCharaIconView?                          SCharaIcon                              { get; set; }
        public UITextMeshProUGUI?                       FriendNameText                          { get; set; }
        public UITextMeshProUGUI?                       LoginTimeText                           { get; set; }
        public UITextMeshProUGUI?                       NickNameText                            { get; set; }
        public UITextMeshProUGUI?                       CharaNameText                           { get; set; }
        public List<GameObject>?                        FollowSignObjects                       { get; set; }
        public List<GameObject>?                        SkillSlots                              { get; set; }
        public List<GameObject>?                        SkillSlotLocks                          { get; set; }
        public UITextMeshProUGUI?                       GoodScheduleTypeText                    { get; set; }
        public IDisposable?                             Disposable                              { get; set; }

        public static ProduceFriendSupportListViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceFriendSupportListViewCell();

            value.SCharaIcon                                = GetObject<SCharaIconView>(new IntPtr(p + 0x040), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0270DA0DC970 0x40 SCharaIcon                  ( 0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.FriendNameText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA0DC990 0x48 FriendNameText              ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LoginTimeText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA0DC9B0 0x50 LoginTimeText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NickNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA0DC9D0 0x58 NickNameText                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CharaNameText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA0DC9F0 0x60 CharaNameText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FollowSignObjects                         = GetObjectList<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0DCA10 0x68 FollowSignObjects           ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.SkillSlots                                = GetObjectList<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0DCA30 0x70 SkillSlots                  ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.SkillSlotLocks                            = GetObjectList<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0270DA0DCA50 0x78 SkillSlotLocks              ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.GoodScheduleTypeText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA0DCA70 0x80 GoodScheduleTypeText        ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x088), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DA0DCA90 0x88 Disposable                  ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
