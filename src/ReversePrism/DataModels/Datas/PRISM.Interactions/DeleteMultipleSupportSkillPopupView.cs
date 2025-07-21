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
    // 030 SkillListButton                          ModelClassType UIButton UIButton UIButton Pointer
    // 038 NowSlotText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 MaxSlotText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 onClosed                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 onSelect                                 Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 058 onDecide                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 onClickSkillList                         Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 068 NodeList                                 ModelClassListType List`1<SupportSkillNode> List`1<SupportSkillNode> List<SupportSkillNode> Pointer
    // 070 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class DeleteMultipleSupportSkillPopupView : DataModel
    {
        public SupportSkillNode?                        NodePrefab                              { get; set; }
        public Transform?                               NodeParent                              { get; set; }
        public UIButton?                                SkillListButton                         { get; set; }
        public UITextMeshProUGUI?                       NowSlotText                             { get; set; }
        public UITextMeshProUGUI?                       MaxSlotText                             { get; set; }
        public List<SupportSkillNode>?                  NodeList                                { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static DeleteMultipleSupportSkillPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeleteMultipleSupportSkillPopupView() { Pointer= p0 };

            value.NodePrefab                                = GetObject<SupportSkillNode>(new IntPtr(p + 0x020), ReversePrism.DataModels.SupportSkillNode.FromPointer); // 0x20 NodePrefab                  ( ModelClassType SupportSkillNode SupportSkillNode SupportSkillNode Pointer )
            value.NodeParent                                = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 NodeParent                  ( ModelClassType Transform Transform Transform Pointer )
            value.SkillListButton                           = GetObject<UIButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.UIButton.FromPointer); // 0x30 SkillListButton             ( ModelClassType UIButton UIButton UIButton Pointer )
            value.NowSlotText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 NowSlotText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MaxSlotText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 MaxSlotText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NodeList                                  = GetObjectList<SupportSkillNode>(new IntPtr(p + 0x068), ReversePrism.DataModels.SupportSkillNode.FromPointer); // 0x68 NodeList                    ( ModelClassListType List`1<SupportSkillNode> List`1<SupportSkillNode> List<SupportSkillNode> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x070), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x70 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
