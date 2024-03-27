using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Expression                               0001865CF210 ModelClassType Expression Expression Expression Pointer
    public partial class MemberAssignment
    {
        public Expression?                              Expression                              { get; set; }

        public static MemberAssignment? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemberAssignment();

            value.Expression                                = GetObject<Expression>(new IntPtr(p + 0x020), ReversePrism.DataModels.Expression.FromPointer); // 0270D9F66F28 0x20 Expression                  ( 0001865CF210 ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
