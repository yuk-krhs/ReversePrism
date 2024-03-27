using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Title                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ScrollRect                               0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 030 NodeListParent                           0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 038 CloseButton                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 040 TalkNodePrefab                           000186667250 ModelClassType ADVLogTalkNode ADVLogTalkNode ADVLogTalkNode Pointer
    // 048 ActionNodePrefab                         000186663090 ModelClassType ADVLogActionNode ADVLogActionNode ADVLogActionNode Pointer
    // 050 BackKeyDisposable                        0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 058 TalkNodeList                             000185CCB088 ModelClassListType List`1<ADVLogTalkNode> List`1<ADVLogTalkNode> List<ADVLogTalkNode> Pointer
    // 060 TalkNodeVoicePlaybackContainer           000186668620 ModelClassType ADVLogTalkNodeVoicePlaybackContainer ADVLogTalkNodeVoicePlaybackContainer ADVLogTalkNodeVoicePlaybackContainer Pointer
    // 068 onClickClose                             Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 070 IsOpen                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ADVLogOverlayView
    {
        public UITextMeshProUGUI?                       Title                                   { get; set; }
        public ScrollRect?                              ScrollRect                              { get; set; }
        public Transform?                               NodeListParent                          { get; set; }
        public UIButton?                                CloseButton                             { get; set; }
        public ADVLogTalkNode?                          TalkNodePrefab                          { get; set; }
        public ADVLogActionNode?                        ActionNodePrefab                        { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }
        public List<ADVLogTalkNode>?                    TalkNodeList                            { get; set; }
        public ADVLogTalkNodeVoicePlaybackContainer?    TalkNodeVoicePlaybackContainer          { get; set; }
        public bool                                     IsOpen                                  { get; set; }

        public static ADVLogOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVLogOverlayView();

            value.Title                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBE3A8A8 0x20 Title                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x028), ReversePrism.DataModels.ScrollRect.FromPointer); // 0270DBE3A8C8 0x28 ScrollRect                  ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.NodeListParent                            = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0270DBE3A8E8 0x30 NodeListParent              ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.CloseButton                               = GetObject<UIButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.UIButton.FromPointer); // 0270DBE3A908 0x38 CloseButton                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.TalkNodePrefab                            = GetObject<ADVLogTalkNode>(new IntPtr(p + 0x040), ReversePrism.DataModels.ADVLogTalkNode.FromPointer); // 0270DBE3A928 0x40 TalkNodePrefab              ( 000186667250 ModelClassType ADVLogTalkNode ADVLogTalkNode ADVLogTalkNode Pointer )
            value.ActionNodePrefab                          = GetObject<ADVLogActionNode>(new IntPtr(p + 0x048), ReversePrism.DataModels.ADVLogActionNode.FromPointer); // 0270DBE3A948 0x48 ActionNodePrefab            ( 000186663090 ModelClassType ADVLogActionNode ADVLogActionNode ADVLogActionNode Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x050), ReversePrism.DataModels.IDisposable.FromPointer); // 0270DBE3A968 0x50 BackKeyDisposable           ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.TalkNodeList                              = GetObjectList<ADVLogTalkNode>(new IntPtr(p + 0x058), ReversePrism.DataModels.ADVLogTalkNode.FromPointer); // 0270DBE3A988 0x58 TalkNodeList                ( 000185CCB088 ModelClassListType List`1<ADVLogTalkNode> List`1<ADVLogTalkNode> List<ADVLogTalkNode> Pointer )
            value.TalkNodeVoicePlaybackContainer            = GetObject<ADVLogTalkNodeVoicePlaybackContainer>(new IntPtr(p + 0x060), ReversePrism.DataModels.ADVLogTalkNodeVoicePlaybackContainer.FromPointer); // 0270DBE3A9A8 0x60 TalkNodeVoicePlaybackContainer ( 000186668620 ModelClassType ADVLogTalkNodeVoicePlaybackContainer ADVLogTalkNodeVoicePlaybackContainer ADVLogTalkNodeVoicePlaybackContainer Pointer )
            value.IsOpen                                    = GetBool(new IntPtr(p + 0x070)); // 0270DBE3A9E8 0x70 IsOpen                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
