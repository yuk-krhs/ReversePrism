using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CloseButton                              0001865140C0 ModelClassType Button Button Button Pointer
    // 028 InformationButton                        0001865140C0 ModelClassType Button Button Button Pointer
    // 030 CloseButtonText                          000186631C00 ModelClassType Text Text Text Pointer
    // 038 InformationButtonText                    000186631C00 ModelClassType Text Text Text Pointer
    // 040 Message                                  000186631C00 ModelClassType Text Text Text Pointer
    // 000 Path                                     string IL2CPP_TYPE_STRING
    // 000 _dialog                                  GameObject IL2CPP_TYPE_CLASS
    // 008 _instance                                ShowMaintenanceDialog IL2CPP_TYPE_CLASS
    // 048 Logo                                     0001866CCDB0 ModelClassType Image Image Image Pointer
    public partial class ShowMaintenanceDialog : DataModel
    {
        public Button?                                  CloseButton                             { get; set; }
        public Button?                                  InformationButton                       { get; set; }
        public Text?                                    CloseButtonText                         { get; set; }
        public Text?                                    InformationButtonText                   { get; set; }
        public Text?                                    Message                                 { get; set; }
        public Image?                                   Logo                                    { get; set; }

        public static ShowMaintenanceDialog? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShowMaintenanceDialog() { Pointer= p0 };

            value.CloseButton                               = GetObject<Button>(new IntPtr(p + 0x020), ReversePrism.DataModels.Button.FromPointer); // 02466B4EB230 0x20 CloseButton                 ( 0001865140C0 ModelClassType Button Button Button Pointer )
            value.InformationButton                         = GetObject<Button>(new IntPtr(p + 0x028), ReversePrism.DataModels.Button.FromPointer); // 02466B4EB250 0x28 InformationButton           ( 0001865140C0 ModelClassType Button Button Button Pointer )
            value.CloseButtonText                           = GetObject<Text>(new IntPtr(p + 0x030), ReversePrism.DataModels.Text.FromPointer); // 02466B4EB270 0x30 CloseButtonText             ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.InformationButtonText                     = GetObject<Text>(new IntPtr(p + 0x038), ReversePrism.DataModels.Text.FromPointer); // 02466B4EB290 0x38 InformationButtonText       ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.Message                                   = GetObject<Text>(new IntPtr(p + 0x040), ReversePrism.DataModels.Text.FromPointer); // 02466B4EB2B0 0x40 Message                     ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.Logo                                      = GetObject<Image>(new IntPtr(p + 0x048), ReversePrism.DataModels.Image.FromPointer); // 02466B4EB330 0x48 Logo                        ( 0001866CCDB0 ModelClassType Image Image Image Pointer )

            return value;
        }
    }
}
