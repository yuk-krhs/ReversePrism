using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 messagePopupViewFactory                  PopupViewFactory`1<IMessagePopupView> IL2CPP_TYPE_GENERICINST
    // 028 itemDetailPopupFactory                   PopupViewFactory`1<IItemDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 030 announceOverlayFactory                   OverlayViewFactory`1<IAnnounceOverlayView> IL2CPP_TYPE_GENERICINST
    // 038 announceDetailPopupFactory               PopupViewFactory`1<IAnnounceDetailPopupView> IL2CPP_TYPE_GENERICINST
    // 040 globalMenuFactory                        OverlayViewFactory`1<IGlobalMenuView> IL2CPP_TYPE_GENERICINST
    // 048 receiveRewardPopupFactory                PopupViewFactory`1<IReceiveRewardPopupView> IL2CPP_TYPE_GENERICINST
    // 050 MessagePopupSequencer                    00018660A720 ModelClassType MessagePopupSequencer MessagePopupSequencer MessagePopupSequencer Pointer
    // 058 ItemDetailSequencer                      00018673D040 ModelClassType ItemDetailPopupSequencer ItemDetailPopupSequencer ItemDetailPopupSequencer Pointer
    // 060 GlobalMenuSequencer                      00018667DB50 ModelClassType GlobalMenuSequencer GlobalMenuSequencer GlobalMenuSequencer Pointer
    // 068 ReceiveRewardPopupSequencer              000186625C80 ModelClassType ReceiveRewardPopupSequencer ReceiveRewardPopupSequencer ReceiveRewardPopupSequencer Pointer
    // 070 Announce                                 0001866F6530 ModelClassType IAnnounceSequencer IAnnounceSequencer IAnnounceSequencer Pointer
    public partial class CommonPopupReference : DataModel
    {
        public MessagePopupSequencer?                   MessagePopupSequencer                   { get; set; }
        public ItemDetailPopupSequencer?                ItemDetailSequencer                     { get; set; }
        public GlobalMenuSequencer?                     GlobalMenuSequencer                     { get; set; }
        public ReceiveRewardPopupSequencer?             ReceiveRewardPopupSequencer             { get; set; }
        public IAnnounceSequencer?                      Announce                                { get; set; }

        public static CommonPopupReference? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommonPopupReference() { Pointer= p0 };

            value.MessagePopupSequencer                     = GetObject<MessagePopupSequencer>(new IntPtr(p + 0x050), ReversePrism.DataModels.MessagePopupSequencer.FromPointer); // 0245A1E9CE70 0x50 MessagePopupSequencer       ( 00018660A720 ModelClassType MessagePopupSequencer MessagePopupSequencer MessagePopupSequencer Pointer )
            value.ItemDetailSequencer                       = GetObject<ItemDetailPopupSequencer>(new IntPtr(p + 0x058), ReversePrism.DataModels.ItemDetailPopupSequencer.FromPointer); // 0245A1E9CE90 0x58 ItemDetailSequencer         ( 00018673D040 ModelClassType ItemDetailPopupSequencer ItemDetailPopupSequencer ItemDetailPopupSequencer Pointer )
            value.GlobalMenuSequencer                       = GetObject<GlobalMenuSequencer>(new IntPtr(p + 0x060), ReversePrism.DataModels.GlobalMenuSequencer.FromPointer); // 0245A1E9CEB0 0x60 GlobalMenuSequencer         ( 00018667DB50 ModelClassType GlobalMenuSequencer GlobalMenuSequencer GlobalMenuSequencer Pointer )
            value.ReceiveRewardPopupSequencer               = GetObject<ReceiveRewardPopupSequencer>(new IntPtr(p + 0x068), ReversePrism.DataModels.ReceiveRewardPopupSequencer.FromPointer); // 0245A1E9CED0 0x68 ReceiveRewardPopupSequencer ( 000186625C80 ModelClassType ReceiveRewardPopupSequencer ReceiveRewardPopupSequencer ReceiveRewardPopupSequencer Pointer )
            value.Announce                                  = GetObject<IAnnounceSequencer>(new IntPtr(p + 0x070), ReversePrism.DataModels.IAnnounceSequencer.FromPointer); // 0245A1E9CEF0 0x70 Announce                    ( 0001866F6530 ModelClassType IAnnounceSequencer IAnnounceSequencer IAnnounceSequencer Pointer )

            return value;
        }
    }
}
