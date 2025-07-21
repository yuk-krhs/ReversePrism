using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<CostumeSetStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstCostumeSetIdFieldNumber               int IL2CPP_TYPE_I4
    // 018 MstCostumeSetId                          ModelPrimitiveType int int int Int32
    // 000 MstCostumeIdFieldNumber                  int IL2CPP_TYPE_I4
    // 01C MstCostumeId                             ModelPrimitiveType int int int Int32
    // 000 MstHairstyleIdFieldNumber                int IL2CPP_TYPE_I4
    // 020 MstHairstyleId                           ModelPrimitiveType int int int Int32
    // 000 MstAccessoryIdListFieldNumber            int IL2CPP_TYPE_I4
    // 008 _repeated_mstAccessoryIdList_codec       FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 028 MstAccessoryIdList                       ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 SortIdFieldNumber                        int IL2CPP_TYPE_I4
    // 030 SortId                                   ModelPrimitiveType int int int Int32
    // 000 ProductFieldNumber                       int IL2CPP_TYPE_I4
    // 038 Product                                  ModelClassType ProductStatus ProductStatus ProductStatus Pointer
    public partial class CostumeSetStatus : DataModel
    {
        public int                                      MstCostumeSetId                         { get; set; }
        public int                                      MstCostumeId                            { get; set; }
        public int                                      MstHairstyleId                          { get; set; }
        public List<int>?                               MstAccessoryIdList                      { get; set; }
        public int                                      SortId                                  { get; set; }
        public ProductStatus?                           Product                                 { get; set; }

        public static CostumeSetStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeSetStatus() { Pointer= p0 };

            value.MstCostumeSetId                           = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstCostumeSetId             ( ModelPrimitiveType int int int Int32 )
            value.MstCostumeId                              = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstCostumeId                ( ModelPrimitiveType int int int Int32 )
            value.MstHairstyleId                            = GetInt32(new IntPtr(p + 0x020)); // 0x20 MstHairstyleId              ( ModelPrimitiveType int int int Int32 )
            value.MstAccessoryIdList                        = GetInt32List(new IntPtr(p + 0x028)); // 0x28 MstAccessoryIdList          ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x030)); // 0x30 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.Product                                   = GetObject<ProductStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProductStatus.FromPointer); // 0x38 Product                     ( ModelClassType ProductStatus ProductStatus ProductStatus Pointer )

            return value;
        }
    }
}
