using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Provider                                 ModelClassType IArgumentProvider IArgumentProvider IArgumentProvider Pointer
    // 018 Arg0                                     ModelClassType Expression Expression Expression Pointer
    public partial class ListArgumentProvider : DataModel
    {
        public IArgumentProvider?                       Provider                                { get; set; }
        public Expression?                              Arg0                                    { get; set; }

        public static ListArgumentProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ListArgumentProvider() { Pointer= p0 };

            value.Provider                                  = GetObject<IArgumentProvider>(new IntPtr(p + 0x010), ReversePrism.DataModels.IArgumentProvider.FromPointer); // 0x10 Provider                    ( ModelClassType IArgumentProvider IArgumentProvider IArgumentProvider Pointer )
            value.Arg0                                      = GetObject<Expression>(new IntPtr(p + 0x018), ReversePrism.DataModels.Expression.FromPointer); // 0x18 Arg0                        ( ModelClassType Expression Expression Expression Pointer )

            return value;
        }
    }
}
