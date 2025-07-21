using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 Source                                   ModelClassType AudioSource AudioSource AudioSource Pointer
    // 048 audioProcessBuffer                       Queue`1<float>[] IL2CPP_TYPE_SZARRAY
    // 050 LastTimeSample                           ModelPrimitiveType int int int Int32
    // 054 AudioGetOutPutDataSampleLimit            ModelPrimitiveType int int int Int32
    // 058 SamplingRate                             ModelPrimitiveType int int int Int32
    // 060 audioSourceBuffer                        float[][] IL2CPP_TYPE_SZARRAY
    // 068 ProcessBuffer                            ModelPrimitiveListType float[] float[] List<float> Pointer
    // 070 IsConnected                              ModelPrimitiveType bool bool bool Bool
    // 071 IsPlaying                                ModelPrimitiveType bool bool bool Bool
    public partial class CriLipsSamplerForAudioSource : DataModel
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
            var value   = new CriLipsSamplerForAudioSource() { Pointer= p0 };

            value.Source                                    = GetObject<AudioSource>(new IntPtr(p + 0x040), ReversePrism.DataModels.AudioSource.FromPointer); // 0x40 Source                      ( ModelClassType AudioSource AudioSource AudioSource Pointer )
            value.LastTimeSample                            = GetInt32(new IntPtr(p + 0x050)); // 0x50 LastTimeSample              ( ModelPrimitiveType int int int Int32 )
            value.AudioGetOutPutDataSampleLimit             = GetInt32(new IntPtr(p + 0x054)); // 0x54 AudioGetOutPutDataSampleLimit ( ModelPrimitiveType int int int Int32 )
            value.SamplingRate                              = GetInt32(new IntPtr(p + 0x058)); // 0x58 SamplingRate                ( ModelPrimitiveType int int int Int32 )
            value.ProcessBuffer                             = GetSingleList(new IntPtr(p + 0x068)); // 0x68 ProcessBuffer               ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.IsConnected                               = GetBool(new IntPtr(p + 0x070)); // 0x70 IsConnected                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsPlaying                                 = GetBool(new IntPtr(p + 0x071)); // 0x71 IsPlaying                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
