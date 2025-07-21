using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 allLiveIdols                             IList`1<LiveIdol> IL2CPP_TYPE_GENERICINST
    // 018 permanentDataPackage                     SavableJsonObject`1<LiveUnitEditPermanentData> IL2CPP_TYPE_GENERICINST
    // 020 LiveIdolFactory                          ModelClassType LiveIdolFactory LiveIdolFactory LiveIdolFactory Pointer
    // 028 SpecialUnitCount                         ModelPrimitiveType int int int Int32
    // 030 Units                                    ModelClassListType LiveUnit[] LiveUnit[] List<LiveUnit> Pointer
    public partial class LiveUnitEditViewModel : DataModel
    {
        public LiveIdolFactory?                         LiveIdolFactory                         { get; set; }
        public int                                      SpecialUnitCount                        { get; set; }
        public List<LiveUnit>?                          Units                                   { get; set; }

        public static LiveUnitEditViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitEditViewModel() { Pointer= p0 };

            value.LiveIdolFactory                           = GetObject<LiveIdolFactory>(new IntPtr(p + 0x020), ReversePrism.DataModels.LiveIdolFactory.FromPointer); // 0x20 LiveIdolFactory             ( ModelClassType LiveIdolFactory LiveIdolFactory LiveIdolFactory Pointer )
            value.SpecialUnitCount                          = GetInt32(new IntPtr(p + 0x028)); // 0x28 SpecialUnitCount            ( ModelPrimitiveType int int int Int32 )
            value.Units                                     = GetObjectList<LiveUnit>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveUnit.FromPointer); // 0x30 Units                       ( ModelClassListType LiveUnit[] LiveUnit[] List<LiveUnit> Pointer )

            return value;
        }
    }
}
