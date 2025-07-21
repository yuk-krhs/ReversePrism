using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CloseButton                              ModelClassType Button Button Button Pointer
    // 028 InformationButton                        ModelClassType Button Button Button Pointer
    // 030 CloseButtonText                          ModelClassType Text Text Text Pointer
    // 038 InformationButtonText                    ModelClassType Text Text Text Pointer
    // 040 Message                                  ModelClassType Text Text Text Pointer
    // 000 Path                                     string IL2CPP_TYPE_STRING
    // 000 _dialog                                  GameObject IL2CPP_TYPE_CLASS
    // 008 _instance                                ShowMaintenanceDialog IL2CPP_TYPE_CLASS
    // 048 Logo                                     ModelClassType Image Image Image Pointer
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

            value.CloseButton                               = GetObject<Button>(new IntPtr(p + 0x020), ReversePrism.DataModels.Button.FromPointer); // 0x20 CloseButton                 ( ModelClassType Button Button Button Pointer )
            value.InformationButton                         = GetObject<Button>(new IntPtr(p + 0x028), ReversePrism.DataModels.Button.FromPointer); // 0x28 InformationButton           ( ModelClassType Button Button Button Pointer )
            value.CloseButtonText                           = GetObject<Text>(new IntPtr(p + 0x030), ReversePrism.DataModels.Text.FromPointer); // 0x30 CloseButtonText             ( ModelClassType Text Text Text Pointer )
            value.InformationButtonText                     = GetObject<Text>(new IntPtr(p + 0x038), ReversePrism.DataModels.Text.FromPointer); // 0x38 InformationButtonText       ( ModelClassType Text Text Text Pointer )
            value.Message                                   = GetObject<Text>(new IntPtr(p + 0x040), ReversePrism.DataModels.Text.FromPointer); // 0x40 Message                     ( ModelClassType Text Text Text Pointer )
            value.Logo                                      = GetObject<Image>(new IntPtr(p + 0x048), ReversePrism.DataModels.Image.FromPointer); // 0x48 Logo                        ( ModelClassType Image Image Image Pointer )

            return value;
        }
    }
}
