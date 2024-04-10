using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MoveType                                 00018666F3C0 ModelEnumType MoveType MoveType MoveType Int32
    // 014 StartFrame                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 ArgValue1                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 01C ArgValue2                                0001865F36C0 ModelPrimitiveType int int int Int32
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

            value.MoveType                                  = (MoveType)GetInt32(new IntPtr(p + 0x010)); // 0245A6A540E0 0x10 MoveType                    ( 00018666F3C0 ModelEnumType MoveType MoveType MoveType Int32 )
            value.StartFrame                                = GetInt32(new IntPtr(p + 0x014)); // 0245A6A54100 0x14 StartFrame                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ArgValue1                                 = GetInt32(new IntPtr(p + 0x018)); // 0245A6A54120 0x18 ArgValue1                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ArgValue2                                 = GetInt32(new IntPtr(p + 0x01C)); // 0245A6A54140 0x1C ArgValue2                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
