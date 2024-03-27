using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 InitResult                               0001865E7600 ModelEnumType InitResult InitResult InitResult Int32
    public partial class InitializationException
    {
        public InitResult                               InitResult                              { get; set; }

        public static InitializationException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InitializationException();

            value.InitResult                                = (InitResult)GetInt32(new IntPtr(p + 0x090)); // 0270DB744C10 0x90 InitResult                  ( 0001865E7600 ModelEnumType InitResult InitResult InitResult Int32 )

            return value;
        }
    }
}
