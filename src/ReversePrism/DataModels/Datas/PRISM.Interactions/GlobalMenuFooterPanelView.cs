using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CharaButton                              ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer
    // 028 StoryButton                              ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer
    // 030 ProduceButton                            ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer
    // 038 LiveButton                               ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer
    // 040 GashaButton                              ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer
    // 048 HomeButton                               ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer
    // 050 ShopButton                               ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer
    public partial class GlobalMenuFooterPanelView : DataModel
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
            var value   = new GlobalMenuFooterPanelView() { Pointer= p0 };

            value.CharaButton                               = GetObject<CommonFooterButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.CommonFooterButton.FromPointer); // 0x20 CharaButton                 ( ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer )
            value.StoryButton                               = GetObject<CommonFooterButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.CommonFooterButton.FromPointer); // 0x28 StoryButton                 ( ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer )
            value.ProduceButton                             = GetObject<CommonFooterButton>(new IntPtr(p + 0x030), ReversePrism.DataModels.CommonFooterButton.FromPointer); // 0x30 ProduceButton               ( ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer )
            value.LiveButton                                = GetObject<CommonFooterButton>(new IntPtr(p + 0x038), ReversePrism.DataModels.CommonFooterButton.FromPointer); // 0x38 LiveButton                  ( ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer )
            value.GashaButton                               = GetObject<CommonFooterButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.CommonFooterButton.FromPointer); // 0x40 GashaButton                 ( ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer )
            value.HomeButton                                = GetObject<CommonFooterButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.CommonFooterButton.FromPointer); // 0x48 HomeButton                  ( ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer )
            value.ShopButton                                = GetObject<CommonFooterButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.CommonFooterButton.FromPointer); // 0x50 ShopButton                  ( ModelClassType CommonFooterButton CommonFooterButton CommonFooterButton Pointer )

            return value;
        }
    }
}
