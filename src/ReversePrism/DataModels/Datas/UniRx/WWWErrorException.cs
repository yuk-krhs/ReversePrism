using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 RawErrorMessage                          ModelPrimitiveType string string string String
    // 098 HasResponse                              ModelPrimitiveType bool bool bool Bool
    // 0A0 Text                                     ModelPrimitiveType string string string String
    // 0A8 StatusCode                               ModelEnumType HttpStatusCode HttpStatusCode HttpStatusCode Int32
    // 0B0 <ResponseHeaders>k__BackingField         Dictionary`2<string, string> IL2CPP_TYPE_GENERICINST
    // 0B8 WWW                                      ModelClassType WWW WWW WWW Pointer
    public partial class WWWErrorException : DataModel
    {
        public string                                   RawErrorMessage                         { get; set; }
        public bool                                     HasResponse                             { get; set; }
        public string                                   Text                                    { get; set; }
        public HttpStatusCode                           StatusCode                              { get; set; }
        public WWW?                                     WWW                                     { get; set; }

        public static WWWErrorException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WWWErrorException() { Pointer= p0 };

            value.RawErrorMessage                           = GetString(new IntPtr(p + 0x090)); // 0x90 RawErrorMessage             ( ModelPrimitiveType string string string String )
            value.HasResponse                               = GetBool(new IntPtr(p + 0x098)); // 0x98 HasResponse                 ( ModelPrimitiveType bool bool bool Bool )
            value.Text                                      = GetString(new IntPtr(p + 0x0A0)); // 0xA0 Text                        ( ModelPrimitiveType string string string String )
            value.StatusCode                                = (HttpStatusCode)GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 StatusCode                  ( ModelEnumType HttpStatusCode HttpStatusCode HttpStatusCode Int32 )
            value.WWW                                       = GetObject<WWW>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.WWW.FromPointer); // 0xB8 WWW                         ( ModelClassType WWW WWW WWW Pointer )

            return value;
        }
    }
}
