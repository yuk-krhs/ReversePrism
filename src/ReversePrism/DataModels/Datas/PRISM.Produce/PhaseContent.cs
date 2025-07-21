using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 GameObjects                              ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    public partial class PhaseContent : DataModel
    {
        public List<GameObject>?                        GameObjects                             { get; set; }

        public static PhaseContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PhaseContent() { Pointer= p0 };

            value.GameObjects                               = GetObjectList<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 GameObjects                 ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )

            return value;
        }
    }
}
