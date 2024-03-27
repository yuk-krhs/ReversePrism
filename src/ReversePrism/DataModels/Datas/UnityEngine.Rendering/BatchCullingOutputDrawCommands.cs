using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 drawCommands                             IntPtr IL2CPP_TYPE_PTR
    // 018 visibleInstances                         IntPtr IL2CPP_TYPE_PTR
    // 020 drawRanges                               IntPtr IL2CPP_TYPE_PTR
    // 028 instanceSortingPositions                 IntPtr IL2CPP_TYPE_PTR
    // 030 drawCommandPickingInstanceIDs            IntPtr IL2CPP_TYPE_PTR
    // 038 DrawCommandCount                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 03C VisibleInstanceCount                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 040 DrawRangeCount                           0001865F36C0 ModelPrimitiveType int int int Int32
    // 044 InstanceSortingPositionFloatCount        0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class BatchCullingOutputDrawCommands
    {
        public int                                      DrawCommandCount                        { get; set; }
        public int                                      VisibleInstanceCount                    { get; set; }
        public int                                      DrawRangeCount                          { get; set; }
        public int                                      InstanceSortingPositionFloatCount       { get; set; }

        public static BatchCullingOutputDrawCommands? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BatchCullingOutputDrawCommands();

            value.DrawCommandCount                          = GetInt32(new IntPtr(p + 0x038)); // 0270068CAD28 0x38 DrawCommandCount            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.VisibleInstanceCount                      = GetInt32(new IntPtr(p + 0x03C)); // 0270068CAD48 0x3C VisibleInstanceCount        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.DrawRangeCount                            = GetInt32(new IntPtr(p + 0x040)); // 0270068CAD68 0x40 DrawRangeCount              ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.InstanceSortingPositionFloatCount         = GetInt32(new IntPtr(p + 0x044)); // 0270068CAD88 0x44 InstanceSortingPositionFloatCount ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
