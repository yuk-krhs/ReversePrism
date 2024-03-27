using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NegativeButton                           0001865140C0 ModelClassType Button Button Button Pointer
    // 028 PositiveButton                           0001865140C0 ModelClassType Button Button Button Pointer
    // 030 NegativeButtonText                       000186631C00 ModelClassType Text Text Text Pointer
    // 038 PositiveButtonText                       000186631C00 ModelClassType Text Text Text Pointer
    // 040 Message                                  000186631C00 ModelClassType Text Text Text Pointer
    // 000 Path                                     string IL2CPP_TYPE_STRING
    // 000 _dialog                                  GameObject IL2CPP_TYPE_CLASS
    // 008 _instance                                ShowRetryDialog IL2CPP_TYPE_CLASS
    // 048 Logo                                     0001866CCDB0 ModelClassType Image Image Image Pointer
    public partial class ShowRetryDialog
    {
        public Button?                                  NegativeButton                          { get; set; }
        public Button?                                  PositiveButton                          { get; set; }
        public Text?                                    NegativeButtonText                      { get; set; }
        public Text?                                    PositiveButtonText                      { get; set; }
        public Text?                                    Message                                 { get; set; }
        public Image?                                   Logo                                    { get; set; }

        public static ShowRetryDialog? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShowRetryDialog();

            value.NegativeButton                            = GetObject<Button>(new IntPtr(p + 0x020), ReversePrism.DataModels.Button.FromPointer); // 0270DB45F820 0x20 NegativeButton              ( 0001865140C0 ModelClassType Button Button Button Pointer )
            value.PositiveButton                            = GetObject<Button>(new IntPtr(p + 0x028), ReversePrism.DataModels.Button.FromPointer); // 0270DB45F840 0x28 PositiveButton              ( 0001865140C0 ModelClassType Button Button Button Pointer )
            value.NegativeButtonText                        = GetObject<Text>(new IntPtr(p + 0x030), ReversePrism.DataModels.Text.FromPointer); // 0270DB45F860 0x30 NegativeButtonText          ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.PositiveButtonText                        = GetObject<Text>(new IntPtr(p + 0x038), ReversePrism.DataModels.Text.FromPointer); // 0270DB45F880 0x38 PositiveButtonText          ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.Message                                   = GetObject<Text>(new IntPtr(p + 0x040), ReversePrism.DataModels.Text.FromPointer); // 0270DB45F8A0 0x40 Message                     ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.Logo                                      = GetObject<Image>(new IntPtr(p + 0x048), ReversePrism.DataModels.Image.FromPointer); // 0270DB45F920 0x48 Logo                        ( 0001866CCDB0 ModelClassType Image Image Image Pointer )

            return value;
        }
    }
}
