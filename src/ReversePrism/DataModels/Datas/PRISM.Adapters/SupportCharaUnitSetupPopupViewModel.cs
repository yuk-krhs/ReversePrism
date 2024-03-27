using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UnitId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 UnitName                                 000186671910 ModelPrimitiveType string string string String
    // 020 AllSupportCharacters                     000185D0D808 ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer
    // 028 InitialSupportCharacters                 000185D0D808 ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer
    // 030 SelfSupportCharacters                    000185CE93B8 ModelClassListType List`1<ISupportCharacterStatus> List`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer
    public partial class SupportCharaUnitSetupPopupViewModel
    {
        public int                                      UnitId                                  { get; set; }
        public string                                   UnitName                                { get; set; }
        public List<ISupportCharacterStatus>?           AllSupportCharacters                    { get; set; }
        public List<ISupportCharacterStatus>?           InitialSupportCharacters                { get; set; }
        public List<ISupportCharacterStatus>?           SelfSupportCharacters                   { get; set; }

        public static SupportCharaUnitSetupPopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaUnitSetupPopupViewModel();

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x010)); // 0270D60213B8 0x10 UnitId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnitName                                  = GetString(new IntPtr(p + 0x018)); // 0270D60213D8 0x18 UnitName                    ( 000186671910 ModelPrimitiveType string string string String )
            value.AllSupportCharacters                      = GetObjectList<ISupportCharacterStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0270D60213F8 0x20 AllSupportCharacters        ( 000185D0D808 ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer )
            value.InitialSupportCharacters                  = GetObjectList<ISupportCharacterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0270D6021418 0x28 InitialSupportCharacters    ( 000185D0D808 ModelClassListType IReadOnlyList`1<ISupportCharacterStatus> IReadOnlyList`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer )
            value.SelfSupportCharacters                     = GetObjectList<ISupportCharacterStatus>(new IntPtr(p + 0x030), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0270D6021438 0x30 SelfSupportCharacters       ( 000185CE93B8 ModelClassListType List`1<ISupportCharacterStatus> List`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer )

            return value;
        }
    }
}
