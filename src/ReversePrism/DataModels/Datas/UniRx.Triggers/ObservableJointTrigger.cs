using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 onJointBreak                             Subject`1<float> IL2CPP_TYPE_GENERICINST
    // 058 onJointBreak2D                           Subject`1<Joint2D> IL2CPP_TYPE_GENERICINST
    public partial class ObservableJointTrigger
    {

        public static ObservableJointTrigger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObservableJointTrigger();


            return value;
        }
    }
}
