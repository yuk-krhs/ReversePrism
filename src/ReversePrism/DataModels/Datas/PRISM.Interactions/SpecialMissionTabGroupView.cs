using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 SpecialMissionTabList                    000185D0B1D8 ModelClassListType List`1<SpecialMissionTab> List`1<SpecialMissionTab> List<SpecialMissionTab> Pointer
    // 040 TabPrefab                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 048 TabRoot                                  0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class SpecialMissionTabGroupView : DataModel
    {
        public List<SpecialMissionTab>?                 SpecialMissionTabList                   { get; set; }
        public GameObject?                              TabPrefab                               { get; set; }
        public Transform?                               TabRoot                                 { get; set; }

        public static SpecialMissionTabGroupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SpecialMissionTabGroupView() { Pointer= p0 };

            value.SpecialMissionTabList                     = GetObjectList<SpecialMissionTab>(new IntPtr(p + 0x038), ReversePrism.DataModels.SpecialMissionTab.FromPointer); // 02466BE020E0 0x38 SpecialMissionTabList       ( 000185D0B1D8 ModelClassListType List`1<SpecialMissionTab> List`1<SpecialMissionTab> List<SpecialMissionTab> Pointer )
            value.TabPrefab                                 = GetObject<GameObject>(new IntPtr(p + 0x040), ReversePrism.DataModels.GameObject.FromPointer); // 02466BE02100 0x40 TabPrefab                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TabRoot                                   = GetObject<Transform>(new IntPtr(p + 0x048), ReversePrism.DataModels.Transform.FromPointer); // 02466BE02120 0x48 TabRoot                     ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
