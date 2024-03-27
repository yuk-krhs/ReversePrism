using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 BOTTOM_HEIGHT                            float IL2CPP_TYPE_R4
    // 038 Rect                                     000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 BaseHeight                               0001866656B0 ModelPrimitiveType float float float Single
    // 048 TxtNotes                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class StepUpGashaRatesNotesCellView
    {
        public RectTransform?                           Rect                                    { get; set; }
        public float                                    BaseHeight                              { get; set; }
        public UITextMeshProUGUI?                       TxtNotes                                { get; set; }

        public static StepUpGashaRatesNotesCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StepUpGashaRatesNotesCellView();

            value.Rect                                      = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0270DBA138E0 0x38 Rect                        ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.BaseHeight                                = GetSingle(new IntPtr(p + 0x040)); // 0270DBA13900 0x40 BaseHeight                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TxtNotes                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x048), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBA13920 0x48 TxtNotes                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
