using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 AcfFile                                  ModelPrimitiveType string string string String
    // 038 AcfIsLoading                             ModelPrimitiveType bool bool bool Bool
    // 040 CueSheets                                ModelClassListType CriAtomCueSheet[] CriAtomCueSheet[] List<CriAtomCueSheet> Pointer
    // 048 DspBusSetting                            ModelPrimitiveType string string string String
    // 050 DontDestroyOnLoad                        ModelPrimitiveType bool bool bool Bool
    // 000 eventUserCallback                        EventCallback IL2CPP_TYPE_CLASS
    // 008 eventUserCbFunc                          EventCbFunc IL2CPP_TYPE_CLASS
    // 010 BeatsyncUserCbFunc                       ModelClassType CbFunc CbFunc CbFunc Pointer
    // 018 ObsoleteBeatSyncFunc                     ModelClassType CbFunc CbFunc CbFunc Pointer
    // 020 CueLinkUserCbFunc                        ModelClassType CueLinkCbFunc CueLinkCbFunc CueLinkCbFunc Pointer
    // 028 Instance                                 ModelClassType CriAtom CriAtom CriAtom Pointer
    // 058 AcfRegisterGCHandle                      ModelEnumType GCHandle GCHandle GCHandle Int32
    // 060 DontRemoveExistsCueSheet                 ModelPrimitiveType bool bool bool Bool
    public partial class CriAtom : DataModel
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
            var value   = new CriAtom() { Pointer= p0 };

            value.AcfFile                                   = GetString(new IntPtr(p + 0x030)); // 0x30 AcfFile                     ( ModelPrimitiveType string string string String )
            value.AcfIsLoading                              = GetBool(new IntPtr(p + 0x038)); // 0x38 AcfIsLoading                ( ModelPrimitiveType bool bool bool Bool )
            value.CueSheets                                 = GetObjectList<CriAtomCueSheet>(new IntPtr(p + 0x040), ReversePrism.DataModels.CriAtomCueSheet.FromPointer); // 0x40 CueSheets                   ( ModelClassListType CriAtomCueSheet[] CriAtomCueSheet[] List<CriAtomCueSheet> Pointer )
            value.DspBusSetting                             = GetString(new IntPtr(p + 0x048)); // 0x48 DspBusSetting               ( ModelPrimitiveType string string string String )
            value.DontDestroyOnLoad                         = GetBool(new IntPtr(p + 0x050)); // 0x50 DontDestroyOnLoad           ( ModelPrimitiveType bool bool bool Bool )
            value.BeatsyncUserCbFunc                        = GetObject<CbFunc>(new IntPtr(p + 0x010), ReversePrism.DataModels.CbFunc.FromPointer); // 0x10 BeatsyncUserCbFunc          ( ModelClassType CbFunc CbFunc CbFunc Pointer )
            value.ObsoleteBeatSyncFunc                      = GetObject<CbFunc>(new IntPtr(p + 0x018), ReversePrism.DataModels.CbFunc.FromPointer); // 0x18 ObsoleteBeatSyncFunc        ( ModelClassType CbFunc CbFunc CbFunc Pointer )
            value.CueLinkUserCbFunc                         = GetObject<CueLinkCbFunc>(new IntPtr(p + 0x020), ReversePrism.DataModels.CueLinkCbFunc.FromPointer); // 0x20 CueLinkUserCbFunc           ( ModelClassType CueLinkCbFunc CueLinkCbFunc CueLinkCbFunc Pointer )
            value.Instance                                  = GetObject<CriAtom>(new IntPtr(p + 0x028), ReversePrism.DataModels.CriAtom.FromPointer); // 0x28 Instance                    ( ModelClassType CriAtom CriAtom CriAtom Pointer )
            value.AcfRegisterGCHandle                       = (GCHandle)GetInt32(new IntPtr(p + 0x058)); // 0x58 AcfRegisterGCHandle         ( ModelEnumType GCHandle GCHandle GCHandle Int32 )
            value.DontRemoveExistsCueSheet                  = GetBool(new IntPtr(p + 0x060)); // 0x60 DontRemoveExistsCueSheet    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
