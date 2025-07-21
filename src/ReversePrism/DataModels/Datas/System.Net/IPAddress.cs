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
    // 010 Broadcast                                ModelClassType IPAddress IPAddress IPAddress Pointer
    // 018 None                                     ModelClassType IPAddress IPAddress IPAddress Pointer
    // 000 LoopbackMask                             long IL2CPP_TYPE_I8
    // 020 IPv6Any                                  ModelClassType IPAddress IPAddress IPAddress Pointer
    // 028 IPv6Loopback                             ModelClassType IPAddress IPAddress IPAddress Pointer
    // 030 IPv6None                                 ModelClassType IPAddress IPAddress IPAddress Pointer
    // 010 AddressOrScopeId                         ModelPrimitiveType uint uint uint UInt32
    // 018 Numbers                                  ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
    // 020 ToString                                 ModelPrimitiveType string string string String
    // 028 HashCode                                 ModelPrimitiveType int int int Int32
    // 000 NumberOfLabels                           int IL2CPP_TYPE_I4
    public partial class IPAddress : DataModel
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
            var value   = new IPAddress() { Pointer= p0 };

            value.Broadcast                                 = GetObject<IPAddress>(new IntPtr(p + 0x010), ReversePrism.DataModels.IPAddress.FromPointer); // 0x10 Broadcast                   ( ModelClassType IPAddress IPAddress IPAddress Pointer )
            value.None                                      = GetObject<IPAddress>(new IntPtr(p + 0x018), ReversePrism.DataModels.IPAddress.FromPointer); // 0x18 None                        ( ModelClassType IPAddress IPAddress IPAddress Pointer )
            value.IPv6Any                                   = GetObject<IPAddress>(new IntPtr(p + 0x020), ReversePrism.DataModels.IPAddress.FromPointer); // 0x20 IPv6Any                     ( ModelClassType IPAddress IPAddress IPAddress Pointer )
            value.IPv6Loopback                              = GetObject<IPAddress>(new IntPtr(p + 0x028), ReversePrism.DataModels.IPAddress.FromPointer); // 0x28 IPv6Loopback                ( ModelClassType IPAddress IPAddress IPAddress Pointer )
            value.IPv6None                                  = GetObject<IPAddress>(new IntPtr(p + 0x030), ReversePrism.DataModels.IPAddress.FromPointer); // 0x30 IPv6None                    ( ModelClassType IPAddress IPAddress IPAddress Pointer )
            value.AddressOrScopeId                          = GetUInt32(new IntPtr(p + 0x010)); // 0x10 AddressOrScopeId            ( ModelPrimitiveType uint uint uint UInt32 )
            value.Numbers                                   = GetUInt16List(new IntPtr(p + 0x018)); // 0x18 Numbers                     ( ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )
            value.ToString                                  = GetString(new IntPtr(p + 0x020)); // 0x20 ToString                    ( ModelPrimitiveType string string string String )
            value.HashCode                                  = GetInt32(new IntPtr(p + 0x028)); // 0x28 HashCode                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
