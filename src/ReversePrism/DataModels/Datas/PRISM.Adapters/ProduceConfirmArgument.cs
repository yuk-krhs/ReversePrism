using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EpisodeSelectModel                       000186520560 ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer
    // 018 SelectedFriendSCharaStatus               00018666A290 ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer
    // 020 SelectedFriendSupportId                  0001866736C0 ModelPrimitiveType string string string String
    public partial class ProduceConfirmArgument
    {
        public ViewProducePreparationEpisodeSelectModel? EpisodeSelectModel                      { get; set; }
        public ISupportCharacterStatus?                 SelectedFriendSCharaStatus              { get; set; }
        public string                                   SelectedFriendSupportId                 { get; set; }

        public static ProduceConfirmArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceConfirmArgument();

            value.EpisodeSelectModel                        = GetObject<ViewProducePreparationEpisodeSelectModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ViewProducePreparationEpisodeSelectModel.FromPointer); // 0270D6559358 0x10 EpisodeSelectModel          ( 000186520560 ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer )
            value.SelectedFriendSCharaStatus                = GetObject<ISupportCharacterStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0270D6559378 0x18 SelectedFriendSCharaStatus  ( 00018666A290 ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer )
            value.SelectedFriendSupportId                   = GetString(new IntPtr(p + 0x020)); // 0270D6559398 0x20 SelectedFriendSupportId     ( 0001866736C0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
