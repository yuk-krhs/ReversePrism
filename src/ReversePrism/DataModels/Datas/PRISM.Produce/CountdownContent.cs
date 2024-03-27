using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 StartUIs                                 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer
    // 028 CountdownAnimator                        0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer
    // 030 AnimatorHashID                           0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class CountdownContent
    {
        public List<GameObject>?                        StartUIs                                { get; set; }
        public AnimatorWithEvent?                       CountdownAnimator                       { get; set; }
        public int                                      AnimatorHashID                          { get; set; }

        public static CountdownContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CountdownContent();

            value.StartUIs                                  = GetObjectList<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5B023E0 0x20 StartUIs                    ( 000185B81520 ModelClassListType GameObject[] GameObject[] List<GameObject> Pointer )
            value.CountdownAnimator                         = GetObject<AnimatorWithEvent>(new IntPtr(p + 0x028), ReversePrism.DataModels.AnimatorWithEvent.FromPointer); // 0270D5B02400 0x28 CountdownAnimator           ( 0001866BBE80 ModelClassType AnimatorWithEvent AnimatorWithEvent AnimatorWithEvent Pointer )
            value.AnimatorHashID                            = GetInt32(new IntPtr(p + 0x030)); // 0270D5B02420 0x30 AnimatorHashID              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
