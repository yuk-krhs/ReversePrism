using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 trainingLvRP                             ReactiveProperty`1<ILimitedValueStatus> IL2CPP_TYPE_GENERICINST
    // 018 AwakeningLvRP                            000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer
    // 020 IdolAliasRP                              0001865C1960 ModelClassType StringReactiveProperty StringReactiveProperty StringReactiveProperty Pointer
    // 028 IdolNameRP                               0001865C1960 ModelClassType StringReactiveProperty StringReactiveProperty StringReactiveProperty Pointer
    // 030 voDaViMeRP                               ReactiveProperty`1<VoDaViMeViewModel> IL2CPP_TYPE_GENERICINST
    // 038 IdolBaseParameter                        000186575570 ModelClassType IIdolParameterStatus IIdolParameterStatus IIdolParameterStatus Pointer
    public partial class ProduceIdolStatusViewModel
    {
        public IntReactiveProperty?                     AwakeningLvRP                           { get; set; }
        public StringReactiveProperty?                  IdolAliasRP                             { get; set; }
        public StringReactiveProperty?                  IdolNameRP                              { get; set; }
        public IIdolParameterStatus?                    IdolBaseParameter                       { get; set; }

        public static ProduceIdolStatusViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolStatusViewModel();

            value.AwakeningLvRP                             = GetObject<IntReactiveProperty>(new IntPtr(p + 0x018), ReversePrism.DataModels.IntReactiveProperty.FromPointer); // 0270D5FBBDC8 0x18 AwakeningLvRP               ( 000186714660 ModelClassType IntReactiveProperty IntReactiveProperty IntReactiveProperty Pointer )
            value.IdolAliasRP                               = GetObject<StringReactiveProperty>(new IntPtr(p + 0x020), ReversePrism.DataModels.StringReactiveProperty.FromPointer); // 0270D5FBBDE8 0x20 IdolAliasRP                 ( 0001865C1960 ModelClassType StringReactiveProperty StringReactiveProperty StringReactiveProperty Pointer )
            value.IdolNameRP                                = GetObject<StringReactiveProperty>(new IntPtr(p + 0x028), ReversePrism.DataModels.StringReactiveProperty.FromPointer); // 0270D5FBBE08 0x28 IdolNameRP                  ( 0001865C1960 ModelClassType StringReactiveProperty StringReactiveProperty StringReactiveProperty Pointer )
            value.IdolBaseParameter                         = GetObject<IIdolParameterStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IIdolParameterStatus.FromPointer); // 0270D5FBBE48 0x38 IdolBaseParameter           ( 000186575570 ModelClassType IIdolParameterStatus IIdolParameterStatus IIdolParameterStatus Pointer )

            return value;
        }
    }
}
