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
    // 01C HairResourceIdForClient                  0001865F4260 ModelPrimitiveType int int int Int32
    // 020 HairAccessoryResourceIdListForClient     000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 SortId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 030 CharacterInfo                            00018661BCB0 ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer
    // 038 HairResource                             000186622B00 ModelClassType MstHairstyleResource MstHairstyleResource MstHairstyleResource Pointer
    // 040 HairAccessoryResources                   000185B948E0 ModelClassListType MstAccessoryResource[] MstAccessoryResource[] List<MstAccessoryResource> Pointer
    public partial class MstHairstyle : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public int                                      CostumeType                             { get; set; }
        public int                                      HairResourceIdForClient                 { get; set; }
        public List<int>?                               HairAccessoryResourceIdListForClient    { get; set; }
        public int                                      SortId                                  { get; set; }
        public MstCharacterInfo?                        CharacterInfo                           { get; set; }
        public MstHairstyleResource?                    HairResource                            { get; set; }
        public List<MstAccessoryResource>?              HairAccessoryResources                  { get; set; }

        public static MstHairstyle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstHairstyle() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0245A4703CA8 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x014)); // 0245A4703CC8 0x14 MstCharacterInfoId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CostumeType                               = GetInt32(new IntPtr(p + 0x018)); // 0245A4703CE8 0x18 CostumeType                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.HairResourceIdForClient                   = GetInt32(new IntPtr(p + 0x01C)); // 0245A4703D08 0x1C HairResourceIdForClient     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.HairAccessoryResourceIdListForClient      = GetInt32List(new IntPtr(p + 0x020)); // 0245A4703D28 0x20 HairAccessoryResourceIdListForClient ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x028)); // 0245A4703D48 0x28 SortId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CharacterInfo                             = GetObject<MstCharacterInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.MstCharacterInfo.FromPointer); // 0245A4703D68 0x30 CharacterInfo               ( 00018661BCB0 ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer )
            value.HairResource                              = GetObject<MstHairstyleResource>(new IntPtr(p + 0x038), ReversePrism.DataModels.MstHairstyleResource.FromPointer); // 0245A4703D88 0x38 HairResource                ( 000186622B00 ModelClassType MstHairstyleResource MstHairstyleResource MstHairstyleResource Pointer )
            value.HairAccessoryResources                    = GetObjectList<MstAccessoryResource>(new IntPtr(p + 0x040), ReversePrism.DataModels.MstAccessoryResource.FromPointer); // 0245A4703DA8 0x40 HairAccessoryResources      ( 000185B948E0 ModelClassListType MstAccessoryResource[] MstAccessoryResource[] List<MstAccessoryResource> Pointer )

            return value;
        }
    }
}
