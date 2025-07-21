using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceAdvIDStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TypeFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Type                                     ModelEnumType ProduceAdvType ProduceAdvType ProduceAdvType Int32
    // 000 IdFieldNumber                            int IL2CPP_TYPE_I4
    // 01C Id                                       ModelPrimitiveType int int int Int32
    public partial class ProduceAdvIDStatus : DataModel
    {
        public ProduceAdvType                           Type                                    { get; set; }
        public int                                      Id                                      { get; set; }

        public static ProduceAdvIDStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAdvIDStatus() { Pointer= p0 };

            value.Type                                      = (ProduceAdvType)GetInt32(new IntPtr(p + 0x018)); // 0x18 Type                        ( ModelEnumType ProduceAdvType ProduceAdvType ProduceAdvType Int32 )
            value.Id                                        = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Id                          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
