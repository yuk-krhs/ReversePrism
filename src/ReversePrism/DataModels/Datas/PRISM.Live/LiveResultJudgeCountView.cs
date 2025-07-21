using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TotalText                                ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 DetailText                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 ViewModel                                ModelEnumType LiveResultJudgeCountViewModel LiveResultJudgeCountViewModel LiveResultJudgeCountViewModel Int32
    public partial class LiveResultJudgeCountView : DataModel
    {
        public UITextMeshProUGUI?                       TotalText                               { get; set; }
        public UITextMeshProUGUI?                       DetailText                              { get; set; }
        public LiveResultJudgeCountViewModel            ViewModel                               { get; set; }

        public static LiveResultJudgeCountView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultJudgeCountView() { Pointer= p0 };

            value.TotalText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TotalText                   ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DetailText                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 DetailText                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ViewModel                                 = (LiveResultJudgeCountViewModel)GetInt32(new IntPtr(p + 0x030)); // 0x30 ViewModel                   ( ModelEnumType LiveResultJudgeCountViewModel LiveResultJudgeCountViewModel LiveResultJudgeCountViewModel Int32 )

            return value;
        }
    }
}
