using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GashaButtonColor                         string IL2CPP_TYPE_STRING
    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 GashaId                                  ModelPrimitiveType int int int Int32
    // 018 BeginDate                                ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 028 EndDate                                  ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 038 GashaMedal                               ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer
    // 040 PriceList                                ModelClassListType IReadOnlyList`1<IGashaPriceStatus> IReadOnlyList`1<IGashaPriceStatus> List<IGashaPriceStatus> Pointer
    // 048 BoxCount                                 ModelPrimitiveType int int int Int32
    // 04C IsLockEnabled                            ModelPrimitiveType bool bool bool Bool
    public partial class MedalGashaStatusModel : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      GashaId                                 { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public IHavingProductStatus?                    GashaMedal                              { get; set; }
        public List<IGashaPriceStatus>?                 PriceList                               { get; set; }
        public int                                      BoxCount                                { get; set; }
        public bool                                     IsLockEnabled                           { get; set; }

        public static MedalGashaStatusModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaStatusModel() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.GashaId                                   = GetInt32(new IntPtr(p + 0x014)); // 0x14 GashaId                     ( ModelPrimitiveType int int int Int32 )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x018)); // 0x18 BeginDate                   ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x028)); // 0x28 EndDate                     ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.GashaMedal                                = GetObject<IHavingProductStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IHavingProductStatus.FromPointer); // 0x38 GashaMedal                  ( ModelClassType IHavingProductStatus IHavingProductStatus IHavingProductStatus Pointer )
            value.PriceList                                 = GetObjectList<IGashaPriceStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IGashaPriceStatus.FromPointer); // 0x40 PriceList                   ( ModelClassListType IReadOnlyList`1<IGashaPriceStatus> IReadOnlyList`1<IGashaPriceStatus> List<IGashaPriceStatus> Pointer )
            value.BoxCount                                  = GetInt32(new IntPtr(p + 0x048)); // 0x48 BoxCount                    ( ModelPrimitiveType int int int Int32 )
            value.IsLockEnabled                             = GetBool(new IntPtr(p + 0x04C)); // 0x4C IsLockEnabled               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
