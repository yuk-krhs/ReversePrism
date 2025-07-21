using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultUserName                          string IL2CPP_TYPE_STRING
    // 008 DefaultPassword                          string IL2CPP_TYPE_STRING
    // 010 Client                                   ModelClassType HttpClient HttpClient HttpClient Pointer
    // 018 UserName                                 ModelPrimitiveType string string string String
    // 020 Password                                 ModelPrimitiveType string string string String
    public partial class DevelopServerResponder : DataModel
    {
        public HttpClient?                              Client                                  { get; set; }
        public string                                   UserName                                { get; set; }
        public string                                   Password                                { get; set; }

        public static DevelopServerResponder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DevelopServerResponder() { Pointer= p0 };

            value.Client                                    = GetObject<HttpClient>(new IntPtr(p + 0x010), ReversePrism.DataModels.HttpClient.FromPointer); // 0x10 Client                      ( ModelClassType HttpClient HttpClient HttpClient Pointer )
            value.UserName                                  = GetString(new IntPtr(p + 0x018)); // 0x18 UserName                    ( ModelPrimitiveType string string string String )
            value.Password                                  = GetString(new IntPtr(p + 0x020)); // 0x20 Password                    ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
