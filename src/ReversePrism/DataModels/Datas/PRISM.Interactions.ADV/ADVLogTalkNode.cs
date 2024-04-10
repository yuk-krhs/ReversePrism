using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 SpeakerText                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 SpeakerProducerText                      0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 SpeakerCharaBackGround                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 SpeakerProducerBackGround                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 TalkContent                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 VoiceButton                              000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer
    // 050 VoiceButtonOn                            0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 058 VoiceButtonOff                           0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 060 IconRoot                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 CharaIcon                                0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 070 CharaBackGround                          0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer
    // 078 OtherIcon                                0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer
    // 080 ChoiceIcon                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 088 ViewModel                                0001866679C0 ModelClassType ADVLogTalkNodeViewModel ADVLogTalkNodeViewModel ADVLogTalkNodeViewModel Pointer
    // 090 TalkNodeVoicePlaybackContainer           000186668140 ModelClassType ADVLogTalkNodeVoicePlaybackContainer ADVLogTalkNodeVoicePlaybackContainer ADVLogTalkNodeVoicePlaybackContainer Pointer
    // 098 ResourceTag                              00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 0A0 CurrentPlayVoicePlayback                 0001866481C0 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32
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
        public IResourceTag?                            ResourceTag                             { get; set; }
        public CriAtomExPlayback                        CurrentPlayVoicePlayback                { get; set; }

        public static ADVLogTalkNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ADVLogTalkNode() { Pointer= p0 };

            value.SpeakerText                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A262520 0x20 SpeakerText                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SpeakerProducerText                       = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A262540 0x28 SpeakerProducerText         ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SpeakerCharaBackGround                    = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466A262560 0x30 SpeakerCharaBackGround      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.SpeakerProducerBackGround                 = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 02466A262580 0x38 SpeakerProducerBackGround   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TalkContent                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A2625A0 0x40 TalkContent                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.VoiceButton                               = GetObject<ButtonBase>(new IntPtr(p + 0x048), ReversePrism.DataModels.ButtonBase.FromPointer); // 02466A2625C0 0x48 VoiceButton                 ( 000186515660 ModelClassType ButtonBase ButtonBase ButtonBase Pointer )
            value.VoiceButtonOn                             = GetObject<UIImage>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIImage.FromPointer); // 02466A2625E0 0x50 VoiceButtonOn               ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.VoiceButtonOff                            = GetObject<UIImage>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIImage.FromPointer); // 02466A262600 0x58 VoiceButtonOff              ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.IconRoot                                  = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 02466A262620 0x60 IconRoot                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CharaIcon                                 = GetObject<UIRawImage>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466A262640 0x68 CharaIcon                   ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.CharaBackGround                           = GetObject<UIImage>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIImage.FromPointer); // 02466A262660 0x70 CharaBackGround             ( 0001866EAE30 ModelClassType UIImage UIImage UIImage Pointer )
            value.OtherIcon                                 = GetObject<UIRawImage>(new IntPtr(p + 0x078), ReversePrism.DataModels.UIRawImage.FromPointer); // 02466A262680 0x78 OtherIcon                   ( 0001866EF910 ModelClassType UIRawImage UIRawImage UIRawImage Pointer )
            value.ChoiceIcon                                = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 02466A2626A0 0x80 ChoiceIcon                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ViewModel                                 = GetObject<ADVLogTalkNodeViewModel>(new IntPtr(p + 0x088), ReversePrism.DataModels.ADVLogTalkNodeViewModel.FromPointer); // 02466A2626C0 0x88 ViewModel                   ( 0001866679C0 ModelClassType ADVLogTalkNodeViewModel ADVLogTalkNodeViewModel ADVLogTalkNodeViewModel Pointer )
            value.TalkNodeVoicePlaybackContainer            = GetObject<ADVLogTalkNodeVoicePlaybackContainer>(new IntPtr(p + 0x090), ReversePrism.DataModels.ADVLogTalkNodeVoicePlaybackContainer.FromPointer); // 02466A2626E0 0x90 TalkNodeVoicePlaybackContainer ( 000186668140 ModelClassType ADVLogTalkNodeVoicePlaybackContainer ADVLogTalkNodeVoicePlaybackContainer ADVLogTalkNodeVoicePlaybackContainer Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x098), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466A262700 0x98 ResourceTag                 ( 00018661C240 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.CurrentPlayVoicePlayback                  = (CriAtomExPlayback)GetInt32(new IntPtr(p + 0x0A0)); // 02466A262720 0xA0 CurrentPlayVoicePlayback    ( 0001866481C0 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32 )

            return value;
        }
    }
}
