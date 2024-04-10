using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SourcePIdolIcons                         000185B99FA0 ModelClassListType PIdolIcon[] PIdolIcon[] List<PIdolIcon> Pointer
    // 018 PossessionOnlyPIdolIcons                 000185B99FA0 ModelClassListType PIdolIcon[] PIdolIcon[] List<PIdolIcon> Pointer
    // 020 SourceSCharaIcons                        000185CA2738 ModelClassListType SCharaIcon[] SCharaIcon[] List<SCharaIcon> Pointer
    // 028 PossessionOnlySCharaIcons                000185CA2738 ModelClassListType SCharaIcon[] SCharaIcon[] List<SCharaIcon> Pointer
    // 030 PToggle                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 SToggle                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 034 Current                                  00018669FB50 ModelEnumType AlbumType AlbumType AlbumType Int32
    // 038 IsActive                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class AlbumViewModel : DataModel
    {
        public List<PIdolIcon>?                         SourcePIdolIcons                        { get; set; }
        public List<PIdolIcon>?                         PossessionOnlyPIdolIcons                { get; set; }
        public List<SCharaIcon>?                        SourceSCharaIcons                       { get; set; }
        public List<SCharaIcon>?                        PossessionOnlySCharaIcons               { get; set; }
        public bool                                     PToggle                                 { get; set; }
        public bool                                     SToggle                                 { get; set; }
        public AlbumType                                Current                                 { get; set; }
        public bool                                     IsActive                                { get; set; }

        public static AlbumViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AlbumViewModel() { Pointer= p0 };

            value.SourcePIdolIcons                          = GetObjectList<PIdolIcon>(new IntPtr(p + 0x010), ReversePrism.DataModels.PIdolIcon.FromPointer); // 024665EDB7C0 0x10 SourcePIdolIcons            ( 000185B99FA0 ModelClassListType PIdolIcon[] PIdolIcon[] List<PIdolIcon> Pointer )
            value.PossessionOnlyPIdolIcons                  = GetObjectList<PIdolIcon>(new IntPtr(p + 0x018), ReversePrism.DataModels.PIdolIcon.FromPointer); // 024665EDB7E0 0x18 PossessionOnlyPIdolIcons    ( 000185B99FA0 ModelClassListType PIdolIcon[] PIdolIcon[] List<PIdolIcon> Pointer )
            value.SourceSCharaIcons                         = GetObjectList<SCharaIcon>(new IntPtr(p + 0x020), ReversePrism.DataModels.SCharaIcon.FromPointer); // 024665EDB800 0x20 SourceSCharaIcons           ( 000185CA2738 ModelClassListType SCharaIcon[] SCharaIcon[] List<SCharaIcon> Pointer )
            value.PossessionOnlySCharaIcons                 = GetObjectList<SCharaIcon>(new IntPtr(p + 0x028), ReversePrism.DataModels.SCharaIcon.FromPointer); // 024665EDB820 0x28 PossessionOnlySCharaIcons   ( 000185CA2738 ModelClassListType SCharaIcon[] SCharaIcon[] List<SCharaIcon> Pointer )
            value.PToggle                                   = GetBool(new IntPtr(p + 0x030)); // 024665EDB840 0x30 PToggle                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SToggle                                   = GetBool(new IntPtr(p + 0x031)); // 024665EDB860 0x31 SToggle                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Current                                   = (AlbumType)GetInt32(new IntPtr(p + 0x034)); // 024665EDB880 0x34 Current                     ( 00018669FB50 ModelEnumType AlbumType AlbumType AlbumType Int32 )
            value.IsActive                                  = GetBool(new IntPtr(p + 0x038)); // 024665EDB8A0 0x38 IsActive                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
