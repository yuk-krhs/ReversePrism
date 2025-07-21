using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AudioType                                ModelEnumType AudioType AudioType AudioType Int32
    // 018 Player                                   ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer
    // 020 DurationFrame                            ModelPrimitiveType float float float Single
    // 024 StartVolume                              ModelPrimitiveType float float float Single
    // 028 VolumeRate                               ModelPrimitiveType float float float Single
    // 02C Frame                                    ModelPrimitiveType float float float Single
    // 030 CueName                                  ModelPrimitiveType string string string String
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

            value.AudioType                                 = (AudioType)GetInt32(new IntPtr(p + 0x010)); // 0x10 AudioType                   ( ModelEnumType AudioType AudioType AudioType Int32 )
            value.Player                                    = GetObject<CriAtomExPlayer>(new IntPtr(p + 0x018), ReversePrism.DataModels.CriAtomExPlayer.FromPointer); // 0x18 Player                      ( ModelClassType CriAtomExPlayer CriAtomExPlayer CriAtomExPlayer Pointer )
            value.DurationFrame                             = GetSingle(new IntPtr(p + 0x020)); // 0x20 DurationFrame               ( ModelPrimitiveType float float float Single )
            value.StartVolume                               = GetSingle(new IntPtr(p + 0x024)); // 0x24 StartVolume                 ( ModelPrimitiveType float float float Single )
            value.VolumeRate                                = GetSingle(new IntPtr(p + 0x028)); // 0x28 VolumeRate                  ( ModelPrimitiveType float float float Single )
            value.Frame                                     = GetSingle(new IntPtr(p + 0x02C)); // 0x2C Frame                       ( ModelPrimitiveType float float float Single )
            value.CueName                                   = GetString(new IntPtr(p + 0x030)); // 0x30 CueName                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
