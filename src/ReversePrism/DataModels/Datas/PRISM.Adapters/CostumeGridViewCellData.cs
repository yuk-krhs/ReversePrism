using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 CostumeCategory                          ModelEnumType CostumeCategory CostumeCategory CostumeCategory Int32
    // 02C IsUnlocked                               ModelPrimitiveType bool bool bool Bool
    // 030 CostumeName                              ModelPrimitiveType string string string String
    // 038 UnlockCondition                          ModelPrimitiveType string string string String
    // 040 OriginalOwnerCharacterId                 ModelPrimitiveType int int int Int32
    // 044 IsMyCostume                              ModelPrimitiveType bool bool bool Bool
    // 045 CanDressOrder                            ModelPrimitiveType bool bool bool Bool
    // 048 SortId                                   ModelPrimitiveType int int int Int32
    public partial class CostumeGridViewCellData : DataModel
    {
        public CostumeCategory                          CostumeCategory                         { get; set; }
        public bool                                     IsUnlocked                              { get; set; }
        public string                                   CostumeName                             { get; set; }
        public string                                   UnlockCondition                         { get; set; }
        public int                                      OriginalOwnerCharacterId                { get; set; }
        public bool                                     IsMyCostume                             { get; set; }
        public bool                                     CanDressOrder                           { get; set; }
        public int                                      SortId                                  { get; set; }

        public static CostumeGridViewCellData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeGridViewCellData() { Pointer= p0 };

            value.CostumeCategory                           = (CostumeCategory)GetInt32(new IntPtr(p + 0x028)); // 0x28 CostumeCategory             ( ModelEnumType CostumeCategory CostumeCategory CostumeCategory Int32 )
            value.IsUnlocked                                = GetBool(new IntPtr(p + 0x02C)); // 0x2C IsUnlocked                  ( ModelPrimitiveType bool bool bool Bool )
            value.CostumeName                               = GetString(new IntPtr(p + 0x030)); // 0x30 CostumeName                 ( ModelPrimitiveType string string string String )
            value.UnlockCondition                           = GetString(new IntPtr(p + 0x038)); // 0x38 UnlockCondition             ( ModelPrimitiveType string string string String )
            value.OriginalOwnerCharacterId                  = GetInt32(new IntPtr(p + 0x040)); // 0x40 OriginalOwnerCharacterId    ( ModelPrimitiveType int int int Int32 )
            value.IsMyCostume                               = GetBool(new IntPtr(p + 0x044)); // 0x44 IsMyCostume                 ( ModelPrimitiveType bool bool bool Bool )
            value.CanDressOrder                             = GetBool(new IntPtr(p + 0x045)); // 0x45 CanDressOrder               ( ModelPrimitiveType bool bool bool Bool )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x048)); // 0x48 SortId                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
