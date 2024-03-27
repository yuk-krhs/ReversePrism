using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GoTemplatePrefabs                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 ContentRoot                              0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class GashaMembersView
    {
        public GameObject?                              GoTemplatePrefabs                       { get; set; }
        public Transform?                               ContentRoot                             { get; set; }

        public static GashaMembersView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaMembersView();

            value.GoTemplatePrefabs                         = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D530A728 0x20 GoTemplatePrefabs           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ContentRoot                               = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270D530A748 0x28 ContentRoot                 ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
