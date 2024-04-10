using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 SheetName                                string IL2CPP_TYPE_STRING
    // 000 GashaTopSelect                           SoundKey IL2CPP_TYPE_VALUETYPE
    // 010 GashaCharaNameNew                        000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 020 GashaCharaNameNewS                       000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 030 GashaCharaNamePiace                      000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 040 PGashaP6CharaNameR                       000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 050 PGashaP6CharaNameSR                      000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 060 PGashaP7CharaNameSSR                     000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 070 SGashaS2Touch                            000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 080 SGashaTouchSR                            000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 090 SGashaTouchSSR                           000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0A0 SGashaS2Zoom                             000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0B0 SGashaHadukiMessage                      000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0C0 SGashaZentaiShokaku                      000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0D0 SGashaP4KakuteiR                         000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0E0 SGashaP4KakuteiSR                        000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 0F0 SGashaP4KakuteiSSR                       000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 100 SGashaS4KakuteiSSRLayer1                 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    // 110 SGashaS4KakuteiSSRLayer2                 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32
    public partial class GashaSE : DataModel
    {
        public SoundKey                                 GashaCharaNameNew                       { get; set; }
        public SoundKey                                 GashaCharaNameNewS                      { get; set; }
        public SoundKey                                 GashaCharaNamePiace                     { get; set; }
        public SoundKey                                 PGashaP6CharaNameR                      { get; set; }
        public SoundKey                                 PGashaP6CharaNameSR                     { get; set; }
        public SoundKey                                 PGashaP7CharaNameSSR                    { get; set; }
        public SoundKey                                 SGashaS2Touch                           { get; set; }
        public SoundKey                                 SGashaTouchSR                           { get; set; }
        public SoundKey                                 SGashaTouchSSR                          { get; set; }
        public SoundKey                                 SGashaS2Zoom                            { get; set; }
        public SoundKey                                 SGashaHadukiMessage                     { get; set; }
        public SoundKey                                 SGashaZentaiShokaku                     { get; set; }
        public SoundKey                                 SGashaP4KakuteiR                        { get; set; }
        public SoundKey                                 SGashaP4KakuteiSR                       { get; set; }
        public SoundKey                                 SGashaP4KakuteiSSR                      { get; set; }
        public SoundKey                                 SGashaS4KakuteiSSRLayer1                { get; set; }
        public SoundKey                                 SGashaS4KakuteiSSRLayer2                { get; set; }

        public static GashaSE? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaSE() { Pointer= p0 };

            value.GashaCharaNameNew                         = (SoundKey)GetInt32(new IntPtr(p + 0x010)); // 02466542BA50 0x10 GashaCharaNameNew           ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.GashaCharaNameNewS                        = (SoundKey)GetInt32(new IntPtr(p + 0x020)); // 02466542BA70 0x20 GashaCharaNameNewS          ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.GashaCharaNamePiace                       = (SoundKey)GetInt32(new IntPtr(p + 0x030)); // 02466542BA90 0x30 GashaCharaNamePiace         ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.PGashaP6CharaNameR                        = (SoundKey)GetInt32(new IntPtr(p + 0x040)); // 02466542BAB0 0x40 PGashaP6CharaNameR          ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.PGashaP6CharaNameSR                       = (SoundKey)GetInt32(new IntPtr(p + 0x050)); // 02466542BAD0 0x50 PGashaP6CharaNameSR         ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.PGashaP7CharaNameSSR                      = (SoundKey)GetInt32(new IntPtr(p + 0x060)); // 02466542BAF0 0x60 PGashaP7CharaNameSSR        ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.SGashaS2Touch                             = (SoundKey)GetInt32(new IntPtr(p + 0x070)); // 02466542BB10 0x70 SGashaS2Touch               ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.SGashaTouchSR                             = (SoundKey)GetInt32(new IntPtr(p + 0x080)); // 02466542BB30 0x80 SGashaTouchSR               ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.SGashaTouchSSR                            = (SoundKey)GetInt32(new IntPtr(p + 0x090)); // 02466542BB50 0x90 SGashaTouchSSR              ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.SGashaS2Zoom                              = (SoundKey)GetInt32(new IntPtr(p + 0x0A0)); // 02466542BB70 0xA0 SGashaS2Zoom                ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.SGashaHadukiMessage                       = (SoundKey)GetInt32(new IntPtr(p + 0x0B0)); // 02466542BB90 0xB0 SGashaHadukiMessage         ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.SGashaZentaiShokaku                       = (SoundKey)GetInt32(new IntPtr(p + 0x0C0)); // 02466542BBB0 0xC0 SGashaZentaiShokaku         ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.SGashaP4KakuteiR                          = (SoundKey)GetInt32(new IntPtr(p + 0x0D0)); // 02466542BBD0 0xD0 SGashaP4KakuteiR            ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.SGashaP4KakuteiSR                         = (SoundKey)GetInt32(new IntPtr(p + 0x0E0)); // 02466542BBF0 0xE0 SGashaP4KakuteiSR           ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.SGashaP4KakuteiSSR                        = (SoundKey)GetInt32(new IntPtr(p + 0x0F0)); // 02466542BC10 0xF0 SGashaP4KakuteiSSR          ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.SGashaS4KakuteiSSRLayer1                  = (SoundKey)GetInt32(new IntPtr(p + 0x100)); // 02466542BC30 0x100 SGashaS4KakuteiSSRLayer1    ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )
            value.SGashaS4KakuteiSSRLayer2                  = (SoundKey)GetInt32(new IntPtr(p + 0x110)); // 02466542BC50 0x110 SGashaS4KakuteiSSRLayer2    ( 000186536C30 ModelEnumType SoundKey SoundKey SoundKey Int32 )

            return value;
        }
    }
}
