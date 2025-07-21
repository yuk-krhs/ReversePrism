using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GoTemplatePrefabs                        ModelClassType GameObject GameObject GameObject Pointer
    // 028 ContentRoot                              ModelClassType Transform Transform Transform Pointer
    public partial class GashaMembersView : DataModel
    {
        public GameObject?                              GoTemplatePrefabs                       { get; set; }
        public Transform?                               ContentRoot                             { get; set; }

        public static GashaMembersView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaMembersView() { Pointer= p0 };

            value.GoTemplatePrefabs                         = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 GoTemplatePrefabs           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ContentRoot                               = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0x28 ContentRoot                 ( ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
