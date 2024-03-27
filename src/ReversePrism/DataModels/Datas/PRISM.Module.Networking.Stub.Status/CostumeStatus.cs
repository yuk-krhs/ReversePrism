using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CreateDate                               000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<CostumeStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstCostumeIdFieldNumber                  int IL2CPP_TYPE_I4
    // 028 MstCostumeId                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 02C MstCharacterInfoId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 IsUnlockedFieldNumber                    int IL2CPP_TYPE_I4
    // 030 IsUnlocked                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 CostumeTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 034 CostumeType                              000186637B40 ModelEnumType CostumeType CostumeType CostumeType Int32
    // 000 CreateDateFieldNumber                    int IL2CPP_TYPE_I4
    // 038 _CreateDate                              000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 SortIdFieldNumber                        int IL2CPP_TYPE_I4
    // 040 SortId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ProductFieldNumber                       int IL2CPP_TYPE_I4
    // 048 Product                                  0001865A5470 ModelClassType ProductStatus ProductStatus ProductStatus Pointer
    // 000 ResourceIdFieldNumber                    int IL2CPP_TYPE_I4
    // 050 ResourceId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class CostumeStatus
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

        public static CostumeStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeStatus();

            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x010)); // 0270D0F56170 0x10 CreateDate                  ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstCostumeId                              = GetInt32(new IntPtr(p + 0x028)); // 0270D0F561F0 0x28 MstCostumeId                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x02C)); // 0270D0F56230 0x2C MstCharacterInfoId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsUnlocked                                = GetBool(new IntPtr(p + 0x030)); // 0270D0F56270 0x30 IsUnlocked                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CostumeType                               = (CostumeType)GetInt32(new IntPtr(p + 0x034)); // 0270D0F562B0 0x34 CostumeType                 ( 000186637B40 ModelEnumType CostumeType CostumeType CostumeType Int32 )
            value._CreateDate                               = GetObject<Timestamp>(new IntPtr(p + 0x038), ReversePrism.DataModels.Timestamp.FromPointer); // 0270D0F562F0 0x38 _CreateDate                 ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x040)); // 0270D0F56330 0x40 SortId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Product                                   = GetObject<ProductStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProductStatus.FromPointer); // 0270D0F56370 0x48 Product                     ( 0001865A5470 ModelClassType ProductStatus ProductStatus ProductStatus Pointer )
            value.ResourceId                                = GetInt32(new IntPtr(p + 0x050)); // 0270D0F563B0 0x50 ResourceId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CreateDate                    = ToDateTime(value._CreateDate);

            return value;
        }
    }
}
