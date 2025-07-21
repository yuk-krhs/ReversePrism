using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _arg0                                    <object> IL2CPP_TYPE_OBJECT
    // 018 Arg1                                     ModelClassType Expression Expression Expression Pointer
    public partial class Block2 : DataModel
    {
        public Expression?                              Arg1                                    { get; set; }

        public static Block2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Block2() { Pointer= p0 };

            value.Arg1                                      = GetObject<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 0x18 Arg1                        ( ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
