using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MessagePopupSequencer                    ModelClassType MessagePopupSequencer MessagePopupSequencer MessagePopupSequencer Pointer
    // 018 ItemDetailSequencer                      ModelClassType ItemDetailPopupSequencer ItemDetailPopupSequencer ItemDetailPopupSequencer Pointer
    // 020 ReceiveRewardPopupSequencer              ModelClassType ReceiveRewardPopupSequencer ReceiveRewardPopupSequencer ReceiveRewardPopupSequencer Pointer
    // 028 ExchangeOverlaySequencer                 ModelClassType ExchangeOverlaySequencer ExchangeOverlaySequencer ExchangeOverlaySequencer Pointer
    // 030 Announce                                 ModelClassType IAnnounceSequencer IAnnounceSequencer IAnnounceSequencer Pointer
    public partial class CommonSequencerContainer : DataModel
    {
        public MessagePopupSequencer?                   MessagePopupSequencer                   { get; set; }
        public ItemDetailPopupSequencer?                ItemDetailSequencer                     { get; set; }
        public ReceiveRewardPopupSequencer?             ReceiveRewardPopupSequencer             { get; set; }
        public ExchangeOverlaySequencer?                ExchangeOverlaySequencer                { get; set; }
        public IAnnounceSequencer?                      Announce                                { get; set; }

        public static CommonSequencerContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonSequencerContainer() { Pointer= p0 };

            value.MessagePopupSequencer                     = GetObject<MessagePopupSequencer>(new IntPtr(p + 0x010), ReversePrism.DataModels.MessagePopupSequencer.FromPointer); // 0x10 MessagePopupSequencer       ( ModelClassType MessagePopupSequencer MessagePopupSequencer MessagePopupSequencer Pointer )
            value.ItemDetailSequencer                       = GetObject<ItemDetailPopupSequencer>(new IntPtr(p + 0x018), ReversePrism.DataModels.ItemDetailPopupSequencer.FromPointer); // 0x18 ItemDetailSequencer         ( ModelClassType ItemDetailPopupSequencer ItemDetailPopupSequencer ItemDetailPopupSequencer Pointer )
            value.ReceiveRewardPopupSequencer               = GetObject<ReceiveRewardPopupSequencer>(new IntPtr(p + 0x020), ReversePrism.DataModels.ReceiveRewardPopupSequencer.FromPointer); // 0x20 ReceiveRewardPopupSequencer ( ModelClassType ReceiveRewardPopupSequencer ReceiveRewardPopupSequencer ReceiveRewardPopupSequencer Pointer )
            value.ExchangeOverlaySequencer                  = GetObject<ExchangeOverlaySequencer>(new IntPtr(p + 0x028), ReversePrism.DataModels.ExchangeOverlaySequencer.FromPointer); // 0x28 ExchangeOverlaySequencer    ( ModelClassType ExchangeOverlaySequencer ExchangeOverlaySequencer ExchangeOverlaySequencer Pointer )
            value.Announce                                  = GetObject<IAnnounceSequencer>(new IntPtr(p + 0x030), ReversePrism.DataModels.IAnnounceSequencer.FromPointer); // 0x30 Announce                    ( ModelClassType IAnnounceSequencer IAnnounceSequencer IAnnounceSequencer Pointer )

            return value;
        }
    }
}
