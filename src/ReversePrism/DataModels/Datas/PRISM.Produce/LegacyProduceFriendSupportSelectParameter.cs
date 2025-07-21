using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitId                                   ModelPrimitiveType int int int Int32
    // 018 UnitName                                 ModelPrimitiveType string string string String
    // 020 SelfSupportCharacters                    ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer
    // 028 EpisodeSelectModel                       ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer
    // 030 TutorialFriendSupport                    ModelClassType IFriendSupportStatus IFriendSupportStatus IFriendSupportStatus Pointer
    public partial class LegacyProduceFriendSupportSelectParameter : DataModel
    {
        public int                                      UnitId                                  { get; set; }
        public string                                   UnitName                                { get; set; }
        public List<ISupportCharacterStatus>?           SelfSupportCharacters                   { get; set; }
        public ViewProducePreparationEpisodeSelectModel? EpisodeSelectModel                      { get; set; }
        public IFriendSupportStatus?                    TutorialFriendSupport                   { get; set; }

        public static LegacyProduceFriendSupportSelectParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacyProduceFriendSupportSelectParameter() { Pointer= p0 };

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.UnitName                                  = GetString(new IntPtr(p + 0x018)); // 0x18 UnitName                    ( ModelPrimitiveType string string string String )
            value.SelfSupportCharacters                     = GetObjectList<ISupportCharacterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0x20 SelfSupportCharacters       ( ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer )
            value.EpisodeSelectModel                        = GetObject<ViewProducePreparationEpisodeSelectModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.ViewProducePreparationEpisodeSelectModel.FromPointer); // 0x28 EpisodeSelectModel          ( ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer )
            value.TutorialFriendSupport                     = GetObject<IFriendSupportStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IFriendSupportStatus.FromPointer); // 0x30 TutorialFriendSupport       ( ModelClassType IFriendSupportStatus IFriendSupportStatus IFriendSupportStatus Pointer )

            return value;
        }
    }
}
