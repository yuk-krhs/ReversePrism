using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     ModelPrimitiveType string string string String
    // 018 Stime                                    ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 020 Etime                                    ModelPrimitiveType DateTime DateTime DateTime DateTime
    public partial class TimeSpan : DataModel
    {
        public string                                   Name                                    { get; set; }
        public DateTime                                 Stime                                   { get; set; }
        public DateTime                                 Etime                                   { get; set; }

        public static TimeSpan? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeSpan() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0x10 Name                        ( ModelPrimitiveType string string string String )
            value.Stime                                     = GetDateTime(new IntPtr(p + 0x018)); // 0x18 Stime                       ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.Etime                                     = GetDateTime(new IntPtr(p + 0x020)); // 0x20 Etime                       ( ModelPrimitiveType DateTime DateTime DateTime DateTime )

            return value;
        }
    }
}
