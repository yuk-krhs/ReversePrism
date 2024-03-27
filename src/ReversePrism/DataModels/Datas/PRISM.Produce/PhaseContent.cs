using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GameObjects                              000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    public partial class PhaseContent
    {
        public List<GameObject>?                        GameObjects                             { get; set; }

        public static PhaseContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PhaseContent();

            value.GameObjects                               = GetObjectList<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5BCD7A0 0x20 GameObjects                 ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )

            return value;
        }
    }
}
