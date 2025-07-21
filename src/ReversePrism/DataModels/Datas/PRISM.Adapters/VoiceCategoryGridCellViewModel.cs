using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 VoiceCategory                            ModelEnumType VoiceCategory VoiceCategory VoiceCategory Int32
    // 014 MstProduceIdolId                         ModelPrimitiveType int int int Int32
    // 018 MstSupportCharacterId                    ModelPrimitiveType int int int Int32
    // 01C MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    // 020 InCasualCostume                          ModelPrimitiveType bool bool bool Bool
    // 024 CurrentAmount                            ModelPrimitiveType int int int Int32
    // 028 MaxAmount                                ModelPrimitiveType int int int Int32
    // 02C Star                                     ModelPrimitiveType int int int Int32
    // 030 UnitId                                   ModelPrimitiveType int int int Int32
    // 034 SupportCharacterRarity                   ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32
    public partial class VoiceCategoryGridCellViewModel : DataModel
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
            var value   = new VoiceCategoryGridCellViewModel() { Pointer= p0 };

            value.VoiceCategory                             = (VoiceCategory)GetInt32(new IntPtr(p + 0x010)); // 0x10 VoiceCategory               ( ModelEnumType VoiceCategory VoiceCategory VoiceCategory Int32 )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstProduceIdolId            ( ModelPrimitiveType int int int Int32 )
            value.MstSupportCharacterId                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSupportCharacterId       ( ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.InCasualCostume                           = GetBool(new IntPtr(p + 0x020)); // 0x20 InCasualCostume             ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentAmount                             = GetInt32(new IntPtr(p + 0x024)); // 0x24 CurrentAmount               ( ModelPrimitiveType int int int Int32 )
            value.MaxAmount                                 = GetInt32(new IntPtr(p + 0x028)); // 0x28 MaxAmount                   ( ModelPrimitiveType int int int Int32 )
            value.Star                                      = GetInt32(new IntPtr(p + 0x02C)); // 0x2C Star                        ( ModelPrimitiveType int int int Int32 )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x030)); // 0x30 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.SupportCharacterRarity                    = (SupportCharacterRarity)GetInt32(new IntPtr(p + 0x034)); // 0x34 SupportCharacterRarity      ( ModelEnumType SupportCharacterRarity SupportCharacterRarity SupportCharacterRarity Int32 )

            return value;
        }
    }
}
