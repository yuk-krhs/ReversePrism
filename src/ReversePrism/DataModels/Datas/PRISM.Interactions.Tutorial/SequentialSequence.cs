using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SubSequences                             ModelClassListType ITutorialSequence[] ITutorialSequence[] List<ITutorialSequence> Pointer
    public partial class SequentialSequence : DataModel
    {
        public List<ITutorialSequence>?                 SubSequences                            { get; set; }

        public static SequentialSequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SequentialSequence() { Pointer= p0 };

            value.SubSequences                              = GetObjectList<ITutorialSequence>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITutorialSequence.FromPointer); // 0x10 SubSequences                ( ModelClassListType ITutorialSequence[] ITutorialSequence[] List<ITutorialSequence> Pointer )

            return value;
        }
    }
}
