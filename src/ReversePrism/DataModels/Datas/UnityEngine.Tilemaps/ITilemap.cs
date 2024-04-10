using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Instance                               ITilemap IL2CPP_TYPE_CLASS
    // 010 M_Tilemap                                0001866657B0 ModelClassType Tilemap Tilemap Tilemap Pointer
    // 018 M_AddToList                              000186595210 ModelPrimitiveType bool bool bool Bool
    // 01C M_RefreshCount                           0001865F2F90 ModelPrimitiveType int int int Int32
    // 020 m_RefreshPos                             NativeArray`1<Vector3Int> IL2CPP_TYPE_GENERICINST
    public partial class ITilemap : DataModel
    {
        public Tilemap?                                 M_Tilemap                               { get; set; }
        public bool                                     M_AddToList                             { get; set; }
        public int                                      M_RefreshCount                          { get; set; }

        public static ITilemap? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ITilemap() { Pointer= p0 };

            value.M_Tilemap                                 = GetObject<Tilemap>(new IntPtr(p + 0x010), ReversePrism.DataModels.Tilemap.FromPointer); // 0245A220C260 0x10 M_Tilemap                   ( 0001866657B0 ModelClassType Tilemap Tilemap Tilemap Pointer )
            value.M_AddToList                               = GetBool(new IntPtr(p + 0x018)); // 0245A220C280 0x18 M_AddToList                 ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.M_RefreshCount                            = GetInt32(new IntPtr(p + 0x01C)); // 0245A220C2A0 0x1C M_RefreshCount              ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
