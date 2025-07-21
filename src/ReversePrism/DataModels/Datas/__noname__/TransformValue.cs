using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IdName                                   ModelPrimitiveType string string string String
    // 018 Rotation                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 024 Position                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class TransformValue : DataModel
    {
        public string                                   IdName                                  { get; set; }
        public Vector3                                  Rotation                                { get; set; }
        public Vector3                                  Position                                { get; set; }

        public static TransformValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransformValue() { Pointer= p0 };

            value.IdName                                    = GetString(new IntPtr(p + 0x010)); // 0x10 IdName                      ( ModelPrimitiveType string string string String )
            value.Rotation                                  = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 0x18 Rotation                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x024)); // 0x24 Position                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
