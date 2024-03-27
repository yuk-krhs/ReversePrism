using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TutorialExternalAccess                   0001866B98B0 ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer
    // 018 IsNotMaxAppeal                           000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ProduceTutorialNotMaxAppealEvent
    {
        public TutorialExternalAccess?                  TutorialExternalAccess                  { get; set; }
        public bool                                     IsNotMaxAppeal                          { get; set; }

        public static ProduceTutorialNotMaxAppealEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialNotMaxAppealEvent();

            value.TutorialExternalAccess                    = GetObject<TutorialExternalAccess>(new IntPtr(p + 0x010), ReversePrism.DataModels.TutorialExternalAccess.FromPointer); // 0270D5D4A588 0x10 TutorialExternalAccess      ( 0001866B98B0 ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer )
            value.IsNotMaxAppeal                            = GetBool(new IntPtr(p + 0x018)); // 0270D5D4A5A8 0x18 IsNotMaxAppeal              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
