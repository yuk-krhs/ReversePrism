using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VoiceCategory                            000186534230 ModelEnumType VoiceCategory VoiceCategory VoiceCategory Int32
    // 014 MstProduceIdolId                         0001865F4260 ModelPrimitiveType int int int Int32
    // 018 MstSupportCharacterId                    0001865F4260 ModelPrimitiveType int int int Int32
    // 01C MstCharacterInfoId                       0001865F4260 ModelPrimitiveType int int int Int32
    // 020 InCasualCostume                          0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 024 CurrentAmount                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 MaxAmount                                0001865F4260 ModelPrimitiveType int int int Int32
    // 02C Star                                     0001865F4260 ModelPrimitiveType int int int Int32
    // 030 UnitId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 034 SupportCharacterRarity                   0001866201C0 ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32
    public partial class VoiceCategoryGridCellViewModel
    {
        public VoiceCategory                            VoiceCategory                           { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      MstSupportCharacterId                   { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public bool                                     InCasualCostume                         { get; set; }
        public int                                      CurrentAmount                           { get; set; }
        public int                                      MaxAmount                               { get; set; }
        public int                                      Star                                    { get; set; }
        public int                                      UnitId                                  { get; set; }
        public SupportCharacterRarity                   SupportCharacterRarity                  { get; set; }

        public static VoiceCategoryGridCellViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VoiceCategoryGridCellViewModel();

            value.VoiceCategory                             = (VoiceCategory)GetInt32(new IntPtr(p + 0x010)); // 0270D604A968 0x10 VoiceCategory               ( 000186534230 ModelEnumType VoiceCategory VoiceCategory VoiceCategory Int32 )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x014)); // 0270D604A988 0x14 MstProduceIdolId            ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x018)); // 0270D604A9A8 0x18 MstSupportCharacterId       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x01C)); // 0270D604A9C8 0x1C MstCharacterInfoId          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.InCasualCostume                           = GetBool(new IntPtr(p + 0x020)); // 0270D604A9E8 0x20 InCasualCostume             ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.CurrentAmount                             = GetInt32(new IntPtr(p + 0x024)); // 0270D604AA08 0x24 CurrentAmount               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxAmount                                 = GetInt32(new IntPtr(p + 0x028)); // 0270D604AA28 0x28 MaxAmount                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Star                                      = GetInt32(new IntPtr(p + 0x02C)); // 0270D604AA48 0x2C Star                        ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x030)); // 0270D604AA68 0x30 UnitId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.SupportCharacterRarity                    = (SupportCharacterRarity)GetInt32(new IntPtr(p + 0x034)); // 0270D604AA88 0x34 SupportCharacterRarity      ( 0001866201C0 ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32 )

            return value;
        }
    }
}
