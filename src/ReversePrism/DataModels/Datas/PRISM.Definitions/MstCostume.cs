using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 MstCharacterInfoId                       0001865F4260 ModelPrimitiveType int int int Int32
    // 018 CostumeType                              0001865F4260 ModelPrimitiveType int int int Int32
    // 01C ResourceId                               0001865F4260 ModelPrimitiveType int int int Int32
    // 020 SortId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 028 CharacterInfo                            00018661BCB0 ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer
    // 030 Resource                                 00018661CCC0 ModelClassType MstCostumeResource MstCostumeResource MstCostumeResource Pointer
    public partial class MstCostume
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public int                                      CostumeType                             { get; set; }
        public int                                      ResourceId                              { get; set; }
        public int                                      SortId                                  { get; set; }
        public MstCharacterInfo?                        CharacterInfo                           { get; set; }
        public MstCostumeResource?                      Resource                                { get; set; }

        public static MstCostume? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstCostume();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 027004640388 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x014)); // 0270046403A8 0x14 MstCharacterInfoId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CostumeType                               = GetInt32(new IntPtr(p + 0x018)); // 0270046403C8 0x18 CostumeType                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ResourceId                                = GetInt32(new IntPtr(p + 0x01C)); // 0270046403E8 0x1C ResourceId                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x020)); // 027004640408 0x20 SortId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CharacterInfo                             = GetObject<MstCharacterInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MstCharacterInfo.FromPointer); // 027004640428 0x28 CharacterInfo               ( 00018661BCB0 ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer )
            value.Resource                                  = GetObject<MstCostumeResource>(new IntPtr(p + 0x030), ReversePrism.DataModels.MstCostumeResource.FromPointer); // 027004640448 0x30 Resource                    ( 00018661CCC0 ModelClassType MstCostumeResource MstCostumeResource MstCostumeResource Pointer )

            return value;
        }
    }
}
