using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SkipSequence                             ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer
    public partial class StartWholeTutorialSequence : DataModel
    {
        public ITutorialSequence?                       SkipSequence                            { get; set; }

        public static StartWholeTutorialSequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartWholeTutorialSequence() { Pointer= p0 };

            value.SkipSequence                              = GetObject<ITutorialSequence>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITutorialSequence.FromPointer); // 0x10 SkipSequence                ( ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer )

            return value;
        }
    }
}
