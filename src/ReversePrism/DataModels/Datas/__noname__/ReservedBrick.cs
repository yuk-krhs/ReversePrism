using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Brick                                    0001865B35E0 ModelEnumType Brick Brick Brick Int32
    // 020 FlattenedIdx                             0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class ReservedBrick : DataModel
    {
        public Brick                                    Brick                                   { get; set; }
        public int                                      FlattenedIdx                            { get; set; }

        public static ReservedBrick? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReservedBrick() { Pointer= p0 };

            value.Brick                                     = (Brick)GetInt32(new IntPtr(p + 0x010)); // 0246692097B8 0x10 Brick                       ( 0001865B35E0 ModelEnumType Brick Brick Brick Int32 )
            value.FlattenedIdx                              = GetInt32(new IntPtr(p + 0x020)); // 0246692097D8 0x20 FlattenedIdx                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
