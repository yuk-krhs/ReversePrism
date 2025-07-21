using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NegativeButton                           ModelClassType Button Button Button Pointer
    // 028 PositiveButton                           ModelClassType Button Button Button Pointer
    // 030 NegativeButtonText                       ModelClassType Text Text Text Pointer
    // 038 PositiveButtonText                       ModelClassType Text Text Text Pointer
    // 040 ProductIcon                              ModelClassType RawImage RawImage RawImage Pointer
    // 048 ProductTitle                             ModelClassType Text Text Text Pointer
    // 050 ProductPoint                             ModelClassType Text Text Text Pointer
    // 058 AvailablePoint                           ModelClassType Text Text Text Pointer
    // 060 PeriodTimeDescription                    ModelClassType Text Text Text Pointer
    // 068 TermOfPayment                            ModelClassType Button Button Button Pointer
    // 070 TermOfDelivery                           ModelClassType Button Button Button Pointer
    // 078 ReturnPolicy                             ModelClassType Button Button Button Pointer
    // 080 PointShortage                            ModelClassType GameObject GameObject GameObject Pointer
    // 088 DeveloperPayload                         ModelClassType DeveloperPayload DeveloperPayload DeveloperPayload Pointer
    // 000 Path                                     string IL2CPP_TYPE_STRING
    // 000 _dialog                                  GameObject IL2CPP_TYPE_CLASS
    // 008 _instance                                ShowOrderDialog IL2CPP_TYPE_CLASS
    // 090 Logo                                     ModelClassType Image Image Image Pointer
    public partial class ShowOrderDialog : DataModel
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
            var value   = new ShowOrderDialog() { Pointer= p0 };

            value.NegativeButton                            = GetObject<Button>(new IntPtr(p + 0x020), ReversePrism.DataModels.Button.FromPointer); // 0x20 NegativeButton              ( ModelClassType Button Button Button Pointer )
            value.PositiveButton                            = GetObject<Button>(new IntPtr(p + 0x028), ReversePrism.DataModels.Button.FromPointer); // 0x28 PositiveButton              ( ModelClassType Button Button Button Pointer )
            value.NegativeButtonText                        = GetObject<Text>(new IntPtr(p + 0x030), ReversePrism.DataModels.Text.FromPointer); // 0x30 NegativeButtonText          ( ModelClassType Text Text Text Pointer )
            value.PositiveButtonText                        = GetObject<Text>(new IntPtr(p + 0x038), ReversePrism.DataModels.Text.FromPointer); // 0x38 PositiveButtonText          ( ModelClassType Text Text Text Pointer )
            value.ProductIcon                               = GetObject<RawImage>(new IntPtr(p + 0x040), ReversePrism.DataModels.RawImage.FromPointer); // 0x40 ProductIcon                 ( ModelClassType RawImage RawImage RawImage Pointer )
            value.ProductTitle                              = GetObject<Text>(new IntPtr(p + 0x048), ReversePrism.DataModels.Text.FromPointer); // 0x48 ProductTitle                ( ModelClassType Text Text Text Pointer )
            value.ProductPoint                              = GetObject<Text>(new IntPtr(p + 0x050), ReversePrism.DataModels.Text.FromPointer); // 0x50 ProductPoint                ( ModelClassType Text Text Text Pointer )
            value.AvailablePoint                            = GetObject<Text>(new IntPtr(p + 0x058), ReversePrism.DataModels.Text.FromPointer); // 0x58 AvailablePoint              ( ModelClassType Text Text Text Pointer )
            value.PeriodTimeDescription                     = GetObject<Text>(new IntPtr(p + 0x060), ReversePrism.DataModels.Text.FromPointer); // 0x60 PeriodTimeDescription       ( ModelClassType Text Text Text Pointer )
            value.TermOfPayment                             = GetObject<Button>(new IntPtr(p + 0x068), ReversePrism.DataModels.Button.FromPointer); // 0x68 TermOfPayment               ( ModelClassType Button Button Button Pointer )
            value.TermOfDelivery                            = GetObject<Button>(new IntPtr(p + 0x070), ReversePrism.DataModels.Button.FromPointer); // 0x70 TermOfDelivery              ( ModelClassType Button Button Button Pointer )
            value.ReturnPolicy                              = GetObject<Button>(new IntPtr(p + 0x078), ReversePrism.DataModels.Button.FromPointer); // 0x78 ReturnPolicy                ( ModelClassType Button Button Button Pointer )
            value.PointShortage                             = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 PointShortage               ( ModelClassType GameObject GameObject GameObject Pointer )
            value.DeveloperPayload                          = GetObject<DeveloperPayload>(new IntPtr(p + 0x088), ReversePrism.DataModels.DeveloperPayload.FromPointer); // 0x88 DeveloperPayload            ( ModelClassType DeveloperPayload DeveloperPayload DeveloperPayload Pointer )
            value.Logo                                      = GetObject<Image>(new IntPtr(p + 0x090), ReversePrism.DataModels.Image.FromPointer); // 0x90 Logo                        ( ModelClassType Image Image Image Pointer )

            return value;
        }
    }
}
