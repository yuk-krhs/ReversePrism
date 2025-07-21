using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EpisodeSelectModel                       ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer
    // 018 SelectedFriendId                         ModelPrimitiveType string string string String
    // 020 SelectedFriendSCharaStatus               ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer
    public partial class LegacyProduceConfirmParameter : DataModel
    {
        public ViewProducePreparationEpisodeSelectModel? EpisodeSelectModel                      { get; set; }
        public string                                   SelectedFriendId                        { get; set; }
        public ISupportCharacterStatus?                 SelectedFriendSCharaStatus              { get; set; }

        public static LegacyProduceConfirmParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LegacyProduceConfirmParameter() { Pointer= p0 };

            value.EpisodeSelectModel                        = GetObject<ViewProducePreparationEpisodeSelectModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ViewProducePreparationEpisodeSelectModel.FromPointer); // 0x10 EpisodeSelectModel          ( ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer )
            value.SelectedFriendId                          = GetString(new IntPtr(p + 0x018)); // 0x18 SelectedFriendId            ( ModelPrimitiveType string string string String )
            value.SelectedFriendSCharaStatus                = GetObject<ISupportCharacterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0x20 SelectedFriendSCharaStatus  ( ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer )

            return value;
        }
    }
}
