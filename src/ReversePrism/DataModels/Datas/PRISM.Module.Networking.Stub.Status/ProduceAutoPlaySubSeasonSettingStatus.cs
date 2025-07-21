using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ProduceAutoPlaySubSeasonSettingStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSubSeasonIdFieldNumber                int IL2CPP_TYPE_I4
    // 018 MstSubSeasonId                           ModelPrimitiveType int int int Int32
    // 000 SeasonFieldNumber                        int IL2CPP_TYPE_I4
    // 01C Season                                   ModelPrimitiveType int int int Int32
    // 000 MstIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 020 MstIdolId                                ModelPrimitiveType int int int Int32
    public partial class ProduceAutoPlaySubSeasonSettingStatus : DataModel
    {
        public int                                      MstSubSeasonId                          { get; set; }
        public int                                      Season                                  { get; set; }
        public int                                      MstIdolId                               { get; set; }

        public static ProduceAutoPlaySubSeasonSettingStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceAutoPlaySubSeasonSettingStatus() { Pointer= p0 };

            value.MstSubSeasonId                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSubSeasonId              ( ModelPrimitiveType int int int Int32 )
            value.Season                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Season                      ( ModelPrimitiveType int int int Int32 )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 MstIdolId                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
