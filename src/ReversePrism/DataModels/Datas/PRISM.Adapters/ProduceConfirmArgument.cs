using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EpisodeSelectModel                       ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer
    // 018 SelectedFriendSCharaStatus               ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer
    // 020 SelectedFriendSupportId                  ModelPrimitiveType string string string String
    public partial class ProduceConfirmArgument : DataModel
    {
        public ViewProducePreparationEpisodeSelectModel? EpisodeSelectModel                      { get; set; }
        public ISupportCharacterStatus?                 SelectedFriendSCharaStatus              { get; set; }
        public string                                   SelectedFriendSupportId                 { get; set; }

        public static ProduceConfirmArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceConfirmArgument() { Pointer= p0 };

            value.EpisodeSelectModel                        = GetObject<ViewProducePreparationEpisodeSelectModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.ViewProducePreparationEpisodeSelectModel.FromPointer); // 0x10 EpisodeSelectModel          ( ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer )
            value.SelectedFriendSCharaStatus                = GetObject<ISupportCharacterStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0x18 SelectedFriendSCharaStatus  ( ModelClassType ISupportCharacterStatus ISupportCharacterStatus ISupportCharacterStatus Pointer )
            value.SelectedFriendSupportId                   = GetString(new IntPtr(p + 0x020)); // 0x20 SelectedFriendSupportId     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
