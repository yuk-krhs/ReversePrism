using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DisplayNameEncoding                      00018672E680 ModelClassType Encoding Encoding Encoding Pointer
    // 018 DisplayName                              000186672F10 ModelPrimitiveType string string string String
    // 020 UserName                                 000186672F10 ModelPrimitiveType string string string String
    // 028 Host                                     000186672F10 ModelPrimitiveType string string string String
    // 000 s_encoderFactory                         EncodedStreamFactory IL2CPP_TYPE_CLASS
    public partial class MailAddress : DataModel
    {
        public Encoding?                                DisplayNameEncoding                     { get; set; }
        public string                                   DisplayName                             { get; set; }
        public string                                   UserName                                { get; set; }
        public string                                   Host                                    { get; set; }

        public static MailAddress? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MailAddress() { Pointer= p0 };

            value.DisplayNameEncoding                       = GetObject<Encoding>(new IntPtr(p + 0x010), ReversePrism.DataModels.Encoding.FromPointer); // 024667B7A8B8 0x10 DisplayNameEncoding         ( 00018672E680 ModelClassType Encoding Encoding Encoding Pointer )
            value.DisplayName                               = GetString(new IntPtr(p + 0x018)); // 024667B7A8D8 0x18 DisplayName                 ( 000186672F10 ModelPrimitiveType string string string String )
            value.UserName                                  = GetString(new IntPtr(p + 0x020)); // 024667B7A8F8 0x20 UserName                    ( 000186672F10 ModelPrimitiveType string string string String )
            value.Host                                      = GetString(new IntPtr(p + 0x028)); // 024667B7A918 0x28 Host                        ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
