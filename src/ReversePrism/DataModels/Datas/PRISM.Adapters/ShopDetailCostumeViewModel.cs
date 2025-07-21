using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstCharaInfoId                           ModelPrimitiveType int int int Int32
    // 018 CostumeTitleName                         ModelPrimitiveType string string string String
    // 020 MstCostumeSet                            ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer
    // 028 MstCostume                               ModelClassType MstCostume MstCostume MstCostume Pointer
    // 030 MstHairstyle                             ModelClassType MstHairstyle MstHairstyle MstHairstyle Pointer
    // 038 AccessoryArray                           ModelClassListType MstAccessory[] MstAccessory[] List<MstAccessory> Pointer
    public partial class ShopDetailCostumeViewModel : DataModel
    {
        public int                                      MstCharaInfoId                          { get; set; }
        public string                                   CostumeTitleName                        { get; set; }
        public MstCostumeSet?                           MstCostumeSet                           { get; set; }
        public MstCostume?                              MstCostume                              { get; set; }
        public MstHairstyle?                            MstHairstyle                            { get; set; }
        public List<MstAccessory>?                      AccessoryArray                          { get; set; }

        public static ShopDetailCostumeViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShopDetailCostumeViewModel() { Pointer= p0 };

            value.MstCharaInfoId                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstCharaInfoId              ( ModelPrimitiveType int int int Int32 )
            value.CostumeTitleName                          = GetString(new IntPtr(p + 0x018)); // 0x18 CostumeTitleName            ( ModelPrimitiveType string string string String )
            value.MstCostumeSet                             = GetObject<MstCostumeSet>(new IntPtr(p + 0x020), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 0x20 MstCostumeSet               ( ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )
            value.MstCostume                                = GetObject<MstCostume>(new IntPtr(p + 0x028), ReversePrism.DataModels.MstCostume.FromPointer); // 0x28 MstCostume                  ( ModelClassType MstCostume MstCostume MstCostume Pointer )
            value.MstHairstyle                              = GetObject<MstHairstyle>(new IntPtr(p + 0x030), ReversePrism.DataModels.MstHairstyle.FromPointer); // 0x30 MstHairstyle                ( ModelClassType MstHairstyle MstHairstyle MstHairstyle Pointer )
            value.AccessoryArray                            = GetObjectList<MstAccessory>(new IntPtr(p + 0x038), ReversePrism.DataModels.MstAccessory.FromPointer); // 0x38 AccessoryArray              ( ModelClassListType MstAccessory[] MstAccessory[] List<MstAccessory> Pointer )

            return value;
        }
    }
}
