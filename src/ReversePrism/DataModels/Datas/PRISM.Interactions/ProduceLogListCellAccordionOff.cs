using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 LittleIndexTransform                     ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 LittleIndexText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 BaseProduceLogAccordionOffView           ModelClassType ProduceLogAccordionOffView ProduceLogAccordionOffView ProduceLogAccordionOffView Pointer
    // 050 CurrentProduceLogAccordionOffView        ModelClassType ProduceLogAccordionOffView ProduceLogAccordionOffView ProduceLogAccordionOffView Pointer
    // 058 ParentRectTransform                      ModelClassType RectTransform RectTransform RectTransform Pointer
    // 060 CellRectTransform                        ModelClassType RectTransform RectTransform RectTransform Pointer
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

            value.LittleIndexTransform                      = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0x38 LittleIndexTransform        ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.LittleIndexText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 LittleIndexText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.BaseProduceLogAccordionOffView            = GetObject<ProduceLogAccordionOffView>(new IntPtr(p + 0x048), ReversePrism.DataModels.ProduceLogAccordionOffView.FromPointer); // 0x48 BaseProduceLogAccordionOffView ( ModelClassType ProduceLogAccordionOffView ProduceLogAccordionOffView ProduceLogAccordionOffView Pointer )
            value.CurrentProduceLogAccordionOffView         = GetObject<ProduceLogAccordionOffView>(new IntPtr(p + 0x050), ReversePrism.DataModels.ProduceLogAccordionOffView.FromPointer); // 0x50 CurrentProduceLogAccordionOffView ( ModelClassType ProduceLogAccordionOffView ProduceLogAccordionOffView ProduceLogAccordionOffView Pointer )
            value.ParentRectTransform                       = GetObject<RectTransform>(new IntPtr(p + 0x058), ReversePrism.DataModels.RectTransform.FromPointer); // 0x58 ParentRectTransform         ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.CellRectTransform                         = GetObject<RectTransform>(new IntPtr(p + 0x060), ReversePrism.DataModels.RectTransform.FromPointer); // 0x60 CellRectTransform           ( ModelClassType RectTransform RectTransform RectTransform Pointer )

            return value;
        }
    }
}
