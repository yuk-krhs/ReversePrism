using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 CostumeService                           ModelClassType ICachedCostumeService ICachedCostumeService ICachedCostumeService Pointer
    // 030 SaveData                                 ModelClassType LiveMVUnitConfirmationSaveData LiveMVUnitConfirmationSaveData LiveMVUnitConfirmationSaveData Pointer
    // 038 Option                                   ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer
    // 040 Units                                    ModelClassListType LiveMVUnit[] LiveMVUnit[] List<LiveMVUnit> Pointer
    // 048 MVOriginalUnit                           ModelClassType LiveMVUnit LiveMVUnit LiveMVUnit Pointer
    public partial class LiveMVUnitConfirmationModel : DataModel
    {
        public ICachedCostumeService?                   CostumeService                          { get; set; }
        public LiveMVUnitConfirmationSaveData?          SaveData                                { get; set; }
        public RhythmGameOption?                        Option                                  { get; set; }
        public List<LiveMVUnit>?                        Units                                   { get; set; }
        public LiveMVUnit?                              MVOriginalUnit                          { get; set; }

        public static LiveMVUnitConfirmationModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVUnitConfirmationModel() { Pointer= p0 };

            value.CostumeService                            = GetObject<ICachedCostumeService>(new IntPtr(p + 0x028), ReversePrism.DataModels.ICachedCostumeService.FromPointer); // 0x28 CostumeService              ( ModelClassType ICachedCostumeService ICachedCostumeService ICachedCostumeService Pointer )
            value.SaveData                                  = GetObject<LiveMVUnitConfirmationSaveData>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveMVUnitConfirmationSaveData.FromPointer); // 0x30 SaveData                    ( ModelClassType LiveMVUnitConfirmationSaveData LiveMVUnitConfirmationSaveData LiveMVUnitConfirmationSaveData Pointer )
            value.Option                                    = GetObject<RhythmGameOption>(new IntPtr(p + 0x038), ReversePrism.DataModels.RhythmGameOption.FromPointer); // 0x38 Option                      ( ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer )
            value.Units                                     = GetObjectList<LiveMVUnit>(new IntPtr(p + 0x040), ReversePrism.DataModels.LiveMVUnit.FromPointer); // 0x40 Units                       ( ModelClassListType LiveMVUnit[] LiveMVUnit[] List<LiveMVUnit> Pointer )
            value.MVOriginalUnit                            = GetObject<LiveMVUnit>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveMVUnit.FromPointer); // 0x48 MVOriginalUnit              ( ModelClassType LiveMVUnit LiveMVUnit LiveMVUnit Pointer )

            return value;
        }
    }
}
