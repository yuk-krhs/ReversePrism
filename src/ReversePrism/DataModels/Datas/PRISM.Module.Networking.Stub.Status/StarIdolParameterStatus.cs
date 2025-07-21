using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<StarIdolParameterStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StarFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Star                                     ModelPrimitiveType int int int Int32
    // 000 IdolParameterFieldNumber                 int IL2CPP_TYPE_I4
    // 020 IdolParameter                            ModelClassType IdolParameterStatus IdolParameterStatus IdolParameterStatus Pointer
    public partial class StarIdolParameterStatus : DataModel
    {
        public int                                      Star                                    { get; set; }
        public IdolParameterStatus?                     IdolParameter                           { get; set; }

        public static StarIdolParameterStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StarIdolParameterStatus() { Pointer= p0 };

            value.Star                                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 Star                        ( ModelPrimitiveType int int int Int32 )
            value.IdolParameter                             = GetObject<IdolParameterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolParameterStatus.FromPointer); // 0x20 IdolParameter               ( ModelClassType IdolParameterStatus IdolParameterStatus IdolParameterStatus Pointer )

            return value;
        }
    }
}
