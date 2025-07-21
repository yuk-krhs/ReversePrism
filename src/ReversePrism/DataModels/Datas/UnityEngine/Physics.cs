using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ContactModifyEvent                       Action`2<PhysicsScene, NativeArray`1<ModifiableContactPair>> IL2CPP_TYPE_GENERICINST
    // 008 ContactModifyEventCCD                    Action`2<PhysicsScene, NativeArray`1<ModifiableContactPair>> IL2CPP_TYPE_GENERICINST
    // 010 ContactEvent                             ModelClassType ContactEventDelegate ContactEventDelegate ContactEventDelegate Pointer
    // 018 S_ReusableCollision                      ModelClassType Collision Collision Collision Pointer
    public partial class Physics : DataModel
    {
        public ContactEventDelegate?                    ContactEvent                            { get; set; }
        public Collision?                               S_ReusableCollision                     { get; set; }

        public static Physics? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Physics() { Pointer= p0 };

            value.ContactEvent                              = GetObject<ContactEventDelegate>(new IntPtr(p + 0x010), ReversePrism.DataModels.ContactEventDelegate.FromPointer); // 0x10 ContactEvent                ( ModelClassType ContactEventDelegate ContactEventDelegate ContactEventDelegate Pointer )
            value.S_ReusableCollision                       = GetObject<Collision>(new IntPtr(p + 0x018), ReversePrism.DataModels.Collision.FromPointer); // 0x18 S_ReusableCollision         ( ModelClassType Collision Collision Collision Pointer )

            return value;
        }
    }
}
