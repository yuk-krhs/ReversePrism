using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TutorialExternalAccess                   ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer
    // 018 IsNotMaxAppeal                           ModelPrimitiveType bool bool bool Bool
    public partial class ProduceTutorialNotMaxAppealEvent : DataModel
    {
        public TutorialExternalAccess?                  TutorialExternalAccess                  { get; set; }
        public bool                                     IsNotMaxAppeal                          { get; set; }

        public static ProduceTutorialNotMaxAppealEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialNotMaxAppealEvent() { Pointer= p0 };

            value.TutorialExternalAccess                    = GetObject<TutorialExternalAccess>(new IntPtr(p + 0x010), ReversePrism.DataModels.TutorialExternalAccess.FromPointer); // 0x10 TutorialExternalAccess      ( ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer )
            value.IsNotMaxAppeal                            = GetBool(new IntPtr(p + 0x018)); // 0x18 IsNotMaxAppeal              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
