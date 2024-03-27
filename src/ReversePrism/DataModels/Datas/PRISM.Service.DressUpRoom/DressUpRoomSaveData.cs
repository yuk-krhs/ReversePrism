using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Saved                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 014 SelectedCharacterInfoId                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 CostumeType                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C IsShowUnlockedCostumeOnly                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class DressUpRoomSaveData
    {
        public bool                                     Saved                                   { get; set; }
        public int                                      SelectedCharacterInfoId                 { get; set; }
        public int                                      CostumeType                             { get; set; }
        public bool                                     IsShowUnlockedCostumeOnly               { get; set; }

        public static DressUpRoomSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressUpRoomSaveData();

            value.Saved                                     = GetBool(new IntPtr(p + 0x010)); // 027003A6B208 0x10 Saved                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SelectedCharacterInfoId                   = GetInt32(new IntPtr(p + 0x014)); // 027003A6B228 0x14 SelectedCharacterInfoId     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CostumeType                               = GetInt32(new IntPtr(p + 0x018)); // 027003A6B248 0x18 CostumeType                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsShowUnlockedCostumeOnly                 = GetBool(new IntPtr(p + 0x01C)); // 027003A6B268 0x1C IsShowUnlockedCostumeOnly   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
