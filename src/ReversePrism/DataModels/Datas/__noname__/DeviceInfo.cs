using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DeviceId                                 000186674C50 ModelPrimitiveType string string string String
    // 018 DeviceName                               000186674C50 ModelPrimitiveType string string string String
    // 020 DeviceFlags                              0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 024 MaxChannels                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 MaxSamplingRate                          0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class DeviceInfo : DataModel
    {
        public string                                   DeviceId                                { get; set; }
        public string                                   DeviceName                              { get; set; }
        public uint                                     DeviceFlags                             { get; set; }
        public int                                      MaxChannels                             { get; set; }
        public int                                      MaxSamplingRate                         { get; set; }

        public static DeviceInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeviceInfo() { Pointer= p0 };

            value.DeviceId                                  = GetString(new IntPtr(p + 0x010)); // 02466ACDC888 0x10 DeviceId                    ( 000186674C50 ModelPrimitiveType string string string String )
            value.DeviceName                                = GetString(new IntPtr(p + 0x018)); // 02466ACDC8A8 0x18 DeviceName                  ( 000186674C50 ModelPrimitiveType string string string String )
            value.DeviceFlags                               = GetUInt32(new IntPtr(p + 0x020)); // 02466ACDC8C8 0x20 DeviceFlags                 ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.MaxChannels                               = GetInt32(new IntPtr(p + 0x024)); // 02466ACDC8E8 0x24 MaxChannels                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MaxSamplingRate                           = GetInt32(new IntPtr(p + 0x028)); // 02466ACDC908 0x28 MaxSamplingRate             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
