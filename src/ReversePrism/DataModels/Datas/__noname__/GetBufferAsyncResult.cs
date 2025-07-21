using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 070 Writer                                   ModelClassType XmlStreamNodeWriter XmlStreamNodeWriter XmlStreamNodeWriter Pointer
    // 078 Offset                                   ModelPrimitiveType int int int Int32
    // 07C Count                                    ModelPrimitiveType int int int Int32
    // 000 onComplete                               AsyncCompletion IL2CPP_TYPE_CLASS
    public partial class GetBufferAsyncResult : DataModel
    {
        public XmlStreamNodeWriter?                     Writer                                  { get; set; }
        public int                                      Offset                                  { get; set; }
        public int                                      Count                                   { get; set; }

        public static GetBufferAsyncResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetBufferAsyncResult() { Pointer= p0 };

            value.Writer                                    = GetObject<XmlStreamNodeWriter>(new IntPtr(p + 0x070), ReversePrism.DataModels.XmlStreamNodeWriter.FromPointer); // 0x70 Writer                      ( ModelClassType XmlStreamNodeWriter XmlStreamNodeWriter XmlStreamNodeWriter Pointer )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x078)); // 0x78 Offset                      ( ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x07C)); // 0x7C Count                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
