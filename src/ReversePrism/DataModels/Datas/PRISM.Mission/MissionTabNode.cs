using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ObjNewBadge                              ModelClassType GameObject GameObject GameObject Pointer
    // 028 BadgeNumber                              ModelClassType BadgeNumber BadgeNumber BadgeNumber Pointer
    // 030 SelectedTextMissionGroupName             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 NormalTextMissionGroupName               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 MissionTabGroup                          ModelPrimitiveType int int int Int32
    // 044 IsEventTab                               ModelPrimitiveType bool bool bool Bool
    public partial class MissionTabNode : DataModel
    {
        public GameObject?                              ObjNewBadge                             { get; set; }
        public BadgeNumber?                             BadgeNumber                             { get; set; }
        public UITextMeshProUGUI?                       SelectedTextMissionGroupName            { get; set; }
        public UITextMeshProUGUI?                       NormalTextMissionGroupName              { get; set; }
        public int                                      MissionTabGroup                         { get; set; }
        public bool                                     IsEventTab                              { get; set; }

        public static MissionTabNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionTabNode() { Pointer= p0 };

            value.ObjNewBadge                               = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 ObjNewBadge                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.BadgeNumber                               = GetObject<BadgeNumber>(new IntPtr(p + 0x028), ReversePrism.DataModels.BadgeNumber.FromPointer); // 0x28 BadgeNumber                 ( ModelClassType BadgeNumber BadgeNumber BadgeNumber Pointer )
            value.SelectedTextMissionGroupName              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 SelectedTextMissionGroupName ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.NormalTextMissionGroupName                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 NormalTextMissionGroupName  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.MissionTabGroup                           = GetInt32(new IntPtr(p + 0x040)); // 0x40 MissionTabGroup             ( ModelPrimitiveType int int int Int32 )
            value.IsEventTab                                = GetBool(new IntPtr(p + 0x044)); // 0x44 IsEventTab                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
