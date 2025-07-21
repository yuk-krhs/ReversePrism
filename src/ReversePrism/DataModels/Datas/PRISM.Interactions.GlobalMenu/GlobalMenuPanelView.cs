using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ItemButton                               ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer
    // 028 ProducerButton                           ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer
    // 030 FriendButton                             ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer
    // 038 AccountButton                            ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer
    // 040 ProduceSettingsButton                    ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer
    // 048 LiveSettingsButton                       ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer
    // 050 SystemSettingsButton                     ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer
    // 058 DmButton                                 ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer
    // 060 HelpButton                               ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer
    // 068 InquiryButton                            ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer
    // 070 OthersButton                             ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer
    // 078 TitleButton                              ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer
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

            value.ItemButton                                = GetObject<GlobalMenuButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.GlobalMenuButton.FromPointer); // 0x20 ItemButton                  ( ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer )
            value.ProducerButton                            = GetObject<GlobalMenuButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.GlobalMenuButton.FromPointer); // 0x28 ProducerButton              ( ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer )
            value.FriendButton                              = GetObject<GlobalMenuButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.GlobalMenuButton.FromPointer); // 0x30 FriendButton                ( ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer )
            value.AccountButton                             = GetObject<GlobalMenuButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.GlobalMenuButton.FromPointer); // 0x38 AccountButton               ( ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer )
            value.ProduceSettingsButton                     = GetObject<GlobalMenuButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.GlobalMenuButton.FromPointer); // 0x40 ProduceSettingsButton       ( ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer )
            value.LiveSettingsButton                        = GetObject<GlobalMenuButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.GlobalMenuButton.FromPointer); // 0x48 LiveSettingsButton          ( ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer )
            value.SystemSettingsButton                      = GetObject<GlobalMenuButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.GlobalMenuButton.FromPointer); // 0x50 SystemSettingsButton        ( ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer )
            value.DmButton                                  = GetObject<GlobalMenuButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.GlobalMenuButton.FromPointer); // 0x58 DmButton                    ( ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer )
            value.HelpButton                                = GetObject<GlobalMenuButton>(new IntPtr(p + 0x060), ReversePrism.DataModels.GlobalMenuButton.FromPointer); // 0x60 HelpButton                  ( ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer )
            value.InquiryButton                             = GetObject<GlobalMenuButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.GlobalMenuButton.FromPointer); // 0x68 InquiryButton               ( ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer )
            value.OthersButton                              = GetObject<GlobalMenuButton>(new IntPtr(p + 0x070), ReversePrism.DataModels.GlobalMenuButton.FromPointer); // 0x70 OthersButton                ( ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer )
            value.TitleButton                               = GetObject<GlobalMenuButton>(new IntPtr(p + 0x078), ReversePrism.DataModels.GlobalMenuButton.FromPointer); // 0x78 TitleButton                 ( ModelClassType GlobalMenuButton GlobalMenuButton GlobalMenuButton Pointer )

            return value;
        }
    }
}
