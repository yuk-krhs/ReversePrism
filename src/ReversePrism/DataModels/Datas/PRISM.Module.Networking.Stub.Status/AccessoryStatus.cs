using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CreateDate                               000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 000 _parser                                  MessageParser`1<AccessoryStatus> IL2CPP_TYPE_GENERICINST
    // 020 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstAccessoryIdFieldNumber                int IL2CPP_TYPE_I4
    // 028 MstAccessoryId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstCharacterInfoIdFieldNumber            int IL2CPP_TYPE_I4
    // 02C MstCharacterInfoId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 AccessoryTypeFieldNumber                 int IL2CPP_TYPE_I4
    // 030 AccessoryType                            0001866727F0 ModelEnumType AccessoryType AccessoryType AccessoryType Int32
    // 000 IsUnlockedFieldNumber                    int IL2CPP_TYPE_I4
    // 034 IsUnlocked                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 CostumeTypeFieldNumber                   int IL2CPP_TYPE_I4
    // 038 CostumeType                              000186637B40 ModelEnumType CostumeType CostumeType CostumeType Int32
    // 000 CreateDateFieldNumber                    int IL2CPP_TYPE_I4
    // 040 _CreateDate                              000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer
    // 000 SortIdFieldNumber                        int IL2CPP_TYPE_I4
    // 048 SortId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ProductFieldNumber                       int IL2CPP_TYPE_I4
    // 050 Product                                  0001865A5470 ModelClassType ProductStatus ProductStatus ProductStatus Pointer
    // 000 ResourceIdFieldNumber                    int IL2CPP_TYPE_I4
    // 058 ResourceId                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class AccessoryStatus : DataModel
    {
        public DateTime                                 CreateDate                              { get; set; }
        public int                                      MstAccessoryId                          { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public AccessoryType                            AccessoryType                           { get; set; }
        public bool                                     IsUnlocked                              { get; set; }
        public CostumeType                              CostumeType                             { get; set; }
        public Timestamp?                               _CreateDate                             { get; set; }
        public int                                      SortId                                  { get; set; }
        public ProductStatus?                           Product                                 { get; set; }
        public int                                      ResourceId                              { get; set; }

        public static AccessoryStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AccessoryStatus() { Pointer= p0 };

            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x010)); // 024660EF65D8 0x10 CreateDate                  ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.MstAccessoryId                            = GetInt32(new IntPtr(p + 0x028)); // 024660EF6658 0x28 MstAccessoryId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x02C)); // 024660EF6698 0x2C MstCharacterInfoId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.AccessoryType                             = (AccessoryType)GetInt32(new IntPtr(p + 0x030)); // 024660EF66D8 0x30 AccessoryType               ( 0001866727F0 ModelEnumType AccessoryType AccessoryType AccessoryType Int32 )
            value.IsUnlocked                                = GetBool(new IntPtr(p + 0x034)); // 024660EF6718 0x34 IsUnlocked                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CostumeType                               = (CostumeType)GetInt32(new IntPtr(p + 0x038)); // 024660EF6758 0x38 CostumeType                 ( 000186637B40 ModelEnumType CostumeType CostumeType CostumeType Int32 )
            value._CreateDate                               = GetObject<Timestamp>(new IntPtr(p + 0x040), ReversePrism.DataModels.Timestamp.FromPointer); // 024660EF6798 0x40 _CreateDate                 ( 000186675810 ModelClassType Timestamp Timestamp Timestamp Pointer )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x048)); // 024660EF67D8 0x48 SortId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Product                                   = GetObject<ProductStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProductStatus.FromPointer); // 024660EF6818 0x50 Product                     ( 0001865A5470 ModelClassType ProductStatus ProductStatus ProductStatus Pointer )
            value.ResourceId                                = GetInt32(new IntPtr(p + 0x058)); // 024660EF6858 0x58 ResourceId                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CreateDate                    = ToDateTime(value._CreateDate);

            return value;
        }
    }
}
