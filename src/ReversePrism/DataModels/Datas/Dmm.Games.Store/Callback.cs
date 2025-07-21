using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GameObject                               ModelPrimitiveType string string string String
    // 018 MethodName                               ModelPrimitiveType string string string String
    public partial class Callback : DataModel
    {
        public string                                   GameObject                              { get; set; }
        public string                                   MethodName                              { get; set; }

        public static Callback? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Callback() { Pointer= p0 };

            value.GameObject                                = GetString(new IntPtr(p + 0x010)); // 0x10 GameObject                  ( ModelPrimitiveType string string string String )
            value.MethodName                                = GetString(new IntPtr(p + 0x018)); // 0x18 MethodName                  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
