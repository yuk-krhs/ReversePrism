using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ItemButton                               00018667C2C0 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer
    // 028 ProducerButton                           00018667C2C0 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer
    // 030 FriendButton                             00018667C2C0 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer
    // 038 AccountButton                            00018667C2C0 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer
    // 040 ProduceSettingsButton                    00018667C2C0 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer
    // 048 LiveSettingsButton                       00018667C2C0 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer
    // 050 SystemSettingsButton                     00018667C2C0 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer
    // 058 DmButton                                 00018667C2C0 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer
    // 060 HelpButton                               00018667C2C0 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer
    // 068 InquiryButton                            00018667C2C0 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer
    // 070 OthersButton                             00018667C2C0 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer
    // 078 TitleButton                              00018667C2C0 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer
    public partial class GlobalMenuPanelView : DataModel
    {
        public GlobalMenuButton?                        ItemButton                              { get; set; }
        public GlobalMenuButton?                        ProducerButton                          { get; set; }
        public GlobalMenuButton?                        FriendButton                            { get; set; }
        public GlobalMenuButton?                        AccountButton                           { get; set; }
        public GlobalMenuButton?                        ProduceSettingsButton                   { get; set; }
        public GlobalMenuButton?                        LiveSettingsButton                      { get; set; }
        public GlobalMenuButton?                        SystemSettingsButton                    { get; set; }
        public GlobalMenuButton?                        DmButton                                { get; set; }
        public GlobalMenuButton?                        HelpButton                              { get; set; }
        public GlobalMenuButton?                        InquiryButton                           { get; set; }
        public GlobalMenuButton?                        OthersButton                            { get; set; }
        public GlobalMenuButton?                        TitleButton                             { get; set; }

        public static GlobalMenuPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlobalMenuPanelView() { Pointer= p0 };

            value.ItemButton                                = GetObject<GlobalMenuButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.GlobalMenuButton.FromPointer); // 02466BF309E8 0x20 ItemButton                  ( 00018667C2C0 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer )
            value.ProducerButton                            = GetObject<GlobalMenuButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.GlobalMenuButton.FromPointer); // 02466BF30A08 0x28 ProducerButton              ( 00018667C2C0 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer )
            value.FriendButton                              = GetObject<GlobalMenuButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.GlobalMenuButton.FromPointer); // 02466BF30A28 0x30 FriendButton                ( 00018667C2C0 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer )
            value.AccountButton                             = GetObject<GlobalMenuButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.GlobalMenuButton.FromPointer); // 02466BF30A48 0x38 AccountButton               ( 00018667C2C0 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer )
            value.ProduceSettingsButton                     = GetObject<GlobalMenuButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.GlobalMenuButton.FromPointer); // 02466BF30A68 0x40 ProduceSettingsButton       ( 00018667C2C0 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer )
            value.LiveSettingsButton                        = GetObject<GlobalMenuButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.GlobalMenuButton.FromPointer); // 02466BF30A88 0x48 LiveSettingsButton          ( 00018667C2C0 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer )
            value.SystemSettingsButton                      = GetObject<GlobalMenuButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.GlobalMenuButton.FromPointer); // 02466BF30AA8 0x50 SystemSettingsButton        ( 00018667C2C0 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer )
            value.DmButton                                  = GetObject<GlobalMenuButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.GlobalMenuButton.FromPointer); // 02466BF30AC8 0x58 DmButton                    ( 00018667C2C0 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer )
            value.HelpButton                                = GetObject<GlobalMenuButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.GlobalMenuButton.FromPointer); // 02466BF30AE8 0x60 HelpButton                  ( 00018667C2C0 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer )
            value.InquiryButton                             = GetObject<GlobalMenuButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.GlobalMenuButton.FromPointer); // 02466BF30B08 0x68 InquiryButton               ( 00018667C2C0 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer )
            value.OthersButton                              = GetObject<GlobalMenuButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.GlobalMenuButton.FromPointer); // 02466BF30B28 0x70 OthersButton                ( 00018667C2C0 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer )
            value.TitleButton                               = GetObject<GlobalMenuButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.GlobalMenuButton.FromPointer); // 02466BF30B48 0x78 TitleButton                 ( 00018667C2C0 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer )

            return value;
        }
    }
}
