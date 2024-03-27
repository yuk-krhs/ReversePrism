using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SkipSequence                             0001866807A0 ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer
    public partial class StartWholeTutorialSequence
    {
        public ITutorialSequence?                       SkipSequence                            { get; set; }

        public static StartWholeTutorialSequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StartWholeTutorialSequence();

            value.SkipSequence                              = GetObject<ITutorialSequence>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITutorialSequence.FromPointer); // 0270DB646658 0x10 SkipSequence                ( 0001866807A0 ModelClassType ITutorialSequence ITutorialSequence ITutorialSequence Pointer )

            return value;
        }
    }
}
