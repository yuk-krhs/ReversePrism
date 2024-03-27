using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IdName                                   0001866722E0 ModelPrimitiveType string string string String
    // 018 Rotation                                 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 024 Position                                 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class TransformValue
    {
        public string                                   IdName                                  { get; set; }
        public Vector3                                  Rotation                                { get; set; }
        public Vector3                                  Position                                { get; set; }

        public static TransformValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransformValue();

            value.IdName                                    = GetString(new IntPtr(p + 0x010)); // 0270D4D61830 0x10 IdName                      ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Rotation                                  = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 0270D4D61850 0x18 Rotation                    ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x024)); // 0270D4D61870 0x24 Position                    ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
