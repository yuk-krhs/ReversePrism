using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 BaseHeight                               0001866656B0 ModelPrimitiveType float float float Single
    // 040 TxtTitle                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class StepUpGashaRatesTitleCellView
    {
        public float                                    BaseHeight                              { get; set; }
        public UITextMeshProUGUI?                       TxtTitle                                { get; set; }

        public static StepUpGashaRatesTitleCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StepUpGashaRatesTitleCellView();

            value.BaseHeight                                = GetSingle(new IntPtr(p + 0x038)); // 0270DBA28C58 0x38 BaseHeight                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TxtTitle                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DBA28C78 0x40 TxtTitle                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
