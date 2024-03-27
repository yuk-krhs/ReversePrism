using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 BaseInfo                                 0001865E3630 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 098 UnitModel                                00018659BBD0 ModelClassType ProduceUnitModel ProduceUnitModel ProduceUnitModel Pointer
    public partial class ProduceResumeConfirmPopupParam
    {
        public IProduceBaseInfoStatus?                  BaseInfo                                { get; set; }
        public ProduceUnitModel?                        UnitModel                               { get; set; }

        public static ProduceResumeConfirmPopupParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResumeConfirmPopupParam();

            value.BaseInfo                                  = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x090), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 0270D5C7B2E8 0x90 BaseInfo                    ( 0001865E3630 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.UnitModel                                 = GetObject<ProduceUnitModel>(new IntPtr(p + 0x098), ReversePrism.DataModels.ProduceUnitModel.FromPointer); // 0270D5C7B308 0x98 UnitModel                   ( 00018659BBD0 ModelClassType ProduceUnitModel ProduceUnitModel ProduceUnitModel Pointer )

            return value;
        }
    }
}
