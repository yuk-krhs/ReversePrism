using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Password                                 000185B79F90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 Salt                                     000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 Iterations                               000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 028 Hmac                                     0001866A3300 ModelClassType HMAC HMAC HMAC Pointer
    // 030 BlockSize                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 Buffer                                   000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 040 Block                                    000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 044 StartIndex                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 EndIndex                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 HashAlgorithm                            0001866A9530 ModelEnumType HashAlgorithmName HashAlgorithmName HashAlgorithmName Int32
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

            value.Password                                  = GetSByteList(new IntPtr(p + 0x010)); // 024661922D88 0x10 Password                    ( 000185B79F90 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Salt                                      = GetSByteList(new IntPtr(p + 0x018)); // 024661922DA8 0x18 Salt                        ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Iterations                                = GetUInt32(new IntPtr(p + 0x020)); // 024661922DC8 0x20 Iterations                  ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.Hmac                                      = GetObject<HMAC>(new IntPtr(p + 0x028), ReversePrism.DataModels.HMAC.FromPointer); // 024661922DE8 0x28 Hmac                        ( 0001866A3300 ModelClassType HMAC HMAC HMAC Pointer )
            value.BlockSize                                 = GetInt32(new IntPtr(p + 0x030)); // 024661922E08 0x30 BlockSize                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x038)); // 024661922E28 0x38 Buffer                      ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Block                                     = GetUInt32(new IntPtr(p + 0x040)); // 024661922E48 0x40 Block                       ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.StartIndex                                = GetInt32(new IntPtr(p + 0x044)); // 024661922E68 0x44 StartIndex                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EndIndex                                  = GetInt32(new IntPtr(p + 0x048)); // 024661922E88 0x48 EndIndex                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HashAlgorithm                             = (HashAlgorithmName)GetInt32(new IntPtr(p + 0x050)); // 024661922EA8 0x50 HashAlgorithm               ( 0001866A9530 ModelEnumType HashAlgorithmName HashAlgorithmName HashAlgorithmName Int32 )

            return value;
        }
    }
}
