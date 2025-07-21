using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 In                                       ModelClassType StreamReader StreamReader StreamReader Pointer
    // 018 NumCharRead                              ModelPrimitiveType int int int Int32
    public partial class StreamTokenReader : DataModel
    {
        public StreamReader?                            In                                      { get; set; }
        public int                                      NumCharRead                             { get; set; }

        public static StreamTokenReader? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StreamTokenReader() { Pointer= p0 };

            value.In                                        = GetObject<StreamReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.StreamReader.FromPointer); // 0x10 In                          ( ModelClassType StreamReader StreamReader StreamReader Pointer )
            value.NumCharRead                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 NumCharRead                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
