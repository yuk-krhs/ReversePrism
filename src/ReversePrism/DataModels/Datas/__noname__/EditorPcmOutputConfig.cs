using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enable                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 BufferLength                             0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class EditorPcmOutputConfig
    {
        public bool                                     Enable                                  { get; set; }
        public int                                      BufferLength                            { get; set; }

        public static EditorPcmOutputConfig? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EditorPcmOutputConfig();

            value.Enable                                    = GetBool(new IntPtr(p + 0x010)); // 0270D1174BA0 0x10 Enable                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.BufferLength                              = GetInt32(new IntPtr(p + 0x014)); // 0270D1174BC0 0x14 BufferLength                ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
