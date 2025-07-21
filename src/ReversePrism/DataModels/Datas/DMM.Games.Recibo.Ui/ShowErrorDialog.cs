using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Message                                  ModelClassType Text Text Text Pointer
    // 028 CloseButton                              ModelClassType Button Button Button Pointer
    // 030 InquiryButton                            ModelClassType Button Button Button Pointer
    // 000 Path                                     string IL2CPP_TYPE_STRING
    // 000 _dialog                                  GameObject IL2CPP_TYPE_CLASS
    // 000 InquiryUrl                               string IL2CPP_TYPE_STRING
    // 008 _instance                                ShowErrorDialog IL2CPP_TYPE_CLASS
    // 038 Logo                                     ModelClassType Image Image Image Pointer
    public partial class ShowErrorDialog : DataModel
    {
        public Text?                                    Message                                 { get; set; }
        public Button?                                  CloseButton                             { get; set; }
        public Button?                                  InquiryButton                           { get; set; }
        public Image?                                   Logo                                    { get; set; }

        public static ShowErrorDialog? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShowErrorDialog() { Pointer= p0 };

            value.Message                                   = GetObject<Text>(new IntPtr(p + 0x020), ReversePrism.DataModels.Text.FromPointer); // 0x20 Message                     ( ModelClassType Text Text Text Pointer )
            value.CloseButton                               = GetObject<Button>(new IntPtr(p + 0x028), ReversePrism.DataModels.Button.FromPointer); // 0x28 CloseButton                 ( ModelClassType Button Button Button Pointer )
            value.InquiryButton                             = GetObject<Button>(new IntPtr(p + 0x030), ReversePrism.DataModels.Button.FromPointer); // 0x30 InquiryButton               ( ModelClassType Button Button Button Pointer )
            value.Logo                                      = GetObject<Image>(new IntPtr(p + 0x038), ReversePrism.DataModels.Image.FromPointer); // 0x38 Logo                        ( ModelClassType Image Image Image Pointer )

            return value;
        }
    }
}
