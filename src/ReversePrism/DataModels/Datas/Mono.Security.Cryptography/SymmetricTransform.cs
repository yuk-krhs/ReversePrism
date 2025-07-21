using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Algo                                     ModelClassType SymmetricAlgorithm SymmetricAlgorithm SymmetricAlgorithm Pointer
    // 018 Encrypt                                  ModelPrimitiveType bool bool bool Bool
    // 01C BlockSizeByte                            ModelPrimitiveType int int int Int32
    // 020 Temp                                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 028 Temp2                                    ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 030 WorkBuff                                 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 038 Workout                                  ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 040 Padmode                                  ModelEnumType PaddingMode PaddingMode PaddingMode Int32
    // 044 FeedBackByte                             ModelPrimitiveType int int int Int32
    // 048 M_disposed                               ModelPrimitiveType bool bool bool Bool
    // 049 LastBlock                                ModelPrimitiveType bool bool bool Bool
    // 050 Rng                                      ModelClassType RandomNumberGenerator RandomNumberGenerator RandomNumberGenerator Pointer
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

            value.Algo                                      = GetObject<SymmetricAlgorithm>(new IntPtr(p + 0x010), ReversePrism.DataModels.SymmetricAlgorithm.FromPointer); // 0x10 Algo                        ( ModelClassType SymmetricAlgorithm SymmetricAlgorithm SymmetricAlgorithm Pointer )
            value.Encrypt                                   = GetBool(new IntPtr(p + 0x018)); // 0x18 Encrypt                     ( ModelPrimitiveType bool bool bool Bool )
            value.BlockSizeByte                             = GetInt32(new IntPtr(p + 0x01C)); // 0x1C BlockSizeByte               ( ModelPrimitiveType int int int Int32 )
            value.Temp                                      = GetSByteList(new IntPtr(p + 0x020)); // 0x20 Temp                        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Temp2                                     = GetSByteList(new IntPtr(p + 0x028)); // 0x28 Temp2                       ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.WorkBuff                                  = GetSByteList(new IntPtr(p + 0x030)); // 0x30 WorkBuff                    ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Workout                                   = GetSByteList(new IntPtr(p + 0x038)); // 0x38 Workout                     ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Padmode                                   = (PaddingMode)GetInt32(new IntPtr(p + 0x040)); // 0x40 Padmode                     ( ModelEnumType PaddingMode PaddingMode PaddingMode Int32 )
            value.FeedBackByte                              = GetInt32(new IntPtr(p + 0x044)); // 0x44 FeedBackByte                ( ModelPrimitiveType int int int Int32 )
            value.M_disposed                                = GetBool(new IntPtr(p + 0x048)); // 0x48 M_disposed                  ( ModelPrimitiveType bool bool bool Bool )
            value.LastBlock                                 = GetBool(new IntPtr(p + 0x049)); // 0x49 LastBlock                   ( ModelPrimitiveType bool bool bool Bool )
            value.Rng                                       = GetObject<RandomNumberGenerator>(new IntPtr(p + 0x050), ReversePrism.DataModels.RandomNumberGenerator.FromPointer); // 0x50 Rng                         ( ModelClassType RandomNumberGenerator RandomNumberGenerator RandomNumberGenerator Pointer )

            return value;
        }
    }
}
