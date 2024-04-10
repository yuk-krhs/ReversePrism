using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ListMesh                                 000185B81700 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 018 ListSwayString                           000185CA8888 ModelClassListType SwayString[] SwayString[] List<SwayString> Pointer
    public partial class SwitchUnitData : DataModel
    {
        public List<GameObject>?                        ListMesh                                { get; set; }
        public List<SwayString>?                        ListSwayString                          { get; set; }

        public static SwitchUnitData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchUnitData() { Pointer= p0 };

            value.ListMesh                                  = GetObjectList<GameObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.GameObject.FromPointer); // 0245A69E5828 0x10 ListMesh                    ( 000185B81700 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.ListSwayString                            = GetObjectList<SwayString>(new IntPtr(p + 0x018), ReversePrism.DataModels.SwayString.FromPointer); // 0245A69E5848 0x18 ListSwayString              ( 000185CA8888 ModelClassListType SwayString[] SwayString[] List<SwayString> Pointer )

            return value;
        }
    }
}
