using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Pos                                      ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C RotY                                     ModelPrimitiveType float float float Single
    // 020 AnimName                                 ModelPrimitiveType string string string String
    public partial class CharaData : DataModel
    {
        public Vector3                                  Pos                                     { get; set; }
        public float                                    RotY                                    { get; set; }
        public string                                   AnimName                                { get; set; }

        public static CharaData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharaData() { Pointer= p0 };

            value.Pos                                       = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0x10 Pos                         ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.RotY                                      = GetSingle(new IntPtr(p + 0x01C)); // 0x1C RotY                        ( ModelPrimitiveType float float float Single )
            value.AnimName                                  = GetString(new IntPtr(p + 0x020)); // 0x20 AnimName                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
