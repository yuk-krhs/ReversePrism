using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Position                                 0001866ADBF0 ModelEnumType Vector3Int Vector3Int Vector3Int Int32
    // 01C SubdivisionLevel                         0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class Brick
    {
        public Vector3Int                               Position                                { get; set; }
        public int                                      SubdivisionLevel                        { get; set; }

        public static Brick? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Brick();

            value.Position                                  = (Vector3Int)GetInt32(new IntPtr(p + 0x010)); // 0270D91B63E0 0x10 Position                    ( 0001866ADBF0 ModelEnumType Vector3Int Vector3Int Vector3Int Int32 )
            value.SubdivisionLevel                          = GetInt32(new IntPtr(p + 0x01C)); // 0270D91B6400 0x1C SubdivisionLevel            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
