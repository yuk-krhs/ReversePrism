using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Source                                   000186719870 ModelClassType AudioSource AudioSource AudioSource Pointer
    // 048 audioProcessBuffer                       Queue`1<float>[] IL2CPP_TYPE_SZARRAY
    // 050 LastTimeSample                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 054 AudioGetOutPutDataSampleLimit            0001865F4260 ModelPrimitiveType int int int Int32
    // 058 SamplingRate                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 060 audioSourceBuffer                        float[][] IL2CPP_TYPE_SZARRAY
    // 068 ProcessBuffer                            000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 070 IsConnected                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 071 IsPlaying                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class CriLipsSamplerForAudioSource
    {
        public AudioSource?                             Source                                  { get; set; }
        public int                                      LastTimeSample                          { get; set; }
        public int                                      AudioGetOutPutDataSampleLimit           { get; set; }
        public int                                      SamplingRate                            { get; set; }
        public List<float>?                             ProcessBuffer                           { get; set; }
        public bool                                     IsConnected                             { get; set; }
        public bool                                     IsPlaying                               { get; set; }

        public static CriLipsSamplerForAudioSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriLipsSamplerForAudioSource();

            value.Source                                    = GetObject<AudioSource>(new IntPtr(p + 0x040), ReversePrism.DataModels.AudioSource.FromPointer); // 0270DBBA90A8 0x40 Source                      ( 000186719870 ModelClassType AudioSource AudioSource AudioSource Pointer )
            value.LastTimeSample                            = GetInt32(new IntPtr(p + 0x050)); // 0270DBBA90E8 0x50 LastTimeSample              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AudioGetOutPutDataSampleLimit             = GetInt32(new IntPtr(p + 0x054)); // 0270DBBA9108 0x54 AudioGetOutPutDataSampleLimit ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.SamplingRate                              = GetInt32(new IntPtr(p + 0x058)); // 0270DBBA9128 0x58 SamplingRate                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProcessBuffer                             = GetSingleList(new IntPtr(p + 0x068)); // 0270DBBA9168 0x68 ProcessBuffer               ( 000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.IsConnected                               = GetBool(new IntPtr(p + 0x070)); // 0270DBBA9188 0x70 IsConnected                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsPlaying                                 = GetBool(new IntPtr(p + 0x071)); // 0270DBBA91A8 0x71 IsPlaying                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
