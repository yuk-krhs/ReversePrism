using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MaxNumDevices                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 CurrentNumDevices                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 MaxStateSizeInBytes                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C CurrentStateSizeInBytes                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 CurrentControlCount                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 CurrentLayoutCount                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 TotalEventBytes                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C TotalEventCount                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 TotalUpdateCount                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 TotalEventProcessingTime                 0001865C2950 ModelPrimitiveType double double double Double
    // 040 TotalEventLagTime                        0001865C2950 ModelPrimitiveType double double double Double
    public partial class InputMetrics
    {
        public int                                      MaxNumDevices                           { get; set; }
        public int                                      CurrentNumDevices                       { get; set; }
        public int                                      MaxStateSizeInBytes                     { get; set; }
        public int                                      CurrentStateSizeInBytes                 { get; set; }
        public int                                      CurrentControlCount                     { get; set; }
        public int                                      CurrentLayoutCount                      { get; set; }
        public int                                      TotalEventBytes                         { get; set; }
        public int                                      TotalEventCount                         { get; set; }
        public int                                      TotalUpdateCount                        { get; set; }
        public double                                   TotalEventProcessingTime                { get; set; }
        public double                                   TotalEventLagTime                       { get; set; }

        public static InputMetrics? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputMetrics();

            value.MaxNumDevices                             = GetInt32(new IntPtr(p + 0x010)); // 02700334E6B0 0x10 MaxNumDevices               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentNumDevices                         = GetInt32(new IntPtr(p + 0x014)); // 02700334E6D0 0x14 CurrentNumDevices           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxStateSizeInBytes                       = GetInt32(new IntPtr(p + 0x018)); // 02700334E6F0 0x18 MaxStateSizeInBytes         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentStateSizeInBytes                   = GetInt32(new IntPtr(p + 0x01C)); // 02700334E710 0x1C CurrentStateSizeInBytes     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentControlCount                       = GetInt32(new IntPtr(p + 0x020)); // 02700334E730 0x20 CurrentControlCount         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CurrentLayoutCount                        = GetInt32(new IntPtr(p + 0x024)); // 02700334E750 0x24 CurrentLayoutCount          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TotalEventBytes                           = GetInt32(new IntPtr(p + 0x028)); // 02700334E770 0x28 TotalEventBytes             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TotalEventCount                           = GetInt32(new IntPtr(p + 0x02C)); // 02700334E790 0x2C TotalEventCount             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TotalUpdateCount                          = GetInt32(new IntPtr(p + 0x030)); // 02700334E7B0 0x30 TotalUpdateCount            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TotalEventProcessingTime                  = GetDouble(new IntPtr(p + 0x038)); // 02700334E7D0 0x38 TotalEventProcessingTime    ( 0001865C2950 ModelPrimitiveType double double double Double )
            value.TotalEventLagTime                         = GetDouble(new IntPtr(p + 0x040)); // 02700334E7F0 0x40 TotalEventLagTime           ( 0001865C2950 ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
