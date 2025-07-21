using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitModel                                ModelClassType ProduceUnitModel ProduceUnitModel ProduceUnitModel Pointer
    // 018 Idols                                    ModelClassListType List`1<ProduceIdolModel> List`1<ProduceIdolModel> List<ProduceIdolModel> Pointer
    // 020 SCharas                                  ModelClassListType List`1<SupportCharacterModel> List`1<SupportCharacterModel> List<SupportCharacterModel> Pointer
    // 028 FriendModel                              ModelClassType SupportCharacterModel SupportCharacterModel SupportCharacterModel Pointer
    // 030 InheritanceIcon                          ModelClassType FUnitIcon FUnitIcon FUnitIcon Pointer
    // 038 EpisodeStatus                            ModelClassType IEpisodeStatus IEpisodeStatus IEpisodeStatus Pointer
    // 040 SelectedDifficultyType                   ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32
    // 048 FriendSupportId                          ModelPrimitiveType string string string String
    // 050 IsAutoPlay                               ModelPrimitiveType bool bool bool Bool
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

            value.UnitModel                                 = GetObject<ProduceUnitModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProduceUnitModel.FromPointer); // 0x10 UnitModel                   ( ModelClassType ProduceUnitModel ProduceUnitModel ProduceUnitModel Pointer )
            value.Idols                                     = GetObjectList<ProduceIdolModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceIdolModel.FromPointer); // 0x18 Idols                       ( ModelClassListType List`1<ProduceIdolModel> List`1<ProduceIdolModel> List<ProduceIdolModel> Pointer )
            value.SCharas                                   = GetObjectList<SupportCharacterModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.SupportCharacterModel.FromPointer); // 0x20 SCharas                     ( ModelClassListType List`1<SupportCharacterModel> List`1<SupportCharacterModel> List<SupportCharacterModel> Pointer )
            value.FriendModel                               = GetObject<SupportCharacterModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.SupportCharacterModel.FromPointer); // 0x28 FriendModel                 ( ModelClassType SupportCharacterModel SupportCharacterModel SupportCharacterModel Pointer )
            value.InheritanceIcon                           = GetObject<FUnitIcon>(new IntPtr(p + 0x030), ReversePrism.DataModels.FUnitIcon.FromPointer); // 0x30 InheritanceIcon             ( ModelClassType FUnitIcon FUnitIcon FUnitIcon Pointer )
            value.EpisodeStatus                             = GetObject<IEpisodeStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IEpisodeStatus.FromPointer); // 0x38 EpisodeStatus               ( ModelClassType IEpisodeStatus IEpisodeStatus IEpisodeStatus Pointer )
            value.SelectedDifficultyType                    = (ProduceDifficultyType)GetInt32(new IntPtr(p + 0x040)); // 0x40 SelectedDifficultyType      ( ModelEnumType ProduceDifficultyType ProduceDifficultyType ProduceDifficultyType Int32 )
            value.FriendSupportId                           = GetString(new IntPtr(p + 0x048)); // 0x48 FriendSupportId             ( ModelPrimitiveType string string string String )
            value.IsAutoPlay                                = GetBool(new IntPtr(p + 0x050)); // 0x50 IsAutoPlay                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
