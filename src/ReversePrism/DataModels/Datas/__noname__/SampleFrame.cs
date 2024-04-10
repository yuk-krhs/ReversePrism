using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 parent                                   SampleFrameObservable`1<<var>> IL2CPP_TYPE_GENERICINST
    // 000 gate                                     <object> IL2CPP_TYPE_OBJECT
    // 000 latestValue                              <var> IL2CPP_TYPE_VAR
    // 000 isUpdated                                bool IL2CPP_TYPE_BOOLEAN
    // 000 isCompleted                              bool IL2CPP_TYPE_BOOLEAN
    // 000 sourceSubscription                       SingleAssignmentDisposable IL2CPP_TYPE_CLASS
    public partial class SampleFrame : DataModel
    {

        public static SampleFrame? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SampleFrame() { Pointer= p0 };


            return value;
        }
    }
}
