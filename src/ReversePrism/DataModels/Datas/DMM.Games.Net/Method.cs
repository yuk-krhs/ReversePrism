using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GET                                      Method IL2CPP_TYPE_CLASS
    // 008 POST                                     Method IL2CPP_TYPE_CLASS
    // 010 DELETE                                   00018660E270 ModelClassType Method Method Method Pointer
    // 018 PUT                                      00018660E270 ModelClassType Method Method Method Pointer
    // 010 ExistsRequestBody                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 011 ExistsResponseBody                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    public partial class Method
    {
        public Method?                                  DELETE                                  { get; set; }
        public Method?                                  PUT                                     { get; set; }
        public bool                                     ExistsRequestBody                       { get; set; }
        public bool                                     ExistsResponseBody                      { get; set; }
        public string                                   Name                                    { get; set; }

        public static Method? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Method();

            value.DELETE                                    = GetObject<Method>(new IntPtr(p + 0x010), ReversePrism.DataModels.Method.FromPointer); // 027004C0F5C0 0x10 DELETE                      ( 00018660E270 ModelClassType Method Method Method Pointer )
            value.PUT                                       = GetObject<Method>(new IntPtr(p + 0x018), ReversePrism.DataModels.Method.FromPointer); // 027004C0F5E0 0x18 PUT                         ( 00018660E270 ModelClassType Method Method Method Pointer )
            value.ExistsRequestBody                         = GetBool(new IntPtr(p + 0x010)); // 027004C0F600 0x10 ExistsRequestBody           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ExistsResponseBody                        = GetBool(new IntPtr(p + 0x011)); // 027004C0F620 0x11 ExistsResponseBody          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 027004C0F640 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
