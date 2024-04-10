using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Index                                    0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class CADArgHolder : DataModel
    {
        public int                                      Index                                   { get; set; }

        public static CADArgHolder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CADArgHolder() { Pointer= p0 };

            value.Index                                     = GetInt32(new IntPtr(p + 0x010)); // 024666C60AF8 0x10 Index                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
