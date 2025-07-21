using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EfficacyDetailParent                     ModelClassType Transform Transform Transform Pointer
    // 028 CopyBaseEfficacyDetailObject             ModelClassType EfficacyDetailContent EfficacyDetailContent EfficacyDetailContent Pointer
    // 030 EfficacyDetailList                       ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 038 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class EfficacyDetailListPopupView : DataModel
    {
        public Transform?                               EfficacyDetailParent                    { get; set; }
        public EfficacyDetailContent?                   CopyBaseEfficacyDetailObject            { get; set; }
        public List<GameObject>?                        EfficacyDetailList                      { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static EfficacyDetailListPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EfficacyDetailListPopupView() { Pointer= p0 };

            value.EfficacyDetailParent                      = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0x20 EfficacyDetailParent        ( ModelClassType Transform Transform Transform Pointer )
            value.CopyBaseEfficacyDetailObject              = GetObject<EfficacyDetailContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.EfficacyDetailContent.FromPointer); // 0x28 CopyBaseEfficacyDetailObject ( ModelClassType EfficacyDetailContent EfficacyDetailContent EfficacyDetailContent Pointer )
            value.EfficacyDetailList                        = GetObjectList<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 EfficacyDetailList          ( ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x40 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
