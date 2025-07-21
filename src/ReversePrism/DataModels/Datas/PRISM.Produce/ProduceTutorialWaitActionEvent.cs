using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TutorialExternalAccess                   ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer
    // 018 Action                                   ModelClassType Action Action Action Pointer
    // 020 WaitSec                                  ModelPrimitiveType float float float Single
    public partial class ProduceTutorialWaitActionEvent : DataModel
    {
        public TutorialExternalAccess?                  TutorialExternalAccess                  { get; set; }
        public Action?                                  Action                                  { get; set; }
        public float                                    WaitSec                                 { get; set; }

        public static ProduceTutorialWaitActionEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialWaitActionEvent() { Pointer= p0 };

            value.TutorialExternalAccess                    = GetObject<TutorialExternalAccess>(new IntPtr(p + 0x010), ReversePrism.DataModels.TutorialExternalAccess.FromPointer); // 0x10 TutorialExternalAccess      ( ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer )
            value.Action                                    = GetObject<Action>(new IntPtr(p + 0x018), ReversePrism.DataModels.Action.FromPointer); // 0x18 Action                      ( ModelClassType Action Action Action Pointer )
            value.WaitSec                                   = GetSingle(new IntPtr(p + 0x020)); // 0x20 WaitSec                     ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
