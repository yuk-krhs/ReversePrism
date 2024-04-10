using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Expression                               0001865CF210 ModelClassType Expression Expression Expression Pointer
    // 018 _instance                                <object> IL2CPP_TYPE_OBJECT
    public partial class InstanceRestriction : DataModel
    {
        public Expression?                              Expression                              { get; set; }

        public static InstanceRestriction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InstanceRestriction() { Pointer= p0 };

            value.Expression                                = GetObject<Expression>(new IntPtr(p + 0x010), ReversePrism.DataModels.Expression.FromPointer); // 02466A0D0678 0x10 Expression                  ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
