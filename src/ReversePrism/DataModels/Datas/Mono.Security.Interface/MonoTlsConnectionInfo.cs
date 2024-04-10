using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CipherSuiteCode                          0001865ADB80 ModelEnumType CipherSuiteCode CipherSuiteCode CipherSuiteCode Int32
    // 014 ProtocolVersion                          00018667DB70 ModelEnumType TlsProtocols TlsProtocols TlsProtocols Int32
    // 018 PeerDomainName                           000186671910 ModelPrimitiveType string string string String
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

            value.CipherSuiteCode                           = (CipherSuiteCode)GetInt32(new IntPtr(p + 0x010)); // 0246679561A8 0x10 CipherSuiteCode             ( 0001865ADB80 ModelEnumType CipherSuiteCode CipherSuiteCode CipherSuiteCode Int32 )
            value.ProtocolVersion                           = (TlsProtocols)GetInt32(new IntPtr(p + 0x014)); // 0246679561C8 0x14 ProtocolVersion             ( 00018667DB70 ModelEnumType TlsProtocols TlsProtocols TlsProtocols Int32 )
            value.PeerDomainName                            = GetString(new IntPtr(p + 0x018)); // 0246679561E8 0x18 PeerDomainName              ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
