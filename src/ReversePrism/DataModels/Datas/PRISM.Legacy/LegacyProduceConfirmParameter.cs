using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EpisodeSelectModel                       000186520000 ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer
    // 018 SelectedFriendId                         0001866722E0 ModelPrimitiveType string string string String
    // 020 SelectedFriendSCharaStatus               000186669DA0 ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer
    public partial class LegacyProduceConfirmParameter
    {
        public ViewProducePreparationEpisodeSelectModel? EpisodeSelectModel                      { get; set; }
        public string                                   SelectedFriendId                        { get; set; }
        public ISupportCharacterStatus?                 SelectedFriendSCharaStatus              { get; set; }

        public static LegacyProduceConfirmParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacyProduceConfirmParameter();

            value.EpisodeSelectModel                        = GetObject<ViewProducePreparationEpisodeSelectModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ViewProducePreparationEpisodeSelectModel.FromPointer); // 0270D5DFD660 0x10 EpisodeSelectModel          ( 000186520000 ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer )
            value.SelectedFriendId                          = GetString(new IntPtr(p + 0x018)); // 0270D5DFD680 0x18 SelectedFriendId            ( 0001866722E0 ModelPrimitiveType string string string String )
            value.SelectedFriendSCharaStatus                = GetObject<ISupportCharacterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0270D5DFD6A0 0x20 SelectedFriendSCharaStatus  ( 000186669DA0 ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer )

            return value;
        }
    }
}
