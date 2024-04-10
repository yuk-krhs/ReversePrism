using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AtomSources                              000185B77F30 ModelClassListType CriAtomSource[] CriAtomSource[] List<CriAtomSource> Pointer
    // 018 CueSheetNameList                         000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class MvCutSceneSoundResources : DataModel
    {
        public List<CriAtomSource>?                     AtomSources                             { get; set; }
        public List<string>?                            CueSheetNameList                        { get; set; }

        public static MvCutSceneSoundResources? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MvCutSceneSoundResources() { Pointer= p0 };

            value.AtomSources                               = GetObjectList<CriAtomSource>(new IntPtr(p + 0x010), ReversePrism.DataModels.CriAtomSource.FromPointer); // 024664E1AC00 0x10 AtomSources                 ( 000185B77F30 ModelClassListType CriAtomSource[] CriAtomSource[] List<CriAtomSource> Pointer )
            value.CueSheetNameList                          = GetStringList(new IntPtr(p + 0x018)); // 024664E1AC20 0x18 CueSheetNameList            ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
