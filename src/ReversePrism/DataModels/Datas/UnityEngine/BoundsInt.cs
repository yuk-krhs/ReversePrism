using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Position                               ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 01C M_Size                                   ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    public partial class BoundsInt : DataModel
    {
        public Vector3Int                               M_Position                              { get; set; }
        public Vector3Int                               M_Size                                  { get; set; }

        public static BoundsInt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BoundsInt() { Pointer= p0 };

            value.M_Position                                = (Vector3Int)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Position                  ( ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.M_Size                                    = (Vector3Int)GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_Size                      ( ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )

            return value;
        }
    }
}
