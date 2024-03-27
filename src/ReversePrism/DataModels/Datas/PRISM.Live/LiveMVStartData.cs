using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MusicMaster                              00018662C3A0 ModelClassType MstSong MstSong MstSong Pointer
    // 018 CameraIndex                              0001865F4260 ModelPrimitiveType int int int Int32
    // 020 OnStageIdols                             000185CAF458 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 028 IsVocalSeparatedOn                       0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 02C BackgroundMode                           00018653FDD0 ModelEnumType LiveBackgroundMode LiveBackgroundMode LiveBackgroundMode Int32
    // 030 ViewStack                                000185CC59D8 ModelClassListType ViewValue[] ViewValue[] List<ViewValue> Pointer
    public partial class LiveMVStartData
    {
        public MstSong?                                 MusicMaster                             { get; set; }
        public int                                      CameraIndex                             { get; set; }
        public List<UnitIdol>?                          OnStageIdols                            { get; set; }
        public bool                                     IsVocalSeparatedOn                      { get; set; }
        public LiveBackgroundMode                       BackgroundMode                          { get; set; }
        public List<ViewValue>?                         ViewStack                               { get; set; }

        public static LiveMVStartData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVStartData();

            value.MusicMaster                               = GetObject<MstSong>(new IntPtr(p + 0x010), ReversePrism.DataModels.MstSong.FromPointer); // 0270D4E216F8 0x10 MusicMaster                 ( 00018662C3A0 ModelClassType MstSong MstSong MstSong Pointer )
            value.CameraIndex                               = GetInt32(new IntPtr(p + 0x018)); // 0270D4E21718 0x18 CameraIndex                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.OnStageIdols                              = GetObjectList<UnitIdol>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnitIdol.FromPointer); // 0270D4E21738 0x20 OnStageIdols                ( 000185CAF458 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.IsVocalSeparatedOn                        = GetBool(new IntPtr(p + 0x028)); // 0270D4E21758 0x28 IsVocalSeparatedOn          ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.BackgroundMode                            = (LiveBackgroundMode)GetInt32(new IntPtr(p + 0x02C)); // 0270D4E21778 0x2C BackgroundMode              ( 00018653FDD0 ModelEnumType LiveBackgroundMode LiveBackgroundMode LiveBackgroundMode Int32 )
            value.ViewStack                                 = GetObjectList<ViewValue>(new IntPtr(p + 0x030), ReversePrism.DataModels.ViewValue.FromPointer); // 0270D4E21798 0x30 ViewStack                   ( 000185CC59D8 ModelClassListType ViewValue[] ViewValue[] List<ViewValue> Pointer )

            return value;
        }
    }
}
