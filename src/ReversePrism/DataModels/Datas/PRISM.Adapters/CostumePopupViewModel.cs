using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CostumeSetList                           000185B81080 ModelClassListType GalleryCostumeSetViewModel[] GalleryCostumeSetViewModel[] List<GalleryCostumeSetViewModel> Pointer
    // 018 DressList                                000185B812C0 ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer
    // 020 HairStyleList                            000185B812C0 ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer
    // 028 GlassList                                000185B812C0 ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer
    // 030 EarringList                              000185B812C0 ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer
    // 038 MakeUpList                               000185B812C0 ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer
    // 040 CasualCostumeSetList                     000185B81080 ModelClassListType GalleryCostumeSetViewModel[] GalleryCostumeSetViewModel[] List<GalleryCostumeSetViewModel> Pointer
    // 048 CasualDressList                          000185B812C0 ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer
    // 050 CasualHairStyleList                      000185B812C0 ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer
    // 058 CasualGlassList                          000185B812C0 ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer
    // 060 CasualEarringList                        000185B812C0 ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer
    // 068 CasualMakeUpList                         000185B812C0 ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer
    // 070 possessionCount                          <Array> IL2CPP_TYPE_ARRAY
    // 078 casualPossessionCount                    <Array> IL2CPP_TYPE_ARRAY
    // 080 IsActive                                 0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 081 IsSet                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 082 IsCasual                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 084 PartsType                                0001866079A0 ModelEnumType PartsType PartsType PartsType Int32
    public partial class CostumePopupViewModel : DataModel
    {
        public List<GalleryCostumeSetViewModel>?        CostumeSetList                          { get; set; }
        public List<GalleryCostumeViewModel>?           DressList                               { get; set; }
        public List<GalleryCostumeViewModel>?           HairStyleList                           { get; set; }
        public List<GalleryCostumeViewModel>?           GlassList                               { get; set; }
        public List<GalleryCostumeViewModel>?           EarringList                             { get; set; }
        public List<GalleryCostumeViewModel>?           MakeUpList                              { get; set; }
        public List<GalleryCostumeSetViewModel>?        CasualCostumeSetList                    { get; set; }
        public List<GalleryCostumeViewModel>?           CasualDressList                         { get; set; }
        public List<GalleryCostumeViewModel>?           CasualHairStyleList                     { get; set; }
        public List<GalleryCostumeViewModel>?           CasualGlassList                         { get; set; }
        public List<GalleryCostumeViewModel>?           CasualEarringList                       { get; set; }
        public List<GalleryCostumeViewModel>?           CasualMakeUpList                        { get; set; }
        public bool                                     IsActive                                { get; set; }
        public bool                                     IsSet                                   { get; set; }
        public bool                                     IsCasual                                { get; set; }
        public PartsType                                PartsType                               { get; set; }

        public static CostumePopupViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumePopupViewModel() { Pointer= p0 };

            value.CostumeSetList                            = GetObjectList<GalleryCostumeSetViewModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.GalleryCostumeSetViewModel.FromPointer); // 024665EE1608 0x10 CostumeSetList              ( 000185B81080 ModelClassListType GalleryCostumeSetViewModel[] GalleryCostumeSetViewModel[] List<GalleryCostumeSetViewModel> Pointer )
            value.DressList                                 = GetObjectList<GalleryCostumeViewModel>(new IntPtr(p + 0x018), ReversePrism.DataModels.GalleryCostumeViewModel.FromPointer); // 024665EE1628 0x18 DressList                   ( 000185B812C0 ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer )
            value.HairStyleList                             = GetObjectList<GalleryCostumeViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.GalleryCostumeViewModel.FromPointer); // 024665EE1648 0x20 HairStyleList               ( 000185B812C0 ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer )
            value.GlassList                                 = GetObjectList<GalleryCostumeViewModel>(new IntPtr(p + 0x028), ReversePrism.DataModels.GalleryCostumeViewModel.FromPointer); // 024665EE1668 0x28 GlassList                   ( 000185B812C0 ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer )
            value.EarringList                               = GetObjectList<GalleryCostumeViewModel>(new IntPtr(p + 0x030), ReversePrism.DataModels.GalleryCostumeViewModel.FromPointer); // 024665EE1688 0x30 EarringList                 ( 000185B812C0 ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer )
            value.MakeUpList                                = GetObjectList<GalleryCostumeViewModel>(new IntPtr(p + 0x038), ReversePrism.DataModels.GalleryCostumeViewModel.FromPointer); // 024665EE16A8 0x38 MakeUpList                  ( 000185B812C0 ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer )
            value.CasualCostumeSetList                      = GetObjectList<GalleryCostumeSetViewModel>(new IntPtr(p + 0x040), ReversePrism.DataModels.GalleryCostumeSetViewModel.FromPointer); // 024665EE16C8 0x40 CasualCostumeSetList        ( 000185B81080 ModelClassListType GalleryCostumeSetViewModel[] GalleryCostumeSetViewModel[] List<GalleryCostumeSetViewModel> Pointer )
            value.CasualDressList                           = GetObjectList<GalleryCostumeViewModel>(new IntPtr(p + 0x048), ReversePrism.DataModels.GalleryCostumeViewModel.FromPointer); // 024665EE16E8 0x48 CasualDressList             ( 000185B812C0 ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer )
            value.CasualHairStyleList                       = GetObjectList<GalleryCostumeViewModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.GalleryCostumeViewModel.FromPointer); // 024665EE1708 0x50 CasualHairStyleList         ( 000185B812C0 ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer )
            value.CasualGlassList                           = GetObjectList<GalleryCostumeViewModel>(new IntPtr(p + 0x058), ReversePrism.DataModels.GalleryCostumeViewModel.FromPointer); // 024665EE1728 0x58 CasualGlassList             ( 000185B812C0 ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer )
            value.CasualEarringList                         = GetObjectList<GalleryCostumeViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.GalleryCostumeViewModel.FromPointer); // 024665EE1748 0x60 CasualEarringList           ( 000185B812C0 ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer )
            value.CasualMakeUpList                          = GetObjectList<GalleryCostumeViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.GalleryCostumeViewModel.FromPointer); // 024665EE1768 0x68 CasualMakeUpList            ( 000185B812C0 ModelClassListType GalleryCostumeViewModel[] GalleryCostumeViewModel[] List<GalleryCostumeViewModel> Pointer )
            value.IsActive                                  = GetBool(new IntPtr(p + 0x080)); // 024665EE17C8 0x80 IsActive                    ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsSet                                     = GetBool(new IntPtr(p + 0x081)); // 024665EE17E8 0x81 IsSet                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsCasual                                  = GetBool(new IntPtr(p + 0x082)); // 024665EE1808 0x82 IsCasual                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PartsType                                 = (PartsType)GetInt32(new IntPtr(p + 0x084)); // 024665EE1828 0x84 PartsType                   ( 0001866079A0 ModelEnumType PartsType PartsType PartsType Int32 )

            return value;
        }
    }
}
