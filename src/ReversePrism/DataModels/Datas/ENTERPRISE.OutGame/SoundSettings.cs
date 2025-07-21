using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 CueSheetName                             string IL2CPP_TYPE_STRING
    // 000 VoiceName                                string IL2CPP_TYPE_STRING
    // 030 Save                                     ModelClassType OptionLocalSave OptionLocalSave OptionLocalSave Pointer
    // 038 BgmNode                                  ModelClassType SoundListNode SoundListNode SoundListNode Pointer
    // 040 SeNode                                   ModelClassType SoundListNode SoundListNode SoundListNode Pointer
    // 048 VoiceNode                                ModelClassType SoundListNode SoundListNode SoundListNode Pointer
    // 050 SetInitialSettingsButton                 ModelClassType UIButton UIButton UIButton Pointer
    // 058 VoicePlayback                            ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32
    // 05C SePlayback                               ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32
    // 000 InitialVolume                            int IL2CPP_TYPE_I4
    // 000 InitialIsMute                            bool IL2CPP_TYPE_BOOLEAN
    public partial class SoundSettings : DataModel
    {
        public OptionLocalSave?                         Save                                    { get; set; }
        public SoundListNode?                           BgmNode                                 { get; set; }
        public SoundListNode?                           SeNode                                  { get; set; }
        public SoundListNode?                           VoiceNode                               { get; set; }
        public UIButton?                                SetInitialSettingsButton                { get; set; }
        public CriAtomExPlayback                        VoicePlayback                           { get; set; }
        public CriAtomExPlayback                        SePlayback                              { get; set; }

        public static SoundSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SoundSettings() { Pointer= p0 };

            value.Save                                      = GetObject<OptionLocalSave>(new IntPtr(p + 0x030), ReversePrism.DataModels.OptionLocalSave.FromPointer); // 0x30 Save                        ( ModelClassType OptionLocalSave OptionLocalSave OptionLocalSave Pointer )
            value.BgmNode                                   = GetObject<SoundListNode>(new IntPtr(p + 0x038), ReversePrism.DataModels.SoundListNode.FromPointer); // 0x38 BgmNode                     ( ModelClassType SoundListNode SoundListNode SoundListNode Pointer )
            value.SeNode                                    = GetObject<SoundListNode>(new IntPtr(p + 0x040), ReversePrism.DataModels.SoundListNode.FromPointer); // 0x40 SeNode                      ( ModelClassType SoundListNode SoundListNode SoundListNode Pointer )
            value.VoiceNode                                 = GetObject<SoundListNode>(new IntPtr(p + 0x048), ReversePrism.DataModels.SoundListNode.FromPointer); // 0x48 VoiceNode                   ( ModelClassType SoundListNode SoundListNode SoundListNode Pointer )
            value.SetInitialSettingsButton                  = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 SetInitialSettingsButton    ( ModelClassType UIButton UIButton UIButton Pointer )
            value.VoicePlayback                             = (CriAtomExPlayback)GetInt32(new IntPtr(p + 0x058)); // 0x58 VoicePlayback               ( ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32 )
            value.SePlayback                                = (CriAtomExPlayback)GetInt32(new IntPtr(p + 0x05C)); // 0x5C SePlayback                  ( ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32 )

            return value;
        }
    }
}
