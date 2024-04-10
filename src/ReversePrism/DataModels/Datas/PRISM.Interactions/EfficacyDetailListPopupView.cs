using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 EfficacyDetailParent                     0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 028 CopyBaseEfficacyDetailObject             000186721850 ModelClassType EfficacyDetailContent EfficacyDetailContent EfficacyDetailContent Pointer
    // 030 EfficacyDetailList                       000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer
    // 038 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
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

            value.EfficacyDetailParent                      = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 02466B5F6400 0x20 EfficacyDetailParent        ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.CopyBaseEfficacyDetailObject              = GetObject<EfficacyDetailContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.EfficacyDetailContent.FromPointer); // 02466B5F6420 0x28 CopyBaseEfficacyDetailObject ( 000186721850 ModelClassType EfficacyDetailContent EfficacyDetailContent EfficacyDetailContent Pointer )
            value.EfficacyDetailList                        = GetObjectList<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 02466B5F6440 0x30 EfficacyDetailList          ( 000185CDD468 ModelClassListType List`1<GameObject> List`1<GameObject> List<GameObject> Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x040), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466B5F6480 0x40 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
