using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstUnitId                                ModelPrimitiveType int int int Int32
    // 014 UnitNumber                               ModelPrimitiveType int int int Int32
    // 018 Name                                     ModelPrimitiveType string string string String
    // 020 ProduceUnitIdolList                      ModelClassListType IReadOnlyList`1<ProduceUnitIdol> IReadOnlyList`1<ProduceUnitIdol> List<ProduceUnitIdol> Pointer
    // 028 SupportCharacterList                     ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer
    // 030 UnitParameter                            ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    public partial class ProduceIdolUnit : DataModel
    {
        public int                                      MstUnitId                               { get; set; }
        public int                                      UnitNumber                              { get; set; }
        public string                                   Name                                    { get; set; }
        public List<ProduceUnitIdol>?                   ProduceUnitIdolList                     { get; set; }
        public List<ISupportCharacterStatus>?           SupportCharacterList                    { get; set; }
        public IProduceParameterStatus?                 UnitParameter                           { get; set; }

        public static ProduceIdolUnit? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolUnit() { Pointer= p0 };

            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.UnitNumber                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 UnitNumber                  ( ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )
            value.ProduceUnitIdolList                       = GetObjectList<ProduceUnitIdol>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceUnitIdol.FromPointer); // 0x20 ProduceUnitIdolList         ( ModelClassListType IReadOnlyList`1<ProduceUnitIdol> IReadOnlyList`1<ProduceUnitIdol> List<ProduceUnitIdol> Pointer )
            value.SupportCharacterList                      = GetObjectList<ISupportCharacterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0x28 SupportCharacterList        ( ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer )
            value.UnitParameter                             = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 0x30 UnitParameter               ( ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )

            return value;
        }
    }
}
