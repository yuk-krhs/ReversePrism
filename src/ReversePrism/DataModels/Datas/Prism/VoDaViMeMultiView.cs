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

            value.AttributeUIParent                         = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 024664F561B8 0x20 AttributeUIParent           ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.AttributeUIs                              = GetObjectList<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 024664F561D8 0x28 AttributeUIs                ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )

            return value;
        }
    }
}
