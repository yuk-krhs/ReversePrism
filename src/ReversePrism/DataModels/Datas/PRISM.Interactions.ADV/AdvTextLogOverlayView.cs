using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScrollRect                               ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 028 CloseButton                              ModelClassType UIButton UIButton UIButton Pointer
    // 030 Title                                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 CellParent                               ModelClassType Transform Transform Transform Pointer
    // 040 TalkCellPrefab                           ModelClassType AdvTextLogTalkCell AdvTextLogTalkCell AdvTextLogTalkCell Pointer
    // 048 VoicePlaybackContainer                   ModelClassType ADVLogTalkNodeVoicePlaybackContainer ADVLogTalkNodeVoicePlaybackContainer ADVLogTalkNodeVoicePlaybackContainer Pointer
    // 050 onClose                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 058 BackKeyDisposable                        ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class AdvTextLogOverlayView : DataModel
    {
        public ScrollRect?                              ScrollRect                              { get; set; }
        public UIButton?                                CloseButton                             { get; set; }
        public UITextMeshProUGUI?                       Title                                   { get; set; }
        public Transform?                               CellParent                              { get; set; }
        public AdvTextLogTalkCell?                      TalkCellPrefab                          { get; set; }
        public ADVLogTalkNodeVoicePlaybackContainer?    VoicePlaybackContainer                  { get; set; }
        public IDisposable?                             BackKeyDisposable                       { get; set; }

        public static AdvTextLogOverlayView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdvTextLogOverlayView() { Pointer= p0 };

            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScrollRect.FromPointer); // 0x20 ScrollRect                  ( ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.CloseButton                               = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 CloseButton                 ( ModelClassType UIButton UIButton UIButton Pointer )
            value.Title                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 Title                       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CellParent                                = GetObject<Transform>(new IntPtr(p + 0x038), ReversePrism.DataModels.Transform.FromPointer); // 0x38 CellParent                  ( ModelClassType Transform Transform Transform Pointer )
            value.TalkCellPrefab                            = GetObject<AdvTextLogTalkCell>(new IntPtr(p + 0x040), ReversePrism.DataModels.AdvTextLogTalkCell.FromPointer); // 0x40 TalkCellPrefab              ( ModelClassType AdvTextLogTalkCell AdvTextLogTalkCell AdvTextLogTalkCell Pointer )
            value.VoicePlaybackContainer                    = GetObject<ADVLogTalkNodeVoicePlaybackContainer>(new IntPtr(p + 0x048), ReversePrism.DataModels.ADVLogTalkNodeVoicePlaybackContainer.FromPointer); // 0x48 VoicePlaybackContainer      ( ModelClassType ADVLogTalkNodeVoicePlaybackContainer ADVLogTalkNodeVoicePlaybackContainer ADVLogTalkNodeVoicePlaybackContainer Pointer )
            value.BackKeyDisposable                         = GetObject<IDisposable>(new IntPtr(p + 0x058), ReversePrism.DataModels.IDisposable.FromPointer); // 0x58 BackKeyDisposable           ( ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
