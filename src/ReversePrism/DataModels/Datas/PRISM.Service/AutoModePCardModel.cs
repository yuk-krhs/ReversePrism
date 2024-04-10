using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultPhase                             int IL2CPP_TYPE_I4
    // 010 ProduceCard                              0001865E4AE0 ModelClassType IProduceCardStatus IProduceCardStatus IProduceCardStatus Pointer
    // 018 AppealTypes                              000185CBA038 ModelEnumListType ProduceParameterType[] ProduceParameterType[] List<ProduceParameterType> Pointer
    // 020 BaseCost                                 0001865F4260 ModelPrimitiveType int int int Int32
    // 024 IsCardRankOverWrite                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 OverWriteCardRank                        0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.ProduceCard                               = GetObject<IProduceCardStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceCardStatus.FromPointer); // 02466AE35E98 0x10 ProduceCard                 ( 0001865E4AE0 ModelClassType IProduceCardStatus IProduceCardStatus IProduceCardStatus Pointer )
            value.AppealTypes                               = GetEnumList<ProduceParameterType>(new IntPtr(p + 0x018)); // 02466AE35EB8 0x18 AppealTypes                 ( 000185CBA038 ModelEnumListType ProduceParameterType[] ProduceParameterType[] List<ProduceParameterType> Pointer )
            value.BaseCost                                  = GetInt32(new IntPtr(p + 0x020)); // 02466AE35ED8 0x20 BaseCost                    ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IsCardRankOverWrite                       = GetBool(new IntPtr(p + 0x024)); // 02466AE35EF8 0x24 IsCardRankOverWrite         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.OverWriteCardRank                         = GetInt32(new IntPtr(p + 0x028)); // 02466AE35F18 0x28 OverWriteCardRank           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
