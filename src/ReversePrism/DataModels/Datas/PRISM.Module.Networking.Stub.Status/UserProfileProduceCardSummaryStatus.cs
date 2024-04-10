using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<UserProfileProduceCardSummaryStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UnitIdFieldNumber                        int IL2CPP_TYPE_I4
    // 018 UnitId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 TotalFieldNumber                         int IL2CPP_TYPE_I4
    // 01C Total                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 TotalOpenedFieldNumber                   int IL2CPP_TYPE_I4
    // 020 TotalOpened                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class UserProfileProduceCardSummaryStatus : DataModel
    {
        public int                                      UnitId                                  { get; set; }
        public int                                      Total                                   { get; set; }
        public int                                      TotalOpened                             { get; set; }

        public static UserProfileProduceCardSummaryStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UserProfileProduceCardSummaryStatus() { Pointer= p0 };

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x018)); // 024662694090 0x18 UnitId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Total                                     = GetInt32(new IntPtr(p + 0x01C)); // 0246626940D0 0x1C Total                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TotalOpened                               = GetInt32(new IntPtr(p + 0x020)); // 024662694110 0x20 TotalOpened                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
