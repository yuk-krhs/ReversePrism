using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_patchSize                              0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C M_errorCode                              000186630F60 ModelEnumType TerrainMapStatusCode TerrainMapStatusCode TerrainMapStatusCode Int32
    // 020 m_terrainTiles                           Dictionary`2<TerrainTileCoord, Terrain> IL2CPP_TYPE_GENERICINST
    public partial class TerrainMap : DataModel
    {
        public Vector3                                  M_patchSize                             { get; set; }
        public TerrainMapStatusCode                     M_errorCode                             { get; set; }

        public static TerrainMap? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TerrainMap() { Pointer= p0 };

            value.M_patchSize                               = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0245A6929F88 0x10 M_patchSize                 ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_errorCode                               = (TerrainMapStatusCode)GetInt32(new IntPtr(p + 0x01C)); // 0245A6929FA8 0x1C M_errorCode                 ( 000186630F60 ModelEnumType TerrainMapStatusCode TerrainMapStatusCode TerrainMapStatusCode Int32 )

            return value;
        }
    }
}
