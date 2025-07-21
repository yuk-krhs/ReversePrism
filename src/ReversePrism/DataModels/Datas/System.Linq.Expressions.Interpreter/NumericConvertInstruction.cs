using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 From                                     ModelEnumType TypeCode TypeCode TypeCode Int32
    // 014 To                                       ModelEnumType TypeCode TypeCode TypeCode Int32
    // 018 IsLiftedToNull                           ModelPrimitiveType bool bool bool Bool
    public partial class NumericConvertInstruction : DataModel
    {
        public TypeCode                                 From                                    { get; set; }
        public TypeCode                                 To                                      { get; set; }
        public bool                                     IsLiftedToNull                          { get; set; }

        public static NumericConvertInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NumericConvertInstruction() { Pointer= p0 };

            value.From                                      = (TypeCode)GetInt32(new IntPtr(p + 0x010)); // 0x10 From                        ( ModelEnumType TypeCode TypeCode TypeCode Int32 )
            value.To                                        = (TypeCode)GetInt32(new IntPtr(p + 0x014)); // 0x14 To                          ( ModelEnumType TypeCode TypeCode TypeCode Int32 )
            value.IsLiftedToNull                            = GetBool(new IntPtr(p + 0x018)); // 0x18 IsLiftedToNull              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
