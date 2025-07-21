using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_HitBuffer                              RaycastHit[] IL2CPP_TYPE_SZARRAY
    // 008 s_PenetrationIndexBuffer                 int[] IL2CPP_TYPE_SZARRAY
    // 010 S_ScratchCollider                        ModelClassType SphereCollider SphereCollider SphereCollider Pointer
    // 018 S_ScratchColliderGameObject              ModelClassType GameObject GameObject GameObject Pointer
    public partial class RuntimeUtility : DataModel
    {
        public SphereCollider?                          S_ScratchCollider                       { get; set; }
        public GameObject?                              S_ScratchColliderGameObject             { get; set; }

        public static RuntimeUtility? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeUtility() { Pointer= p0 };

            value.S_ScratchCollider                         = GetObject<SphereCollider>(new IntPtr(p + 0x010), ReversePrism.DataModels.SphereCollider.FromPointer); // 0x10 S_ScratchCollider           ( ModelClassType SphereCollider SphereCollider SphereCollider Pointer )
            value.S_ScratchColliderGameObject               = GetObject<GameObject>(new IntPtr(p + 0x018), ReversePrism.DataModels.GameObject.FromPointer); // 0x18 S_ScratchColliderGameObject ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
