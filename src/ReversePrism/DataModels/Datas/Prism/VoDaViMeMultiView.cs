using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 AttributeUIParent                        0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 028 AttributeUIs                             000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    public partial class VoDaViMeMultiView
    {
        public GameObject?                              AttributeUIParent                       { get; set; }
        public List<GameObject>?                        AttributeUIs                            { get; set; }

        public static VoDaViMeMultiView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VoDaViMeMultiView();

            value.AttributeUIParent                         = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4EF0620 0x20 AttributeUIParent           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.AttributeUIs                              = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0270D4EF0640 0x28 AttributeUIs                ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )

            return value;
        }
    }
}
