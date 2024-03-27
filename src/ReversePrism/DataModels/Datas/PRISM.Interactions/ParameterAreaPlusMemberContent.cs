using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MemberAmountText                         0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 ScheduleParameterContent                 0001866D6360 ModelClassType ScheduleParameterContent ScheduleParameterContent ScheduleParameterContent Pointer
    // 030 ScheduleRewardContentList                000185D061F8 ModelClassListType List`1<ScheduleRewardContent> List`1<ScheduleRewardContent> List<ScheduleRewardContent> Pointer
    public partial class ParameterAreaPlusMemberContent
    {
        public UITextMeshProUGUI?                       MemberAmountText                        { get; set; }
        public ScheduleParameterContent?                ScheduleParameterContent                { get; set; }
        public List<ScheduleRewardContent>?             ScheduleRewardContentList               { get; set; }

        public static ParameterAreaPlusMemberContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParameterAreaPlusMemberContent();

            value.MemberAmountText                          = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA166FE0 0x20 MemberAmountText            ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ScheduleParameterContent                  = GetObject<ScheduleParameterContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.ScheduleParameterContent.FromPointer); // 0270DA167000 0x28 ScheduleParameterContent    ( 0001866D6360 ModelClassType ScheduleParameterContent ScheduleParameterContent ScheduleParameterContent Pointer )
            value.ScheduleRewardContentList                 = GetObjectList<ScheduleRewardContent>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScheduleRewardContent.FromPointer); // 0270DA167020 0x30 ScheduleRewardContentList   ( 000185D061F8 ModelClassListType List`1<ScheduleRewardContent> List`1<ScheduleRewardContent> List<ScheduleRewardContent> Pointer )

            return value;
        }
    }
}
