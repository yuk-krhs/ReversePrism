using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 018 Parameter                                00018671C880 ModelClassType ParameterExpression ParameterExpression ParameterExpression Pointer
    public partial class LocalDefinition : DataModel
    {
        public int                                      Index                                   { get; set; }
        public ParameterExpression?                     Parameter                               { get; set; }

        public static LocalDefinition? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalDefinition() { Pointer= p0 };

            value.Index                                     = GetInt32(new IntPtr(p + 0x010)); // 02466A070210 0x10 Index                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Parameter                                 = GetObject<ParameterExpression>(new IntPtr(p + 0x018), ReversePrism.DataModels.ParameterExpression.FromPointer); // 02466A070230 0x18 Parameter                   ( 00018671C880 ModelClassType ParameterExpression ParameterExpression ParameterExpression Pointer )

            return value;
        }
    }
}
