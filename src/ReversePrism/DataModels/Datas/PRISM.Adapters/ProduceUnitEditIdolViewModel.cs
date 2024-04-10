using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharacterInfoIdRP                        000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 018 ProduceIdolIdRP                          000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 020 voDaViMeRP                               ReactiveProperty`1<VoDaViMeViewModel> IL2CPP_TYPE_GENERICINST
    // 028 idolSkillRP                              ReactiveProperty`1<IIdolSkillStatus> IL2CPP_TYPE_GENERICINST
    // 030 StandingOrder                            0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ProduceUnitEditIdolViewModel : DataModel
    {
        public IntReactiveProperty?                     CharacterInfoIdRP                       { get; set; }
        public IntReactiveProperty?                     ProduceIdolIdRP                         { get; set; }
        public int                                      StandingOrder                           { get; set; }

        public static ProduceUnitEditIdolViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceUnitEditIdolViewModel() { Pointer= p0 };

            value.CharacterInfoIdRP                         = GetObject<IntReactiveProperty>(new IntPtr(p + 0x010), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0246661F8700 0x10 CharacterInfoIdRP           ( 000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.ProduceIdolIdRP                           = GetObject<IntReactiveProperty>(new IntPtr(p + 0x018), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0246661F8720 0x18 ProduceIdolIdRP             ( 000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.StandingOrder                             = GetInt32(new IntPtr(p + 0x030)); // 0246661F8780 0x30 StandingOrder               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
