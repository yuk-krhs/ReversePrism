using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Format                                   0001865511E0 ModelEnumType RawPcmFormat RawPcmFormat RawPcmFormat Int32
    // 014 MaxChannels                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 MaxSamplingRate                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C SoundRendererType                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 DecodeLatency                            0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 context                                  <int> IL2CPP_TYPE_I
    public partial class RawPcmPlayerConfig : DataModel
    {
        public RawPcmFormat                             Format                                  { get; set; }
        public int                                      MaxChannels                             { get; set; }
        public int                                      MaxSamplingRate                         { get; set; }
        public int                                      SoundRendererType                       { get; set; }
        public int                                      DecodeLatency                           { get; set; }

        public static RawPcmPlayerConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RawPcmPlayerConfig() { Pointer= p0 };

            value.Format                                    = (RawPcmFormat)GetInt32(new IntPtr(p + 0x010)); // 02466ACE2238 0x10 Format                      ( 0001865511E0 ModelEnumType RawPcmFormat RawPcmFormat RawPcmFormat Int32 )
            value.MaxChannels                               = GetInt32(new IntPtr(p + 0x014)); // 02466ACE2258 0x14 MaxChannels                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxSamplingRate                           = GetInt32(new IntPtr(p + 0x018)); // 02466ACE2278 0x18 MaxSamplingRate             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SoundRendererType                         = GetInt32(new IntPtr(p + 0x01C)); // 02466ACE2298 0x1C SoundRendererType           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.DecodeLatency                             = GetInt32(new IntPtr(p + 0x020)); // 02466ACE22B8 0x20 DecodeLatency               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
