using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 SaveData                                 00018655EBD0 ModelClassType LiveMVUnitConfirmationSaveData LiveMVUnitConfirmationSaveData LiveMVUnitConfirmationSaveData Pointer
    // 038 Option                                   000186685BF0 ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer
    // 040 Units                                    000185B911B0 ModelClassListType LiveMVUnit[] LiveMVUnit[] List<LiveMVUnit> Pointer
    // 048 MVOriginalUnit                           00018655DA20 ModelClassType LiveMVUnit LiveMVUnit LiveMVUnit Pointer
    public partial class LiveMVUnitConfirmationModel
    {
        public LiveMVUnitConfirmationSaveData?          SaveData                                { get; set; }
        public RhythmGameOption?                        Option                                  { get; set; }
        public List<LiveMVUnit>?                        Units                                   { get; set; }
        public LiveMVUnit?                              MVOriginalUnit                          { get; set; }

        public static LiveMVUnitConfirmationModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVUnitConfirmationModel();

            value.SaveData                                  = GetObject<LiveMVUnitConfirmationSaveData>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveMVUnitConfirmationSaveData.FromPointer); // 0270D518B5C8 0x30 SaveData                    ( 00018655EBD0 ModelClassType LiveMVUnitConfirmationSaveData LiveMVUnitConfirmationSaveData LiveMVUnitConfirmationSaveData Pointer )
            value.Option                                    = GetObject<RhythmGameOption>(new IntPtr(p + 0x038), ReversePrism.DataModels.RhythmGameOption.FromPointer); // 0270D518B5E8 0x38 Option                      ( 000186685BF0 ModelClassType RhythmGameOption RhythmGameOption RhythmGameOption Pointer )
            value.Units                                     = GetObjectList<LiveMVUnit>(new IntPtr(p + 0x040), ReversePrism.DataModels.LiveMVUnit.FromPointer); // 0270D518B608 0x40 Units                       ( 000185B911B0 ModelClassListType LiveMVUnit[] LiveMVUnit[] List<LiveMVUnit> Pointer )
            value.MVOriginalUnit                            = GetObject<LiveMVUnit>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveMVUnit.FromPointer); // 0270D518B628 0x48 MVOriginalUnit              ( 00018655DA20 ModelClassType LiveMVUnit LiveMVUnit LiveMVUnit Pointer )

            return value;
        }
    }
}
