using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultPhase                             int IL2CPP_TYPE_I4
    // 010 ProduceCard                              ModelClassType IProduceCardStatus IProduceCardStatus IProduceCardStatus Pointer
    // 018 AppealTypes                              ModelEnumListType ProduceParameterType[] ProduceParameterType[] List<ProduceParameterType> Pointer
    // 020 BaseCost                                 ModelPrimitiveType int int int Int32
    // 024 IsCardRankOverWrite                      ModelPrimitiveType bool bool bool Bool
    // 028 OverWriteCardRank                        ModelPrimitiveType int int int Int32
    public partial class AutoModePCardModel : DataModel
    {
        public IProduceCardStatus?                      ProduceCard                             { get; set; }
        public List<ProduceParameterType>?              AppealTypes                             { get; set; }
        public int                                      BaseCost                                { get; set; }
        public bool                                     IsCardRankOverWrite                     { get; set; }
        public int                                      OverWriteCardRank                       { get; set; }

        public static AutoModePCardModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AutoModePCardModel() { Pointer= p0 };

            value.ProduceCard                               = GetObject<IProduceCardStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 0x10 ProduceCard                 ( ModelClassType IProduceCardStatus IProduceCardStatus IProduceCardStatus Pointer )
            value.AppealTypes                               = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x018)); // 0x18 AppealTypes                 ( ModelEnumListType ProduceParameterType[] ProduceParameterType[] List<ProduceParameterType> Pointer )
            value.BaseCost                                  = GetInt32(new IntPtr(p + 0x020)); // 0x20 BaseCost                    ( ModelPrimitiveType int int int Int32 )
            value.IsCardRankOverWrite                       = GetBool(new IntPtr(p + 0x024)); // 0x24 IsCardRankOverWrite         ( ModelPrimitiveType bool bool bool Bool )
            value.OverWriteCardRank                         = GetInt32(new IntPtr(p + 0x028)); // 0x28 OverWriteCardRank           ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
