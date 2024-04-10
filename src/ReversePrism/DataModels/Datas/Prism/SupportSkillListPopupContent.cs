using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 SkillNodeListParent                      0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 068 SkillNodePrefab                          0001865F52E0 ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer
    // 070 ScrollView                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 EmptyText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 NumText                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 Prm                                      0001865D19F0 ModelClassType SupportSkillListPopupContentParam SupportSkillListPopupContentParam SupportSkillListPopupContentParam Pointer
    public partial class SupportSkillListPopupContent : DataModel
    {
        public Transform?                               SkillNodeListParent                     { get; set; }
        public SupportSkillNode?                        SkillNodePrefab                         { get; set; }
        public GameObject?                              ScrollView                              { get; set; }
        public UITextMeshProUGUI?                       EmptyText                               { get; set; }
        public UITextMeshProUGUI?                       NumText                                 { get; set; }
        public SupportSkillListPopupContentParam?       Prm                                     { get; set; }

        public static SupportSkillListPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportSkillListPopupContent() { Pointer= p0 };

            value.SkillNodeListParent                       = GetObject<Transform>(new IntPtr(p + 0x060), ReversePrism.DataModels.Transform.FromPointer); // 024664D93328 0x60 SkillNodeListParent         ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.SkillNodePrefab                           = GetObject<SupportSkillNode>(new IntPtr(p + 0x068), ReversePrism.DataModels.SupportSkillNode.FromPointer); // 024664D93348 0x68 SkillNodePrefab             ( 0001865F52E0 ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer )
            value.ScrollView                                = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 024664D93368 0x70 ScrollView                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.EmptyText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024664D93388 0x78 EmptyText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NumText                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024664D933A8 0x80 NumText                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Prm                                       = GetObject<SupportSkillListPopupContentParam>(new IntPtr(p + 0x088), ReversePrism.DataModels.SupportSkillListPopupContentParam.FromPointer); // 024664D933C8 0x88 Prm                         ( 0001865D19F0 ModelClassType SupportSkillListPopupContentParam SupportSkillListPopupContentParam SupportSkillListPopupContentParam Pointer )

            return value;
        }
    }
}
