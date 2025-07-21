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
    // 01C ResourceId                               ModelPrimitiveType int int int Int32
    // 020 SortId                                   ModelPrimitiveType int int int Int32
    // 024 IsDressOrderTarget                       ModelPrimitiveType bool bool bool Bool
    // 028 CharacterInfo                            ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer
    // 030 Resource                                 ModelClassType MstCostumeResource MstCostumeResource MstCostumeResource Pointer
    public partial class MstCostume : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public int                                      CostumeType                             { get; set; }
        public int                                      ResourceId                              { get; set; }
        public int                                      SortId                                  { get; set; }
        public bool                                     IsDressOrderTarget                      { get; set; }
        public MstCharacterInfo?                        CharacterInfo                           { get; set; }
        public MstCostumeResource?                      Resource                                { get; set; }

        public static MstCostume? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstCostume() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.CostumeType                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 CostumeType                 ( ModelPrimitiveType int int int Int32 )
            value.ResourceId                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C ResourceId                  ( ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.IsDressOrderTarget                        = GetBool(new IntPtr(p + 0x024)); // 0x24 IsDressOrderTarget          ( ModelPrimitiveType bool bool bool Bool )
            value.CharacterInfo                             = GetObject<MstCharacterInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MstCharacterInfo.FromPointer); // 0x28 CharacterInfo               ( ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer )
            value.Resource                                  = GetObject<MstCostumeResource>(new IntPtr(p + 0x030), ReversePrism.DataModels.MstCostumeResource.FromPointer); // 0x30 Resource                    ( ModelClassType MstCostumeResource MstCostumeResource MstCostumeResource Pointer )

            return value;
        }
    }
}
