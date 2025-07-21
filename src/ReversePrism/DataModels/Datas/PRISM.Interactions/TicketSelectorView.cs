using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtName                                  ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ImgTicket                                ModelClassType RawImage RawImage RawImage Pointer
    // 030 TxtTicketAmount                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 TxtCount                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 BtnMin                                   ModelClassType UIButton UIButton UIButton Pointer
    // 048 BtnDown                                  ModelClassType UIButton UIButton UIButton Pointer
    // 050 BtnUp                                    ModelClassType UIButton UIButton UIButton Pointer
    // 058 BtnMax                                   ModelClassType UIButton UIButton UIButton Pointer
    // 060 Index                                    ModelPrimitiveType int int int Int32
    // 064 Nothing                                  ModelPrimitiveType bool bool bool Bool
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

            value.TxtName                                   = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TxtName                     ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ImgTicket                                 = GetObject<RawImage>(new IntPtr(p + 0x028), ReversePrism.DataModels.RawImage.FromPointer); // 0x28 ImgTicket                   ( ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtTicketAmount                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtTicketAmount             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtCount                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 TxtCount                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BtnMin                                    = GetObject<UIButton>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIButton.FromPointer); // 0x40 BtnMin                      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnDown                                   = GetObject<UIButton>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIButton.FromPointer); // 0x48 BtnDown                     ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnUp                                     = GetObject<UIButton>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIButton.FromPointer); // 0x50 BtnUp                       ( ModelClassType UIButton UIButton UIButton Pointer )
            value.BtnMax                                    = GetObject<UIButton>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIButton.FromPointer); // 0x58 BtnMax                      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x060)); // 0x60 Index                       ( ModelPrimitiveType int int int Int32 )
            value.Nothing                                   = GetBool(new IntPtr(p + 0x064)); // 0x64 Nothing                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
