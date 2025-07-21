using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 SkillNodeListParent                      ModelClassType Transform Transform Transform Pointer
    // 068 SkillNodePrefab                          ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer
    // 070 ScrollView                               ModelClassType GameObject GameObject GameObject Pointer
    // 078 EmptyText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 080 NumText                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 Prm                                      ModelClassType SupportSkillListPopupContentParam SupportSkillListPopupContentParam SupportSkillListPopupContentParam Pointer
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

            value.SkillNodeListParent                       = GetObject<Transform>(new IntPtr(p + 0x060), ReversePrism.DataModels.Transform.FromPointer); // 0x60 SkillNodeListParent         ( ModelClassType Transform Transform Transform Pointer )
            value.SkillNodePrefab                           = GetObject<SupportSkillNode>(new IntPtr(p + 0x068), ReversePrism.DataModels.SupportSkillNode.FromPointer); // 0x68 SkillNodePrefab             ( ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer )
            value.ScrollView                                = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 ScrollView                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EmptyText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x078), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x78 EmptyText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NumText                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 NumText                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Prm                                       = GetObject<SupportSkillListPopupContentParam>(new IntPtr(p + 0x088), ReversePrism.DataModels.SupportSkillListPopupContentParam.FromPointer); // 0x88 Prm                         ( ModelClassType SupportSkillListPopupContentParam SupportSkillListPopupContentParam SupportSkillListPopupContentParam Pointer )

            return value;
        }
    }
}
