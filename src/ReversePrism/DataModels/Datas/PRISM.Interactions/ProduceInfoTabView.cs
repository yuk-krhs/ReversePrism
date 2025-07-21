using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EpisodeNameAndDifficultyText             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 OneSchedulePolicyContentList             ModelClassListType List`1<OneSchedulePolicyContent> List`1<OneSchedulePolicyContent> List<OneSchedulePolicyContent> Pointer
    // 030 FesUnitIconView                          ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer
    // 038 InheritanceArea                          ModelClassType GameObject GameObject GameObject Pointer
    // 040 onLongPressInheritanceFesUnitIcon        Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ProduceInfoTabView : DataModel
    {
        public UITextMeshProUGUI?                       EpisodeNameAndDifficultyText            { get; set; }
        public List<OneSchedulePolicyContent>?          OneSchedulePolicyContentList            { get; set; }
        public FUnitIconView?                           FesUnitIconView                         { get; set; }
        public GameObject?                              InheritanceArea                         { get; set; }

        public static ProduceInfoTabView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceInfoTabView() { Pointer= p0 };

            value.EpisodeNameAndDifficultyText              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 EpisodeNameAndDifficultyText ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.OneSchedulePolicyContentList              = GetObjectList<OneSchedulePolicyContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.OneSchedulePolicyContent.FromPointer); // 0x28 OneSchedulePolicyContentList ( ModelClassListType List`1<OneSchedulePolicyContent> List`1<OneSchedulePolicyContent> List<OneSchedulePolicyContent> Pointer )
            value.FesUnitIconView                           = GetObject<FUnitIconView>(new IntPtr(p + 0x030), ReversePrism.DataModels.FUnitIconView.FromPointer); // 0x30 FesUnitIconView             ( ModelClassType FUnitIconView FUnitIconView FUnitIconView Pointer )
            value.InheritanceArea                           = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 InheritanceArea             ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
