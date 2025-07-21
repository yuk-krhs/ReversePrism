using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Certificate                              ModelClassType X509Certificate2 X509Certificate2 X509Certificate2 Pointer
    // 018 Status                                   ModelEnumListType X509ChainStatus[] X509ChainStatus[] List<X509ChainStatus> Pointer
    // 020 Info                                     ModelPrimitiveType string string string String
    // 028 Compressed_status_flags                  ModelEnumType X509ChainStatusFlags X509ChainStatusFlags X509ChainStatusFlags Int32
    public partial class X509ChainElement : DataModel
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
            var value   = new X509ChainElement() { Pointer= p0 };

            value.Certificate                               = GetObject<X509Certificate2>(new IntPtr(p + 0x010), ReversePrism.DataModels.X509Certificate2.FromPointer); // 0x10 Certificate                 ( ModelClassType X509Certificate2 X509Certificate2 X509Certificate2 Pointer )
            value.Status                                    = GetEnumList<X509ChainStatus>(new IntPtr(p + 0x018)); // 0x18 Status                      ( ModelEnumListType X509ChainStatus[] X509ChainStatus[] List<X509ChainStatus> Pointer )
            value.Info                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Info                        ( ModelPrimitiveType string string string String )
            value.Compressed_status_flags                   = (X509ChainStatusFlags)GetInt32(new IntPtr(p + 0x028)); // 0x28 Compressed_status_flags     ( ModelEnumType X509ChainStatusFlags X509ChainStatusFlags X509ChainStatusFlags Int32 )

            return value;
        }
    }
}
