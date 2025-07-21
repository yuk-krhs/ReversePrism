using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 UnitMaxCount                             int IL2CPP_TYPE_I4
    // 000 UnitMaxCountSummer                       int IL2CPP_TYPE_I4
    // 010 onChangeCameraModeSetting                Subject`1<LiveCameraModeSetting> IL2CPP_TYPE_GENERICINST
    // 018 SpecialUnitCount                         ModelPrimitiveType int int int Int32
    // 020 MusicData                                ModelClassType MusicData MusicData MusicData Pointer
    public partial class LiveUnitConfirmationModelBase : DataModel
    {
        public int                                      SpecialUnitCount                        { get; set; }
        public MusicData?                               MusicData                               { get; set; }

        public static LiveUnitConfirmationModelBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveUnitConfirmationModelBase() { Pointer= p0 };

            value.SpecialUnitCount                          = GetInt32(new IntPtr(p + 0x018)); // 0x18 SpecialUnitCount            ( ModelPrimitiveType int int int Int32 )
            value.MusicData                                 = GetObject<MusicData>(new IntPtr(p + 0x020), ReversePrism.DataModels.MusicData.FromPointer); // 0x20 MusicData                   ( ModelClassType MusicData MusicData MusicData Pointer )

            return value;
        }
    }
}
