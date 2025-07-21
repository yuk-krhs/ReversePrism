using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 CostumeType                              ModelPrimitiveType int int int Int32
    // 018 MstCostumeId                             ModelPrimitiveType int int int Int32
    // 01C MstHairstyleId                           ModelPrimitiveType int int int Int32
    // 020 MstAccessoryIdList                       ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 SortId                                   ModelPrimitiveType int int int Int32
    // 030 Costume                                  ModelClassType MstCostume MstCostume MstCostume Pointer
    // 038 Hairstyle                                ModelClassType MstHairstyle MstHairstyle MstHairstyle Pointer
    // 040 Accessories                              ModelClassListType MstAccessory[] MstAccessory[] List<MstAccessory> Pointer
    public partial class MstCostumeSet : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      CostumeType                             { get; set; }
        public int                                      MstCostumeId                            { get; set; }
        public int                                      MstHairstyleId                          { get; set; }
        public List<int>?                               MstAccessoryIdList                      { get; set; }
        public int                                      SortId                                  { get; set; }
        public MstCostume?                              Costume                                 { get; set; }
        public MstHairstyle?                            Hairstyle                               { get; set; }
        public List<MstAccessory>?                      Accessories                             { get; set; }

        public static MstCostumeSet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstCostumeSet() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.CostumeType                               = GetInt32(new IntPtr(p + 0x014)); // 0x14 CostumeType                 ( ModelPrimitiveType int int int Int32 )
            value.MstCostumeId                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstCostumeId                ( ModelPrimitiveType int int int Int32 )
            value.MstHairstyleId                            = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstHairstyleId              ( ModelPrimitiveType int int int Int32 )
            value.MstAccessoryIdList                        = GetInt32List(new IntPtr(p + 0x020)); // 0x20 MstAccessoryIdList          ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x028)); // 0x28 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.Costume                                   = GetObject<MstCostume>(new IntPtr(p + 0x030), ReversePrism.DataModels.MstCostume.FromPointer); // 0x30 Costume                     ( ModelClassType MstCostume MstCostume MstCostume Pointer )
            value.Hairstyle                                 = GetObject<MstHairstyle>(new IntPtr(p + 0x038), ReversePrism.DataModels.MstHairstyle.FromPointer); // 0x38 Hairstyle                   ( ModelClassType MstHairstyle MstHairstyle MstHairstyle Pointer )
            value.Accessories                               = GetObjectList<MstAccessory>(new IntPtr(p + 0x040), ReversePrism.DataModels.MstAccessory.FromPointer); // 0x40 Accessories                 ( ModelClassListType MstAccessory[] MstAccessory[] List<MstAccessory> Pointer )

            return value;
        }
    }
}
