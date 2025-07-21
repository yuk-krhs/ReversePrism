using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 MstEventId                               ModelPrimitiveType int int int Int32
    // 018 EventRankingType                         ModelPrimitiveType int int int Int32
    // 01C MstIdolId                                ModelPrimitiveType int int int Int32
    public partial class MstEventRanking : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      MstEventId                              { get; set; }
        public int                                      EventRankingType                        { get; set; }
        public int                                      MstIdolId                               { get; set; }

        public static MstEventRanking? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstEventRanking() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.MstEventId                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 MstEventId                  ( ModelPrimitiveType int int int Int32 )
            value.EventRankingType                          = GetInt32(new IntPtr(p + 0x018)); // 0x18 EventRankingType            ( ModelPrimitiveType int int int Int32 )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstIdolId                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
