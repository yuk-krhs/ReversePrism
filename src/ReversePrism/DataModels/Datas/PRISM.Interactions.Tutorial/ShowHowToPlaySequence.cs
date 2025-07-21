using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ConfigRef                                ModelPrimitiveType string string string String
    public partial class ShowHowToPlaySequence : DataModel
    {
        public string                                   ConfigRef                               { get; set; }

        public static ShowHowToPlaySequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShowHowToPlaySequence() { Pointer= p0 };

            value.ConfigRef                                 = GetString(new IntPtr(p + 0x010)); // 0x10 ConfigRef                   ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
