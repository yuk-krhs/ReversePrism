using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 HostName                                 000186674C50 ModelPrimitiveType string string string String
    // 018 DomainName                               000186674C50 ModelPrimitiveType string string string String
    // 020 CurrentDnsServer                         <int> IL2CPP_TYPE_I
    // 028 DnsServerList                            00018655AFF0 ModelEnumType Win32_IP_ADDR_STRING Win32_IP_ADDR_STRING Win32_IP_ADDR_STRING Int32
    // 048 NodeType                                 0001866992E0 ModelEnumType NetBiosNodeType NetBiosNodeType NetBiosNodeType Int32
    // 050 ScopeId                                  000186674C50 ModelPrimitiveType string string string String
    // 058 EnableRouting                            0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 05C EnableProxy                              0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 060 EnableDns                                0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class Win32_FIXED_INFO : DataModel
    {
        public string                                   HostName                                { get; set; }
        public string                                   DomainName                              { get; set; }
        public Win32_IP_ADDR_STRING                     DnsServerList                           { get; set; }
        public NetBiosNodeType                          NodeType                                { get; set; }
        public string                                   ScopeId                                 { get; set; }
        public uint                                     EnableRouting                           { get; set; }
        public uint                                     EnableProxy                             { get; set; }
        public uint                                     EnableDns                               { get; set; }

        public static Win32_FIXED_INFO? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Win32_FIXED_INFO() { Pointer= p0 };

            value.HostName                                  = GetString(new IntPtr(p + 0x010)); // 024667B4B790 0x10 HostName                    ( 000186674C50 ModelPrimitiveType string string string String )
            value.DomainName                                = GetString(new IntPtr(p + 0x018)); // 024667B4B7B0 0x18 DomainName                  ( 000186674C50 ModelPrimitiveType string string string String )
            value.DnsServerList                             = (Win32_IP_ADDR_STRING)GetInt32(new IntPtr(p + 0x028)); // 024667B4B7F0 0x28 DnsServerList               ( 00018655AFF0 ModelEnumType Win32_IP_ADDR_STRING Win32_IP_ADDR_STRING Win32_IP_ADDR_STRING Int32 )
            value.NodeType                                  = (NetBiosNodeType)GetInt32(new IntPtr(p + 0x048)); // 024667B4B810 0x48 NodeType                    ( 0001866992E0 ModelEnumType NetBiosNodeType NetBiosNodeType NetBiosNodeType Int32 )
            value.ScopeId                                   = GetString(new IntPtr(p + 0x050)); // 024667B4B830 0x50 ScopeId                     ( 000186674C50 ModelPrimitiveType string string string String )
            value.EnableRouting                             = GetUInt32(new IntPtr(p + 0x058)); // 024667B4B850 0x58 EnableRouting               ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.EnableProxy                               = GetUInt32(new IntPtr(p + 0x05C)); // 024667B4B870 0x5C EnableProxy                 ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.EnableDns                                 = GetUInt32(new IntPtr(p + 0x060)); // 024667B4B890 0x60 EnableDns                   ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
