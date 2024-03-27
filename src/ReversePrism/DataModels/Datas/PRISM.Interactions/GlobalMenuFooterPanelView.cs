using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CharaButton                              0001865E3500 ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer
    // 028 StoryButton                              0001865E3500 ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer
    // 030 ProduceButton                            0001865E3500 ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer
    // 038 LiveButton                               0001865E3500 ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer
    // 040 GashaButton                              0001865E3500 ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer
    // 048 HomeButton                               0001865E3500 ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer
    // 050 ShopButton                               0001865E3500 ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer
    public partial class GlobalMenuFooterPanelView
    {
        public CommonFooterButton?                      CharaButton                             { get; set; }
        public CommonFooterButton?                      StoryButton                             { get; set; }
        public CommonFooterButton?                      ProduceButton                           { get; set; }
        public CommonFooterButton?                      LiveButton                              { get; set; }
        public CommonFooterButton?                      GashaButton                             { get; set; }
        public CommonFooterButton?                      HomeButton                              { get; set; }
        public CommonFooterButton?                      ShopButton                              { get; set; }

        public static GlobalMenuFooterPanelView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GlobalMenuFooterPanelView();

            value.CharaButton                               = GetObject<CommonFooterButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.CommonFooterButton.FromPointer); // 0270DBEB09D0 0x20 CharaButton                 ( 0001865E3500 ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer )
            value.StoryButton                               = GetObject<CommonFooterButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommonFooterButton.FromPointer); // 0270DBEB09F0 0x28 StoryButton                 ( 0001865E3500 ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer )
            value.ProduceButton                             = GetObject<CommonFooterButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.CommonFooterButton.FromPointer); // 0270DBEB0A10 0x30 ProduceButton               ( 0001865E3500 ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer )
            value.LiveButton                                = GetObject<CommonFooterButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.CommonFooterButton.FromPointer); // 0270DBEB0A30 0x38 LiveButton                  ( 0001865E3500 ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer )
            value.GashaButton                               = GetObject<CommonFooterButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.CommonFooterButton.FromPointer); // 0270DBEB0A50 0x40 GashaButton                 ( 0001865E3500 ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer )
            value.HomeButton                                = GetObject<CommonFooterButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.CommonFooterButton.FromPointer); // 0270DBEB0A70 0x48 HomeButton                  ( 0001865E3500 ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer )
            value.ShopButton                                = GetObject<CommonFooterButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.CommonFooterButton.FromPointer); // 0270DBEB0A90 0x50 ShopButton                  ( 0001865E3500 ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer )

            return value;
        }
    }
}
