using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstUnitId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 UnitNumber                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Name                                     000186671910 ModelPrimitiveType string string string String
    // 020 ProduceUnitIdolList                      000185D151B8 ModelClassListType IReadOnlyList`1<ProduceUnitIdol> IReadOnlyList`1<ProduceUnitIdol> List<ProduceUnitIdol> Pointer
    // 028 SupportCharacterList                     000185D0D808 ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer
    // 030 UnitParameter                            0001865EF0E0 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
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

            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x010)); // 02466568C050 0x10 MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnitNumber                                = GetInt32(new IntPtr(p + 0x014)); // 02466568C070 0x14 UnitNumber                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 02466568C090 0x18 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.ProduceUnitIdolList                       = GetObjectList<ProduceUnitIdol>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceUnitIdol.FromPointer); // 02466568C0B0 0x20 ProduceUnitIdolList         ( 000185D151B8 ModelClassListType IReadOnlyList`1<ProduceUnitIdol> IReadOnlyList`1<ProduceUnitIdol> List<ProduceUnitIdol> Pointer )
            value.SupportCharacterList                      = GetObjectList<ISupportCharacterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 02466568C0D0 0x28 SupportCharacterList        ( 000185D0D808 ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer )
            value.UnitParameter                             = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 02466568C0F0 0x30 UnitParameter               ( 0001865EF0E0 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )

            return value;
        }
    }
}
