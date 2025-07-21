using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitTabGroup                             ModelClassType UnitTabGroupView UnitTabGroupView UnitTabGroupView Pointer
    // 028 IdolStatusView                           ModelClassType ProduceUnitEditIdolStatusView ProduceUnitEditIdolStatusView ProduceUnitEditIdolStatusView Pointer
    // 030 FooterView                               ModelClassType ProduceUnitEditFooterView ProduceUnitEditFooterView ProduceUnitEditFooterView Pointer
    // 038 PageAnimationTarget                      ModelClassListType List`1<CanvasGroup> List`1<CanvasGroup> List<CanvasGroup> Pointer
    // 040 PageAnimationHideTarget                  ModelClassListType List`1<CanvasGroup> List`1<CanvasGroup> List<CanvasGroup> Pointer
    // 048 PageAnimationDistance                    ModelPrimitiveType float float float Single
    // 04C PageAnimationTime                        ModelPrimitiveType float float float Single
    // 050 IsPageMove                               ModelPrimitiveType bool bool bool Bool
    // 058 onIdolTap                                Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 060 onPIdolDetail                            Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 068 onSCharaDetail                           Subject`1<int> IL2CPP_TYPE_GENERICINST
    public partial class ProduceUnitEditView : DataModel
    {
        public UnitTabGroupView?                        UnitTabGroup                            { get; set; }
        public ProduceUnitEditIdolStatusView?           IdolStatusView                          { get; set; }
        public ProduceUnitEditFooterView?               FooterView                              { get; set; }
        public List<CanvasGroup>?                       PageAnimationTarget                     { get; set; }
        public List<CanvasGroup>?                       PageAnimationHideTarget                 { get; set; }
        public float                                    PageAnimationDistance                   { get; set; }
        public float                                    PageAnimationTime                       { get; set; }
        public bool                                     IsPageMove                              { get; set; }

        public static ProduceUnitEditView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceUnitEditView() { Pointer= p0 };

            value.UnitTabGroup                              = GetObject<UnitTabGroupView>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnitTabGroupView.FromPointer); // 0x20 UnitTabGroup                ( ModelClassType UnitTabGroupView UnitTabGroupView UnitTabGroupView Pointer )
            value.IdolStatusView                            = GetObject<ProduceUnitEditIdolStatusView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceUnitEditIdolStatusView.FromPointer); // 0x28 IdolStatusView              ( ModelClassType ProduceUnitEditIdolStatusView ProduceUnitEditIdolStatusView ProduceUnitEditIdolStatusView Pointer )
            value.FooterView                                = GetObject<ProduceUnitEditFooterView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceUnitEditFooterView.FromPointer); // 0x30 FooterView                  ( ModelClassType ProduceUnitEditFooterView ProduceUnitEditFooterView ProduceUnitEditFooterView Pointer )
            value.PageAnimationTarget                       = GetObjectList<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x38 PageAnimationTarget         ( ModelClassListType List`1<CanvasGroup> List`1<CanvasGroup> List<CanvasGroup> Pointer )
            value.PageAnimationHideTarget                   = GetObjectList<CanvasGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x40 PageAnimationHideTarget     ( ModelClassListType List`1<CanvasGroup> List`1<CanvasGroup> List<CanvasGroup> Pointer )
            value.PageAnimationDistance                     = GetSingle(new IntPtr(p + 0x048)); // 0x48 PageAnimationDistance       ( ModelPrimitiveType float float float Single )
            value.PageAnimationTime                         = GetSingle(new IntPtr(p + 0x04C)); // 0x4C PageAnimationTime           ( ModelPrimitiveType float float float Single )
            value.IsPageMove                                = GetBool(new IntPtr(p + 0x050)); // 0x50 IsPageMove                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
