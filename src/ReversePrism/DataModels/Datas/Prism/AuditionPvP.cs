using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AuditionCueSuffix                        string IL2CPP_TYPE_STRING
    // 000 UnitMax                                  int IL2CPP_TYPE_I4
    // 000 fadeOutTime                              float IL2CPP_TYPE_R4
    // 020 UnitSceneData                            ModelClassListType UnitSceneData[] UnitSceneData[] List<UnitSceneData> Pointer
    // 028 PlayUnit                                 ModelPrimitiveType int int int Int32
    // 030 ScreenEffect                             ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer
    // 000 baseSceneData                            StartData IL2CPP_TYPE_CLASS
    // 038 IsInitializeEnd                          ModelPrimitiveType bool bool bool Bool
    // 03C FadeCountTime                            ModelPrimitiveType float float float Single
    // 040 IsEnd                                    ModelPrimitiveType bool bool bool Bool
    // 041 IsPause                                  ModelPrimitiveType bool bool bool Bool
    // 044 ChangeCount                              ModelPrimitiveType int int int Int32
    // 048 TimeFromUnitChange                       ModelPrimitiveType float float float Single
    // 008 isPreloadEnd                             bool IL2CPP_TYPE_BOOLEAN
    // 010 dressList                                UnitIdol[][] IL2CPP_TYPE_SZARRAY
    public partial class AuditionPvP : DataModel
    {
        public List<UnitSceneData>?                     UnitSceneData                           { get; set; }
        public int                                      PlayUnit                                { get; set; }
        public ScreenEffectEx?                          ScreenEffect                            { get; set; }
        public bool                                     IsInitializeEnd                         { get; set; }
        public float                                    FadeCountTime                           { get; set; }
        public bool                                     IsEnd                                   { get; set; }
        public bool                                     IsPause                                 { get; set; }
        public int                                      ChangeCount                             { get; set; }
        public float                                    TimeFromUnitChange                      { get; set; }

        public static AuditionPvP? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AuditionPvP() { Pointer= p0 };

            value.UnitSceneData                             = GetObjectList<UnitSceneData>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnitSceneData.FromPointer); // 0x20 UnitSceneData               ( ModelClassListType UnitSceneData[] UnitSceneData[] List<UnitSceneData> Pointer )
            value.PlayUnit                                  = GetInt32(new IntPtr(p + 0x028)); // 0x28 PlayUnit                    ( ModelPrimitiveType int int int Int32 )
            value.ScreenEffect                              = GetObject<ScreenEffectEx>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScreenEffectEx.FromPointer); // 0x30 ScreenEffect                ( ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer )
            value.IsInitializeEnd                           = GetBool(new IntPtr(p + 0x038)); // 0x38 IsInitializeEnd             ( ModelPrimitiveType bool bool bool Bool )
            value.FadeCountTime                             = GetSingle(new IntPtr(p + 0x03C)); // 0x3C FadeCountTime               ( ModelPrimitiveType float float float Single )
            value.IsEnd                                     = GetBool(new IntPtr(p + 0x040)); // 0x40 IsEnd                       ( ModelPrimitiveType bool bool bool Bool )
            value.IsPause                                   = GetBool(new IntPtr(p + 0x041)); // 0x41 IsPause                     ( ModelPrimitiveType bool bool bool Bool )
            value.ChangeCount                               = GetInt32(new IntPtr(p + 0x044)); // 0x44 ChangeCount                 ( ModelPrimitiveType int int int Int32 )
            value.TimeFromUnitChange                        = GetSingle(new IntPtr(p + 0x048)); // 0x48 TimeFromUnitChange          ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
