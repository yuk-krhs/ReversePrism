using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TutorialExternalAccess                   ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer
    // 018 getMaskPosFanc                           Func`1<Vector2> IL2CPP_TYPE_GENERICINST
    // 020 getMaskSizeFanc                          Func`1<Vector2> IL2CPP_TYPE_GENERICINST
    // 028 AnchorMin                                ModelEnumType Vector2 Vector2 Vector2 Int32
    // 030 AnchorMax                                ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class ProduceTutorialShowMaskEvent : DataModel
    {
        public TutorialExternalAccess?                  TutorialExternalAccess                  { get; set; }
        public Vector2                                  AnchorMin                               { get; set; }
        public Vector2                                  AnchorMax                               { get; set; }

        public static ProduceTutorialShowMaskEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialShowMaskEvent() { Pointer= p0 };

            value.TutorialExternalAccess                    = GetObject<TutorialExternalAccess>(new IntPtr(p + 0x010), ReversePrism.DataModels.TutorialExternalAccess.FromPointer); // 0x10 TutorialExternalAccess      ( ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer )
            value.AnchorMin                                 = (Vector2)GetInt32(new IntPtr(p + 0x028)); // 0x28 AnchorMin                   ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.AnchorMax                                 = (Vector2)GetInt32(new IntPtr(p + 0x030)); // 0x30 AnchorMax                   ( ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
