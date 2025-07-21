using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CreateDate                               ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<CostumeStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstCostumeIdFieldNumber                  int IL2CPP_TYPE_I4
    // 028 MstCostumeId                             ModelPrimitiveType int int int Int32
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 02C MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    // 000 IsUnlockedFieldNumber                    int IL2CPP_TYPE_I4
    // 030 IsUnlocked                               ModelPrimitiveType bool bool bool Bool
    // 000 CostumeTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 034 CostumeType                              ModelEnumType CostumeType CostumeType CostumeType Int32
    // 000 CreateDateFieldNumber                    int IL2CPP_TYPE_I4
    // 038 _CreateDate                              ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 SortIdFieldNumber                        int IL2CPP_TYPE_I4
    // 040 SortId                                   ModelPrimitiveType int int int Int32
    // 000 ProductFieldNumber                       int IL2CPP_TYPE_I4
    // 048 Product                                  ModelClassType ProductStatus ProductStatus ProductStatus Pointer
    // 000 ResourceIdFieldNumber                    int IL2CPP_TYPE_I4
    // 050 ResourceId                               ModelPrimitiveType int int int Int32
    // 000 IsDressOrderReleasedFieldNumber          int IL2CPP_TYPE_I4
    // 054 IsDressOrderReleased                     ModelPrimitiveType bool bool bool Bool
    // 000 DressOrderMstIdolIdListFieldNumber       int IL2CPP_TYPE_I4
    // 008 _repeated_dressOrderMstIdolIdList_codec  FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 058 DressOrderMstIdolIdList                  ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    public partial class CostumeStatus : DataModel
    {
        public DateTime                                 CreateDate                              { get; set; }
        public int                                      MstCostumeId                            { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public bool                                     IsUnlocked                              { get; set; }
        public CostumeType                              CostumeType                             { get; set; }
        public Timestamp?                               _CreateDate                             { get; set; }
        public int                                      SortId                                  { get; set; }
        public ProductStatus?                           Product                                 { get; set; }
        public int                                      ResourceId                              { get; set; }
        public bool                                     IsDressOrderReleased                    { get; set; }
        public List<int>?                               DressOrderMstIdolIdList                 { get; set; }

        public static CostumeStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeStatus() { Pointer= p0 };

            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x010)); // 0x10 CreateDate                  ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstCostumeId                              = GetInt32(new IntPtr(p + 0x028)); // 0x28 MstCostumeId                ( ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x02C)); // 0x2C MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.IsUnlocked                                = GetBool(new IntPtr(p + 0x030)); // 0x30 IsUnlocked                  ( ModelPrimitiveType bool bool bool Bool )
            value.CostumeType                               = (CostumeType)GetInt32(new IntPtr(p + 0x034)); // 0x34 CostumeType                 ( ModelEnumType CostumeType CostumeType CostumeType Int32 )
            value._CreateDate                               = GetObject<Timestamp>(new IntPtr(p + 0x038), ReversePrism.DataModels.Timestamp.FromPointer); // 0x38 _CreateDate                 ( ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x040)); // 0x40 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.Product                                   = GetObject<ProductStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProductStatus.FromPointer); // 0x48 Product                     ( ModelClassType ProductStatus ProductStatus ProductStatus Pointer )
            value.ResourceId                                = GetInt32(new IntPtr(p + 0x050)); // 0x50 ResourceId                  ( ModelPrimitiveType int int int Int32 )
            value.IsDressOrderReleased                      = GetBool(new IntPtr(p + 0x054)); // 0x54 IsDressOrderReleased        ( ModelPrimitiveType bool bool bool Bool )
            value.DressOrderMstIdolIdList                   = GetInt32List(new IntPtr(p + 0x058)); // 0x58 DressOrderMstIdolIdList     ( ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.CreateDate                    = ToDateTime(value._CreateDate);

            return value;
        }
    }
}
