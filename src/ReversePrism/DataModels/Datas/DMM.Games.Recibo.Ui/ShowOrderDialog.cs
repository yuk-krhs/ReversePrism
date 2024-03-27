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
    // 040 ProductIcon                              000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 048 ProductTitle                             000186631C00 ModelClassType Text Text Text Pointer
    // 050 ProductPoint                             000186631C00 ModelClassType Text Text Text Pointer
    // 058 AvailablePoint                           000186631C00 ModelClassType Text Text Text Pointer
    // 060 PeriodTimeDescription                    000186631C00 ModelClassType Text Text Text Pointer
    // 068 TermOfPayment                            0001865140C0 ModelClassType Button Button Button Pointer
    // 070 TermOfDelivery                           0001865140C0 ModelClassType Button Button Button Pointer
    // 078 ReturnPolicy                             0001865140C0 ModelClassType Button Button Button Pointer
    // 080 PointShortage                            0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 088 DeveloperPayload                         0001866CA730 ModelClassType DeveloperPayload DeveloperPayload DeveloperPayload Pointer
    // 000 Path                                     string IL2CPP_TYPE_STRING
    // 000 _dialog                                  GameObject IL2CPP_TYPE_CLASS
    // 008 _instance                                ShowOrderDialog IL2CPP_TYPE_CLASS
    // 090 Logo                                     0001866CCDB0 ModelClassType Image Image Image Pointer
    public partial class ShowOrderDialog
    {
        public Button?                                  NegativeButton                          { get; set; }
        public Button?                                  PositiveButton                          { get; set; }
        public Text?                                    NegativeButtonText                      { get; set; }
        public Text?                                    PositiveButtonText                      { get; set; }
        public RawImage?                                ProductIcon                             { get; set; }
        public Text?                                    ProductTitle                            { get; set; }
        public Text?                                    ProductPoint                            { get; set; }
        public Text?                                    AvailablePoint                          { get; set; }
        public Text?                                    PeriodTimeDescription                   { get; set; }
        public Button?                                  TermOfPayment                           { get; set; }
        public Button?                                  TermOfDelivery                          { get; set; }
        public Button?                                  ReturnPolicy                            { get; set; }
        public GameObject?                              PointShortage                           { get; set; }
        public DeveloperPayload?                        DeveloperPayload                        { get; set; }
        public Image?                                   Logo                                    { get; set; }

        public static ShowOrderDialog? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShowOrderDialog();

            value.NegativeButton                            = GetObject<Button>(new IntPtr(p + 0x020), ReversePrism.DataModels.Button.FromPointer); // 0270DB45EAC8 0x20 NegativeButton              ( 0001865140C0 ModelClassType Button Button Button Pointer )
            value.PositiveButton                            = GetObject<Button>(new IntPtr(p + 0x028), ReversePrism.DataModels.Button.FromPointer); // 0270DB45EAE8 0x28 PositiveButton              ( 0001865140C0 ModelClassType Button Button Button Pointer )
            value.NegativeButtonText                        = GetObject<Text>(new IntPtr(p + 0x030), ReversePrism.DataModels.Text.FromPointer); // 0270DB45EB08 0x30 NegativeButtonText          ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.PositiveButtonText                        = GetObject<Text>(new IntPtr(p + 0x038), ReversePrism.DataModels.Text.FromPointer); // 0270DB45EB28 0x38 PositiveButtonText          ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.ProductIcon                               = GetObject<RawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.RawImage.FromPointer); // 0270DB45EB48 0x40 ProductIcon                 ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.ProductTitle                              = GetObject<Text>(new IntPtr(p + 0x048), ReversePrism.DataModels.Text.FromPointer); // 0270DB45EB68 0x48 ProductTitle                ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.ProductPoint                              = GetObject<Text>(new IntPtr(p + 0x050), ReversePrism.DataModels.Text.FromPointer); // 0270DB45EB88 0x50 ProductPoint                ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.AvailablePoint                            = GetObject<Text>(new IntPtr(p + 0x058), ReversePrism.DataModels.Text.FromPointer); // 0270DB45EBA8 0x58 AvailablePoint              ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.PeriodTimeDescription                     = GetObject<Text>(new IntPtr(p + 0x060), ReversePrism.DataModels.Text.FromPointer); // 0270DB45EBC8 0x60 PeriodTimeDescription       ( 000186631C00 ModelClassType Text Text Text Pointer )
            value.TermOfPayment                             = GetObject<Button>(new IntPtr(p + 0x068), ReversePrism.DataModels.Button.FromPointer); // 0270DB45EBE8 0x68 TermOfPayment               ( 0001865140C0 ModelClassType Button Button Button Pointer )
            value.TermOfDelivery                            = GetObject<Button>(new IntPtr(p + 0x070), ReversePrism.DataModels.Button.FromPointer); // 0270DB45EC08 0x70 TermOfDelivery              ( 0001865140C0 ModelClassType Button Button Button Pointer )
            value.ReturnPolicy                              = GetObject<Button>(new IntPtr(p + 0x078), ReversePrism.DataModels.Button.FromPointer); // 0270DB45EC28 0x78 ReturnPolicy                ( 0001865140C0 ModelClassType Button Button Button Pointer )
            value.PointShortage                             = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0270DB45EC48 0x80 PointShortage               ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.DeveloperPayload                          = GetObject<DeveloperPayload>(new IntPtr(p + 0x088), ReversePrism.DataModels.DeveloperPayload.FromPointer); // 0270DB45EC68 0x88 DeveloperPayload            ( 0001866CA730 ModelClassType DeveloperPayload DeveloperPayload DeveloperPayload Pointer )
            value.Logo                                      = GetObject<Image>(new IntPtr(p + 0x090), ReversePrism.DataModels.Image.FromPointer); // 0270DB45ECE8 0x90 Logo                        ( 0001866CCDB0 ModelClassType Image Image Image Pointer )

            return value;
        }
    }
}
