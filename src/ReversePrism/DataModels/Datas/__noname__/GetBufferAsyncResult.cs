using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 070 Writer                                   0001865CBC80 ModelClassType XmlStreamNodeWriter XmlStreamNodeWriter XmlStreamNodeWriter Pointer
    // 078 Offset                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 07C Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 onComplete                               AsyncCompletion IL2CPP_TYPE_CLASS
    public partial class GetBufferAsyncResult
    {
        public XmlStreamNodeWriter?                     Writer                                  { get; set; }
        public int                                      Offset                                  { get; set; }
        public int                                      Count                                   { get; set; }

        public static GetBufferAsyncResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetBufferAsyncResult();

            value.Writer                                    = GetObject<XmlStreamNodeWriter>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlStreamNodeWriter.FromPointer); // 0270D7CB1998 0x70 Writer                      ( 0001865CBC80 ModelClassType XmlStreamNodeWriter XmlStreamNodeWriter XmlStreamNodeWriter Pointer )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x078)); // 0270D7CB19B8 0x78 Offset                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x07C)); // 0270D7CB19D8 0x7C Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
