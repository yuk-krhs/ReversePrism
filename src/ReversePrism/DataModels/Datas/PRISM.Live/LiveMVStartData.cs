using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MusicMaster                              ModelClassType MstSong MstSong MstSong Pointer
    // 018 CameraIndex                              ModelPrimitiveType int int int Int32
    // 020 OnStageIdols                             ModelClassListType UnitIdolWithMstCostume[] UnitIdolWithMstCostume[] List<UnitIdolWithMstCostume> Pointer
    // 028 IsVocalSeparatedOn                       ModelPrimitiveType bool bool bool Bool
    // 02C BackgroundMode                           ModelEnumType LiveBackgroundMode LiveBackgroundMode LiveBackgroundMode Int32
    // 030 RenderingDynamicRange                    ModelEnumType RenderingDynamicRange RenderingDynamicRange RenderingDynamicRange Int32
    // 038 ViewStack                                ModelClassListType ViewValue[] ViewValue[] List<ViewValue> Pointer
    public partial class LiveMVStartData : DataModel
    {
        public MstSong?                                 MusicMaster                             { get; set; }
        public int                                      CameraIndex                             { get; set; }
        public List<UnitIdolWithMstCostume>?            OnStageIdols                            { get; set; }
        public bool                                     IsVocalSeparatedOn                      { get; set; }
        public LiveBackgroundMode                       BackgroundMode                          { get; set; }
        public RenderingDynamicRange                    RenderingDynamicRange                   { get; set; }
        public List<ViewValue>?                         ViewStack                               { get; set; }

        public static LiveMVStartData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMVStartData() { Pointer= p0 };

            value.MusicMaster                               = GetObject<MstSong>(new IntPtr(p + 0x010), ReversePrism.DataModels.MstSong.FromPointer); // 0x10 MusicMaster                 ( ModelClassType MstSong MstSong MstSong Pointer )
            value.CameraIndex                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 CameraIndex                 ( ModelPrimitiveType int int int Int32 )
            value.OnStageIdols                              = GetObjectList<UnitIdolWithMstCostume>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnitIdolWithMstCostume.FromPointer); // 0x20 OnStageIdols                ( ModelClassListType UnitIdolWithMstCostume[] UnitIdolWithMstCostume[] List<UnitIdolWithMstCostume> Pointer )
            value.IsVocalSeparatedOn                        = GetBool(new IntPtr(p + 0x028)); // 0x28 IsVocalSeparatedOn          ( ModelPrimitiveType bool bool bool Bool )
            value.BackgroundMode                            = (LiveBackgroundMode)GetInt32(new IntPtr(p + 0x02C)); // 0x2C BackgroundMode              ( ModelEnumType LiveBackgroundMode LiveBackgroundMode LiveBackgroundMode Int32 )
            value.RenderingDynamicRange                     = (RenderingDynamicRange)GetInt32(new IntPtr(p + 0x030)); // 0x30 RenderingDynamicRange       ( ModelEnumType RenderingDynamicRange RenderingDynamicRange RenderingDynamicRange Int32 )
            value.ViewStack                                 = GetObjectList<ViewValue>(new IntPtr(p + 0x038), ReversePrism.DataModels.ViewValue.FromPointer); // 0x38 ViewStack                   ( ModelClassListType ViewValue[] ViewValue[] List<ViewValue> Pointer )

            return value;
        }
    }
}
