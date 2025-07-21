using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitId                                   ModelPrimitiveType int int int Int32
    // 014 UnitNumber                               ModelPrimitiveType int int int Int32
    // 018 UnitName                                 ModelPrimitiveType string string string String
    // 020 Parameter                                ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    // 028 FriendSupportModelData                   ModelClassType FriendSupportModel FriendSupportModel FriendSupportModel Pointer
    // 030 InheritanceFUnitId                       ModelPrimitiveType string string string String
    // 038 ProduceIdolModels                        ModelClassListType List`1<ProduceIdolModel> List`1<ProduceIdolModel> List<ProduceIdolModel> Pointer
    // 040 SupportCharacterModels                   ModelClassListType List`1<SupportCharacterModel> List`1<SupportCharacterModel> List<SupportCharacterModel> Pointer
    // 048 CacheIdolStatusDatas                     ModelClassListType IdolStatusData[] IdolStatusData[] List<IdolStatusData> Pointer
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

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x010)); // 0x10 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.UnitNumber                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 UnitNumber                  ( ModelPrimitiveType int int int Int32 )
            value.UnitName                                  = GetString(new IntPtr(p + 0x018)); // 0x18 UnitName                    ( ModelPrimitiveType string string string String )
            value.Parameter                                 = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 0x20 Parameter                   ( ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )
            value.FriendSupportModelData                    = GetObject<FriendSupportModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.FriendSupportModel.FromPointer); // 0x28 FriendSupportModelData      ( ModelClassType FriendSupportModel FriendSupportModel FriendSupportModel Pointer )
            value.InheritanceFUnitId                        = GetString(new IntPtr(p + 0x030)); // 0x30 InheritanceFUnitId          ( ModelPrimitiveType string string string String )
            value.ProduceIdolModels                         = GetObjectList<ProduceIdolModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProduceIdolModel.FromPointer); // 0x38 ProduceIdolModels           ( ModelClassListType List`1<ProduceIdolModel> List`1<ProduceIdolModel> List<ProduceIdolModel> Pointer )
            value.SupportCharacterModels                    = GetObjectList<SupportCharacterModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.SupportCharacterModel.FromPointer); // 0x40 SupportCharacterModels      ( ModelClassListType List`1<SupportCharacterModel> List`1<SupportCharacterModel> List<SupportCharacterModel> Pointer )
            value.CacheIdolStatusDatas                      = GetObjectList<IdolStatusData>(new IntPtr(p + 0x048), ReversePrism.DataModels.IdolStatusData.FromPointer); // 0x48 CacheIdolStatusDatas        ( ModelClassListType IdolStatusData[] IdolStatusData[] List<IdolStatusData> Pointer )

            return value;
        }
    }
}
