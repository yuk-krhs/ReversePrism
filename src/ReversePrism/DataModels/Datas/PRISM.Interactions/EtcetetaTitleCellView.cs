using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Title                                    ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 Height                                   ModelPrimitiveType float float float Single
    public partial class EtcetetaTitleCellView : DataModel
    {
        public UITextMeshProUGUI?                       Title                                   { get; set; }
        public float                                    Height                                  { get; set; }

        public static EtcetetaTitleCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EtcetetaTitleCellView() { Pointer= p0 };

            value.Title                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 Title                       ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Height                                    = GetSingle(new IntPtr(p + 0x040)); // 0x40 Height                      ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
