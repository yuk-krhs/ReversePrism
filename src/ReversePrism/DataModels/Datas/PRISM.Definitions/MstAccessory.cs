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
    // 01C AccessoryType                            0001865F4260 ModelPrimitiveType int int int Int32
    // 020 ResourceId                               0001865F4260 ModelPrimitiveType int int int Int32
    // 024 SortId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 028 CharacterInfo                            00018661BCB0 ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer
    // 030 Resource                                 000186617FB0 ModelClassType MstAccessoryResource MstAccessoryResource MstAccessoryResource Pointer
    public partial class MstAccessory
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
            var value   = new MstAccessory();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 02700460DB98 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x014)); // 02700460DBB8 0x14 MstCharacterInfoId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CostumeType                               = GetInt32(new IntPtr(p + 0x018)); // 02700460DBD8 0x18 CostumeType                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.AccessoryType                             = GetInt32(new IntPtr(p + 0x01C)); // 02700460DBF8 0x1C AccessoryType               ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ResourceId                                = GetInt32(new IntPtr(p + 0x020)); // 02700460DC18 0x20 ResourceId                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x024)); // 02700460DC38 0x24 SortId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.CharacterInfo                             = GetObject<MstCharacterInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MstCharacterInfo.FromPointer); // 02700460DC58 0x28 CharacterInfo               ( 00018661BCB0 ModelClassType MstCharacterInfo MstCharacterInfo MstCharacterInfo Pointer )
            value.Resource                                  = GetObject<MstAccessoryResource>(new IntPtr(p + 0x030), ReversePrism.DataModels.MstAccessoryResource.FromPointer); // 02700460DC78 0x30 Resource                    ( 000186617FB0 ModelClassType MstAccessoryResource MstAccessoryResource MstAccessoryResource Pointer )

            return value;
        }
    }
}
