using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 ForceLDRMusicIds                         ModelPrimitiveListType int[] int[] List<int> Pointer
    // 058 SelectedUnitEditTabType                  ModelEnumType LiveMVUnitConfirmationUnitEditTabType LiveMVUnitConfirmationUnitEditTabType LiveMVUnitConfirmationUnitEditTabType Int32
    // 05C BackgroundMode                           ModelEnumType LiveBackgroundMode LiveBackgroundMode LiveBackgroundMode Int32
    // 060 <ForceLDRMusicIds>k__BackingField        HashSet`1<int> IL2CPP_TYPE_GENERICINST
    public partial class LiveMVUnitConfirmationSaveData : DataModel
    {
        public List<int>?                               ForceLDRMusicIds                        { get; set; }
        public LiveMVUnitConfirmationUnitEditTabType    SelectedUnitEditTabType                 { get; set; }
        public LiveBackgroundMode                       BackgroundMode                          { get; set; }

        public static LiveMVUnitConfirmationSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVUnitConfirmationSaveData() { Pointer= p0 };

            value.ForceLDRMusicIds                          = GetInt32List(new IntPtr(p + 0x050)); // 0x50 ForceLDRMusicIds            ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.SelectedUnitEditTabType                   = (LiveMVUnitConfirmationUnitEditTabType)GetInt32(new IntPtr(p + 0x058)); // 0x58 SelectedUnitEditTabType     ( ModelEnumType LiveMVUnitConfirmationUnitEditTabType LiveMVUnitConfirmationUnitEditTabType LiveMVUnitConfirmationUnitEditTabType Int32 )
            value.BackgroundMode                            = (LiveBackgroundMode)GetInt32(new IntPtr(p + 0x05C)); // 0x5C BackgroundMode              ( ModelEnumType LiveBackgroundMode LiveBackgroundMode LiveBackgroundMode Int32 )

            return value;
        }
    }
}
