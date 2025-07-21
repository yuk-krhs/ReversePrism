using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CompressionLimit                         ModelPrimitiveType float float float Single
    // 014 StretchLimit                             ModelPrimitiveType float float float Single
    public partial class TetherConstraintParams : DataModel
    {
        public float                                    CompressionLimit                        { get; set; }
        public float                                    StretchLimit                            { get; set; }

        public static TetherConstraintParams? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TetherConstraintParams() { Pointer= p0 };

            value.CompressionLimit                          = GetSingle(new IntPtr(p + 0x010)); // 0x10 CompressionLimit            ( ModelPrimitiveType float float float Single )
            value.StretchLimit                              = GetSingle(new IntPtr(p + 0x014)); // 0x14 StretchLimit                ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
