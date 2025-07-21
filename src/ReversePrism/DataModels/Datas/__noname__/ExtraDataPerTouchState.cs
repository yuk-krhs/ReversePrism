using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AccumulatedDelta                         ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 UniqueId                                 ModelPrimitiveType uint uint uint UInt32
    public partial class ExtraDataPerTouchState : DataModel
    {
        public Vector2                                  AccumulatedDelta                        { get; set; }
        public uint                                     UniqueId                                { get; set; }

        public static ExtraDataPerTouchState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtraDataPerTouchState() { Pointer= p0 };

            value.AccumulatedDelta                          = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0x10 AccumulatedDelta            ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.UniqueId                                  = GetUInt32(new IntPtr(p + 0x018)); // 0x18 UniqueId                    ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
