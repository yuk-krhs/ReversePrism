using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BaseInfo                                 0001865E3630 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer
    // 018 UnitModel                                00018659BBD0 ModelClassType ProduceUnitModel ProduceUnitModel ProduceUnitModel Pointer
    public partial class ProduceResumeModel : DataModel
    {
        public IProduceBaseInfoStatus?                  BaseInfo                                { get; set; }
        public ProduceUnitModel?                        UnitModel                               { get; set; }

        public static ProduceResumeModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceResumeModel() { Pointer= p0 };

            value.BaseInfo                                  = GetObject<IProduceBaseInfoStatus>(new IntPtr(p + 0x010), ReversePrism.DataModels.IProduceBaseInfoStatus.FromPointer); // 0246662638D0 0x10 BaseInfo                    ( 0001865E3630 ModelClassType IProduceBaseInfoStatus IProduceBaseInfoStatus IProduceBaseInfoStatus Pointer )
            value.UnitModel                                 = GetObject<ProduceUnitModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProduceUnitModel.FromPointer); // 0246662638F0 0x18 UnitModel                   ( 00018659BBD0 ModelClassType ProduceUnitModel ProduceUnitModel ProduceUnitModel Pointer )

            return value;
        }
    }
}
