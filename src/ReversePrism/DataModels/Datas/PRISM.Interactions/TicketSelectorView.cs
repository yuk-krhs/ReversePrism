using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtName                                  0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ImgTicket                                000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 030 TxtTicketAmount                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtCount                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 BtnMin                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 048 BtnDown                                  0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 050 BtnUp                                    0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 058 BtnMax                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 060 Index                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 064 Nothing                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 068 OnButton                                 Subject`1<ValueTuple`2<int, TicketButtonType>> IL2CPP_TYPE_GENERICINST
    public partial class TicketSelectorView : DataModel
    {
        public UITextMeshProUGUI?                       TxtName                                 { get; set; }
        public RawImage?                                ImgTicket                               { get; set; }
        public UITextMeshProUGUI?                       TxtTicketAmount                         { get; set; }
        public UITextMeshProUGUI?                       TxtCount                                { get; set; }
        public UIButton?                                BtnMin                                  { get; set; }
        public UIButton?                                BtnDown                                 { get; set; }
        public UIButton?                                BtnUp                                   { get; set; }
        public UIButton?                                BtnMax                                  { get; set; }
        public int                                      Index                                   { get; set; }
        public bool                                     Nothing                                 { get; set; }

        public static TicketSelectorView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TicketSelectorView() { Pointer= p0 };

            value.TxtName                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3ED0E0 0x20 TxtName                     ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgTicket                                 = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 02466A3ED100 0x28 ImgTicket                   ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtTicketAmount                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3ED120 0x30 TxtTicketAmount             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtCount                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A3ED140 0x38 TxtCount                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnMin                                    = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3ED160 0x40 BtnMin                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnDown                                   = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3ED180 0x48 BtnDown                     ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnUp                                     = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3ED1A0 0x50 BtnUp                       ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnMax                                    = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 02466A3ED1C0 0x58 BtnMax                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x060)); // 02466A3ED1E0 0x60 Index                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Nothing                                   = GetBool(new IntPtr(p + 0x064)); // 02466A3ED200 0x64 Nothing                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
