using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _variables                               HybridReferenceDictionary`2<ParameterExpression, VariableScope> IL2CPP_TYPE_GENERICINST
    // 018 _closureVariables                        Dictionary`2<ParameterExpression, LocalVariable> IL2CPP_TYPE_GENERICINST
    // 020 LocalCount                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 MaxLocalCount                            0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LocalVariables : DataModel
    {
        public int                                      LocalCount                              { get; set; }
        public int                                      MaxLocalCount                           { get; set; }

        public static LocalVariables? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalVariables() { Pointer= p0 };

            value.LocalCount                                = GetInt32(new IntPtr(p + 0x020)); // 02466A050320 0x20 LocalCount                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxLocalCount                             = GetInt32(new IntPtr(p + 0x024)); // 02466A050340 0x24 MaxLocalCount               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
