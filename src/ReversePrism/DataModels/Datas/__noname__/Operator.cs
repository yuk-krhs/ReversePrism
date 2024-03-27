using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Op                                       00018666D1C0 ModelEnumType Op Op Op Int32
    // 014 Precedence                               0001865F4940 ModelPrimitiveType int int int Int32
    // 018 Associativity                            00018666CA70 ModelEnumType Associativity Associativity Associativity Int32
    // 01C Inputs                                   0001865F4940 ModelPrimitiveType int int int Int32
    public partial class Operator
    {
        public Op                                       Op                                      { get; set; }
        public int                                      Precedence                              { get; set; }
        public Associativity                            Associativity                           { get; set; }
        public int                                      Inputs                                  { get; set; }

        public static Operator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Operator();

            value.Op                                        = (Op)GetInt32(new IntPtr(p + 0x010)); // 0270068A8C78 0x10 Op                          ( 00018666D1C0 ModelEnumType Op Op Op Int32 )
            value.Precedence                                = GetInt32(new IntPtr(p + 0x014)); // 0270068A8C98 0x14 Precedence                  ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.Associativity                             = (Associativity)GetInt32(new IntPtr(p + 0x018)); // 0270068A8CB8 0x18 Associativity               ( 00018666CA70 ModelEnumType Associativity Associativity Associativity Int32 )
            value.Inputs                                    = GetInt32(new IntPtr(p + 0x01C)); // 0270068A8CD8 0x1C Inputs                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
