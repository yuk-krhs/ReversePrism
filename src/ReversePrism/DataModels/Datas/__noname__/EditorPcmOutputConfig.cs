using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enable                                   ModelPrimitiveType bool bool bool Bool
    // 014 BufferLength                             ModelPrimitiveType int int int Int32
    public partial class EditorPcmOutputConfig : DataModel
    {
        public bool                                     Enable                                  { get; set; }
        public int                                      BufferLength                            { get; set; }

        public static EditorPcmOutputConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EditorPcmOutputConfig() { Pointer= p0 };

            value.Enable                                    = GetBool(new IntPtr(p + 0x010)); // 0x10 Enable                      ( ModelPrimitiveType bool bool bool Bool )
            value.BufferLength                              = GetInt32(new IntPtr(p + 0x014)); // 0x14 BufferLength                ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
