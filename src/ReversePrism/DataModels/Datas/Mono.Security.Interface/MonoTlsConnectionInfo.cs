using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CipherSuiteCode                          ModelEnumType CipherSuiteCode CipherSuiteCode CipherSuiteCode Int32
    // 014 ProtocolVersion                          ModelEnumType TlsProtocols TlsProtocols TlsProtocols Int32
    // 018 PeerDomainName                           ModelPrimitiveType string string string String
    public partial class MonoTlsConnectionInfo : DataModel
    {
        public CipherSuiteCode                          CipherSuiteCode                         { get; set; }
        public TlsProtocols                             ProtocolVersion                         { get; set; }
        public string                                   PeerDomainName                          { get; set; }

        public static MonoTlsConnectionInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoTlsConnectionInfo() { Pointer= p0 };

            value.CipherSuiteCode                           = (CipherSuiteCode)GetInt32(new IntPtr(p + 0x010)); // 0x10 CipherSuiteCode             ( ModelEnumType CipherSuiteCode CipherSuiteCode CipherSuiteCode Int32 )
            value.ProtocolVersion                           = (TlsProtocols)GetInt32(new IntPtr(p + 0x014)); // 0x14 ProtocolVersion             ( ModelEnumType TlsProtocols TlsProtocols TlsProtocols Int32 )
            value.PeerDomainName                            = GetString(new IntPtr(p + 0x018)); // 0x18 PeerDomainName              ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
