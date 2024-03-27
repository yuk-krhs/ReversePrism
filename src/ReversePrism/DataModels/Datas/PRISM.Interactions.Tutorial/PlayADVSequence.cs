using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScenarioId                               000186671910 ModelPrimitiveType string string string String
    public partial class PlayADVSequence
    {
        public string                                   ScenarioId                              { get; set; }

        public static PlayADVSequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayADVSequence();

            value.ScenarioId                                = GetString(new IntPtr(p + 0x010)); // 0270DBC10658 0x10 ScenarioId                  ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
