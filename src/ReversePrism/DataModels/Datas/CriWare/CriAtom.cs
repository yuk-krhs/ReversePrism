using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 AcfFile                                  0001866722E0 ModelPrimitiveType string string string String
    // 038 AcfIsLoading                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 CueSheets                                000185B77D20 ModelClassListType CriAtomCueSheet[] CriAtomCueSheet[] List<CriAtomCueSheet> Pointer
    // 048 DspBusSetting                            0001866722E0 ModelPrimitiveType string string string String
    // 050 DontDestroyOnLoad                        000186595960 ModelPrimitiveType bool bool bool Bool
    // 000 eventUserCallback                        EventCallback IL2CPP_TYPE_CLASS
    // 008 eventUserCbFunc                          EventCbFunc IL2CPP_TYPE_CLASS
    // 010 BeatsyncUserCbFunc                       000186549DD0 ModelClassType CbFunc CbFunc CbFunc Pointer
    // 018 ObsoleteBeatSyncFunc                     000186549DD0 ModelClassType CbFunc CbFunc CbFunc Pointer
    // 020 CueLinkUserCbFunc                        00018653ED40 ModelClassType CueLinkCbFunc CueLinkCbFunc CueLinkCbFunc Pointer
    // 028 Instance                                 000186640EA0 ModelClassType CriAtom CriAtom CriAtom Pointer
    // 058 AcfRegisterGCHandle                      0001865D9120 ModelEnumType GCHandle GCHandle GCHandle Int32
    // 060 DontRemoveExistsCueSheet                 000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class CriAtom
    {
        public string                                   AcfFile                                 { get; set; }
        public bool                                     AcfIsLoading                            { get; set; }
        public List<CriAtomCueSheet>?                   CueSheets                               { get; set; }
        public string                                   DspBusSetting                           { get; set; }
        public bool                                     DontDestroyOnLoad                       { get; set; }
        public CbFunc?                                  BeatsyncUserCbFunc                      { get; set; }
        public CbFunc?                                  ObsoleteBeatSyncFunc                    { get; set; }
        public CueLinkCbFunc?                           CueLinkUserCbFunc                       { get; set; }
        public CriAtom?                                 Instance                                { get; set; }
        public GCHandle                                 AcfRegisterGCHandle                     { get; set; }
        public bool                                     DontRemoveExistsCueSheet                { get; set; }

        public static CriAtom? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtom();

            value.AcfFile                                   = GetString(new IntPtr(p + 0x030)); // 0270D1882348 0x30 AcfFile                     ( 0001866722E0 ModelPrimitiveType string string string String )
            value.AcfIsLoading                              = GetBool(new IntPtr(p + 0x038)); // 0270D1882368 0x38 AcfIsLoading                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CueSheets                                 = GetObjectList<CriAtomCueSheet>(new IntPtr(p + 0x040), ReversePrism.DataModels.CriAtomCueSheet.FromPointer); // 0270D1882388 0x40 CueSheets                   ( 000185B77D20 ModelClassListType CriAtomCueSheet[] CriAtomCueSheet[] List<CriAtomCueSheet> Pointer )
            value.DspBusSetting                             = GetString(new IntPtr(p + 0x048)); // 0270D18823A8 0x48 DspBusSetting               ( 0001866722E0 ModelPrimitiveType string string string String )
            value.DontDestroyOnLoad                         = GetBool(new IntPtr(p + 0x050)); // 0270D18823C8 0x50 DontDestroyOnLoad           ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.BeatsyncUserCbFunc                        = GetObject<CbFunc>(new IntPtr(p + 0x010), ReversePrism.DataModels.CbFunc.FromPointer); // 0270D1882428 0x10 BeatsyncUserCbFunc          ( 000186549DD0 ModelClassType CbFunc CbFunc CbFunc Pointer )
            value.ObsoleteBeatSyncFunc                      = GetObject<CbFunc>(new IntPtr(p + 0x018), ReversePrism.DataModels.CbFunc.FromPointer); // 0270D1882448 0x18 ObsoleteBeatSyncFunc        ( 000186549DD0 ModelClassType CbFunc CbFunc CbFunc Pointer )
            value.CueLinkUserCbFunc                         = GetObject<CueLinkCbFunc>(new IntPtr(p + 0x020), ReversePrism.DataModels.CueLinkCbFunc.FromPointer); // 0270D1882468 0x20 CueLinkUserCbFunc           ( 00018653ED40 ModelClassType CueLinkCbFunc CueLinkCbFunc CueLinkCbFunc Pointer )
            value.Instance                                  = GetObject<CriAtom>(new IntPtr(p + 0x028), ReversePrism.DataModels.CriAtom.FromPointer); // 0270D1882488 0x28 Instance                    ( 000186640EA0 ModelClassType CriAtom CriAtom CriAtom Pointer )
            value.AcfRegisterGCHandle                       = (GCHandle)GetInt32(new IntPtr(p + 0x058)); // 0270D18824A8 0x58 AcfRegisterGCHandle         ( 0001865D9120 ModelEnumType GCHandle GCHandle GCHandle Int32 )
            value.DontRemoveExistsCueSheet                  = GetBool(new IntPtr(p + 0x060)); // 0270D18824C8 0x60 DontRemoveExistsCueSheet    ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
