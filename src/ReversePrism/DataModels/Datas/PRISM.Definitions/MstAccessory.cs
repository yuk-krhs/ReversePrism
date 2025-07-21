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
    // 01C AccessoryType                            ModelPrimitiveType int int int Int32
    // 020 ResourceId                               ModelPrimitiveType int int int Int32
    // 024 SortId                                   ModelPrimitiveType int int int Int32
    // 028 CharacterInfo                            ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer
    // 030 Resource                                 ModelClassType MstAccessoryResource MstAccessoryResource MstAccessoryResource Pointer
    public partial class MstAccessory : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public int                                      CostumeType                             { get; set; }
        public int                                      AccessoryType                           { get; set; }
        public int                                      ResourceId                              { get; set; }
        public int                                      SortId                                  { get; set; }
        public MstCharacterInfo?                        CharacterInfo                           { get; set; }
        public MstAccessoryResource?                    Resource                                { get; set; }

        public static MstAccessory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstAccessory() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.CostumeType                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 CostumeType                 ( ModelPrimitiveType int int int Int32 )
            value.AccessoryType                             = GetInt32(new IntPtr(p + 0x01C)); // 0x1C AccessoryType               ( ModelPrimitiveType int int int Int32 )
            value.ResourceId                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 ResourceId                  ( ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x024)); // 0x24 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.CharacterInfo                             = GetObject<MstCharacterInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MstCharacterInfo.FromPointer); // 0x28 CharacterInfo               ( ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer )
            value.Resource                                  = GetObject<MstAccessoryResource>(new IntPtr(p + 0x030), ReversePrism.DataModels.MstAccessoryResource.FromPointer); // 0x30 Resource                    ( ModelClassType MstAccessoryResource MstAccessoryResource MstAccessoryResource Pointer )

            return value;
        }
    }
}
