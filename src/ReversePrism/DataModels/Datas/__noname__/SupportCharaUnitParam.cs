using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 UnitId                                   ModelPrimitiveType int int int Int32
    // 098 UnitName                                 ModelPrimitiveType string string string String
    // 0A0 PIdolIconDataList                        ModelClassListType List`1<PIdolIcon> List`1<PIdolIcon> List<PIdolIcon> Pointer
    // 0A8 SCharaIconDataList                       ModelClassListType List`1<SCharaIcon> List`1<SCharaIcon> List<SCharaIcon> Pointer
    // 0B0 AllSCharaIconList                        ModelClassListType List`1<SCharaIcon> List`1<SCharaIcon> List<SCharaIcon> Pointer
    // 0B8 AllSCharaList                            ModelClassListType List`1<ISupportCharacterStatus> List`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer
    // 0C0 IsWithoutFriend                          ModelPrimitiveType bool bool bool Bool
    // 0C1 IsProduce                                ModelPrimitiveType bool bool bool Bool
    public partial class SupportCharaUnitParam : DataModel
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
            var value   = new SupportCharaUnitParam() { Pointer= p0 };

            value.UnitId                                    = GetInt32(new IntPtr(p + 0x090)); // 0x90 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.UnitName                                  = GetString(new IntPtr(p + 0x098)); // 0x98 UnitName                    ( ModelPrimitiveType string string string String )
            value.PIdolIconDataList                         = GetObjectList<PIdolIcon>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.PIdolIcon.FromPointer); // 0xA0 PIdolIconDataList           ( ModelClassListType List`1<PIdolIcon> List`1<PIdolIcon> List<PIdolIcon> Pointer )
            value.SCharaIconDataList                        = GetObjectList<SCharaIcon>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.SCharaIcon.FromPointer); // 0xA8 SCharaIconDataList          ( ModelClassListType List`1<SCharaIcon> List`1<SCharaIcon> List<SCharaIcon> Pointer )
            value.AllSCharaIconList                         = GetObjectList<SCharaIcon>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.SCharaIcon.FromPointer); // 0xB0 AllSCharaIconList           ( ModelClassListType List`1<SCharaIcon> List`1<SCharaIcon> List<SCharaIcon> Pointer )
            value.AllSCharaList                             = GetObjectList<ISupportCharacterStatus>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.ISupportCharacterStatus.FromPointer); // 0xB8 AllSCharaList               ( ModelClassListType List`1<ISupportCharacterStatus> List`1<ISupportCharacterStatus> List<ISupportCharacterStatus> Pointer )
            value.IsWithoutFriend                           = GetBool(new IntPtr(p + 0x0C0)); // 0xC0 IsWithoutFriend             ( ModelPrimitiveType bool bool bool Bool )
            value.IsProduce                                 = GetBool(new IntPtr(p + 0x0C1)); // 0xC1 IsProduce                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
