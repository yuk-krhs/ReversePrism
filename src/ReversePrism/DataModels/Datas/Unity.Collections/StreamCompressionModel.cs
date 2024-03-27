using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_BucketSizes                            sbyte[] IL2CPP_TYPE_SZARRAY
    // 008 k_BucketOffsets                          uint[] IL2CPP_TYPE_SZARRAY
    // 010 K_FirstBucketCandidate                   000185B7DDE0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 018 K_DefaultModelData                       000185B7A380 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 000 k_AlphabetSize                           int IL2CPP_TYPE_I4
    // 000 k_MaxHuffmanSymbolLength                 int IL2CPP_TYPE_I4
    // 000 k_MaxContexts                            int IL2CPP_TYPE_I4
    // 010 M_Initialized                            00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 012 EncodeTable                              000186593260 ModelEnumType <encodeTable>e__FixedBuffer <encodeTable>e__FixedBuffer <encodeTable>e__FixedBuffer Int32
    // 032 DecodeTable                              000186592D60 ModelEnumType <decodeTable>e__FixedBuffer <decodeTable>e__FixedBuffer <decodeTable>e__FixedBuffer Int32
    // 0B2 BucketSizes                              000186592880 ModelEnumType <bucketSizes>e__FixedBuffer <bucketSizes>e__FixedBuffer <bucketSizes>e__FixedBuffer Int32
    // 0C4 BucketOffsets                            000186592380 ModelEnumType <bucketOffsets>e__FixedBuffer <bucketOffsets>e__FixedBuffer <bucketOffsets>e__FixedBuffer Int32
    public partial class StreamCompressionModel
    {
        public List<int>?                               K_FirstBucketCandidate                  { get; set; }
        public List<sbyte>?                             K_DefaultModelData                      { get; set; }
        public sbyte                                    M_Initialized                           { get; set; }
        public <encodeTable>e__FixedBuffer              EncodeTable                             { get; set; }
        public <decodeTable>e__FixedBuffer              DecodeTable                             { get; set; }
        public <bucketSizes>e__FixedBuffer              BucketSizes                             { get; set; }
        public <bucketOffsets>e__FixedBuffer            BucketOffsets                           { get; set; }

        public static StreamCompressionModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StreamCompressionModel();

            value.K_FirstBucketCandidate                    = GetInt32List(new IntPtr(p + 0x010)); // 0270D98A42E0 0x10 K_FirstBucketCandidate      ( 000185B7DDE0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.K_DefaultModelData                        = GetSByteList(new IntPtr(p + 0x018)); // 0270D98A4300 0x18 K_DefaultModelData          ( 000185B7A380 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.M_Initialized                             = GetSByte(new IntPtr(p + 0x010)); // 0270D98A4380 0x10 M_Initialized               ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.EncodeTable                               = (<encodeTable>e__FixedBuffer)GetInt32(new IntPtr(p + 0x012)); // 0270D98A43A0 0x12 EncodeTable                 ( 000186593260 ModelEnumType <encodeTable>e__FixedBuffer <encodeTable>e__FixedBuffer <encodeTable>e__FixedBuffer Int32 )
            value.DecodeTable                               = (<decodeTable>e__FixedBuffer)GetInt32(new IntPtr(p + 0x032)); // 0270D98A43C0 0x32 DecodeTable                 ( 000186592D60 ModelEnumType <decodeTable>e__FixedBuffer <decodeTable>e__FixedBuffer <decodeTable>e__FixedBuffer Int32 )
            value.BucketSizes                               = (<bucketSizes>e__FixedBuffer)GetInt32(new IntPtr(p + 0x0B2)); // 0270D98A43E0 0xB2 BucketSizes                 ( 000186592880 ModelEnumType <bucketSizes>e__FixedBuffer <bucketSizes>e__FixedBuffer <bucketSizes>e__FixedBuffer Int32 )
            value.BucketOffsets                             = (<bucketOffsets>e__FixedBuffer)GetInt32(new IntPtr(p + 0x0C4)); // 0270D98A4400 0xC4 BucketOffsets               ( 000186592380 ModelEnumType <bucketOffsets>e__FixedBuffer <bucketOffsets>e__FixedBuffer <bucketOffsets>e__FixedBuffer Int32 )

            return value;
        }
    }
}
