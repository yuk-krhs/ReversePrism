using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 BgmVolumeNode                            ModelClassType SoundListNode SoundListNode SoundListNode Pointer
    // 048 BgmPreviewToggle                         ModelClassType PlayAndStopToggleButton PlayAndStopToggleButton PlayAndStopToggleButton Pointer
    // 050 SeVolumeNode                             ModelClassType SoundListNode SoundListNode SoundListNode Pointer
    // 058 SePreviewToggle                          ModelClassType PlayAndStopToggleButton PlayAndStopToggleButton PlayAndStopToggleButton Pointer
    // 060 VoiceVolumeNode                          ModelClassType SoundListNode SoundListNode SoundListNode Pointer
    // 068 VoicePreviewToggle                       ModelClassType PlayAndStopToggleButton PlayAndStopToggleButton PlayAndStopToggleButton Pointer
    // 070 StartVoiceTypeToggleGroup                ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer
    // 078 TapSETypeInput                           ModelClassType NumericInput NumericInput NumericInput Pointer
    // 080 TapSEPreviewToggle                       ModelClassType PlayAndStopToggleButton PlayAndStopToggleButton PlayAndStopToggleButton Pointer
    // 088 FlickSETypeInput                         ModelClassType NumericInput NumericInput NumericInput Pointer
    // 090 FlickSEPreviewToggle                     ModelClassType PlayAndStopToggleButton PlayAndStopToggleButton PlayAndStopToggleButton Pointer
    // 098 onSwitchBGMToggle                        Subject`1<bool> IL2CPP_TYPE_GENERICINST
    // 0A0 previewIntervalSE                        IObservable`1<long> IL2CPP_TYPE_GENERICINST
    // 0A8 previewIntervalVoice                     IObservable`1<long> IL2CPP_TYPE_GENERICINST
    // 0B0 VoicePreviewIdolId                       ModelPrimitiveType int int int Int32
    // 0B8 SoundService                             ModelClassType RhythmGameSoundService RhythmGameSoundService RhythmGameSoundService Pointer
    public partial class LiveSettingSoundTabView : DataModel
    {
        public SoundListNode?                           BgmVolumeNode                           { get; set; }
        public PlayAndStopToggleButton?                 BgmPreviewToggle                        { get; set; }
        public SoundListNode?                           SeVolumeNode                            { get; set; }
        public PlayAndStopToggleButton?                 SePreviewToggle                         { get; set; }
        public SoundListNode?                           VoiceVolumeNode                         { get; set; }
        public PlayAndStopToggleButton?                 VoicePreviewToggle                      { get; set; }
        public ToggleButtonGroup?                       StartVoiceTypeToggleGroup               { get; set; }
        public NumericInput?                            TapSETypeInput                          { get; set; }
        public PlayAndStopToggleButton?                 TapSEPreviewToggle                      { get; set; }
        public NumericInput?                            FlickSETypeInput                        { get; set; }
        public PlayAndStopToggleButton?                 FlickSEPreviewToggle                    { get; set; }
        public int                                      VoicePreviewIdolId                      { get; set; }
        public RhythmGameSoundService?                  SoundService                            { get; set; }

        public static LiveSettingSoundTabView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveSettingSoundTabView() { Pointer= p0 };

            value.BgmVolumeNode                             = GetObject<SoundListNode>(new IntPtr(p + 0x040), ReversePrism.DataModels.SoundListNode.FromPointer); // 0x40 BgmVolumeNode               ( ModelClassType SoundListNode SoundListNode SoundListNode Pointer )
            value.BgmPreviewToggle                          = GetObject<PlayAndStopToggleButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.PlayAndStopToggleButton.FromPointer); // 0x48 BgmPreviewToggle            ( ModelClassType PlayAndStopToggleButton PlayAndStopToggleButton PlayAndStopToggleButton Pointer )
            value.SeVolumeNode                              = GetObject<SoundListNode>(new IntPtr(p + 0x050), ReversePrism.DataModels.SoundListNode.FromPointer); // 0x50 SeVolumeNode                ( ModelClassType SoundListNode SoundListNode SoundListNode Pointer )
            value.SePreviewToggle                           = GetObject<PlayAndStopToggleButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.PlayAndStopToggleButton.FromPointer); // 0x58 SePreviewToggle             ( ModelClassType PlayAndStopToggleButton PlayAndStopToggleButton PlayAndStopToggleButton Pointer )
            value.VoiceVolumeNode                           = GetObject<SoundListNode>(new IntPtr(p + 0x060), ReversePrism.DataModels.SoundListNode.FromPointer); // 0x60 VoiceVolumeNode             ( ModelClassType SoundListNode SoundListNode SoundListNode Pointer )
            value.VoicePreviewToggle                        = GetObject<PlayAndStopToggleButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.PlayAndStopToggleButton.FromPointer); // 0x68 VoicePreviewToggle          ( ModelClassType PlayAndStopToggleButton PlayAndStopToggleButton PlayAndStopToggleButton Pointer )
            value.StartVoiceTypeToggleGroup                 = GetObject<ToggleButtonGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.ToggleButtonGroup.FromPointer); // 0x70 StartVoiceTypeToggleGroup   ( ModelClassType ToggleButtonGroup ToggleButtonGroup ToggleButtonGroup Pointer )
            value.TapSETypeInput                            = GetObject<NumericInput>(new IntPtr(p + 0x078), ReversePrism.DataModels.NumericInput.FromPointer); // 0x78 TapSETypeInput              ( ModelClassType NumericInput NumericInput NumericInput Pointer )
            value.TapSEPreviewToggle                        = GetObject<PlayAndStopToggleButton>(new IntPtr(p + 0x080), ReversePrism.DataModels.PlayAndStopToggleButton.FromPointer); // 0x80 TapSEPreviewToggle          ( ModelClassType PlayAndStopToggleButton PlayAndStopToggleButton PlayAndStopToggleButton Pointer )
            value.FlickSETypeInput                          = GetObject<NumericInput>(new IntPtr(p + 0x088), ReversePrism.DataModels.NumericInput.FromPointer); // 0x88 FlickSETypeInput            ( ModelClassType NumericInput NumericInput NumericInput Pointer )
            value.FlickSEPreviewToggle                      = GetObject<PlayAndStopToggleButton>(new IntPtr(p + 0x090), ReversePrism.DataModels.PlayAndStopToggleButton.FromPointer); // 0x90 FlickSEPreviewToggle        ( ModelClassType PlayAndStopToggleButton PlayAndStopToggleButton PlayAndStopToggleButton Pointer )
            value.VoicePreviewIdolId                        = GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 VoicePreviewIdolId          ( ModelPrimitiveType int int int Int32 )
            value.SoundService                              = GetObject<RhythmGameSoundService>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.RhythmGameSoundService.FromPointer); // 0xB8 SoundService                ( ModelClassType RhythmGameSoundService RhythmGameSoundService RhythmGameSoundService Pointer )

            return value;
        }
    }
}
