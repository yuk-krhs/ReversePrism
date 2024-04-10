using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DateText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 DateTextArea                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 TimeText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 EndDate                                  0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 040 IntervalDisposable                       0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 000 intervalSecond                           float IL2CPP_TYPE_R4
    public partial class MusicRankingPeriodView : DataModel
    {
        public UITextMeshProUGUI?                       DateText                                { get; set; }
        public GameObject?                              DateTextArea                            { get; set; }
        public UITextMeshProUGUI?                       TimeText                                { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public IDisposable?                             IntervalDisposable                      { get; set; }

        public static MusicRankingPeriodView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MusicRankingPeriodView() { Pointer= p0 };

            value.DateText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B4674F0 0x20 DateText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DateTextArea                              = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 02466B467510 0x28 DateTextArea                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TimeText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466B467530 0x30 TimeText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x038)); // 02466B467550 0x38 EndDate                     ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.IntervalDisposable                        = GetObject<IDisposable>(new IntPtr(p + 0x040), ReversePrism.DataModels.IDisposable.FromPointer); // 02466B467570 0x40 IntervalDisposable          ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
