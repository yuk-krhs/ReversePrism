using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 tileRanges                               NativeArray`1<InclusiveRange> IL2CPP_TYPE_GENERICINST
    // 020 tileMasks                                NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 030 RangesPerItem                            ModelPrimitiveType int int int Int32
    // 034 ItemsPerTile                             ModelPrimitiveType int int int Int32
    // 038 WordsPerTile                             ModelPrimitiveType int int int Int32
    // 03C TileResolution                           ModelEnumType int2 int2 int2 Int32
    public partial class TileRangeExpansionJob : DataModel
    {
        public int                                      RangesPerItem                           { get; set; }
        public int                                      ItemsPerTile                            { get; set; }
        public int                                      WordsPerTile                            { get; set; }
        public int2                                     TileResolution                          { get; set; }

        public static TileRangeExpansionJob? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TileRangeExpansionJob() { Pointer= p0 };

            value.RangesPerItem                             = GetInt32(new IntPtr(p + 0x030)); // 0x30 RangesPerItem               ( ModelPrimitiveType int int int Int32 )
            value.ItemsPerTile                              = GetInt32(new IntPtr(p + 0x034)); // 0x34 ItemsPerTile                ( ModelPrimitiveType int int int Int32 )
            value.WordsPerTile                              = GetInt32(new IntPtr(p + 0x038)); // 0x38 WordsPerTile                ( ModelPrimitiveType int int int Int32 )
            value.TileResolution                            = (int2)GetInt32(new IntPtr(p + 0x03C)); // 0x3C TileResolution              ( ModelEnumType int2 int2 int2 Int32 )

            return value;
        }
    }
}
