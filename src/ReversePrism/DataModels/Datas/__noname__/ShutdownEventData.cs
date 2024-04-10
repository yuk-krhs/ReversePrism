using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Max_num_devices                          0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Max_state_size_in_bytes                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Total_event_bytes                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C Total_event_count                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 Total_frame_count                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 Total_event_processing_time              000186666050 ModelPrimitiveType float float float Single
    public partial class ShutdownEventData : DataModel
    {
        public int                                      Max_num_devices                         { get; set; }
        public int                                      Max_state_size_in_bytes                 { get; set; }
        public int                                      Total_event_bytes                       { get; set; }
        public int                                      Total_event_count                       { get; set; }
        public int                                      Total_frame_count                       { get; set; }
        public float                                    Total_event_processing_time             { get; set; }

        public static ShutdownEventData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShutdownEventData() { Pointer= p0 };

            value.Max_num_devices                           = GetInt32(new IntPtr(p + 0x010)); // 024667772B48 0x10 Max_num_devices             ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Max_state_size_in_bytes                   = GetInt32(new IntPtr(p + 0x014)); // 024667772B68 0x14 Max_state_size_in_bytes     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Total_event_bytes                         = GetInt32(new IntPtr(p + 0x018)); // 024667772B88 0x18 Total_event_bytes           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Total_event_count                         = GetInt32(new IntPtr(p + 0x01C)); // 024667772BA8 0x1C Total_event_count           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Total_frame_count                         = GetInt32(new IntPtr(p + 0x020)); // 024667772BC8 0x20 Total_frame_count           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Total_event_processing_time               = GetSingle(new IntPtr(p + 0x024)); // 024667772BE8 0x24 Total_event_processing_time ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
