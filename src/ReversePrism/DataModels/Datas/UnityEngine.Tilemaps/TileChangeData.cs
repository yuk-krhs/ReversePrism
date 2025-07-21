using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Position                               ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 020 M_TileAsset                              ModelClassType Object Object Object Pointer
    // 028 M_Color                                  ModelEnumType Color Color Color Int32
    // 038 M_Transform                              ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    public partial class TileChangeData : DataModel
    {
        public Vector3Int                               M_Position                              { get; set; }
        public Object?                                  M_TileAsset                             { get; set; }
        public Color                                    M_Color                                 { get; set; }
        public Matrix4x4                                M_Transform                             { get; set; }

        public static TileChangeData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TileChangeData() { Pointer= p0 };

            value.M_Position                                = (Vector3Int)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Position                  ( ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.M_TileAsset                               = GetObject<Object>(new IntPtr(p + 0x020), ReversePrism.DataModels.Object.FromPointer); // 0x20 M_TileAsset                 ( ModelClassType Object Object Object Pointer )
            value.M_Color                                   = (Color)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_Color                     ( ModelEnumType Color Color Color Int32 )
            value.M_Transform                               = (Matrix4x4)GetInt32(new IntPtr(p + 0x038)); // 0x38 M_Transform                 ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )

            return value;
        }
    }
}
