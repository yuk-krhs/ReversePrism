using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Position                                 ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 01C SubdivisionLevel                         ModelPrimitiveType int int int Int32
    public partial class Brick : DataModel
    {
        public Vector3Int                               Position                                { get; set; }
        public int                                      SubdivisionLevel                        { get; set; }

        public static Brick? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Brick() { Pointer= p0 };

            value.Position                                  = (Vector3Int)GetInt32(new IntPtr(p + 0x010)); // 0x10 Position                    ( ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.SubdivisionLevel                          = GetInt32(new IntPtr(p + 0x01C)); // 0x1C SubdivisionLevel            ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
