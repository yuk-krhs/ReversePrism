using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InstanceID                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Scale                                    000186666050 ModelPrimitiveType float float float Single
    // 018 Sizes                                    0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class Cookie : DataModel
    {
        public int                                      InstanceID                              { get; set; }
        public float                                    Scale                                   { get; set; }
        public Vector2                                  Sizes                                   { get; set; }

        public static Cookie? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Cookie() { Pointer= p0 };

            value.InstanceID                                = GetInt32(new IntPtr(p + 0x010)); // 0245A689A6A0 0x10 InstanceID                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Scale                                     = GetSingle(new IntPtr(p + 0x014)); // 0245A689A6C0 0x14 Scale                       ( 000186666050 ModelPrimitiveType float float float Single )
            value.Sizes                                     = (Vector2)GetInt32(new IntPtr(p + 0x018)); // 0245A689A6E0 0x18 Sizes                       ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
