using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Mobile                                   string IL2CPP_TYPE_STRING
    // 008 Touch                                    string IL2CPP_TYPE_STRING
    // 010 Canvas                                   ModelPrimitiveType string string string String
    public partial class Types : DataModel
    {
        public string                                   Canvas                                  { get; set; }

        public static Types? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Types() { Pointer= p0 };

            value.Canvas                                    = GetString(new IntPtr(p + 0x010)); // 0x10 Canvas                      ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
