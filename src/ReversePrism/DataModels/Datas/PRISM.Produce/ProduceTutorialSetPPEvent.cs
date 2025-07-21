using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TutorialExternalAccess                   ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer
    // 018 Pp                                       ModelPrimitiveType int int int Int32
    public partial class ProduceTutorialSetPPEvent : DataModel
    {
        public TutorialExternalAccess?                  TutorialExternalAccess                  { get; set; }
        public int                                      Pp                                      { get; set; }

        public static ProduceTutorialSetPPEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialSetPPEvent() { Pointer= p0 };

            value.TutorialExternalAccess                    = GetObject<TutorialExternalAccess>(new IntPtr(p + 0x010), ReversePrism.DataModels.TutorialExternalAccess.FromPointer); // 0x10 TutorialExternalAccess      ( ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer )
            value.Pp                                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 Pp                          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
