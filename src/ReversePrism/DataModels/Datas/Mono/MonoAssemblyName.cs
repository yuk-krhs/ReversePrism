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
    // 030 Public_key_token                         ModelEnumType <public_key_token>e__FixedBuffer <public_key_token>e__FixedBuffer <public_key_token>e__FixedBuffer Int32
    // 044 Hash_alg                                 ModelPrimitiveType uint uint uint UInt32
    // 048 Hash_len                                 ModelPrimitiveType uint uint uint UInt32
    // 04C Flags                                    ModelPrimitiveType uint uint uint UInt32
    // 050 Major                                    ModelPrimitiveType ushort ushort ushort UInt16
    // 052 Minor                                    ModelPrimitiveType ushort ushort ushort UInt16
    // 054 Build                                    ModelPrimitiveType ushort ushort ushort UInt16
    // 056 Revision                                 ModelPrimitiveType ushort ushort ushort UInt16
    // 058 Arch                                     ModelPrimitiveType ushort ushort ushort UInt16
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

            value.Public_key_token                          = (<public_key_token>e__FixedBuffer)GetInt32(new IntPtr(p + 0x030)); // 0x30 Public_key_token            ( ModelEnumType <public_key_token>e__FixedBuffer <public_key_token>e__FixedBuffer <public_key_token>e__FixedBuffer Int32 )
            value.Hash_alg                                  = GetUInt32(new IntPtr(p + 0x044)); // 0x44 Hash_alg                    ( ModelPrimitiveType uint uint uint UInt32 )
            value.Hash_len                                  = GetUInt32(new IntPtr(p + 0x048)); // 0x48 Hash_len                    ( ModelPrimitiveType uint uint uint UInt32 )
            value.Flags                                     = GetUInt32(new IntPtr(p + 0x04C)); // 0x4C Flags                       ( ModelPrimitiveType uint uint uint UInt32 )
            value.Major                                     = GetUInt16(new IntPtr(p + 0x050)); // 0x50 Major                       ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Minor                                     = GetUInt16(new IntPtr(p + 0x052)); // 0x52 Minor                       ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Build                                     = GetUInt16(new IntPtr(p + 0x054)); // 0x54 Build                       ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Revision                                  = GetUInt16(new IntPtr(p + 0x056)); // 0x56 Revision                    ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Arch                                      = GetUInt16(new IntPtr(p + 0x058)); // 0x58 Arch                        ( ModelPrimitiveType ushort ushort ushort UInt16 )

            return value;
        }
    }
}
