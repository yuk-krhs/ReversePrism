using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Uri                                      000186671910 ModelPrimitiveType string string string String
    public partial class CADMethodCallMessage : DataModel
    {
        public string                                   Uri                                     { get; set; }

        public static CADMethodCallMessage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CADMethodCallMessage() { Pointer= p0 };

            value.Uri                                       = GetString(new IntPtr(p + 0x038)); // 024666AC4858 0x38 Uri                         ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
