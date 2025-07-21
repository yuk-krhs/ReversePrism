using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TutorialExternalAccess                   ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer
    // 018 IsCansel                                 ModelPrimitiveType bool bool bool Bool
    // 000 targetMilliSec                           int IL2CPP_TYPE_I4
    // 000 sycleSecMilliSec                         int IL2CPP_TYPE_I4
    public partial class ProduceTutorialShowFadeEvent : DataModel
    {
        public TutorialExternalAccess?                  TutorialExternalAccess                  { get; set; }
        public bool                                     IsCansel                                { get; set; }

        public static ProduceTutorialShowFadeEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialShowFadeEvent() { Pointer= p0 };

            value.TutorialExternalAccess                    = GetObject<TutorialExternalAccess>(new IntPtr(p + 0x010), ReversePrism.DataModels.TutorialExternalAccess.FromPointer); // 0x10 TutorialExternalAccess      ( ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer )
            value.IsCansel                                  = GetBool(new IntPtr(p + 0x018)); // 0x18 IsCansel                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
