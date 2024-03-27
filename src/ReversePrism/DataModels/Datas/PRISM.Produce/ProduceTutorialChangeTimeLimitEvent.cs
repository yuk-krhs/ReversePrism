using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TutorialExternalAccess                   0001866B98B0 ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer
    // 018 Action                                   0001866792B0 ModelClassType Action Action Action Pointer
    // 020 TargetSec                                0001866656B0 ModelPrimitiveType float float float Single
    public partial class ProduceTutorialChangeTimeLimitEvent
    {
        public TutorialExternalAccess?                  TutorialExternalAccess                  { get; set; }
        public Action?                                  Action                                  { get; set; }
        public float                                    TargetSec                               { get; set; }

        public static ProduceTutorialChangeTimeLimitEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialChangeTimeLimitEvent();

            value.TutorialExternalAccess                    = GetObject<TutorialExternalAccess>(new IntPtr(p + 0x010), ReversePrism.DataModels.TutorialExternalAccess.FromPointer); // 0270D5D49CB8 0x10 TutorialExternalAccess      ( 0001866B98B0 ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer )
            value.Action                                    = GetObject<Action>(new IntPtr(p + 0x018), ReversePrism.DataModels.Action.FromPointer); // 0270D5D49CD8 0x18 Action                      ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.TargetSec                                 = GetSingle(new IntPtr(p + 0x020)); // 0270D5D49CF8 0x20 TargetSec                   ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
