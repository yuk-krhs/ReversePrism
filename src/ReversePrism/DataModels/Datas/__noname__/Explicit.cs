using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Explicit> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 BoundsFieldNumber                        int IL2CPP_TYPE_I4
    // 008 _repeated_bounds_codec                   FieldCodec`1<double> IL2CPP_TYPE_GENERICINST
    // 018 Bounds                                   ModelPrimitiveListType RepeatedField`1<double> RepeatedField`1<double> List<double> Pointer
    public partial class Explicit : DataModel
    {
        public List<double>?                            Bounds                                  { get; set; }

        public static Explicit? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Explicit() { Pointer= p0 };

            value.Bounds                                    = GetDoubleList(new IntPtr(p + 0x018)); // 0x18 Bounds                      ( ModelPrimitiveListType RepeatedField`1<double> RepeatedField`1<double> List<double> Pointer )

            return value;
        }
    }
}
