using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Pos_id                                   0001866722E0 ModelPrimitiveType string string string String
    // 018 Position                                 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 024 Rotation                                 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class PositionData
    {
        public string                                   Pos_id                                  { get; set; }
        public Vector3                                  Position                                { get; set; }
        public Vector3                                  Rotation                                { get; set; }

        public static PositionData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PositionData();

            value.Pos_id                                    = GetString(new IntPtr(p + 0x010)); // 027006F348C0 0x10 Pos_id                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 027006F348E0 0x18 Position                    ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Rotation                                  = (Vector3)GetInt32(new IntPtr(p + 0x024)); // 027006F34900 0x24 Rotation                    ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
