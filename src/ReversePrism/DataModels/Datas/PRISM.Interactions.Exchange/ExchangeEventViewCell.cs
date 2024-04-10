using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ExchangeEventImageNameBase               string IL2CPP_TYPE_STRING
    // 030 NewBtgObj                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 038 ItemIcon                                 000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 040 EventName                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 PlayablePeriodText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 050 ExchangePeriodText                       0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 058 CellInActiveObj                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 060 ButtonInActiveObj                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 068 ExchangeBtn                              0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 070 GoodsData                                000186778D40 ModelClassType ExchangeEventGridViewModel ExchangeEventGridViewModel ExchangeEventGridViewModel Pointer
    public partial class ExchangeEventViewCell : DataModel
    {
        public GameObject?                              NewBtgObj                               { get; set; }
        public RawImage?                                ItemIcon                                { get; set; }
        public UITextMeshProUGUI?                       EventName                               { get; set; }
        public UITextMeshProUGUI?                       PlayablePeriodText                      { get; set; }
        public UITextMeshProUGUI?                       ExchangePeriodText                      { get; set; }
        public GameObject?                              CellInActiveObj                         { get; set; }
        public GameObject?                              ButtonInActiveObj                       { get; set; }
        public UIButton?                                ExchangeBtn                             { get; set; }
        public ExchangeEventGridViewModel?              GoodsData                               { get; set; }

        public static ExchangeEventViewCell? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExchangeEventViewCell() { Pointer= p0 };

            value.NewBtgObj                                 = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466B98D008 0x30 NewBtgObj                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ItemIcon                                  = GetObject<RawImage>(new IntPtr(p + 0x038), ReversePrism.DataModels.RawImage.FromPointer); // 02466B98D028 0x38 ItemIcon                    ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.EventName                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B98D048 0x40 EventName                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PlayablePeriodText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B98D068 0x48 PlayablePeriodText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ExchangePeriodText                        = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x050), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B98D088 0x50 ExchangePeriodText          ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CellInActiveObj                           = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 02466B98D0A8 0x58 CellInActiveObj             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ButtonInActiveObj                         = GetObject<GameObject>(new IntPtr(p + 0x060), ReversePrism.DataModels.GameObject.FromPointer); // 02466B98D0C8 0x60 ButtonInActiveObj           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ExchangeBtn                               = GetObject<UIButton>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIButton.FromPointer); // 02466B98D0E8 0x68 ExchangeBtn                 ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.GoodsData                                 = GetObject<ExchangeEventGridViewModel>(new IntPtr(p + 0x070), ReversePrism.DataModels.ExchangeEventGridViewModel.FromPointer); // 02466B98D108 0x70 GoodsData                   ( 000186778D40 ModelClassType ExchangeEventGridViewModel ExchangeEventGridViewModel ExchangeEventGridViewModel Pointer )

            return value;
        }
    }
}
