using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 ButtonBaseObject                         ModelClassType GameObject GameObject GameObject Pointer
    // 040 TabButtonRoot                            ModelClassType Transform Transform Transform Pointer
    // 048 MissionTabNodeList                       ModelClassListType List`1<MissionTabNode> List`1<MissionTabNode> List<MissionTabNode> Pointer
    public partial class MissionTabButtonGroup : DataModel
    {
        public GameObject?                              ButtonBaseObject                        { get; set; }
        public Transform?                               TabButtonRoot                           { get; set; }
        public List<MissionTabNode>?                    MissionTabNodeList                      { get; set; }

        public static MissionTabButtonGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionTabButtonGroup() { Pointer= p0 };

            value.ButtonBaseObject                          = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 ButtonBaseObject            ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TabButtonRoot                             = GetObject<Transform>(new IntPtr(p + 0x040), ReversePrism.DataModels.Transform.FromPointer); // 0x40 TabButtonRoot               ( ModelClassType Transform Transform Transform Pointer )
            value.MissionTabNodeList                        = GetObjectList<MissionTabNode>(new IntPtr(p + 0x048), ReversePrism.DataModels.MissionTabNode.FromPointer); // 0x48 MissionTabNodeList          ( ModelClassListType List`1<MissionTabNode> List`1<MissionTabNode> List<MissionTabNode> Pointer )

            return value;
        }
    }
}
