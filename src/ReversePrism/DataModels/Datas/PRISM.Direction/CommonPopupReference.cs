using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 messagePopupViewFactory                  PopupViewFactory`1<IMessagePopupView> IL2CPP_TYPE_GENERICINST
    // 028 messageScrollPopupViewFactory            PopupViewFactory`1<IMessagePopupView> IL2CPP_TYPE_GENERICINST
    // 030 itemDetailPopupFactory                   PopupViewFactory`1<IItemDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 038 announceOverlayFactory                   OverlayViewFactory`1<IAnnounceOverlayView> IL2CPP_TYPE_GENERICINST
    // 040 announceDetailPopupFactory               PopupViewFactory`1<IAnnounceDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 048 globalMenuFactory                        OverlayViewFactory`1<IGlobalMenuView> IL2CPP_TYPE_GENERICINST
    // 050 receiveRewardPopupFactory                PopupViewFactory`1<IReceiveRewardPopupView> IL2CPP_TYPE_GENERICINST
    // 058 exchangeTopFactory                       OverlayViewFactory`1<IExchangeTopOverlayView> IL2CPP_TYPE_GENERICINST
    // 060 MessagePopupSequencer                    ModelClassType MessagePopupSequencer MessagePopupSequencer MessagePopupSequencer Pointer
    // 068 MessageScrollPopupSequencer              ModelClassType MessagePopupSequencer MessagePopupSequencer MessagePopupSequencer Pointer
    // 070 ItemDetailSequencer                      ModelClassType ItemDetailPopupSequencer ItemDetailPopupSequencer ItemDetailPopupSequencer Pointer
    // 078 GlobalMenuSequencer                      ModelClassType GlobalMenuSequencer GlobalMenuSequencer GlobalMenuSequencer Pointer
    // 080 ReceiveRewardPopupSequencer              ModelClassType ReceiveRewardPopupSequencer ReceiveRewardPopupSequencer ReceiveRewardPopupSequencer Pointer
    // 088 ExchangeOverlaySequencer                 ModelClassType ExchangeOverlaySequencer ExchangeOverlaySequencer ExchangeOverlaySequencer Pointer
    // 090 Announce                                 ModelClassType IAnnounceSequencer IAnnounceSequencer IAnnounceSequencer Pointer
    public partial class CommonPopupReference : DataModel
    {
        public MessagePopupSequencer?                   MessagePopupSequencer                   { get; set; }
        public MessagePopupSequencer?                   MessageScrollPopupSequencer             { get; set; }
        public ItemDetailPopupSequencer?                ItemDetailSequencer                     { get; set; }
        public GlobalMenuSequencer?                     GlobalMenuSequencer                     { get; set; }
        public ReceiveRewardPopupSequencer?             ReceiveRewardPopupSequencer             { get; set; }
        public ExchangeOverlaySequencer?                ExchangeOverlaySequencer                { get; set; }
        public IAnnounceSequencer?                      Announce                                { get; set; }

        public static CommonPopupReference? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonPopupReference() { Pointer= p0 };

            value.MessagePopupSequencer                     = GetObject<MessagePopupSequencer>(new IntPtr(p + 0x060), ReversePrism.DataModels.MessagePopupSequencer.FromPointer); // 0x60 MessagePopupSequencer       ( ModelClassType MessagePopupSequencer MessagePopupSequencer MessagePopupSequencer Pointer )
            value.MessageScrollPopupSequencer               = GetObject<MessagePopupSequencer>(new IntPtr(p + 0x068), ReversePrism.DataModels.MessagePopupSequencer.FromPointer); // 0x68 MessageScrollPopupSequencer ( ModelClassType MessagePopupSequencer MessagePopupSequencer MessagePopupSequencer Pointer )
            value.ItemDetailSequencer                       = GetObject<ItemDetailPopupSequencer>(new IntPtr(p + 0x070), ReversePrism.DataModels.ItemDetailPopupSequencer.FromPointer); // 0x70 ItemDetailSequencer         ( ModelClassType ItemDetailPopupSequencer ItemDetailPopupSequencer ItemDetailPopupSequencer Pointer )
            value.GlobalMenuSequencer                       = GetObject<GlobalMenuSequencer>(new IntPtr(p + 0x078), ReversePrism.DataModels.GlobalMenuSequencer.FromPointer); // 0x78 GlobalMenuSequencer         ( ModelClassType GlobalMenuSequencer GlobalMenuSequencer GlobalMenuSequencer Pointer )
            value.ReceiveRewardPopupSequencer               = GetObject<ReceiveRewardPopupSequencer>(new IntPtr(p + 0x080), ReversePrism.DataModels.ReceiveRewardPopupSequencer.FromPointer); // 0x80 ReceiveRewardPopupSequencer ( ModelClassType ReceiveRewardPopupSequencer ReceiveRewardPopupSequencer ReceiveRewardPopupSequencer Pointer )
            value.ExchangeOverlaySequencer                  = GetObject<ExchangeOverlaySequencer>(new IntPtr(p + 0x088), ReversePrism.DataModels.ExchangeOverlaySequencer.FromPointer); // 0x88 ExchangeOverlaySequencer    ( ModelClassType ExchangeOverlaySequencer ExchangeOverlaySequencer ExchangeOverlaySequencer Pointer )
            value.Announce                                  = GetObject<IAnnounceSequencer>(new IntPtr(p + 0x090), ReversePrism.DataModels.IAnnounceSequencer.FromPointer); // 0x90 Announce                    ( ModelClassType IAnnounceSequencer IAnnounceSequencer IAnnounceSequencer Pointer )

            return value;
        }
    }
}
