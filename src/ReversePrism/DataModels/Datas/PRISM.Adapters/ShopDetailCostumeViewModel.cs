using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstCharaInfoId                           0001865F4940 ModelPrimitiveType int int int Int32
    // 018 CostumeTitleName                         000186671910 ModelPrimitiveType string string string String
    // 020 MstCostumeSet                            00018661D250 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer
    // 028 MstCostume                               00018661C6D0 ModelClassType MstCostume MstCostume MstCostume Pointer
    // 030 MstHairstyle                             000186622510 ModelClassType MstHairstyle MstHairstyle MstHairstyle Pointer
    // 038 AccessoryArray                           000185B946F0 ModelClassListType MstAccessory[] MstAccessory[] List<MstAccessory> Pointer
    public partial class ShopDetailCostumeViewModel
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
            var value   = new ShopDetailCostumeViewModel();

            value.MstCharaInfoId                            = GetInt32(new IntPtr(p + 0x010)); // 0270D66FA378 0x10 MstCharaInfoId              ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.CostumeTitleName                          = GetString(new IntPtr(p + 0x018)); // 0270D66FA398 0x18 CostumeTitleName            ( 000186671910 ModelPrimitiveType string string string String )
            value.MstCostumeSet                             = GetObject<MstCostumeSet>(new IntPtr(p + 0x020), ReversePrism.DataModels.MstCostumeSet.FromPointer); // 0270D66FA3B8 0x20 MstCostumeSet               ( 00018661D250 ModelClassType MstCostumeSet MstCostumeSet MstCostumeSet Pointer )
            value.MstCostume                                = GetObject<MstCostume>(new IntPtr(p + 0x028), ReversePrism.DataModels.MstCostume.FromPointer); // 0270D66FA3D8 0x28 MstCostume                  ( 00018661C6D0 ModelClassType MstCostume MstCostume MstCostume Pointer )
            value.MstHairstyle                              = GetObject<MstHairstyle>(new IntPtr(p + 0x030), ReversePrism.DataModels.MstHairstyle.FromPointer); // 0270D66FA3F8 0x30 MstHairstyle                ( 000186622510 ModelClassType MstHairstyle MstHairstyle MstHairstyle Pointer )
            value.AccessoryArray                            = GetObjectList<MstAccessory>(new IntPtr(p + 0x038), ReversePrism.DataModels.MstAccessory.FromPointer); // 0270D66FA418 0x38 AccessoryArray              ( 000185B946F0 ModelClassListType MstAccessory[] MstAccessory[] List<MstAccessory> Pointer )

            return value;
        }
    }
}
