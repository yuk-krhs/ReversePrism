using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Algo                                     000186600AD0 ModelClassType SymmetricAlgorithm SymmetricAlgorithm SymmetricAlgorithm Pointer
    // 018 Encrypt                                  000186595480 ModelPrimitiveType bool bool bool Bool
    // 01C BlockSizeByte                            0001865F3220 ModelPrimitiveType int int int Int32
    // 020 Temp                                     000185B79A50 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 Temp2                                    000185B79A50 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 WorkBuff                                 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 038 Workout                                  000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 040 Padmode                                  000186713600 ModelEnumType PaddingMode PaddingMode PaddingMode Int32
    // 044 FeedBackByte                             0001865F3220 ModelPrimitiveType int int int Int32
    // 048 M_disposed                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 049 LastBlock                                000186595480 ModelPrimitiveType bool bool bool Bool
    // 050 Rng                                      00018660A680 ModelClassType RandomNumberGenerator RandomNumberGenerator RandomNumberGenerator Pointer
    public partial class SymmetricTransform : DataModel
    {
        public SymmetricAlgorithm?                      Algo                                    { get; set; }
        public bool                                     Encrypt                                 { get; set; }
        public int                                      BlockSizeByte                           { get; set; }
        public List<sbyte>?                             Temp                                    { get; set; }
        public List<sbyte>?                             Temp2                                   { get; set; }
        public List<sbyte>?                             WorkBuff                                { get; set; }
        public List<sbyte>?                             Workout                                 { get; set; }
        public PaddingMode                              Padmode                                 { get; set; }
        public int                                      FeedBackByte                            { get; set; }
        public bool                                     M_disposed                              { get; set; }
        public bool                                     LastBlock                               { get; set; }
        public RandomNumberGenerator?                   Rng                                     { get; set; }

        public static SymmetricTransform? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SymmetricTransform() { Pointer= p0 };

            value.Algo                                      = GetObject<SymmetricAlgorithm>(new IntPtr(p + 0x010), ReversePrism.DataModels.SymmetricAlgorithm.FromPointer); // 024661952878 0x10 Algo                        ( 000186600AD0 ModelClassType SymmetricAlgorithm SymmetricAlgorithm SymmetricAlgorithm Pointer )
            value.Encrypt                                   = GetBool(new IntPtr(p + 0x018)); // 024661952898 0x18 Encrypt                     ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.BlockSizeByte                             = GetInt32(new IntPtr(p + 0x01C)); // 0246619528B8 0x1C BlockSizeByte               ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.Temp                                      = GetSByteList(new IntPtr(p + 0x020)); // 0246619528D8 0x20 Temp                        ( 000185B79A50 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Temp2                                     = GetSByteList(new IntPtr(p + 0x028)); // 0246619528F8 0x28 Temp2                       ( 000185B79A50 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.WorkBuff                                  = GetSByteList(new IntPtr(p + 0x030)); // 024661952918 0x30 WorkBuff                    ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Workout                                   = GetSByteList(new IntPtr(p + 0x038)); // 024661952938 0x38 Workout                     ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Padmode                                   = (PaddingMode)GetInt32(new IntPtr(p + 0x040)); // 024661952958 0x40 Padmode                     ( 000186713600 ModelEnumType PaddingMode PaddingMode PaddingMode Int32 )
            value.FeedBackByte                              = GetInt32(new IntPtr(p + 0x044)); // 024661952978 0x44 FeedBackByte                ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.M_disposed                                = GetBool(new IntPtr(p + 0x048)); // 024661952998 0x48 M_disposed                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LastBlock                                 = GetBool(new IntPtr(p + 0x049)); // 0246619529B8 0x49 LastBlock                   ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.Rng                                       = GetObject<RandomNumberGenerator>(new IntPtr(p + 0x050), ReversePrism.DataModels.RandomNumberGenerator.FromPointer); // 0246619529D8 0x50 Rng                         ( 00018660A680 ModelClassType RandomNumberGenerator RandomNumberGenerator RandomNumberGenerator Pointer )

            return value;
        }
    }
}
