using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 BaseHeight                               ModelPrimitiveType float float float Single
    // 040 TxtTitle                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class GashaRatesTitleCellView : DataModel
    {
        public float                                    BaseHeight                              { get; set; }
        public UITextMeshProUGUI?                       TxtTitle                                { get; set; }

        public static GashaRatesTitleCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaRatesTitleCellView() { Pointer= p0 };

            value.BaseHeight                                = GetSingle(new IntPtr(p + 0x038)); // 0x38 BaseHeight                  ( ModelPrimitiveType float float float Single )
            value.TxtTitle                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x40 TxtTitle                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
