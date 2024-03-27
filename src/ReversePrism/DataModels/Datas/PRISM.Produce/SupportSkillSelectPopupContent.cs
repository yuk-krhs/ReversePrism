using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 RemoveSkill                              0001865F52E0 ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer
    // 068 GetSkill                                 0001865F52E0 ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer
    // 070 SkillNodeListParent                      0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 078 SkillNodePrefab                          0001865F52E0 ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer
    // 080 NumText                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 088 ConfirmSkillListButton                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 090 SkillNodeList                            000185D10F88 ModelClassListType List`1<SupportSkillNode> List`1<SupportSkillNode> List<SupportSkillNode> Pointer
    // 098 Prm                                      0001865D27D0 ModelClassType SupportSkillSelectPopupParam SupportSkillSelectPopupParam SupportSkillSelectPopupParam Pointer
    // 0A0 RemoveSkillData                          0001865DBC80 ModelClassType IPotentialSupportSkillStatus IPotentialSupportSkillStatus IPotentialSupportSkillStatus Pointer
    // 0A8 RemoveIndex                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class SupportSkillSelectPopupContent
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
            var value   = new SupportSkillSelectPopupContent();

            value.RemoveSkill                               = GetObject<SupportSkillNode>(new IntPtr(p + 0x060), ReversePrism.DataModels.SupportSkillNode.FromPointer); // 0270D5CF57E8 0x60 RemoveSkill                 ( 0001865F52E0 ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer )
            value.GetSkill                                  = GetObject<SupportSkillNode>(new IntPtr(p + 0x068), ReversePrism.DataModels.SupportSkillNode.FromPointer); // 0270D5CF5808 0x68 GetSkill                    ( 0001865F52E0 ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer )
            value.SkillNodeListParent                       = GetObject<Transform>(new IntPtr(p + 0x070), ReversePrism.DataModels.Transform.FromPointer); // 0270D5CF5828 0x70 SkillNodeListParent         ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.SkillNodePrefab                           = GetObject<SupportSkillNode>(new IntPtr(p + 0x078), ReversePrism.DataModels.SupportSkillNode.FromPointer); // 0270D5CF5848 0x78 SkillNodePrefab             ( 0001865F52E0 ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer )
            value.NumText                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x080), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5CF5868 0x80 NumText                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ConfirmSkillListButton                    = GetObject<UIButton>(new IntPtr(p + 0x088), ReversePrism.DataModels.UIButton.FromPointer); // 0270D5CF5888 0x88 ConfirmSkillListButton      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.SkillNodeList                             = GetObjectList<SupportSkillNode>(new IntPtr(p + 0x090), ReversePrism.DataModels.SupportSkillNode.FromPointer); // 0270D5CF58A8 0x90 SkillNodeList               ( 000185D10F88 ModelClassListType List`1<SupportSkillNode> List`1<SupportSkillNode> List<SupportSkillNode> Pointer )
            value.Prm                                       = GetObject<SupportSkillSelectPopupParam>(new IntPtr(p + 0x098), ReversePrism.DataModels.SupportSkillSelectPopupParam.FromPointer); // 0270D5CF58C8 0x98 Prm                         ( 0001865D27D0 ModelClassType SupportSkillSelectPopupParam SupportSkillSelectPopupParam SupportSkillSelectPopupParam Pointer )
            value.RemoveSkillData                           = GetObject<IPotentialSupportSkillStatus>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.IPotentialSupportSkillStatus.FromPointer); // 0270D5CF58E8 0xA0 RemoveSkillData             ( 0001865DBC80 ModelClassType IPotentialSupportSkillStatus IPotentialSupportSkillStatus IPotentialSupportSkillStatus Pointer )
            value.RemoveIndex                               = GetInt32(new IntPtr(p + 0x0A8)); // 0270D5CF5908 0xA8 RemoveIndex                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
