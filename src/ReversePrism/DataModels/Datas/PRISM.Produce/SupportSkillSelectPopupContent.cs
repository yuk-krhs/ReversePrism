using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 RemoveSkill                              ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer
    // 068 GetSkill                                 ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer
    // 070 SkillNodeListParent                      ModelClassType Transform Transform Transform Pointer
    // 078 SkillNodePrefab                          ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer
    // 080 NumText                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 ConfirmSkillListButton                   ModelClassType UIButton UIButton UIButton Pointer
    // 090 SkillNodeList                            ModelClassListType List`1<SupportSkillNode> List`1<SupportSkillNode> List<SupportSkillNode> Pointer
    // 098 Prm                                      ModelClassType SupportSkillSelectPopupParam SupportSkillSelectPopupParam SupportSkillSelectPopupParam Pointer
    // 0A0 RemoveSkillData                          ModelClassType IPotentialSupportSkillStatus IPotentialSupportSkillStatus IPotentialSupportSkillStatus Pointer
    // 0A8 RemoveIndex                              ModelPrimitiveType int int int Int32
    public partial class SupportSkillSelectPopupContent : DataModel
    {
        public SupportSkillNode?                        RemoveSkill                             { get; set; }
        public SupportSkillNode?                        GetSkill                                { get; set; }
        public Transform?                               SkillNodeListParent                     { get; set; }
        public SupportSkillNode?                        SkillNodePrefab                         { get; set; }
        public UITextMeshProUGUI?                       NumText                                 { get; set; }
        public UIButton?                                ConfirmSkillListButton                  { get; set; }
        public List<SupportSkillNode>?                  SkillNodeList                           { get; set; }
        public SupportSkillSelectPopupParam?            Prm                                     { get; set; }
        public IPotentialSupportSkillStatus?            RemoveSkillData                         { get; set; }
        public int                                      RemoveIndex                             { get; set; }

        public static SupportSkillSelectPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportSkillSelectPopupContent() { Pointer= p0 };

            value.RemoveSkill                               = GetObject<SupportSkillNode>(new IntPtr(p + 0x060), ReversePrism.DataModels.SupportSkillNode.FromPointer); // 0x60 RemoveSkill                 ( ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer )
            value.GetSkill                                  = GetObject<SupportSkillNode>(new IntPtr(p + 0x068), ReversePrism.DataModels.SupportSkillNode.FromPointer); // 0x68 GetSkill                    ( ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer )
            value.SkillNodeListParent                       = GetObject<Transform>(new IntPtr(p + 0x070), ReversePrism.DataModels.Transform.FromPointer); // 0x70 SkillNodeListParent         ( ModelClassType Transform Transform Transform Pointer )
            value.SkillNodePrefab                           = GetObject<SupportSkillNode>(new IntPtr(p + 0x078), ReversePrism.DataModels.SupportSkillNode.FromPointer); // 0x78 SkillNodePrefab             ( ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer )
            value.NumText                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x80 NumText                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ConfirmSkillListButton                    = GetObject<UIButton>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIButton.FromPointer); // 0x88 ConfirmSkillListButton      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.SkillNodeList                             = GetObjectList<SupportSkillNode>(new IntPtr(p + 0x090), ReversePrism.DataModels.SupportSkillNode.FromPointer); // 0x90 SkillNodeList               ( ModelClassListType List`1<SupportSkillNode> List`1<SupportSkillNode> List<SupportSkillNode> Pointer )
            value.Prm                                       = GetObject<SupportSkillSelectPopupParam>(new IntPtr(p + 0x098), ReversePrism.DataModels.SupportSkillSelectPopupParam.FromPointer); // 0x98 Prm                         ( ModelClassType SupportSkillSelectPopupParam SupportSkillSelectPopupParam SupportSkillSelectPopupParam Pointer )
            value.RemoveSkillData                           = GetObject<IPotentialSupportSkillStatus>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IPotentialSupportSkillStatus.FromPointer); // 0xA0 RemoveSkillData             ( ModelClassType IPotentialSupportSkillStatus IPotentialSupportSkillStatus IPotentialSupportSkillStatus Pointer )
            value.RemoveIndex                               = GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 RemoveIndex                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
