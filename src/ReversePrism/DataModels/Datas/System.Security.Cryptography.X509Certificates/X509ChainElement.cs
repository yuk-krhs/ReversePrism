using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Certificate                              000186563D80 ModelClassType X509Certificate2 X509Certificate2 X509Certificate2 Pointer
    // 018 Status                                   000185CB2ED8 ModelEnumListType X509ChainStatus[] X509ChainStatus[] List<X509ChainStatus> Pointer
    // 020 Info                                     000186671910 ModelPrimitiveType string string string String
    // 028 Compressed_status_flags                  000186569910 ModelEnumType X509ChainStatusFlags X509ChainStatusFlags X509ChainStatusFlags Int32
    public partial class X509ChainElement
    {
        public X509Certificate2?                        Certificate                             { get; set; }
        public List<X509ChainStatus>?                   Status                                  { get; set; }
        public string                                   Info                                    { get; set; }
        public X509ChainStatusFlags                     Compressed_status_flags                 { get; set; }

        public static X509ChainElement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new X509ChainElement();

            value.Certificate                               = GetObject<X509Certificate2>(new IntPtr(p + 0x010), ReversePrism.DataModels.X509Certificate2.FromPointer); // 0270D79EA9C8 0x10 Certificate                 ( 000186563D80 ModelClassType X509Certificate2 X509Certificate2 X509Certificate2 Pointer )
            value.Status                                    = GetEnumList<X509ChainStatus>(new IntPtr(p + 0x018)); // 0270D79EA9E8 0x18 Status                      ( 000185CB2ED8 ModelEnumListType X509ChainStatus[] X509ChainStatus[] List<X509ChainStatus> Pointer )
            value.Info                                      = GetString(new IntPtr(p + 0x020)); // 0270D79EAA08 0x20 Info                        ( 000186671910 ModelPrimitiveType string string string String )
            value.Compressed_status_flags                   = (X509ChainStatusFlags)GetInt32(new IntPtr(p + 0x028)); // 0270D79EAA28 0x28 Compressed_status_flags     ( 000186569910 ModelEnumType X509ChainStatusFlags X509ChainStatusFlags X509ChainStatusFlags Int32 )

            return value;
        }
    }
}
