using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_references                             000185B988D0 ModelClassListType Object[] Object[] List<Object> Pointer
    // 028 DraggedReferenceSkin                     0001866F2E90 ModelClassType UISkin UISkin UISkin Pointer
    // 030 HoldTime                                 0001866656B0 ModelPrimitiveType float float float Single
    // 038 PointerHeldCoroutine                     00018675F880 ModelClassType IEnumerator IEnumerator IEnumerator Pointer
    public partial class DraggedReferenceSourceUI
    {
        public List<Object>?                            M_references                            { get; set; }
        public UISkin?                                  DraggedReferenceSkin                    { get; set; }
        public float                                    HoldTime                                { get; set; }
        public IEnumerator?                             PointerHeldCoroutine                    { get; set; }

        public static DraggedReferenceSourceUI? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DraggedReferenceSourceUI();

            value.M_references                              = GetObjectList<Object>(new IntPtr(p + 0x020), ReversePrism.DataModels.Object.FromPointer); // 0270DB1E97C8 0x20 M_references                ( 000185B988D0 ModelClassListType Object[] Object[] List<Object> Pointer )
            value.DraggedReferenceSkin                      = GetObject<UISkin>(new IntPtr(p + 0x028), ReversePrism.DataModels.UISkin.FromPointer); // 0270DB1E97E8 0x28 DraggedReferenceSkin        ( 0001866F2E90 ModelClassType UISkin UISkin UISkin Pointer )
            value.HoldTime                                  = GetSingle(new IntPtr(p + 0x030)); // 0270DB1E9808 0x30 HoldTime                    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.PointerHeldCoroutine                      = GetObject<IEnumerator>(new IntPtr(p + 0x038), ReversePrism.DataModels.IEnumerator.FromPointer); // 0270DB1E9828 0x38 PointerHeldCoroutine        ( 00018675F880 ModelClassType IEnumerator IEnumerator IEnumerator Pointer )

            return value;
        }
    }
}
