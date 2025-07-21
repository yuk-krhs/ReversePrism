using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Velocity                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C Weight                                   ModelPrimitiveType float float float Single
    // 020 Time                                     ModelPrimitiveType float float float Single
    public partial class Item : DataModel
    {
        public Vector3                                  Velocity                                { get; set; }
        public float                                    Weight                                  { get; set; }
        public float                                    Time                                    { get; set; }

        public static Item? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Item() { Pointer= p0 };

            value.Velocity                                  = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0x10 Velocity                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Weight                                    = GetSingle(new IntPtr(p + 0x01C)); // 0x1C Weight                      ( ModelPrimitiveType float float float Single )
            value.Time                                      = GetSingle(new IntPtr(p + 0x020)); // 0x20 Time                        ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
