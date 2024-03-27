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
    // 018 MstCostumeSetId                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstCostumeIdFieldNumber                  int IL2CPP_TYPE_I4
    // 01C MstCostumeId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstHairstyleIdFieldNumber                int IL2CPP_TYPE_I4
    // 020 MstHairstyleId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstAccessoryIdListFieldNumber            int IL2CPP_TYPE_I4
    // 008 _repeated_mstAccessoryIdList_codec       FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 028 MstAccessoryIdList                       000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 SortIdFieldNumber                        int IL2CPP_TYPE_I4
    // 030 SortId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ProductFieldNumber                       int IL2CPP_TYPE_I4
    // 038 Product                                  0001865A5470 ModelClassType ProductStatus ProductStatus ProductStatus Pointer
    public partial class CostumeSetStatus
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
            var value   = new CostumeSetStatus();

            value.MstCostumeSetId                           = GetInt32(new IntPtr(p + 0x018)); // 0270D0F526D8 0x18 MstCostumeSetId             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstCostumeId                              = GetInt32(new IntPtr(p + 0x01C)); // 0270D0F52718 0x1C MstCostumeId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstHairstyleId                            = GetInt32(new IntPtr(p + 0x020)); // 0270D0F52758 0x20 MstHairstyleId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstAccessoryIdList                        = GetInt32List(new IntPtr(p + 0x028)); // 0270D0F527B8 0x28 MstAccessoryIdList          ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x030)); // 0270D0F527F8 0x30 SortId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Product                                   = GetObject<ProductStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProductStatus.FromPointer); // 0270D0F52838 0x38 Product                     ( 0001865A5470 ModelClassType ProductStatus ProductStatus ProductStatus Pointer )

            return value;
        }
    }
}
