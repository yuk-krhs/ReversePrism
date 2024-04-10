using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TutorialExternalAccess                   0001866B98B0 ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer
    // 018 getHandPosFanc                           Func`1<Vector3> IL2CPP_TYPE_GENERICINST
    // 020 MoveOffset                               0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 028 LocalOffset                              0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class ProduceTutorialShowInfoHandEvent : DataModel
    {
        public TutorialExternalAccess?                  TutorialExternalAccess                  { get; set; }
        public Vector2                                  MoveOffset                              { get; set; }
        public Vector2                                  LocalOffset                             { get; set; }

        public static ProduceTutorialShowInfoHandEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceTutorialShowInfoHandEvent() { Pointer= p0 };

            value.TutorialExternalAccess                    = GetObject<TutorialExternalAccess>(new IntPtr(p + 0x010), ReversePrism.DataModels.TutorialExternalAccess.FromPointer); // 024664DAE808 0x10 TutorialExternalAccess      ( 0001866B98B0 ModelClassType TutorialExternalAccess TutorialExternalAccess TutorialExternalAccess Pointer )
            value.MoveOffset                                = (Vector2)GetInt32(new IntPtr(p + 0x020)); // 024664DAE848 0x20 MoveOffset                  ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.LocalOffset                               = (Vector2)GetInt32(new IntPtr(p + 0x028)); // 024664DAE868 0x28 LocalOffset                 ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
