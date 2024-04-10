using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitModel                                00018659B940 ModelClassType ProduceUnitModel ProduceUnitModel ProduceUnitModel Pointer
    // 018 Idols                                    000185CFC158 ModelClassListType List`1<ProduceIdolModel> List`1<ProduceIdolModel> List<ProduceIdolModel> Pointer
    // 020 SCharas                                  000185D10168 ModelClassListType List`1<SupportCharacterModel> List`1<SupportCharacterModel> List<SupportCharacterModel> Pointer
    // 028 FriendModel                              0001865EAD20 ModelClassType SupportCharacterModel SupportCharacterModel SupportCharacterModel Pointer
    // 030 InheritanceIcon                          00018654C900 ModelClassType FUnitIcon FUnitIcon FUnitIcon Pointer
    // 038 EpisodeStatus                            000186761B50 ModelClassType IEpisodeStatus IEpisodeStatus IEpisodeStatus Pointer
    // 040 SelectedDifficultyType                   00018660C140 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 048 FriendSupportId                          0001866722E0 ModelPrimitiveType string string string String
    // 050 IsAutoPlay                               000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class ProduceConfirmViewModel : DataModel
    {
        public ProduceUnitModel?                        UnitModel                               { get; set; }
        public List<ProduceIdolModel>?                  Idols                                   { get; set; }
        public List<SupportCharacterModel>?             SCharas                                 { get; set; }
        public SupportCharacterModel?                   FriendModel                             { get; set; }
        public FUnitIcon?                               InheritanceIcon                         { get; set; }
        public IEpisodeStatus?                          EpisodeStatus                           { get; set; }
        public ProduceDifficultyType                    SelectedDifficultyType                  { get; set; }
        public string                                   FriendSupportId                         { get; set; }
        public bool                                     IsAutoPlay                              { get; set; }

        public static ProduceConfirmViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceConfirmViewModel() { Pointer= p0 };

            value.UnitModel                                 = GetObject<ProduceUnitModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceUnitModel.FromPointer); // 0246665C9148 0x10 UnitModel                   ( 00018659B940 ModelClassType ProduceUnitModel ProduceUnitModel ProduceUnitModel Pointer )
            value.Idols                                     = GetObjectList<ProduceIdolModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceIdolModel.FromPointer); // 0246665C9168 0x18 Idols                       ( 000185CFC158 ModelClassListType List`1<ProduceIdolModel> List`1<ProduceIdolModel> List<ProduceIdolModel> Pointer )
            value.SCharas                                   = GetObjectList<SupportCharacterModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.SupportCharacterModel.FromPointer); // 0246665C9188 0x20 SCharas                     ( 000185D10168 ModelClassListType List`1<SupportCharacterModel> List`1<SupportCharacterModel> List<SupportCharacterModel> Pointer )
            value.FriendModel                               = GetObject<SupportCharacterModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.SupportCharacterModel.FromPointer); // 0246665C91A8 0x28 FriendModel                 ( 0001865EAD20 ModelClassType SupportCharacterModel SupportCharacterModel SupportCharacterModel Pointer )
            value.InheritanceIcon                           = GetObject<FUnitIcon>(new IntPtr(p + 0x030), ReversePrism.DataModels.FUnitIcon.FromPointer); // 0246665C91C8 0x30 InheritanceIcon             ( 00018654C900 ModelClassType FUnitIcon FUnitIcon FUnitIcon Pointer )
            value.EpisodeStatus                             = GetObject<IEpisodeStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IEpisodeStatus.FromPointer); // 0246665C91E8 0x38 EpisodeStatus               ( 000186761B50 ModelClassType IEpisodeStatus IEpisodeStatus IEpisodeStatus Pointer )
            value.SelectedDifficultyType                    = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x040)); // 0246665C9208 0x40 SelectedDifficultyType      ( 00018660C140 ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.FriendSupportId                           = GetString(new IntPtr(p + 0x048)); // 0246665C9228 0x48 FriendSupportId             ( 0001866722E0 ModelPrimitiveType string string string String )
            value.IsAutoPlay                                = GetBool(new IntPtr(p + 0x050)); // 0246665C9248 0x50 IsAutoPlay                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
