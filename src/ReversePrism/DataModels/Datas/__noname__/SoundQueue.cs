using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AudioType                                00018671A260 ModelEnumType AudioType AudioType AudioType Int32
    // 018 Player                                   000186649300 ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer
    // 020 DurationFrame                            000186666050 ModelPrimitiveType float float float Single
    // 024 StartVolume                              000186666050 ModelPrimitiveType float float float Single
    // 028 VolumeRate                               000186666050 ModelPrimitiveType float float float Single
    // 02C Frame                                    000186666050 ModelPrimitiveType float float float Single
    // 030 CueName                                  0001866722E0 ModelPrimitiveType string string string String
    public partial class SoundQueue : DataModel
    {
        public AudioType                                AudioType                               { get; set; }
        public CriAtomExPlayer?                         Player                                  { get; set; }
        public float                                    DurationFrame                           { get; set; }
        public float                                    StartVolume                             { get; set; }
        public float                                    VolumeRate                              { get; set; }
        public float                                    Frame                                   { get; set; }
        public string                                   CueName                                 { get; set; }

        public static SoundQueue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SoundQueue() { Pointer= p0 };

            value.AudioType                                 = (AudioType)GetInt32(new IntPtr(p + 0x010)); // 0245A6992278 0x10 AudioType                   ( 00018671A260 ModelEnumType AudioType AudioType AudioType Int32 )
            value.Player                                    = GetObject<CriAtomExPlayer>(new IntPtr(p + 0x018), ReversePrism.DataModels.CriAtomExPlayer.FromPointer); // 0245A6992298 0x18 Player                      ( 000186649300 ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer )
            value.DurationFrame                             = GetSingle(new IntPtr(p + 0x020)); // 0245A69922B8 0x20 DurationFrame               ( 000186666050 ModelPrimitiveType float float float Single )
            value.StartVolume                               = GetSingle(new IntPtr(p + 0x024)); // 0245A69922D8 0x24 StartVolume                 ( 000186666050 ModelPrimitiveType float float float Single )
            value.VolumeRate                                = GetSingle(new IntPtr(p + 0x028)); // 0245A69922F8 0x28 VolumeRate                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.Frame                                     = GetSingle(new IntPtr(p + 0x02C)); // 0245A6992318 0x2C Frame                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.CueName                                   = GetString(new IntPtr(p + 0x030)); // 0245A6992338 0x30 CueName                     ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
