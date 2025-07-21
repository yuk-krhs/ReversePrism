using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    // 018 CostumeType                              ModelPrimitiveType int int int Int32
    // 01C HairResourceIdForClient                  ModelPrimitiveType int int int Int32
    // 020 HairAccessoryResourceIdListForClient     ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 SortId                                   ModelPrimitiveType int int int Int32
    // 030 CharacterInfo                            ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer
    // 038 HairResource                             ModelClassType MstHairstyleResource MstHairstyleResource MstHairstyleResource Pointer
    // 040 HairAccessoryResources                   ModelClassListType MstAccessoryResource[] MstAccessoryResource[] List<MstAccessoryResource> Pointer
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

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.CostumeType                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 CostumeType                 ( ModelPrimitiveType int int int Int32 )
            value.HairResourceIdForClient                   = GetInt32(new IntPtr(p + 0x01C)); // 0x1C HairResourceIdForClient     ( ModelPrimitiveType int int int Int32 )
            value.HairAccessoryResourceIdListForClient      = GetInt32List(new IntPtr(p + 0x020)); // 0x20 HairAccessoryResourceIdListForClient ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x028)); // 0x28 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.CharacterInfo                             = GetObject<MstCharacterInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.MstCharacterInfo.FromPointer); // 0x30 CharacterInfo               ( ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer )
            value.HairResource                              = GetObject<MstHairstyleResource>(new IntPtr(p + 0x038), ReversePrism.DataModels.MstHairstyleResource.FromPointer); // 0x38 HairResource                ( ModelClassType MstHairstyleResource MstHairstyleResource MstHairstyleResource Pointer )
            value.HairAccessoryResources                    = GetObjectList<MstAccessoryResource>(new IntPtr(p + 0x040), ReversePrism.DataModels.MstAccessoryResource.FromPointer); // 0x40 HairAccessoryResources      ( ModelClassListType MstAccessoryResource[] MstAccessoryResource[] List<MstAccessoryResource> Pointer )

            return value;
        }
    }
}
