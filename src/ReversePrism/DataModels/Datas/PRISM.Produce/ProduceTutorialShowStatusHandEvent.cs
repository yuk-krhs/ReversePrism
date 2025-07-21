using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TutorialExternalAccess                   ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer
    // 018 getHandPosFanc                           Func`1<Vector3> IL2CPP_TYPE_GENERICINST
    // 020 MoveOffset                               ModelEnumType Vector2 Vector2 Vector2 Int32
    // 028 LocalOffset                              ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class ProduceTutorialShowStatusHandEvent : DataModel
    {
        public TutorialExternalAccess?                  TutorialExternalAccess                  { get; set; }
        public Vector2                                  MoveOffset                              { get; set; }
        public Vector2                                  LocalOffset                             { get; set; }

        public static ProduceTutorialShowStatusHandEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialShowStatusHandEvent() { Pointer= p0 };

            value.TutorialExternalAccess                    = GetObject<TutorialExternalAccess>(new IntPtr(p + 0x010), ReversePrism.DataModels.TutorialExternalAccess.FromPointer); // 0x10 TutorialExternalAccess      ( ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer )
            value.MoveOffset                                = (Vector2)GetInt32(new IntPtr(p + 0x020)); // 0x20 MoveOffset                  ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.LocalOffset                               = (Vector2)GetInt32(new IntPtr(p + 0x028)); // 0x28 LocalOffset                 ( ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
