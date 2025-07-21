using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceAdvOptionStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 OptionNumberFieldNumber                  int IL2CPP_TYPE_I4
    // 018 OptionNumber                             ModelPrimitiveType int int int Int32
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 01C MstIdolId                                ModelPrimitiveType int int int Int32
    // 000 BuildUpParameterValueFieldNumber         int IL2CPP_TYPE_I4
    // 020 BuildUpParameterValue                    ModelClassType BuildUpParameterValueStatus BuildUpParameterValueStatus BuildUpParameterValueStatus Pointer
    public partial class ProduceAdvOptionStatus : DataModel
    {
        public int                                      OptionNumber                            { get; set; }
        public int                                      MstIdolId                               { get; set; }
        public BuildUpParameterValueStatus?             BuildUpParameterValue                   { get; set; }

        public static ProduceAdvOptionStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAdvOptionStatus() { Pointer= p0 };

            value.OptionNumber                              = GetInt32(new IntPtr(p + 0x018)); // 0x18 OptionNumber                ( ModelPrimitiveType int int int Int32 )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstIdolId                   ( ModelPrimitiveType int int int Int32 )
            value.BuildUpParameterValue                     = GetObject<BuildUpParameterValueStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.BuildUpParameterValueStatus.FromPointer); // 0x20 BuildUpParameterValue       ( ModelClassType BuildUpParameterValueStatus BuildUpParameterValueStatus BuildUpParameterValueStatus Pointer )

            return value;
        }
    }
}
