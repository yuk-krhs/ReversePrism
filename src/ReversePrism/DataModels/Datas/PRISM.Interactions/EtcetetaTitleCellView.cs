using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Title                                    0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 Height                                   0001866656B0 ModelPrimitiveType float float float Single
    public partial class EtcetetaTitleCellView
    {
        public UITextMeshProUGUI?                       Title                                   { get; set; }
        public float                                    Height                                  { get; set; }

        public static EtcetetaTitleCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EtcetetaTitleCellView();

            value.Title                                     = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2A8BA8 0x38 Title                       ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Height                                    = GetSingle(new IntPtr(p + 0x040)); // 0270DA2A8BC8 0x40 Height                      ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
