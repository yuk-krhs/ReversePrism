using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Position                               0001866AD970 ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 020 M_Tile                                   000186664460 ModelClassType TileBase TileBase TileBase Pointer
    // 028 M_TileData                               000186689DE0 ModelEnumType TileData TileData TileData Int32
    public partial class SyncTile
    {
        public Vector3Int                               M_Position                              { get; set; }
        public TileBase?                                M_Tile                                  { get; set; }
        public TileData                                 M_TileData                              { get; set; }

        public static SyncTile? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SyncTile();

            value.M_Position                                = (Vector3Int)GetInt32(new IntPtr(p + 0x010)); // 027006977AB8 0x10 M_Position                  ( 0001866AD970 ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.M_Tile                                    = GetObject<TileBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.TileBase.FromPointer); // 027006977AD8 0x20 M_Tile                      ( 000186664460 ModelClassType TileBase TileBase TileBase Pointer )
            value.M_TileData                                = (TileData)GetInt32(new IntPtr(p + 0x028)); // 027006977AF8 0x28 M_TileData                  ( 000186689DE0 ModelEnumType TileData TileData TileData Int32 )

            return value;
        }
    }
}
