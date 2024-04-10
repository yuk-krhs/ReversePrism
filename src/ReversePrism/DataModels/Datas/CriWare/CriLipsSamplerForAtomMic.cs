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
    public partial class CriLipsSamplerForAtomMic : DataModel
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
            var value   = new CriLipsSamplerForAtomMic() { Pointer= p0 };

            value.MaximumSamplingRate                       = GetInt32(new IntPtr(p + 0x040)); // 02466BC28D58 0x40 MaximumSamplingRate         ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MinimumSupportSamplingRate                = GetInt32(new IntPtr(p + 0x044)); // 02466BC28D78 0x44 MinimumSupportSamplingRate  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MicrophoneConfig                          = (MicrophoneConfig)GetInt32(new IntPtr(p + 0x048)); // 02466BC28D98 0x48 MicrophoneConfig            ( 0001865607A0 ModelEnumType MicrophoneConfig MicrophoneConfig MicrophoneConfig Int32 )
            value.RunningMicConfig                          = (MicrophoneConfig)GetInt32(new IntPtr(p + 0x058)); // 02466BC28DB8 0x58 RunningMicConfig            ( 0001865607A0 ModelEnumType MicrophoneConfig MicrophoneConfig MicrophoneConfig Int32 )
            value.IsMicrophoneStarted                       = GetBool(new IntPtr(p + 0x068)); // 02466BC28DD8 0x68 IsMicrophoneStarted         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AutoConnect                               = GetBool(new IntPtr(p + 0x069)); // 02466BC28DF8 0x69 AutoConnect                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AtomExMic                                 = GetObject<CriAtomExMic>(new IntPtr(p + 0x070), ReversePrism.DataModels.CriAtomExMic.FromPointer); // 02466BC28E18 0x70 AtomExMic                   ( 000186647700 ModelClassType CriAtomExMic CriAtomExMic CriAtomExMic Pointer )
            value.ShouldLogMicDisconnection                 = GetBool(new IntPtr(p + 0x0A0)); // 02466BC28E58 0xA0 ShouldLogMicDisconnection   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
