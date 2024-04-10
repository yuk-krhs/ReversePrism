using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 048 SelectedUnitEditTabType                  00018655F330 ModelEnumType LiveMVUnitConfirmationUnitEditTabType LiveMVUnitConfirmationUnitEditTabType LiveMVUnitConfirmationUnitEditTabType Int32
    // 04C BackgroundMode                           00018653FB60 ModelEnumType LiveBackgroundMode LiveBackgroundMode LiveBackgroundMode Int32
    public partial class LiveMVUnitConfirmationSaveData : DataModel
    {
        public LiveMVUnitConfirmationUnitEditTabType    SelectedUnitEditTabType                 { get; set; }
        public LiveBackgroundMode                       BackgroundMode                          { get; set; }

        public static LiveMVUnitConfirmationSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVUnitConfirmationSaveData() { Pointer= p0 };

            value.SelectedUnitEditTabType                   = (LiveMVUnitConfirmationUnitEditTabType)GetInt32(new IntPtr(p + 0x048)); // 0245A3A7D2E8 0x48 SelectedUnitEditTabType     ( 00018655F330 ModelEnumType LiveMVUnitConfirmationUnitEditTabType LiveMVUnitConfirmationUnitEditTabType LiveMVUnitConfirmationUnitEditTabType Int32 )
            value.BackgroundMode                            = (LiveBackgroundMode)GetInt32(new IntPtr(p + 0x04C)); // 0245A3A7D308 0x4C BackgroundMode              ( 00018653FB60 ModelEnumType LiveBackgroundMode LiveBackgroundMode LiveBackgroundMode Int32 )

            return value;
        }
    }
}
