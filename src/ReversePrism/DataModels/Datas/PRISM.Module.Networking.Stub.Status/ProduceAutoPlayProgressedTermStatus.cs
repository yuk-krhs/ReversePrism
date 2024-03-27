using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceAutoPlayProgressedTermStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 SeasonFieldNumber                        int IL2CPP_TYPE_I4
    // 018 Season                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstSubSeasonIdFieldNumber                int IL2CPP_TYPE_I4
    // 01C MstSubSeasonId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ProduceAutoPlayProgressedTermStatus
    {
        public int                                      Season                                  { get; set; }
        public int                                      MstSubSeasonId                          { get; set; }

        public static ProduceAutoPlayProgressedTermStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoPlayProgressedTermStatus();

            value.Season                                    = GetInt32(new IntPtr(p + 0x018)); // 0270D11065A0 0x18 Season                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstSubSeasonId                            = GetInt32(new IntPtr(p + 0x01C)); // 0270D11065E0 0x1C MstSubSeasonId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
