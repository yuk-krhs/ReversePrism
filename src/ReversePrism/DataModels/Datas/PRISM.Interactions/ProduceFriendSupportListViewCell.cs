using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 SCharaIcon                               ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 048 FriendNameText                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 LoginTimeText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 NickNameText                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 CharaNameText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 FollowSignObjects                        ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 070 SkillSlots                               ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 078 SkillSlotLocks                           ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 080 GoodScheduleTypeText                     ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 Disposable                               ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class ProduceFriendSupportListViewCell : DataModel
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
            var value   = new ProduceFriendSupportListViewCell() { Pointer= p0 };

            value.SCharaIcon                                = GetObject<SCharaIconView>(new IntPtr(p + 0x040), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0x40 SCharaIcon                  ( ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.FriendNameText                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x48 FriendNameText              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LoginTimeText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x50 LoginTimeText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NickNameText                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 NickNameText                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CharaNameText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 CharaNameText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FollowSignObjects                         = GetObjectList<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 FollowSignObjects           ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.SkillSlots                                = GetObjectList<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 SkillSlots                  ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.SkillSlotLocks                            = GetObjectList<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 SkillSlotLocks              ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.GoodScheduleTypeText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 GoodScheduleTypeText        ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Disposable                                = GetObject<IDisposable>(new IntPtr(p + 0x088), ReversePrism.DataModels.IDisposable.FromPointer); // 0x88 Disposable                  ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
