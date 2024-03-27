using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Volume                                   000186666050 ModelPrimitiveType float float float Single
    // 014 Pitch                                    000186666050 ModelPrimitiveType float float float Single
    // 018 AISACValue                               000186666050 ModelPrimitiveType float float float Single
    // 000 cPreviewStopTimeMs                       int IL2CPP_TYPE_I4
    // 020 M_acb                                    000186645230 ModelClassType CriAtomExAcb CriAtomExAcb CriAtomExAcb Pointer
    // 028 M_lastCueSheetPath                       000186671910 ModelPrimitiveType string string string String
    // 030 Playback                                 0001866481C0 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32
    // 034 IsClipPlaying                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 CueLength                                0001865C2950 ModelPrimitiveType double double double Double
    public partial class CriAtomBehaviour
    {
        public float                                    Volume                                  { get; set; }
        public float                                    Pitch                                   { get; set; }
        public float                                    AISACValue                              { get; set; }
        public CriAtomExAcb?                            M_acb                                   { get; set; }
        public string                                   M_lastCueSheetPath                      { get; set; }
        public CriAtomExPlayback                        Playback                                { get; set; }
        public bool                                     IsClipPlaying                           { get; set; }
        public double                                   CueLength                               { get; set; }

        public static CriAtomBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomBehaviour();

            value.Volume                                    = GetSingle(new IntPtr(p + 0x010)); // 0270DACEE090 0x10 Volume                      ( 000186666050 ModelPrimitiveType float float float Single )
            value.Pitch                                     = GetSingle(new IntPtr(p + 0x014)); // 0270DACEE0B0 0x14 Pitch                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.AISACValue                                = GetSingle(new IntPtr(p + 0x018)); // 0270DACEE0D0 0x18 AISACValue                  ( 000186666050 ModelPrimitiveType float float float Single )
            value.M_acb                                     = GetObject<CriAtomExAcb>(new IntPtr(p + 0x020), ReversePrism.DataModels.CriAtomExAcb.FromPointer); // 0270DACEE110 0x20 M_acb                       ( 000186645230 ModelClassType CriAtomExAcb CriAtomExAcb CriAtomExAcb Pointer )
            value.M_lastCueSheetPath                        = GetString(new IntPtr(p + 0x028)); // 0270DACEE130 0x28 M_lastCueSheetPath          ( 000186671910 ModelPrimitiveType string string string String )
            value.Playback                                  = (CriAtomExPlayback)GetInt32(new IntPtr(p + 0x030)); // 0270DACEE150 0x30 Playback                    ( 0001866481C0 ModelEnumType CriAtomExPlayback CriAtomExPlayback CriAtomExPlayback Int32 )
            value.IsClipPlaying                             = GetBool(new IntPtr(p + 0x034)); // 0270DACEE170 0x34 IsClipPlaying               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CueLength                                 = GetDouble(new IntPtr(p + 0x038)); // 0270DACEE190 0x38 CueLength                   ( 0001865C2950 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
