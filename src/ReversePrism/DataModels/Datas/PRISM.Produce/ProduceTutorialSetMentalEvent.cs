using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TutorialExternalAccess                   0001866B98B0 ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer
    // 018 MentalRate                               0001866656B0 ModelPrimitiveType float float float Single
    public partial class ProduceTutorialSetMentalEvent
    {
        public TutorialExternalAccess?                  TutorialExternalAccess                  { get; set; }
        public float                                    MentalRate                              { get; set; }

        public static ProduceTutorialSetMentalEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialSetMentalEvent();

            value.TutorialExternalAccess                    = GetObject<TutorialExternalAccess>(new IntPtr(p + 0x010), ReversePrism.DataModels.TutorialExternalAccess.FromPointer); // 0270D5D4A708 0x10 TutorialExternalAccess      ( 0001866B98B0 ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer )
            value.MentalRate                                = GetSingle(new IntPtr(p + 0x018)); // 0270D5D4A728 0x18 MentalRate                  ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
