using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GalleryAlbumSupportCharacterStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSupportCharacterIdFieldNumber         int IL2CPP_TYPE_I4
    // 018 MstSupportCharacterId                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 EnableFieldNumber                        int IL2CPP_TYPE_I4
    // 01C Enable                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 RarityFieldNumber                        int IL2CPP_TYPE_I4
    // 020 Rarity                                   0001865EB1C0 ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32
    public partial class GalleryAlbumSupportCharacterStatus : DataModel
    {
        public int                                      MstSupportCharacterId                   { get; set; }
        public bool                                     Enable                                  { get; set; }
        public SupportCharacterRarity                   Rarity                                  { get; set; }

        public static GalleryAlbumSupportCharacterStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GalleryAlbumSupportCharacterStatus() { Pointer= p0 };

            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x018)); // 02466151B588 0x18 MstSupportCharacterId       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Enable                                    = GetBool(new IntPtr(p + 0x01C)); // 02466151B5C8 0x1C Enable                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Rarity                                    = (SupportCharacterRarity)GetInt32(new IntPtr(p + 0x020)); // 02466151B608 0x20 Rarity                      ( 0001865EB1C0 ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32 )

            return value;
        }
    }
}
