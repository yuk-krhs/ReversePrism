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
    // 020 WaitSec                                  0001866656B0 ModelPrimitiveType float float float Single
    public partial class ProduceTutorialWaitActionEvent
    {
        public TutorialExternalAccess?                  TutorialExternalAccess                  { get; set; }
        public Action?                                  Action                                  { get; set; }
        public float                                    WaitSec                                 { get; set; }

        public static ProduceTutorialWaitActionEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialWaitActionEvent();

            value.TutorialExternalAccess                    = GetObject<TutorialExternalAccess>(new IntPtr(p + 0x010), ReversePrism.DataModels.TutorialExternalAccess.FromPointer); // 0270D5D49948 0x10 TutorialExternalAccess      ( 0001866B98B0 ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer )
            value.Action                                    = GetObject<Action>(new IntPtr(p + 0x018), ReversePrism.DataModels.Action.FromPointer); // 0270D5D49968 0x18 Action                      ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.WaitSec                                   = GetSingle(new IntPtr(p + 0x020)); // 0270D5D49988 0x20 WaitSec                     ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
