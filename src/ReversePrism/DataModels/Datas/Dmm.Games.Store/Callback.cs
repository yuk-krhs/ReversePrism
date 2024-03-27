using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GameObject                               0001866722E0 ModelPrimitiveType string string string String
    // 018 MethodName                               0001866722E0 ModelPrimitiveType string string string String
    public partial class Callback
    {
        public string                                   GameObject                              { get; set; }
        public string                                   MethodName                              { get; set; }

        public static Callback? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Callback();

            value.GameObject                                = GetString(new IntPtr(p + 0x010)); // 0270DB49B9E0 0x10 GameObject                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.MethodName                                = GetString(new IntPtr(p + 0x018)); // 0270DB49BA00 0x18 MethodName                  ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
