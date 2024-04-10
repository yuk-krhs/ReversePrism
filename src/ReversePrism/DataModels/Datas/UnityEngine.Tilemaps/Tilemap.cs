using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 tilemapTileChanged                       Action`2<Tilemap, SyncTile[]> IL2CPP_TYPE_GENERICINST
    // 008 tilemapPositionsChanged                  Action`2<Tilemap, NativeArray`1<Vector3Int>> IL2CPP_TYPE_GENERICINST
    // 018 M_BufferSyncTile                         000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class Tilemap : DataModel
    {
        public bool                                     M_BufferSyncTile                        { get; set; }

        public static Tilemap? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Tilemap() { Pointer= p0 };

            value.M_BufferSyncTile                          = GetBool(new IntPtr(p + 0x018)); // 0245A221E4E8 0x18 M_BufferSyncTile            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
