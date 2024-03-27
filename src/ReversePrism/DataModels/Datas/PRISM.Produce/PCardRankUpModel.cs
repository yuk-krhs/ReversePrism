using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProduceCard                              0001865E4D60 ModelClassType IProduceCardStatus IProduceCardStatus IProduceCardStatus Pointer
    // 018 TargetRank                               0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class PCardRankUpModel
    {
        public IProduceCardStatus?                      ProduceCard                             { get; set; }
        public int                                      TargetRank                              { get; set; }

        public static PCardRankUpModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PCardRankUpModel();

            value.ProduceCard                               = GetObject<IProduceCardStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0270D5CEA468 0x10 ProduceCard                 ( 0001865E4D60 ModelClassType IProduceCardStatus IProduceCardStatus IProduceCardStatus Pointer )
            value.TargetRank                                = GetInt32(new IntPtr(p + 0x018)); // 0270D5CEA488 0x18 TargetRank                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
