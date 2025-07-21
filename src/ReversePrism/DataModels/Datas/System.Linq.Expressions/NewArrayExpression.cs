using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelClassType Type Type Type Pointer
    // 018 <Expressions>k__BackingField             ReadOnlyCollection`1<Expression> IL2CPP_TYPE_GENERICINST
    public partial class NewArrayExpression : DataModel
    {
        public Type?                                    Type                                    { get; set; }

        public static NewArrayExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NewArrayExpression() { Pointer= p0 };

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 Type                        ( ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
