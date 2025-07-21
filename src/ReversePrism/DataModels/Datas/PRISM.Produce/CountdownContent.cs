using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StartUIs                                 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 028 CountdownAnimator                        ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 030 AnimatorHashID                           ModelPrimitiveType int int int Int32
    public partial class CountdownContent : DataModel
    {
        public List<GameObject>?                        StartUIs                                { get; set; }
        public AnimatorWithEvent?                       CountdownAnimator                       { get; set; }
        public int                                      AnimatorHashID                          { get; set; }

        public static CountdownContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CountdownContent() { Pointer= p0 };

            value.StartUIs                                  = GetObjectList<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 StartUIs                    ( ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.CountdownAnimator                         = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x028), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0x28 CountdownAnimator           ( ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.AnimatorHashID                            = GetInt32(new IntPtr(p + 0x030)); // 0x30 AnimatorHashID              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
