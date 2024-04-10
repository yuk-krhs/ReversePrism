using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ParameterVariationStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 BeforeValueFieldNumber                   int IL2CPP_TYPE_I4
    // 018 BeforeValue                              0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer
    // 000 AfterValueFieldNumber                    int IL2CPP_TYPE_I4
    // 020 AfterValue                               0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer
    // 000 BuildUpParameterFieldNumber              int IL2CPP_TYPE_I4
    // 028 BuildUpParameter                         00018650F070 ModelClassType BuildUpParameterStatus BuildUpParameterStatus BuildUpParameterStatus Pointer
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 030 MstIdolId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ParameterVariationStatus : DataModel
    {
        public ProduceParameterStatus?                  BeforeValue                             { get; set; }
        public ProduceParameterStatus?                  AfterValue                              { get; set; }
        public BuildUpParameterStatus?                  BuildUpParameter                        { get; set; }
        public int                                      MstIdolId                               { get; set; }

        public static ParameterVariationStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParameterVariationStatus() { Pointer= p0 };

            value.BeforeValue                               = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 02466107E730 0x18 BeforeValue                 ( 0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )
            value.AfterValue                                = GetObject<ProduceParameterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceParameterStatus.FromPointer); // 02466107E770 0x20 AfterValue                  ( 0001865627F0 ModelClassType ProduceParameterStatus ProduceParameterStatus ProduceParameterStatus Pointer )
            value.BuildUpParameter                          = GetObject<BuildUpParameterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.BuildUpParameterStatus.FromPointer); // 02466107E7B0 0x28 BuildUpParameter            ( 00018650F070 ModelClassType BuildUpParameterStatus BuildUpParameterStatus BuildUpParameterStatus Pointer )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x030)); // 02466107E7F0 0x30 MstIdolId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
