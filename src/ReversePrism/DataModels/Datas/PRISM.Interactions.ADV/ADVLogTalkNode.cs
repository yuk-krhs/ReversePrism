using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SpeakerText                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 SpeakerProducerText                      ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 SpeakerCharaBackGround                   ModelClassType GameObject GameObject GameObject Pointer
    // 038 SpeakerProducerBackGround                ModelClassType GameObject GameObject GameObject Pointer
    // 040 TalkContent                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 VoiceButton                              ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 050 VoiceButtonOn                            ModelClassType UIImage UIImage UIImage Pointer
    // 058 VoiceButtonOff                           ModelClassType UIImage UIImage UIImage Pointer
    // 060 IconRoot                                 ModelClassType GameObject GameObject GameObject Pointer
    // 068 CharaIcon                                ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 070 CharaBackGround                          ModelClassType UIImage UIImage UIImage Pointer
    // 078 OtherIcon                                ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 080 ChoiceIcon                               ModelClassType GameObject GameObject GameObject Pointer
    // 088 ViewModel                                ModelClassType ADVLogTalkNodeViewModel ADVLogTalkNodeViewModel ADVLogTalkNodeViewModel Pointer
    // 090 TalkNodeVoicePlaybackContainer           ModelClassType ADVLogTalkNodeVoicePlaybackContainer ADVLogTalkNodeVoicePlaybackContainer ADVLogTalkNodeVoicePlaybackContainer Pointer
    // 098 CurrentPlayVoicePlayback                 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32
    public partial class ADVLogTalkNode : DataModel
    {
        public UITextMeshProUGUI?                       SpeakerText                             { get; set; }
        public UITextMeshProUGUI?                       SpeakerProducerText                     { get; set; }
        public GameObject?                              SpeakerCharaBackGround                  { get; set; }
        public GameObject?                              SpeakerProducerBackGround               { get; set; }
        public UITextMeshProUGUI?                       TalkContent                             { get; set; }
        public ButtonBase?                              VoiceButton                             { get; set; }
        public UIImage?                                 VoiceButtonOn                           { get; set; }
        public UIImage?                                 VoiceButtonOff                          { get; set; }
        public GameObject?                              IconRoot                                { get; set; }
        public UIRawImage?                              CharaIcon                               { get; set; }
        public UIImage?                                 CharaBackGround                         { get; set; }
        public UIRawImage?                              OtherIcon                               { get; set; }
        public GameObject?                              ChoiceIcon                              { get; set; }
        public ADVLogTalkNodeViewModel?                 ViewModel                               { get; set; }
        public ADVLogTalkNodeVoicePlaybackContainer?    TalkNodeVoicePlaybackContainer          { get; set; }
        public CriAtomExPlayback                        CurrentPlayVoicePlayback                { get; set; }

        public static ADVLogTalkNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVLogTalkNode() { Pointer= p0 };

            value.SpeakerText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 SpeakerText                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SpeakerProducerText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 SpeakerProducerText         ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SpeakerCharaBackGround                    = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 SpeakerCharaBackGround      ( ModelClassType GameObject GameObject GameObject Pointer )
            value.SpeakerProducerBackGround                 = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 SpeakerProducerBackGround   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TalkContent                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TalkContent                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VoiceButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonBase.FromPointer); // 0x48 VoiceButton                 ( ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.VoiceButtonOn                             = GetObject<UIImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIImage.FromPointer); // 0x50 VoiceButtonOn               ( ModelClassType UIImage UIImage UIImage Pointer )
            value.VoiceButtonOff                            = GetObject<UIImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIImage.FromPointer); // 0x58 VoiceButtonOff              ( ModelClassType UIImage UIImage UIImage Pointer )
            value.IconRoot                                  = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 0x60 IconRoot                    ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CharaIcon                                 = GetObject<UIRawImage>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x68 CharaIcon                   ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.CharaBackGround                           = GetObject<UIImage>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIImage.FromPointer); // 0x70 CharaBackGround             ( ModelClassType UIImage UIImage UIImage Pointer )
            value.OtherIcon                                 = GetObject<UIRawImage>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIRawImage.FromPointer); // 0x78 OtherIcon                   ( ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.ChoiceIcon                                = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 ChoiceIcon                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ViewModel                                 = GetObject<ADVLogTalkNodeViewModel>(new IntPtr(p + 0x088), ReversePrism.DataModels.ADVLogTalkNodeViewModel.FromPointer); // 0x88 ViewModel                   ( ModelClassType ADVLogTalkNodeViewModel ADVLogTalkNodeViewModel ADVLogTalkNodeViewModel Pointer )
            value.TalkNodeVoicePlaybackContainer            = GetObject<ADVLogTalkNodeVoicePlaybackContainer>(new IntPtr(p + 0x090), ReversePrism.DataModels.ADVLogTalkNodeVoicePlaybackContainer.FromPointer); // 0x90 TalkNodeVoicePlaybackContainer ( ModelClassType ADVLogTalkNodeVoicePlaybackContainer ADVLogTalkNodeVoicePlaybackContainer ADVLogTalkNodeVoicePlaybackContainer Pointer )
            value.CurrentPlayVoicePlayback                  = (CriAtomExPlayback)GetInt32(new IntPtr(p + 0x098)); // 0x98 CurrentPlayVoicePlayback    ( ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32 )

            return value;
        }
    }
}
