using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CyalumeBaseObject                        ModelClassType GameObject GameObject GameObject Pointer
    // 018 CyalumeSubObjects                        ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    public partial class QuadData : DataModel
    {
        public GameObject?                              CyalumeBaseObject                       { get; set; }
        public List<GameObject>?                        CyalumeSubObjects                       { get; set; }

        public static QuadData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QuadData() { Pointer= p0 };

            value.CyalumeBaseObject                         = GetObject<GameObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.GameObject.FromPointer); // 0x10 CyalumeBaseObject           ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CyalumeSubObjects                         = GetObjectList<GameObject>(new IntPtr(p + 0x018), ReversePrism.DataModels.GameObject.FromPointer); // 0x18 CyalumeSubObjects           ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )

            return value;
        }
    }
}
