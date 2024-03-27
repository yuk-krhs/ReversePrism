using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 MaximumSamplingRate                      0001865F4260 ModelPrimitiveType int int int Int32
    // 044 MinimumSupportSamplingRate               0001865F4260 ModelPrimitiveType int int int Int32
    // 048 MicrophoneConfig                         0001865607A0 ModelEnumType MicrophoneConfig MicrophoneConfig MicrophoneConfig Int32
    // 058 RunningMicConfig                         0001865607A0 ModelEnumType MicrophoneConfig MicrophoneConfig MicrophoneConfig Int32
    // 068 IsMicrophoneStarted                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 069 AutoConnect                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 070 AtomExMic                                000186647700 ModelClassType CriAtomExMic CriAtomExMic CriAtomExMic Pointer
    // 078 deviceInfo                               Nullable`1<DeviceInfo> IL2CPP_TYPE_GENERICINST
    // 0A0 ShouldLogMicDisconnection                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class CriLipsSamplerForAtomMic
    {
        public int                                      MaximumSamplingRate                     { get; set; }
        public int                                      MinimumSupportSamplingRate              { get; set; }
        public MicrophoneConfig                         MicrophoneConfig                        { get; set; }
        public MicrophoneConfig                         RunningMicConfig                        { get; set; }
        public bool                                     IsMicrophoneStarted                     { get; set; }
        public bool                                     AutoConnect                             { get; set; }
        public CriAtomExMic?                            AtomExMic                               { get; set; }
        public bool                                     ShouldLogMicDisconnection               { get; set; }

        public static CriLipsSamplerForAtomMic? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriLipsSamplerForAtomMic();

            value.MaximumSamplingRate                       = GetInt32(new IntPtr(p + 0x040)); // 0270DBBA8838 0x40 MaximumSamplingRate         ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MinimumSupportSamplingRate                = GetInt32(new IntPtr(p + 0x044)); // 0270DBBA8858 0x44 MinimumSupportSamplingRate  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MicrophoneConfig                          = (MicrophoneConfig)GetInt32(new IntPtr(p + 0x048)); // 0270DBBA8878 0x48 MicrophoneConfig            ( 0001865607A0 ModelEnumType MicrophoneConfig MicrophoneConfig MicrophoneConfig Int32 )
            value.RunningMicConfig                          = (MicrophoneConfig)GetInt32(new IntPtr(p + 0x058)); // 0270DBBA8898 0x58 RunningMicConfig            ( 0001865607A0 ModelEnumType MicrophoneConfig MicrophoneConfig MicrophoneConfig Int32 )
            value.IsMicrophoneStarted                       = GetBool(new IntPtr(p + 0x068)); // 0270DBBA88B8 0x68 IsMicrophoneStarted         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AutoConnect                               = GetBool(new IntPtr(p + 0x069)); // 0270DBBA88D8 0x69 AutoConnect                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AtomExMic                                 = GetObject<CriAtomExMic>(new IntPtr(p + 0x070), ReversePrism.DataModels.CriAtomExMic.FromPointer); // 0270DBBA88F8 0x70 AtomExMic                   ( 000186647700 ModelClassType CriAtomExMic CriAtomExMic CriAtomExMic Pointer )
            value.ShouldLogMicDisconnection                 = GetBool(new IntPtr(p + 0x0A0)); // 0270DBBA8938 0xA0 ShouldLogMicDisconnection   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
