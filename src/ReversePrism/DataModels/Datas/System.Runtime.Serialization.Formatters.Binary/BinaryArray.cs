using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectId                                 ModelPrimitiveType int int int Int32
    // 014 Rank                                     ModelPrimitiveType int int int Int32
    // 018 LengthA                                  ModelPrimitiveListType int[] int[] List<int> Pointer
    // 020 LowerBoundA                              ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 BinaryTypeEnum                           ModelEnumType BinaryTypeEnum BinaryTypeEnum BinaryTypeEnum Int32
    // 030 typeInformation                          <object> IL2CPP_TYPE_OBJECT
    // 038 AssemId                                  ModelPrimitiveType int int int Int32
    // 03C BinaryHeaderEnum                         ModelEnumType BinaryHeaderEnum BinaryHeaderEnum BinaryHeaderEnum Int32
    // 040 BinaryArrayTypeEnum                      ModelEnumType BinaryArrayTypeEnum BinaryArrayTypeEnum BinaryArrayTypeEnum Int32
    public partial class BinaryArray : DataModel
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
            var value   = new BinaryArray() { Pointer= p0 };

            value.ObjectId                                  = GetInt32(new IntPtr(p + 0x010)); // 0x10 ObjectId                    ( ModelPrimitiveType int int int Int32 )
            value.Rank                                      = GetInt32(new IntPtr(p + 0x014)); // 0x14 Rank                        ( ModelPrimitiveType int int int Int32 )
            value.LengthA                                   = GetInt32List(new IntPtr(p + 0x018)); // 0x18 LengthA                     ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.LowerBoundA                               = GetInt32List(new IntPtr(p + 0x020)); // 0x20 LowerBoundA                 ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.BinaryTypeEnum                            = (BinaryTypeEnum)GetInt32(new IntPtr(p + 0x028)); // 0x28 BinaryTypeEnum              ( ModelEnumType BinaryTypeEnum BinaryTypeEnum BinaryTypeEnum Int32 )
            value.AssemId                                   = GetInt32(new IntPtr(p + 0x038)); // 0x38 AssemId                     ( ModelPrimitiveType int int int Int32 )
            value.BinaryHeaderEnum                          = (BinaryHeaderEnum)GetInt32(new IntPtr(p + 0x03C)); // 0x3C BinaryHeaderEnum            ( ModelEnumType BinaryHeaderEnum BinaryHeaderEnum BinaryHeaderEnum Int32 )
            value.BinaryArrayTypeEnum                       = (BinaryArrayTypeEnum)GetInt32(new IntPtr(p + 0x040)); // 0x40 BinaryArrayTypeEnum         ( ModelEnumType BinaryArrayTypeEnum BinaryArrayTypeEnum BinaryArrayTypeEnum Int32 )

            return value;
        }
    }
}
