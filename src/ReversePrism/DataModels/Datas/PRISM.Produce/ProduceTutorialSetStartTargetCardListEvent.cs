using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TutorialExternalAccess                   0001866B98B0 ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer
    // 018 CardIds                                  000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class ProduceTutorialSetStartTargetCardListEvent
    {
        public TutorialExternalAccess?                  TutorialExternalAccess                  { get; set; }
        public List<int>?                               CardIds                                 { get; set; }

        public static ProduceTutorialSetStartTargetCardListEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialSetStartTargetCardListEvent();

            value.TutorialExternalAccess                    = GetObject<TutorialExternalAccess>(new IntPtr(p + 0x010), ReversePrism.DataModels.TutorialExternalAccess.FromPointer); // 0270D5D4A288 0x10 TutorialExternalAccess      ( 0001866B98B0 ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer )
            value.CardIds                                   = GetInt32List(new IntPtr(p + 0x018)); // 0270D5D4A2A8 0x18 CardIds                     ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
