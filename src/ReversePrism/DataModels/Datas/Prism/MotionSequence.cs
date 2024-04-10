using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 postNameData                             string IL2CPP_TYPE_STRING
    // 000 postNameActSet                           string IL2CPP_TYPE_STRING
    // 000 CustomFaceActID                          string IL2CPP_TYPE_STRING
    // 000 dicSequence                              Dictionary`2<string, SequenceData> IL2CPP_TYPE_GENERICINST
    // 008 dicFaceAct                               Dictionary`2<string, FaceAct> IL2CPP_TYPE_GENERICINST
    public partial class MotionSequence : DataModel
    {

        public static MotionSequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MotionSequence() { Pointer= p0 };


            return value;
        }
    }
}
