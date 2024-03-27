using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 ButtonBaseObject                         0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 040 TabButtonRoot                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 048 MissionTabNodeList                       000185CF3E68 ModelClassListType List`1<MissionTabNode> List`1<MissionTabNode> List<MissionTabNode> Pointer
    public partial class MissionTabButtonGroup
    {
        public GameObject?                              ButtonBaseObject                        { get; set; }
        public Transform?                               TabButtonRoot                           { get; set; }
        public List<MissionTabNode>?                    MissionTabNodeList                      { get; set; }

        public static MissionTabButtonGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionTabButtonGroup();

            value.ButtonBaseObject                          = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5589950 0x38 ButtonBaseObject            ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.TabButtonRoot                             = GetObject<Transform>(new IntPtr(p + 0x040), ReversePrism.DataModels.Transform.FromPointer); // 0270D5589970 0x40 TabButtonRoot               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.MissionTabNodeList                        = GetObjectList<MissionTabNode>(new IntPtr(p + 0x048), ReversePrism.DataModels.MissionTabNode.FromPointer); // 0270D5589990 0x48 MissionTabNodeList          ( 000185CF3E68 ModelClassListType List`1<MissionTabNode> List`1<MissionTabNode> List<MissionTabNode> Pointer )

            return value;
        }
    }
}
