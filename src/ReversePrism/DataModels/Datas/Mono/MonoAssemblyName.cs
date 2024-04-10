using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 name                                     <int> IL2CPP_TYPE_I
    // 018 culture                                  <int> IL2CPP_TYPE_I
    // 020 hash_value                               <int> IL2CPP_TYPE_I
    // 028 public_key                               <int> IL2CPP_TYPE_I
    // 030 Public_key_token                         00018673D220 ModelEnumType <public_key_token>e__FixedBuffer <public_key_token>e__FixedBuffer <public_key_token>e__FixedBuffer Int32
    // 044 Hash_alg                                 000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 048 Hash_len                                 000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 04C Flags                                    000186698DF0 ModelPrimitiveType uint uint uint UInt32
    // 050 Major                                    000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    // 052 Minor                                    000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    // 054 Build                                    000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    // 056 Revision                                 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    // 058 Arch                                     000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16
    public partial class MonoAssemblyName : DataModel
    {
        public <public_key_token>e__FixedBuffer         Public_key_token                        { get; set; }
        public uint                                     Hash_alg                                { get; set; }
        public uint                                     Hash_len                                { get; set; }
        public uint                                     Flags                                   { get; set; }
        public ushort                                   Major                                   { get; set; }
        public ushort                                   Minor                                   { get; set; }
        public ushort                                   Build                                   { get; set; }
        public ushort                                   Revision                                { get; set; }
        public ushort                                   Arch                                    { get; set; }

        public static MonoAssemblyName? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoAssemblyName() { Pointer= p0 };

            value.Public_key_token                          = (<public_key_token>e__FixedBuffer)GetInt32(new IntPtr(p + 0x030)); // 0246669A8400 0x30 Public_key_token            ( 00018673D220 ModelEnumType <public_key_token>e__FixedBuffer <public_key_token>e__FixedBuffer <public_key_token>e__FixedBuffer Int32 )
            value.Hash_alg                                  = GetUInt32(new IntPtr(p + 0x044)); // 0246669A8420 0x44 Hash_alg                    ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.Hash_len                                  = GetUInt32(new IntPtr(p + 0x048)); // 0246669A8440 0x48 Hash_len                    ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.Flags                                     = GetUInt32(new IntPtr(p + 0x04C)); // 0246669A8460 0x4C Flags                       ( 000186698DF0 ModelPrimitiveType uint uint uint UInt32 )
            value.Major                                     = GetUInt16(new IntPtr(p + 0x050)); // 0246669A8480 0x50 Major                       ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Minor                                     = GetUInt16(new IntPtr(p + 0x052)); // 0246669A84A0 0x52 Minor                       ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Build                                     = GetUInt16(new IntPtr(p + 0x054)); // 0246669A84C0 0x54 Build                       ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Revision                                  = GetUInt16(new IntPtr(p + 0x056)); // 0246669A84E0 0x56 Revision                    ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Arch                                      = GetUInt16(new IntPtr(p + 0x058)); // 0246669A8500 0x58 Arch                        ( 000186696DB0 ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
