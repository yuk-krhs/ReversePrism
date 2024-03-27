using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DeviceName                               0001866722E0 ModelPrimitiveType string string string String
    // 018 SamplingRate                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C NumChannels                              0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class MicrophoneConfig
    {
        public string                                   DeviceName                              { get; set; }
        public int                                      SamplingRate                            { get; set; }
        public int                                      NumChannels                             { get; set; }

        public static MicrophoneConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MicrophoneConfig();

            value.DeviceName                                = GetString(new IntPtr(p + 0x010)); // 0270DBBA8728 0x10 DeviceName                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.SamplingRate                              = GetInt32(new IntPtr(p + 0x018)); // 0270DBBA8748 0x18 SamplingRate                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.NumChannels                               = GetInt32(new IntPtr(p + 0x01C)); // 0270DBBA8768 0x1C NumChannels                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
