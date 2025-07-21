using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TargetRank                               ModelPrimitiveType int int int Int32
    // 018 ProduceCard                              ModelClassType IProduceCardStatus IProduceCardStatus IProduceCardStatus Pointer
    public partial class PCardRankUpViewModel : DataModel
    {
        public int                                      TargetRank                              { get; set; }
        public IProduceCardStatus?                      ProduceCard                             { get; set; }

        public static PCardRankUpViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PCardRankUpViewModel() { Pointer= p0 };

            value.TargetRank                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 TargetRank                  ( ModelPrimitiveType int int int Int32 )
            value.ProduceCard                               = GetObject<IProduceCardStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0x18 ProduceCard                 ( ModelClassType IProduceCardStatus IProduceCardStatus IProduceCardStatus Pointer )

            return value;
        }
    }
}
