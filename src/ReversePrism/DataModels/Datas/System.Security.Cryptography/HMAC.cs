using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 BlockSizeValue                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 M_hashName                               000186671BA0 ModelPrimitiveType string string string String
    // 040 M_hash1                                  0001866A9050 ModelClassType HashAlgorithm HashAlgorithm HashAlgorithm Pointer
    // 048 M_hash2                                  0001866A9050 ModelClassType HashAlgorithm HashAlgorithm HashAlgorithm Pointer
    // 050 M_inner                                  000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 058 M_outer                                  000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 060 M_hashing                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class HMAC
    {
        public int                                      BlockSizeValue                          { get; set; }
        public string                                   M_hashName                              { get; set; }
        public HashAlgorithm?                           M_hash1                                 { get; set; }
        public HashAlgorithm?                           M_hash2                                 { get; set; }
        public List<sbyte>?                             M_inner                                 { get; set; }
        public List<sbyte>?                             M_outer                                 { get; set; }
        public bool                                     M_hashing                               { get; set; }

        public static HMAC? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HMAC();

            value.BlockSizeValue                            = GetInt32(new IntPtr(p + 0x030)); // 027003D048F8 0x30 BlockSizeValue              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_hashName                                = GetString(new IntPtr(p + 0x038)); // 027003D04918 0x38 M_hashName                  ( 000186671BA0 ModelPrimitiveType string string string String )
            value.M_hash1                                   = GetObject<HashAlgorithm>(new IntPtr(p + 0x040), ReversePrism.DataModels.HashAlgorithm.FromPointer); // 027003D04938 0x40 M_hash1                     ( 0001866A9050 ModelClassType HashAlgorithm HashAlgorithm HashAlgorithm Pointer )
            value.M_hash2                                   = GetObject<HashAlgorithm>(new IntPtr(p + 0x048), ReversePrism.DataModels.HashAlgorithm.FromPointer); // 027003D04958 0x48 M_hash2                     ( 0001866A9050 ModelClassType HashAlgorithm HashAlgorithm HashAlgorithm Pointer )
            value.M_inner                                   = GetSByteList(new IntPtr(p + 0x050)); // 027003D04978 0x50 M_inner                     ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.M_outer                                   = GetSByteList(new IntPtr(p + 0x058)); // 027003D04998 0x58 M_outer                     ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.M_hashing                                 = GetBool(new IntPtr(p + 0x060)); // 027003D049B8 0x60 M_hashing                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
