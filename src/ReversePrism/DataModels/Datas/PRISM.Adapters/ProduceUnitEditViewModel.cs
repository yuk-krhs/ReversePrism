using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 produceIdolUnits                         Dictionary`2<ValueTuple`2<int, int>, IProduceIdolUnitStatus> IL2CPP_TYPE_GENERICINST
    // 018 unitCounts                               Dictionary`2<int, int> IL2CPP_TYPE_GENERICINST
    // 020 idolBases                                Dictionary`2<int, IIdolBaseStatus> IL2CPP_TYPE_GENERICINST
    // 028 permanentDataPackage                     SavableJsonObject`1<ProduceUnitEditPermanentData> IL2CPP_TYPE_GENERICINST
    // 030 CurrentProduceIdolUnit                   0001865EC3F0 ModelClassType IProduceIdolUnitStatus IProduceIdolUnitStatus IProduceIdolUnitStatus Pointer
    // 038 ViewUnitIdols                            000185B9DDC0 ModelClassListType ProduceUnitEditIdolViewModel[] ProduceUnitEditIdolViewModel[] List<ProduceUnitEditIdolViewModel> Pointer
    public partial class ProduceUnitEditViewModel : DataModel
    {
        public IProduceIdolUnitStatus?                  CurrentProduceIdolUnit                  { get; set; }
        public List<ProduceUnitEditIdolViewModel>?      ViewUnitIdols                           { get; set; }

        public static ProduceUnitEditViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceUnitEditViewModel() { Pointer= p0 };

            value.CurrentProduceIdolUnit                    = GetObject<IProduceIdolUnitStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProduceIdolUnitStatus.FromPointer); // 024666075038 0x30 CurrentProduceIdolUnit      ( 0001865EC3F0 ModelClassType IProduceIdolUnitStatus IProduceIdolUnitStatus IProduceIdolUnitStatus Pointer )
            value.ViewUnitIdols                             = GetObjectList<ProduceUnitEditIdolViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceUnitEditIdolViewModel.FromPointer); // 024666075058 0x38 ViewUnitIdols               ( 000185B9DDC0 ModelClassListType ProduceUnitEditIdolViewModel[] ProduceUnitEditIdolViewModel[] List<ProduceUnitEditIdolViewModel> Pointer )

            return value;
        }
    }
}
