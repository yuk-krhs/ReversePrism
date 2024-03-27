using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 UnitId                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 098 UnitName                                 0001866722E0 ModelPrimitiveType string string string String
    // 0A0 PIdolIconDataList                        000185CF7868 ModelClassListType List`1<PIdolIcon> List`1<PIdolIcon> List<PIdolIcon> Pointer
    // 0A8 SCharaIconDataList                       000185D05978 ModelClassListType List`1<SCharaIcon> List`1<SCharaIcon> List<SCharaIcon> Pointer
    // 0B0 AllSCharaIconList                        000185D05978 ModelClassListType List`1<SCharaIcon> List`1<SCharaIcon> List<SCharaIcon> Pointer
    // 0B8 AllSCharaList                            000185CE9438 ModelClassListType List`1<ISupportCharacterStatus> List`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer
    // 0C0 IsWithoutFriend                          000186595960 ModelPrimitiveType bool bool bool Bool
    // 0C1 IsProduce                                000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class SupportCharaUnitParam
    {
        public int                                      UnitId                                  { get; set; }
        public string                                   UnitName                                { get; set; }
        public List<PIdolIcon>?                         PIdolIconDataList                       { get; set; }
        public List<SCharaIcon>?                        SCharaIconDataList                      { get; set; }
        public List<SCharaIcon>?                        AllSCharaIconList                       { get; set; }
        public List<ISupportCharacterStatus>?           AllSCharaList                           { get; set; }
        public bool                                     IsWithoutFriend                         { get; set; }
        public bool                                     IsProduce                               { get; set; }

        public static SupportCharaUnitParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaUnitParam();

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x090)); // 0270D543F800 0x90 UnitId                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.UnitName                                  = GetString(new IntPtr(p + 0x098)); // 0270D543F820 0x98 UnitName                    ( 0001866722E0 ModelPrimitiveType string string string String )
            value.PIdolIconDataList                         = GetObjectList<PIdolIcon>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.PIdolIcon.FromPointer); // 0270D543F840 0xA0 PIdolIconDataList           ( 000185CF7868 ModelClassListType List`1<PIdolIcon> List`1<PIdolIcon> List<PIdolIcon> Pointer )
            value.SCharaIconDataList                        = GetObjectList<SCharaIcon>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.SCharaIcon.FromPointer); // 0270D543F860 0xA8 SCharaIconDataList          ( 000185D05978 ModelClassListType List`1<SCharaIcon> List`1<SCharaIcon> List<SCharaIcon> Pointer )
            value.AllSCharaIconList                         = GetObjectList<SCharaIcon>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.SCharaIcon.FromPointer); // 0270D543F880 0xB0 AllSCharaIconList           ( 000185D05978 ModelClassListType List`1<SCharaIcon> List`1<SCharaIcon> List<SCharaIcon> Pointer )
            value.AllSCharaList                             = GetObjectList<ISupportCharacterStatus>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0270D543F8A0 0xB8 AllSCharaList               ( 000185CE9438 ModelClassListType List`1<ISupportCharacterStatus> List`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer )
            value.IsWithoutFriend                           = GetBool(new IntPtr(p + 0x0C0)); // 0270D543F8C0 0xC0 IsWithoutFriend             ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsProduce                                 = GetBool(new IntPtr(p + 0x0C1)); // 0270D543F8E0 0xC1 IsProduce                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
