using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AssetPath                                string IL2CPP_TYPE_STRING
    // 060 GetSkill                                 ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer
    // 068 SkillNodeListParent                      ModelClassType Transform Transform Transform Pointer
    // 070 SkillNodePrefab                          ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer
    // 078 ScrollView                               ModelClassType GameObject GameObject GameObject Pointer
    // 080 EmptyText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 NumText                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 090 ConfirmSkillListButton                   ModelClassType UIButton UIButton UIButton Pointer
    // 098 IsClose                                  ModelPrimitiveType bool bool bool Bool
    // 099 IsSlotFull                               ModelPrimitiveType bool bool bool Bool
    // 0A0 Prm                                      ModelClassType GetSupportSkillPopupContentParam GetSupportSkillPopupContentParam GetSupportSkillPopupContentParam Pointer
    // 0A8 OptionData                               ModelClassType ProduceOptionSaveData ProduceOptionSaveData ProduceOptionSaveData Pointer
    public partial class GetSupportSkillPopupContent : DataModel
    {
        public SupportSkillNode?                        GetSkill                                { get; set; }
        public Transform?                               SkillNodeListParent                     { get; set; }
        public SupportSkillNode?                        SkillNodePrefab                         { get; set; }
        public GameObject?                              ScrollView                              { get; set; }
        public UITextMeshProUGUI?                       EmptyText                               { get; set; }
        public UITextMeshProUGUI?                       NumText                                 { get; set; }
        public UIButton?                                ConfirmSkillListButton                  { get; set; }
        public bool                                     IsClose                                 { get; set; }
        public bool                                     IsSlotFull                              { get; set; }
        public GetSupportSkillPopupContentParam?        Prm                                     { get; set; }
        public ProduceOptionSaveData?                   OptionData                              { get; set; }

        public static GetSupportSkillPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetSupportSkillPopupContent() { Pointer= p0 };

            value.GetSkill                                  = GetObject<SupportSkillNode>(new IntPtr(p + 0x060), ReversePrism.DataModels.SupportSkillNode.FromPointer); // 0x60 GetSkill                    ( ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer )
            value.SkillNodeListParent                       = GetObject<Transform>(new IntPtr(p + 0x068), ReversePrism.DataModels.Transform.FromPointer); // 0x68 SkillNodeListParent         ( ModelClassType Transform Transform Transform Pointer )
            value.SkillNodePrefab                           = GetObject<SupportSkillNode>(new IntPtr(p + 0x070), ReversePrism.DataModels.SupportSkillNode.FromPointer); // 0x70 SkillNodePrefab             ( ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer )
            value.ScrollView                                = GetObject<GameObject>(new IntPtr(p + 0x078), ReversePrism.DataModels.GameObject.FromPointer); // 0x78 ScrollView                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EmptyText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 EmptyText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NumText                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x088), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x88 NumText                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ConfirmSkillListButton                    = GetObject<UIButton>(new IntPtr(p + 0x090), ReversePrism.DataModels.UIButton.FromPointer); // 0x90 ConfirmSkillListButton      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.IsClose                                   = GetBool(new IntPtr(p + 0x098)); // 0x98 IsClose                     ( ModelPrimitiveType bool bool bool Bool )
            value.IsSlotFull                                = GetBool(new IntPtr(p + 0x099)); // 0x99 IsSlotFull                  ( ModelPrimitiveType bool bool bool Bool )
            value.Prm                                       = GetObject<GetSupportSkillPopupContentParam>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GetSupportSkillPopupContentParam.FromPointer); // 0xA0 Prm                         ( ModelClassType GetSupportSkillPopupContentParam GetSupportSkillPopupContentParam GetSupportSkillPopupContentParam Pointer )
            value.OptionData                                = GetObject<ProduceOptionSaveData>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.ProduceOptionSaveData.FromPointer); // 0xA8 OptionData                  ( ModelClassType ProduceOptionSaveData ProduceOptionSaveData ProduceOptionSaveData Pointer )

            return value;
        }
    }
}
