using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitId                                   0001865F4940 ModelPrimitiveType int int int Int32
    // 018 UnitName                                 0001866736C0 ModelPrimitiveType string string string String
    // 020 SelfSupportCharacters                    000185D0D958 ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer
    // 028 SelfSupportCharacterIds                  000185D11FB8 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer
    // 030 TutorialFriendStatus                     00018651C510 ModelClassType IFriendSupportStatus IFriendSupportStatus IFriendSupportStatus Pointer
    // 038 EpisodeSelectModel                       000186520560 ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer
    public partial class ProduceFriendSupportSelectArgument
    {
        public int                                      UnitId                                  { get; set; }
        public string                                   UnitName                                { get; set; }
        public List<ISupportCharacterStatus>?           SelfSupportCharacters                   { get; set; }
        public List<int>?                               SelfSupportCharacterIds                 { get; set; }
        public IFriendSupportStatus?                    TutorialFriendStatus                    { get; set; }
        public ViewProducePreparationEpisodeSelectModel? EpisodeSelectModel                      { get; set; }

        public static ProduceFriendSupportSelectArgument? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceFriendSupportSelectArgument();

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x010)); // 0270D64D02E0 0x10 UnitId                      ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.UnitName                                  = GetString(new IntPtr(p + 0x018)); // 0270D64D0300 0x18 UnitName                    ( 0001866736C0 ModelPrimitiveType string string string String )
            value.SelfSupportCharacters                     = GetObjectList<ISupportCharacterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0270D64D0320 0x20 SelfSupportCharacters       ( 000185D0D958 ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer )
            value.SelfSupportCharacterIds                   = GetInt32List(new IntPtr(p + 0x028)); // 0270D64D0340 0x28 SelfSupportCharacterIds     ( 000185D11FB8 ModelPrimitiveListType IReadOnlyList`1<int> IReadOnlyList`1<int> List<int> Pointer )
            value.TutorialFriendStatus                      = GetObject<IFriendSupportStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IFriendSupportStatus.FromPointer); // 0270D64D0360 0x30 TutorialFriendStatus        ( 00018651C510 ModelClassType IFriendSupportStatus IFriendSupportStatus IFriendSupportStatus Pointer )
            value.EpisodeSelectModel                        = GetObject<ViewProducePreparationEpisodeSelectModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ViewProducePreparationEpisodeSelectModel.FromPointer); // 0270D64D0380 0x38 EpisodeSelectModel          ( 000186520560 ModelClassType ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel ViewProducePreparationEpisodeSelectModel Pointer )

            return value;
        }
    }
}
