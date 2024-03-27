using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BricksCount                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 ProbesCount                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 OffsetsCount                             0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C ChunksCount                              0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class CellCounts
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
            var value   = new CellCounts();

            value.BricksCount                               = GetInt32(new IntPtr(p + 0x010)); // 0270D91FFF18 0x10 BricksCount                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ProbesCount                               = GetInt32(new IntPtr(p + 0x014)); // 0270D91FFF38 0x14 ProbesCount                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.OffsetsCount                              = GetInt32(new IntPtr(p + 0x018)); // 0270D91FFF58 0x18 OffsetsCount                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ChunksCount                               = GetInt32(new IntPtr(p + 0x01C)); // 0270D91FFF78 0x1C ChunksCount                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
