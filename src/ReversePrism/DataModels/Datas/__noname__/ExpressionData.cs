using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MoveType                                 ModelEnumType MoveType MoveType MoveType Int32
    // 014 StartFrame                               ModelPrimitiveType int int int Int32
    // 018 ArgValue1                                ModelPrimitiveType int int int Int32
    // 01C ArgValue2                                ModelPrimitiveType int int int Int32
    public partial class ExpressionData : DataModel
    {
        public MoveType                                 MoveType                                { get; set; }
        public int                                      StartFrame                              { get; set; }
        public int                                      ArgValue1                               { get; set; }
        public int                                      ArgValue2                               { get; set; }

        public static ExpressionData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExpressionData() { Pointer= p0 };

            value.MoveType                                  = (MoveType)GetInt32(new IntPtr(p + 0x010)); // 0x10 MoveType                    ( ModelEnumType MoveType MoveType MoveType Int32 )
            value.StartFrame                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 StartFrame                  ( ModelPrimitiveType int int int Int32 )
            value.ArgValue1                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 ArgValue1                   ( ModelPrimitiveType int int int Int32 )
            value.ArgValue2                                 = GetInt32(new IntPtr(p + 0x01C)); // 0x1C ArgValue2                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
