using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceEntrustStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 AppealTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 018 AppealType                               000186562FD0 ModelEnumType ProduceParameterType ProduceParameterType ProduceParameterType Int32
    // 000 ScoreFieldNumber                         int IL2CPP_TYPE_I4
    // 01C Score                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ProduceEntrustStatus : DataModel
    {
        public ProduceParameterType                     AppealType                              { get; set; }
        public int                                      Score                                   { get; set; }

        public static ProduceEntrustStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceEntrustStatus() { Pointer= p0 };

            value.AppealType                                = (ProduceParameterType)GetInt32(new IntPtr(p + 0x018)); // 02466139E840 0x18 AppealType                  ( 000186562FD0 ModelEnumType ProduceParameterType ProduceParameterType ProduceParameterType Int32 )
            value.Score                                     = GetInt32(new IntPtr(p + 0x01C)); // 02466139E880 0x1C Score                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
