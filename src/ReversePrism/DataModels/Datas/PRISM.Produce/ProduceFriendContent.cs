using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SCharaIcon                               0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer
    // 028 FrinedName                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 LoginTime                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 NickName                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 CharaName                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 FollowSignObjects                        000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 050 SkillSlots                               000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 058 SkillSlotLocks                           000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 060 SelectFrame                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 Button                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    public partial class ProduceFriendContent
    {
        public SCharaIconView?                          SCharaIcon                              { get; set; }
        public UITextMeshProUGUI?                       FrinedName                              { get; set; }
        public UITextMeshProUGUI?                       LoginTime                               { get; set; }
        public UITextMeshProUGUI?                       NickName                                { get; set; }
        public UITextMeshProUGUI?                       CharaName                               { get; set; }
        public List<GameObject>?                        FollowSignObjects                       { get; set; }
        public List<GameObject>?                        SkillSlots                              { get; set; }
        public List<GameObject>?                        SkillSlotLocks                          { get; set; }
        public GameObject?                              SelectFrame                             { get; set; }
        public UIButton?                                Button                                  { get; set; }

        public static ProduceFriendContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceFriendContent();

            value.SCharaIcon                                = GetObject<SCharaIconView>(new IntPtr(p + 0x020), ReversePrism.DataModels.SCharaIconView.FromPointer); // 0270D5A09B18 0x20 SCharaIcon                  ( 0001866ABAC0 ModelClassType SCharaIconView SCharaIconView SCharaIconView Pointer )
            value.FrinedName                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5A09B38 0x28 FrinedName                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.LoginTime                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5A09B58 0x30 LoginTime                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NickName                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5A09B78 0x38 NickName                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CharaName                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5A09B98 0x40 CharaName                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FollowSignObjects                         = GetObjectList<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5A09BB8 0x48 FollowSignObjects           ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.SkillSlots                                = GetObjectList<GameObject>(new IntPtr(p + 0x050), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5A09BD8 0x50 SkillSlots                  ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.SkillSlotLocks                            = GetObjectList<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5A09BF8 0x58 SkillSlotLocks              ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.SelectFrame                               = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5A09C18 0x60 SelectFrame                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5A09C38 0x68 Button                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )

            return value;
        }
    }
}
