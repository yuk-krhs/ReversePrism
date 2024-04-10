using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 LittleIndexTransform                     000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 LittleIndexText                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 BaseProduceLogAccordionOffView           00018655C0E0 ModelClassType ProduceLogAccordionOffView ProduceLogAccordionOffView ProduceLogAccordionOffView Pointer
    // 050 CurrentProduceLogAccordionOffView        00018655C0E0 ModelClassType ProduceLogAccordionOffView ProduceLogAccordionOffView ProduceLogAccordionOffView Pointer
    // 058 ParentRectTransform                      000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 060 CellRectTransform                        000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 068 onAccordionOpened                        Subject`1<ValueTuple`2<bool, int>> IL2CPP_TYPE_GENERICINST
    public partial class ProduceLogListCellAccordionOff : DataModel
    {
        public RectTransform?                           LittleIndexTransform                    { get; set; }
        public UITextMeshProUGUI?                       LittleIndexText                         { get; set; }
        public ProduceLogAccordionOffView?              BaseProduceLogAccordionOffView          { get; set; }
        public ProduceLogAccordionOffView?              CurrentProduceLogAccordionOffView       { get; set; }
        public RectTransform?                           ParentRectTransform                     { get; set; }
        public RectTransform?                           CellRectTransform                       { get; set; }

        public static ProduceLogListCellAccordionOff? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceLogListCellAccordionOff() { Pointer= p0 };

            value.LittleIndexTransform                      = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 02466A1780F8 0x38 LittleIndexTransform        ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.LittleIndexText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A178118 0x40 LittleIndexText             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BaseProduceLogAccordionOffView            = GetObject<ProduceLogAccordionOffView>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProduceLogAccordionOffView.FromPointer); // 02466A178138 0x48 BaseProduceLogAccordionOffView ( 00018655C0E0 ModelClassType ProduceLogAccordionOffView ProduceLogAccordionOffView ProduceLogAccordionOffView Pointer )
            value.CurrentProduceLogAccordionOffView         = GetObject<ProduceLogAccordionOffView>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProduceLogAccordionOffView.FromPointer); // 02466A178158 0x50 CurrentProduceLogAccordionOffView ( 00018655C0E0 ModelClassType ProduceLogAccordionOffView ProduceLogAccordionOffView ProduceLogAccordionOffView Pointer )
            value.ParentRectTransform                       = GetObject<RectTransform>(new IntPtr(p + 0x058), ReversePrism.DataModels.RectTransform.FromPointer); // 02466A178178 0x58 ParentRectTransform         ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.CellRectTransform                         = GetObject<RectTransform>(new IntPtr(p + 0x060), ReversePrism.DataModels.RectTransform.FromPointer); // 02466A178198 0x60 CellRectTransform           ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )

            return value;
        }
    }
}
