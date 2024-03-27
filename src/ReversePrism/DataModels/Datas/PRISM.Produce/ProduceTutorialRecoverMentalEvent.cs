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
    public partial class ProduceTutorialRecoverMentalEvent
    {
        public TutorialExternalAccess?                  TutorialExternalAccess                  { get; set; }
        public Action?                                  Action                                  { get; set; }

        public static ProduceTutorialRecoverMentalEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialRecoverMentalEvent();

            value.TutorialExternalAccess                    = GetObject<TutorialExternalAccess>(new IntPtr(p + 0x010), ReversePrism.DataModels.TutorialExternalAccess.FromPointer); // 0270D5D49068 0x10 TutorialExternalAccess      ( 0001866B98B0 ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer )
            value.Action                                    = GetObject<Action>(new IntPtr(p + 0x018), ReversePrism.DataModels.Action.FromPointer); // 0270D5D49088 0x18 Action                      ( 0001866792B0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
