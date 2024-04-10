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
    // 020 IdolService                              000186716AD0 ModelClassType ICachedIdolService ICachedIdolService ICachedIdolService Pointer
    // 028 CostumeService                           000186715C30 ModelClassType ICachedCostumeService ICachedCostumeService ICachedCostumeService Pointer
    // 030 SpecialUnitCount                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 Units                                    000185B917B0 ModelClassListType LiveUnit[] LiveUnit[] List<LiveUnit> Pointer
    public partial class LiveUnitEditViewModel : DataModel
    {
        public ICachedIdolService?                      IdolService                             { get; set; }
        public ICachedCostumeService?                   CostumeService                          { get; set; }
        public int                                      SpecialUnitCount                        { get; set; }
        public List<LiveUnit>?                          Units                                   { get; set; }

        public static LiveUnitEditViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitEditViewModel() { Pointer= p0 };

            value.IdolService                               = GetObject<ICachedIdolService>(new IntPtr(p + 0x020), ReversePrism.DataModels.ICachedIdolService.FromPointer); // 024665F746C0 0x20 IdolService                 ( 000186716AD0 ModelClassType ICachedIdolService ICachedIdolService ICachedIdolService Pointer )
            value.CostumeService                            = GetObject<ICachedCostumeService>(new IntPtr(p + 0x028), ReversePrism.DataModels.ICachedCostumeService.FromPointer); // 024665F746E0 0x28 CostumeService              ( 000186715C30 ModelClassType ICachedCostumeService ICachedCostumeService ICachedCostumeService Pointer )
            value.SpecialUnitCount                          = GetInt32(new IntPtr(p + 0x030)); // 024665F74700 0x30 SpecialUnitCount            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Units                                     = GetObjectList<LiveUnit>(new IntPtr(p + 0x038), ReversePrism.DataModels.LiveUnit.FromPointer); // 024665F74720 0x38 Units                       ( 000185B917B0 ModelClassListType LiveUnit[] LiveUnit[] List<LiveUnit> Pointer )

            return value;
        }
    }
}
