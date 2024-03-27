using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Any                                      IPAddress IL2CPP_TYPE_CLASS
    // 008 Loopback                                 IPAddress IL2CPP_TYPE_CLASS
    // 010 Broadcast                                0001865E3AC0 ModelClassType IPAddress IPAddress IPAddress Pointer
    // 018 None                                     0001865E3AC0 ModelClassType IPAddress IPAddress IPAddress Pointer
    // 000 LoopbackMask                             long IL2CPP_TYPE_I8
    // 020 IPv6Any                                  0001865E3AC0 ModelClassType IPAddress IPAddress IPAddress Pointer
    // 028 IPv6Loopback                             0001865E3AC0 ModelClassType IPAddress IPAddress IPAddress Pointer
    // 030 IPv6None                                 0001865E3AC0 ModelClassType IPAddress IPAddress IPAddress Pointer
    // 010 AddressOrScopeId                         000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 018 Numbers                                  000185CAED38 ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
    // 020 ToString                                 000186671910 ModelPrimitiveType string string string String
    // 028 HashCode                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 NumberOfLabels                           int IL2CPP_TYPE_I4
    public partial class IPAddress
    {
        public IPAddress?                               Broadcast                               { get; set; }
        public IPAddress?                               None                                    { get; set; }
        public IPAddress?                               IPv6Any                                 { get; set; }
        public IPAddress?                               IPv6Loopback                            { get; set; }
        public IPAddress?                               IPv6None                                { get; set; }
        public uint                                     AddressOrScopeId                        { get; set; }
        public List<ushort>?                            Numbers                                 { get; set; }
        public string                                   ToString                                { get; set; }
        public int                                      HashCode                                { get; set; }

        public static IPAddress? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IPAddress();

            value.Broadcast                                 = GetObject<IPAddress>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPAddress.FromPointer); // 0270D7A09E70 0x10 Broadcast                   ( 0001865E3AC0 ModelClassType IPAddress IPAddress IPAddress Pointer )
            value.None                                      = GetObject<IPAddress>(new IntPtr(p + 0x018), ReversePrism.DataModels.IPAddress.FromPointer); // 0270D7A09E90 0x18 None                        ( 0001865E3AC0 ModelClassType IPAddress IPAddress IPAddress Pointer )
            value.IPv6Any                                   = GetObject<IPAddress>(new IntPtr(p + 0x020), ReversePrism.DataModels.IPAddress.FromPointer); // 0270D7A09ED0 0x20 IPv6Any                     ( 0001865E3AC0 ModelClassType IPAddress IPAddress IPAddress Pointer )
            value.IPv6Loopback                              = GetObject<IPAddress>(new IntPtr(p + 0x028), ReversePrism.DataModels.IPAddress.FromPointer); // 0270D7A09EF0 0x28 IPv6Loopback                ( 0001865E3AC0 ModelClassType IPAddress IPAddress IPAddress Pointer )
            value.IPv6None                                  = GetObject<IPAddress>(new IntPtr(p + 0x030), ReversePrism.DataModels.IPAddress.FromPointer); // 0270D7A09F10 0x30 IPv6None                    ( 0001865E3AC0 ModelClassType IPAddress IPAddress IPAddress Pointer )
            value.AddressOrScopeId                          = GetUInt32(new IntPtr(p + 0x010)); // 0270D7A09F30 0x10 AddressOrScopeId            ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.Numbers                                   = GetUInt16List(new IntPtr(p + 0x018)); // 0270D7A09F50 0x18 Numbers                     ( 000185CAED38 ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )
            value.ToString                                  = GetString(new IntPtr(p + 0x020)); // 0270D7A09F70 0x20 ToString                    ( 000186671910 ModelPrimitiveType string string string String )
            value.HashCode                                  = GetInt32(new IntPtr(p + 0x028)); // 0270D7A09F90 0x28 HashCode                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
