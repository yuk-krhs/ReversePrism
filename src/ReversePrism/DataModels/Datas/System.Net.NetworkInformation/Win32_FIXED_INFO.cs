using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 HostName                                 ModelPrimitiveType string string string String
    // 018 DomainName                               ModelPrimitiveType string string string String
    // 020 CurrentDnsServer                         <int> IL2CPP_TYPE_I
    // 028 DnsServerList                            ModelEnumType Win32_IP_ADDR_STRING Win32_IP_ADDR_STRING Win32_IP_ADDR_STRING Int32
    // 048 NodeType                                 ModelEnumType NetBiosNodeType NetBiosNodeType NetBiosNodeType Int32
    // 050 ScopeId                                  ModelPrimitiveType string string string String
    // 058 EnableRouting                            ModelPrimitiveType uint uint uint UInt32
    // 05C EnableProxy                              ModelPrimitiveType uint uint uint UInt32
    // 060 EnableDns                                ModelPrimitiveType uint uint uint UInt32
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

            value.HostName                                  = GetString(new IntPtr(p + 0x010)); // 0x10 HostName                    ( ModelPrimitiveType string string string String )
            value.DomainName                                = GetString(new IntPtr(p + 0x018)); // 0x18 DomainName                  ( ModelPrimitiveType string string string String )
            value.DnsServerList                             = (Win32_IP_ADDR_STRING)GetInt32(new IntPtr(p + 0x028)); // 0x28 DnsServerList               ( ModelEnumType Win32_IP_ADDR_STRING Win32_IP_ADDR_STRING Win32_IP_ADDR_STRING Int32 )
            value.NodeType                                  = (NetBiosNodeType)GetInt32(new IntPtr(p + 0x048)); // 0x48 NodeType                    ( ModelEnumType NetBiosNodeType NetBiosNodeType NetBiosNodeType Int32 )
            value.ScopeId                                   = GetString(new IntPtr(p + 0x050)); // 0x50 ScopeId                     ( ModelPrimitiveType string string string String )
            value.EnableRouting                             = GetUInt32(new IntPtr(p + 0x058)); // 0x58 EnableRouting               ( ModelPrimitiveType uint uint uint UInt32 )
            value.EnableProxy                               = GetUInt32(new IntPtr(p + 0x05C)); // 0x5C EnableProxy                 ( ModelPrimitiveType uint uint uint UInt32 )
            value.EnableDns                                 = GetUInt32(new IntPtr(p + 0x060)); // 0x60 EnableDns                   ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
