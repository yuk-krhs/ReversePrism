using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GashaStepStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 StepNoFieldNumber                        int IL2CPP_TYPE_I4
    // 018 StepNo                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 GashaPriceFieldNumber                    int IL2CPP_TYPE_I4
    // 020 GashaPrice                               00018660C790 ModelClassType GashaPriceStatus GashaPriceStatus GashaPriceStatus Pointer
    // 000 StateFieldNumber                         int IL2CPP_TYPE_I4
    // 028 State                                    00018661EEF0 ModelEnumType GashaStepState GashaStepState GashaStepState Int32
    // 000 ResourceIdFieldNumber                    int IL2CPP_TYPE_I4
    // 030 ResourceId                               000186671910 ModelPrimitiveType string string string String
    public partial class GashaStepStatus : DataModel
    {
        public int                                      StepNo                                  { get; set; }
        public GashaPriceStatus?                        GashaPrice                              { get; set; }
        public GashaStepState                           State                                   { get; set; }
        public string                                   ResourceId                              { get; set; }

        public static GashaStepStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaStepStatus() { Pointer= p0 };

            value.StepNo                                    = GetInt32(new IntPtr(p + 0x018)); // 0246615485E0 0x18 StepNo                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GashaPrice                                = GetObject<GashaPriceStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.GashaPriceStatus.FromPointer); // 024661548620 0x20 GashaPrice                  ( 00018660C790 ModelClassType GashaPriceStatus GashaPriceStatus GashaPriceStatus Pointer )
            value.State                                     = (GashaStepState)GetInt32(new IntPtr(p + 0x028)); // 024661548660 0x28 State                       ( 00018661EEF0 ModelEnumType GashaStepState GashaStepState GashaStepState Int32 )
            value.ResourceId                                = GetString(new IntPtr(p + 0x030)); // 0246615486A0 0x30 ResourceId                  ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
