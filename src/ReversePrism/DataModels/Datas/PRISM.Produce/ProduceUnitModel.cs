using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitId                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 UnitNumber                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 UnitName                                 0001866722E0 ModelPrimitiveType string string string String
    // 020 Parameter                                0001865EF350 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    // 028 FriendSupportModelData                   0001865CC100 ModelClassType FriendSupportModel FriendSupportModel FriendSupportModel Pointer
    // 030 InheritanceFUnitId                       0001866722E0 ModelPrimitiveType string string string String
    // 038 ProduceIdolModels                        000185CFC158 ModelClassListType List`1<ProduceIdolModel> List`1<ProduceIdolModel> List<ProduceIdolModel> Pointer
    // 040 SupportCharacterModels                   000185D10168 ModelClassListType List`1<SupportCharacterModel> List`1<SupportCharacterModel> List<SupportCharacterModel> Pointer
    // 048 CacheIdolStatusDatas                     000185B8ACD0 ModelClassListType IdolStatusData[] IdolStatusData[] List<IdolStatusData> Pointer
    public partial class ProduceUnitModel : DataModel
    {
        public int                                      UnitId                                  { get; set; }
        public int                                      UnitNumber                              { get; set; }
        public string                                   UnitName                                { get; set; }
        public IProduceParameterStatus?                 Parameter                               { get; set; }
        public FriendSupportModel?                      FriendSupportModelData                  { get; set; }
        public string                                   InheritanceFUnitId                      { get; set; }
        public List<ProduceIdolModel>?                  ProduceIdolModels                       { get; set; }
        public List<SupportCharacterModel>?             SupportCharacterModels                  { get; set; }
        public List<IdolStatusData>?                    CacheIdolStatusDatas                    { get; set; }

        public static ProduceUnitModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceUnitModel() { Pointer= p0 };

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x010)); // 024660BF1C90 0x10 UnitId                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.UnitNumber                                = GetInt32(new IntPtr(p + 0x014)); // 024660BF1CB0 0x14 UnitNumber                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.UnitName                                  = GetString(new IntPtr(p + 0x018)); // 024660BF1CD0 0x18 UnitName                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Parameter                                 = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 024660BF1CF0 0x20 Parameter                   ( 0001865EF350 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )
            value.FriendSupportModelData                    = GetObject<FriendSupportModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.FriendSupportModel.FromPointer); // 024660BF1D10 0x28 FriendSupportModelData      ( 0001865CC100 ModelClassType FriendSupportModel FriendSupportModel FriendSupportModel Pointer )
            value.InheritanceFUnitId                        = GetString(new IntPtr(p + 0x030)); // 024660BF1D30 0x30 InheritanceFUnitId          ( 0001866722E0 ModelPrimitiveType string string string String )
            value.ProduceIdolModels                         = GetObjectList<ProduceIdolModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceIdolModel.FromPointer); // 024660BF1D50 0x38 ProduceIdolModels           ( 000185CFC158 ModelClassListType List`1<ProduceIdolModel> List`1<ProduceIdolModel> List<ProduceIdolModel> Pointer )
            value.SupportCharacterModels                    = GetObjectList<SupportCharacterModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.SupportCharacterModel.FromPointer); // 024660BF1D70 0x40 SupportCharacterModels      ( 000185D10168 ModelClassListType List`1<SupportCharacterModel> List`1<SupportCharacterModel> List<SupportCharacterModel> Pointer )
            value.CacheIdolStatusDatas                      = GetObjectList<IdolStatusData>(new IntPtr(p + 0x048), ReversePrism.DataModels.IdolStatusData.FromPointer); // 024660BF1D90 0x48 CacheIdolStatusDatas        ( 000185B8ACD0 ModelClassListType IdolStatusData[] IdolStatusData[] List<IdolStatusData> Pointer )

            return value;
        }
    }
}
