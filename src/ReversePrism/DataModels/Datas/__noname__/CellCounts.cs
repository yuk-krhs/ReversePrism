using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BricksCount                              ModelPrimitiveType int int int Int32
    // 014 ProbesCount                              ModelPrimitiveType int int int Int32
    // 018 OffsetsCount                             ModelPrimitiveType int int int Int32
    // 01C ChunksCount                              ModelPrimitiveType int int int Int32
    public partial class CellCounts : DataModel
    {
        public int                                      BricksCount                             { get; set; }
        public int                                      ProbesCount                             { get; set; }
        public int                                      OffsetsCount                            { get; set; }
        public int                                      ChunksCount                             { get; set; }

        public static CellCounts? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CellCounts() { Pointer= p0 };

            value.BricksCount                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 BricksCount                 ( ModelPrimitiveType int int int Int32 )
            value.ProbesCount                               = GetInt32(new IntPtr(p + 0x014)); // 0x14 ProbesCount                 ( ModelPrimitiveType int int int Int32 )
            value.OffsetsCount                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 OffsetsCount                ( ModelPrimitiveType int int int Int32 )
            value.ChunksCount                               = GetInt32(new IntPtr(p + 0x01C)); // 0x1C ChunksCount                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
