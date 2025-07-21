using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NodePrefab                               ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer
    // 028 NodeParent                               ModelClassType Transform Transform Transform Pointer
    // 030 MessageText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 NowSlotText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 MaxSlotText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 InheritanceObject                        ModelClassType GameObject GameObject GameObject Pointer
    // 050 SkillListButton                          ModelClassType UIButton UIButton UIButton Pointer
    // 058 InheritanceCountText                     ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 060 InheritanceLimitCountText                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 068 onSelect                                 Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 070 onDecide                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 078 onClickSkillList                         Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 080 onClosed                                 Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 088 NodeList                                 ModelClassListType List`1<SupportSkillNode> List`1<SupportSkillNode> List<SupportSkillNode> Pointer
    // 090 PopupFrameParameter                      ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer
    // 098 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class GetMultipleSupportSkillPopupView : DataModel
    {
        public SupportSkillNode?                        NodePrefab                              { get; set; }
        public Transform?                               NodeParent                              { get; set; }
        public UITextMeshProUGUI?                       MessageText                             { get; set; }
        public UITextMeshProUGUI?                       NowSlotText                             { get; set; }
        public UITextMeshProUGUI?                       MaxSlotText                             { get; set; }
        public GameObject?                              InheritanceObject                       { get; set; }
        public UIButton?                                SkillListButton                         { get; set; }
        public UITextMeshProUGUI?                       InheritanceCountText                    { get; set; }
        public UITextMeshProUGUI?                       InheritanceLimitCountText               { get; set; }
        public List<SupportSkillNode>?                  NodeList                                { get; set; }
        public PopupFrameParameter?                     PopupFrameParameter                     { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static GetMultipleSupportSkillPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetMultipleSupportSkillPopupView() { Pointer= p0 };

            value.NodePrefab                                = GetObject<SupportSkillNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.SupportSkillNode.FromPointer); // 0x20 NodePrefab                  ( ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer )
            value.NodeParent                                = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 NodeParent                  ( ModelClassType Transform Transform Transform Pointer )
            value.MessageText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 MessageText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NowSlotText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 NowSlotText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MaxSlotText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 MaxSlotText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.InheritanceObject                         = GetObject<GameObject>(new IntPtr(p + 0x048), ReversePrism.DataModels.GameObject.FromPointer); // 0x48 InheritanceObject           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SkillListButton                           = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 SkillListButton             ( ModelClassType UIButton UIButton UIButton Pointer )
            value.InheritanceCountText                      = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x058), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x58 InheritanceCountText        ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.InheritanceLimitCountText                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x60 InheritanceLimitCountText   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NodeList                                  = GetObjectList<SupportSkillNode>(new IntPtr(p + 0x088), ReversePrism.DataModels.SupportSkillNode.FromPointer); // 0x88 NodeList                    ( ModelClassListType List`1<SupportSkillNode> List`1<SupportSkillNode> List<SupportSkillNode> Pointer )
            value.PopupFrameParameter                       = GetObject<PopupFrameParameter>(new IntPtr(p + 0x090), ReversePrism.DataModels.PopupFrameParameter.FromPointer); // 0x90 PopupFrameParameter         ( ModelClassType PopupFrameParameter PopupFrameParameter PopupFrameParameter Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x098), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x98 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
