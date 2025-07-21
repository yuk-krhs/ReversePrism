using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DeviceName                               ModelPrimitiveType string string string String
    // 018 SamplingRate                             ModelPrimitiveType int int int Int32
    // 01C NumChannels                              ModelPrimitiveType int int int Int32
    public partial class MicrophoneConfig : DataModel
    {
        public string                                   DeviceName                              { get; set; }
        public int                                      SamplingRate                            { get; set; }
        public int                                      NumChannels                             { get; set; }

        public static MicrophoneConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MicrophoneConfig() { Pointer= p0 };

            value.DeviceName                                = GetString(new IntPtr(p + 0x010)); // 0x10 DeviceName                  ( ModelPrimitiveType string string string String )
            value.SamplingRate                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 SamplingRate                ( ModelPrimitiveType int int int Int32 )
            value.NumChannels                               = GetInt32(new IntPtr(p + 0x01C)); // 0x1C NumChannels                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
