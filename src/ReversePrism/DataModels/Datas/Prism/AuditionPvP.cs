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
    // 020 UnitSceneData                            000185CB6A98 ModelClassListType UnitSceneData[] UnitSceneData[] List<UnitSceneData> Pointer
    // 028 PlayUnit                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 ScreenEffect                             0001866F24C0 ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer
    // 000 baseSceneData                            StartData IL2CPP_TYPE_CLASS
    // 038 IsInitializeEnd                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03C FadeCountTime                            0001866656B0 ModelPrimitiveType float float float Single
    // 040 IsEnd                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 041 IsPause                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 044 ChangeCount                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 048 TimeFromUnitChange                       0001866656B0 ModelPrimitiveType float float float Single
    // 008 isPreloadEnd                             bool IL2CPP_TYPE_BOOLEAN
    // 010 dressList                                UnitIdol[][] IL2CPP_TYPE_SZARRAY
    public partial class AuditionPvP
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
            var value   = new AuditionPvP();

            value.UnitSceneData                             = GetObjectList<UnitSceneData>(new IntPtr(p + 0x020), ReversePrism.DataModels.UnitSceneData.FromPointer); // 0270D4D9BB78 0x20 UnitSceneData               ( 000185CB6A98 ModelClassListType UnitSceneData[] UnitSceneData[] List<UnitSceneData> Pointer )
            value.PlayUnit                                  = GetInt32(new IntPtr(p + 0x028)); // 0270D4D9BB98 0x28 PlayUnit                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ScreenEffect                              = GetObject<ScreenEffectEx>(new IntPtr(p + 0x030), ReversePrism.DataModels.ScreenEffectEx.FromPointer); // 0270D4D9BBB8 0x30 ScreenEffect                ( 0001866F24C0 ModelClassType ScreenEffectEx ScreenEffectEx ScreenEffectEx Pointer )
            value.IsInitializeEnd                           = GetBool(new IntPtr(p + 0x038)); // 0270D4D9BBF8 0x38 IsInitializeEnd             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FadeCountTime                             = GetSingle(new IntPtr(p + 0x03C)); // 0270D4D9BC18 0x3C FadeCountTime               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsEnd                                     = GetBool(new IntPtr(p + 0x040)); // 0270D4D9BC38 0x40 IsEnd                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsPause                                   = GetBool(new IntPtr(p + 0x041)); // 0270D4D9BC58 0x41 IsPause                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ChangeCount                               = GetInt32(new IntPtr(p + 0x044)); // 0270D4D9BC78 0x44 ChangeCount                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TimeFromUnitChange                        = GetSingle(new IntPtr(p + 0x048)); // 0270D4D9BC98 0x48 TimeFromUnitChange          ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
