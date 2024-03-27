using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 NumDsp                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 MaxChannels                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 MaxSamplingRate                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C Config                                   000186554410 ModelEnumType TimeStretchConfig TimeStretchConfig TimeStretchConfig Int32
    public partial class ExTimeStretchConfig
    {
        public int                                      NumDsp                                  { get; set; }
        public int                                      MaxChannels                             { get; set; }
        public int                                      MaxSamplingRate                         { get; set; }
        public TimeStretchConfig                        Config                                  { get; set; }

        public static ExTimeStretchConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExTimeStretchConfig();

            value.NumDsp                                    = GetInt32(new IntPtr(p + 0x010)); // 0270DAC79E00 0x10 NumDsp                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxChannels                               = GetInt32(new IntPtr(p + 0x014)); // 0270DAC79E20 0x14 MaxChannels                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxSamplingRate                           = GetInt32(new IntPtr(p + 0x018)); // 0270DAC79E40 0x18 MaxSamplingRate             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Config                                    = (TimeStretchConfig)GetInt32(new IntPtr(p + 0x01C)); // 0270DAC79E60 0x1C Config                      ( 000186554410 ModelEnumType TimeStretchConfig TimeStretchConfig TimeStretchConfig Int32 )

            return value;
        }
    }
}
