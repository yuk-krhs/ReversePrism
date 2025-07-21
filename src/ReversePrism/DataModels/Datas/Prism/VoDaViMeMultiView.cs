using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AttributeUIParent                        ModelClassType GameObject GameObject GameObject Pointer
    // 028 AttributeUIs                             ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    public partial class VoDaViMeMultiView : DataModel
    {
        public GameObject?                              AttributeUIParent                       { get; set; }
        public List<GameObject>?                        AttributeUIs                            { get; set; }

        public static VoDaViMeMultiView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VoDaViMeMultiView() { Pointer= p0 };

            value.AttributeUIParent                         = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 AttributeUIParent           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.AttributeUIs                              = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 AttributeUIs                ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )

            return value;
        }
    }
}
