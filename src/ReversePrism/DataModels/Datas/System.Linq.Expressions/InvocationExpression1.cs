using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 _arg0                                    <object> IL2CPP_TYPE_OBJECT
    public partial class InvocationExpression1
    {

        public static InvocationExpression1? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InvocationExpression1();


            return value;
        }
    }
}
