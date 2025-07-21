using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TileX                                    ModelPrimitiveType int int int Int32
    // 014 TileZ                                    ModelPrimitiveType int int int Int32
    public partial class TerrainTileCoord : DataModel
    {
        public int                                      TileX                                   { get; set; }
        public int                                      TileZ                                   { get; set; }

        public static TerrainTileCoord? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TerrainTileCoord() { Pointer= p0 };

            value.TileX                                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 TileX                       ( ModelPrimitiveType int int int Int32 )
            value.TileZ                                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 TileZ                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
