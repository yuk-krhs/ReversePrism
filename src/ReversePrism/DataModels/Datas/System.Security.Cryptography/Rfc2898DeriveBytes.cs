using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Password                                 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 Salt                                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 Iterations                               ModelPrimitiveType uint uint uint UInt32
    // 028 Hmac                                     ModelClassType HMAC HMAC HMAC Pointer
    // 030 BlockSize                                ModelPrimitiveType int int int Int32
    // 038 Buffer                                   ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 040 Block                                    ModelPrimitiveType uint uint uint UInt32
    // 044 StartIndex                               ModelPrimitiveType int int int Int32
    // 048 EndIndex                                 ModelPrimitiveType int int int Int32
    // 050 HashAlgorithm                            ModelEnumType HashAlgorithmName HashAlgorithmName HashAlgorithmName Int32
    public partial class Rfc2898DeriveBytes : DataModel
    {
        public List<sbyte>?                             Password                                { get; set; }
        public List<sbyte>?                             Salt                                    { get; set; }
        public uint                                     Iterations                              { get; set; }
        public HMAC?                                    Hmac                                    { get; set; }
        public int                                      BlockSize                               { get; set; }
        public List<sbyte>?                             Buffer                                  { get; set; }
        public uint                                     Block                                   { get; set; }
        public int                                      StartIndex                              { get; set; }
        public int                                      EndIndex                                { get; set; }
        public HashAlgorithmName                        HashAlgorithm                           { get; set; }

        public static Rfc2898DeriveBytes? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Rfc2898DeriveBytes() { Pointer= p0 };

            value.Password                                  = GetSByteList(new IntPtr(p + 0x010)); // 0x10 Password                    ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Salt                                      = GetSByteList(new IntPtr(p + 0x018)); // 0x18 Salt                        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Iterations                                = GetUInt32(new IntPtr(p + 0x020)); // 0x20 Iterations                  ( ModelPrimitiveType uint uint uint UInt32 )
            value.Hmac                                      = GetObject<HMAC>(new IntPtr(p + 0x028), ReversePrism.DataModels.HMAC.FromPointer); // 0x28 Hmac                        ( ModelClassType HMAC HMAC HMAC Pointer )
            value.BlockSize                                 = GetInt32(new IntPtr(p + 0x030)); // 0x30 BlockSize                   ( ModelPrimitiveType int int int Int32 )
            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x038)); // 0x38 Buffer                      ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Block                                     = GetUInt32(new IntPtr(p + 0x040)); // 0x40 Block                       ( ModelPrimitiveType uint uint uint UInt32 )
            value.StartIndex                                = GetInt32(new IntPtr(p + 0x044)); // 0x44 StartIndex                  ( ModelPrimitiveType int int int Int32 )
            value.EndIndex                                  = GetInt32(new IntPtr(p + 0x048)); // 0x48 EndIndex                    ( ModelPrimitiveType int int int Int32 )
            value.HashAlgorithm                             = (HashAlgorithmName)GetInt32(new IntPtr(p + 0x050)); // 0x50 HashAlgorithm               ( ModelEnumType HashAlgorithmName HashAlgorithmName HashAlgorithmName Int32 )

            return value;
        }
    }
}
