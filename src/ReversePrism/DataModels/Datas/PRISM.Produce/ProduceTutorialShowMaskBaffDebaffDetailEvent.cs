using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TutorialExternalAccess                   0001866B98B0 ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer
    // 018 getMaskPosFanc                           Func`1<Vector3> IL2CPP_TYPE_GENERICINST
    // 020 getMaskSizeFanc                          Func`1<Vector2> IL2CPP_TYPE_GENERICINST
    // 028 LocalOffset                              0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class ProduceTutorialShowMaskBaffDebaffDetailEvent
    {
        public TutorialExternalAccess?                  TutorialExternalAccess                  { get; set; }
        public Vector2                                  LocalOffset                             { get; set; }

        public static ProduceTutorialShowMaskBaffDebaffDetailEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialShowMaskBaffDebaffDetailEvent();

            value.TutorialExternalAccess                    = GetObject<TutorialExternalAccess>(new IntPtr(p + 0x010), ReversePrism.DataModels.TutorialExternalAccess.FromPointer); // 0270D5D3F850 0x10 TutorialExternalAccess      ( 0001866B98B0 ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer )
            value.LocalOffset                               = (Vector2)GetInt32(new IntPtr(p + 0x028)); // 0270D5D3F8B0 0x28 LocalOffset                 ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
