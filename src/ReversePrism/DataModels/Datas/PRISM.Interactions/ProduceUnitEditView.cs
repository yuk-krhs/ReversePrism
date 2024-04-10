using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 UnitTabGroup                             000186711840 ModelClassType UnitTabGroupView UnitTabGroupView UnitTabGroupView Pointer
    // 028 IdolStatusView                           0001865989D0 ModelClassType ProduceUnitEditIdolStatusView ProduceUnitEditIdolStatusView ProduceUnitEditIdolStatusView Pointer
    // 030 FooterView                               000186598270 ModelClassType ProduceUnitEditFooterView ProduceUnitEditFooterView ProduceUnitEditFooterView Pointer
    // 038 PageAnimationTarget                      000185CD1368 ModelClassListType List`1<CanvasGroup> List`1<CanvasGroup> List<CanvasGroup> Pointer
    // 040 PageAnimationHideTarget                  000185CD1368 ModelClassListType List`1<CanvasGroup> List`1<CanvasGroup> List<CanvasGroup> Pointer
    // 048 PageAnimationDistance                    0001866656B0 ModelPrimitiveType float float float Single
    // 04C PageAnimationTime                        0001866656B0 ModelPrimitiveType float float float Single
    // 050 IsPageMove                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 058 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 060 onIdolTap                                Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 068 onPIdolDetail                            Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 070 onSCharaDetail                           Subject`1<int> IL2CPP_TYPE_GENERICINST
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
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static ProduceUnitEditView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceUnitEditView() { Pointer= p0 };

            value.UnitTabGroup                              = GetObject<UnitTabGroupView>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnitTabGroupView.FromPointer); // 02466A3C4280 0x20 UnitTabGroup                ( 000186711840 ModelClassType UnitTabGroupView UnitTabGroupView UnitTabGroupView Pointer )
            value.IdolStatusView                            = GetObject<ProduceUnitEditIdolStatusView>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceUnitEditIdolStatusView.FromPointer); // 02466A3C42A0 0x28 IdolStatusView              ( 0001865989D0 ModelClassType ProduceUnitEditIdolStatusView ProduceUnitEditIdolStatusView ProduceUnitEditIdolStatusView Pointer )
            value.FooterView                                = GetObject<ProduceUnitEditFooterView>(new IntPtr(p + 0x030), ReversePrism.DataModels.ProduceUnitEditFooterView.FromPointer); // 02466A3C42C0 0x30 FooterView                  ( 000186598270 ModelClassType ProduceUnitEditFooterView ProduceUnitEditFooterView ProduceUnitEditFooterView Pointer )
            value.PageAnimationTarget                       = GetObjectList<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A3C42E0 0x38 PageAnimationTarget         ( 000185CD1368 ModelClassListType List`1<CanvasGroup> List`1<CanvasGroup> List<CanvasGroup> Pointer )
            value.PageAnimationHideTarget                   = GetObjectList<CanvasGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A3C4300 0x40 PageAnimationHideTarget     ( 000185CD1368 ModelClassListType List`1<CanvasGroup> List`1<CanvasGroup> List<CanvasGroup> Pointer )
            value.PageAnimationDistance                     = GetSingle(new IntPtr(p + 0x048)); // 02466A3C4320 0x48 PageAnimationDistance       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.PageAnimationTime                         = GetSingle(new IntPtr(p + 0x04C)); // 02466A3C4340 0x4C PageAnimationTime           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsPageMove                                = GetBool(new IntPtr(p + 0x050)); // 02466A3C4360 0x50 IsPageMove                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x058), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466A3C4380 0x58 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
