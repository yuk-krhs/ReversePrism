using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectId                                 0001865F2F90 ModelPrimitiveType int int int Int32
    // 014 Rank                                     0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 LengthA                                  000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 LowerBoundA                              000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 BinaryTypeEnum                           000186592980 ModelEnumType BinaryTypeEnum BinaryTypeEnum BinaryTypeEnum Int32
    // 030 typeInformation                          <object> IL2CPP_TYPE_OBJECT
    // 038 AssemId                                  0001865F2F90 ModelPrimitiveType int int int Int32
    // 03C BinaryHeaderEnum                         000186758040 ModelEnumType BinaryHeaderEnum BinaryHeaderEnum BinaryHeaderEnum Int32
    // 040 BinaryArrayTypeEnum                      000186754E30 ModelEnumType BinaryArrayTypeEnum BinaryArrayTypeEnum BinaryArrayTypeEnum Int32
    public partial class BinaryArray
    {
        public int                                      ObjectId                                { get; set; }
        public int                                      Rank                                    { get; set; }
        public List<int>?                               LengthA                                 { get; set; }
        public List<int>?                               LowerBoundA                             { get; set; }
        public BinaryTypeEnum                           BinaryTypeEnum                          { get; set; }
        public int                                      AssemId                                 { get; set; }
        public BinaryHeaderEnum                         BinaryHeaderEnum                        { get; set; }
        public BinaryArrayTypeEnum                      BinaryArrayTypeEnum                     { get; set; }

        public static BinaryArray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinaryArray();

            value.ObjectId                                  = GetInt32(new IntPtr(p + 0x010)); // 0270D6C32A30 0x10 ObjectId                    ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x014)); // 0270D6C32A50 0x14 Rank                        ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.LengthA                                   = GetInt32List(new IntPtr(p + 0x018)); // 0270D6C32A70 0x18 LengthA                     ( 000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.LowerBoundA                               = GetInt32List(new IntPtr(p + 0x020)); // 0270D6C32A90 0x20 LowerBoundA                 ( 000185B7D3F0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.BinaryTypeEnum                            = (BinaryTypeEnum)GetInt32(new IntPtr(p + 0x028)); // 0270D6C32AB0 0x28 BinaryTypeEnum              ( 000186592980 ModelEnumType BinaryTypeEnum BinaryTypeEnum BinaryTypeEnum Int32 )
            value.AssemId                                   = GetInt32(new IntPtr(p + 0x038)); // 0270D6C32AF0 0x38 AssemId                     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.BinaryHeaderEnum                          = (BinaryHeaderEnum)GetInt32(new IntPtr(p + 0x03C)); // 0270D6C32B10 0x3C BinaryHeaderEnum            ( 000186758040 ModelEnumType BinaryHeaderEnum BinaryHeaderEnum BinaryHeaderEnum Int32 )
            value.BinaryArrayTypeEnum                       = (BinaryArrayTypeEnum)GetInt32(new IntPtr(p + 0x040)); // 0270D6C32B30 0x40 BinaryArrayTypeEnum         ( 000186754E30 ModelEnumType BinaryArrayTypeEnum BinaryArrayTypeEnum BinaryArrayTypeEnum Int32 )

            return value;
        }
    }
}
