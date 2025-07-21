using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BeforeDeckDataList                       ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer
    // 018 BeforeGraveyardList                      ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer
    // 020 BeforeHandList                           ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer
    // 028 ExceptHandAndGraveyards                  ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer
    public partial class IngamePlayerActionData : DataModel
    {
        public List<IngamePCardModel>?                  BeforeDeckDataList                      { get; set; }
        public List<IngamePCardModel>?                  BeforeGraveyardList                     { get; set; }
        public List<IngamePCardModel>?                  BeforeHandList                          { get; set; }
        public List<IngamePCardModel>?                  ExceptHandAndGraveyards                 { get; set; }

        public static IngamePlayerActionData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IngamePlayerActionData() { Pointer= p0 };

            value.BeforeDeckDataList                        = GetObjectList<IngamePCardModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 0x10 BeforeDeckDataList          ( ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer )
            value.BeforeGraveyardList                       = GetObjectList<IngamePCardModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 0x18 BeforeGraveyardList         ( ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer )
            value.BeforeHandList                            = GetObjectList<IngamePCardModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 0x20 BeforeHandList              ( ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer )
            value.ExceptHandAndGraveyards                   = GetObjectList<IngamePCardModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.IngamePCardModel.FromPointer); // 0x28 ExceptHandAndGraveyards     ( ModelClassListType List`1<IngamePCardModel> List`1<IngamePCardModel> List<IngamePCardModel> Pointer )

            return value;
        }
    }
}
