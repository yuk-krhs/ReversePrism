using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TutorialExternalAccess                   0001866B98B0 ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer
    // 018 IsDisable                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ProduceTutorialDisableNPCEvent
    {
        public TutorialExternalAccess?                  TutorialExternalAccess                  { get; set; }
        public bool                                     IsDisable                               { get; set; }

        public static ProduceTutorialDisableNPCEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialDisableNPCEvent();

            value.TutorialExternalAccess                    = GetObject<TutorialExternalAccess>(new IntPtr(p + 0x010), ReversePrism.DataModels.TutorialExternalAccess.FromPointer); // 0270D5D4A408 0x10 TutorialExternalAccess      ( 0001866B98B0 ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer )
            value.IsDisable                                 = GetBool(new IntPtr(p + 0x018)); // 0270D5D4A428 0x18 IsDisable                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
