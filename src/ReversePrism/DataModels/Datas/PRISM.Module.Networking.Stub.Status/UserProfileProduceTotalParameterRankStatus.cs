using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<UserProfileProduceTotalParameterRankStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceParameterRankFieldNumber          int IL2CPP_TYPE_I4
    // 018 ProduceParameterRank                     000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 000 TotalFieldNumber                         int IL2CPP_TYPE_I4
    // 01C Total                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class UserProfileProduceTotalParameterRankStatus : DataModel
    {
        public ProduceParameterRank                     ProduceParameterRank                    { get; set; }
        public int                                      Total                                   { get; set; }

        public static UserProfileProduceTotalParameterRankStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UserProfileProduceTotalParameterRankStatus() { Pointer= p0 };

            value.ProduceParameterRank                      = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x018)); // 024662695858 0x18 ProduceParameterRank        ( 000186562070 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.Total                                     = GetInt32(new IntPtr(p + 0x01C)); // 024662695898 0x1C Total                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
