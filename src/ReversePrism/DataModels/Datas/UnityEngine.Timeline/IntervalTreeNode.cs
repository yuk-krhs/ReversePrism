using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Center                                   ModelPrimitiveType long long long Int64
    // 018 First                                    ModelPrimitiveType int int int Int32
    // 01C Last                                     ModelPrimitiveType int int int Int32
    // 020 Left                                     ModelPrimitiveType int int int Int32
    // 024 Right                                    ModelPrimitiveType int int int Int32
    public partial class IntervalTreeNode : DataModel
    {
        public long                                     Center                                  { get; set; }
        public int                                      First                                   { get; set; }
        public int                                      Last                                    { get; set; }
        public int                                      Left                                    { get; set; }
        public int                                      Right                                   { get; set; }

        public static IntervalTreeNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IntervalTreeNode() { Pointer= p0 };

            value.Center                                    = GetInt64(new IntPtr(p + 0x010)); // 0x10 Center                      ( ModelPrimitiveType long long long Int64 )
            value.First                                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 First                       ( ModelPrimitiveType int int int Int32 )
            value.Last                                      = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Last                        ( ModelPrimitiveType int int int Int32 )
            value.Left                                      = GetInt32(new IntPtr(p + 0x020)); // 0x20 Left                        ( ModelPrimitiveType int int int Int32 )
            value.Right                                     = GetInt32(new IntPtr(p + 0x024)); // 0x24 Right                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
