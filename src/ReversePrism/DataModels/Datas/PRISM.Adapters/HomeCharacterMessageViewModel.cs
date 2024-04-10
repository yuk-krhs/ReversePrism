using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharaId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 ActionIndex                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 ActionIndexList                          000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 020 ActionViewModels                         000185B84620 ModelClassListType HomeCharacterActionViewModel[] HomeCharacterActionViewModel[] List<HomeCharacterActionViewModel> Pointer
    // 028 IsTargetAtionAll                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 029 IsLeaveAction                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02C LeaveActionCount                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 LeaveActionLength                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 DefaultActionLength                      0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class HomeCharacterMessageViewModel : DataModel
    {
        public int                                      CharaId                                 { get; set; }
        public int                                      ActionIndex                             { get; set; }
        public List<int>?                               ActionIndexList                         { get; set; }
        public List<HomeCharacterActionViewModel>?      ActionViewModels                        { get; set; }
        public bool                                     IsTargetAtionAll                        { get; set; }
        public bool                                     IsLeaveAction                           { get; set; }
        public int                                      LeaveActionCount                        { get; set; }
        public int                                      LeaveActionLength                       { get; set; }
        public int                                      DefaultActionLength                     { get; set; }

        public static HomeCharacterMessageViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeCharacterMessageViewModel() { Pointer= p0 };

            value.CharaId                                   = GetInt32(new IntPtr(p + 0x010)); // 0245A3664C78 0x10 CharaId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ActionIndex                               = GetInt32(new IntPtr(p + 0x014)); // 0245A3664C98 0x14 ActionIndex                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ActionIndexList                           = GetInt32List(new IntPtr(p + 0x018)); // 0245A3664CB8 0x18 ActionIndexList             ( 000185CECF28 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.ActionViewModels                          = GetObjectList<HomeCharacterActionViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.HomeCharacterActionViewModel.FromPointer); // 0245A3664CD8 0x20 ActionViewModels            ( 000185B84620 ModelClassListType HomeCharacterActionViewModel[] HomeCharacterActionViewModel[] List<HomeCharacterActionViewModel> Pointer )
            value.IsTargetAtionAll                          = GetBool(new IntPtr(p + 0x028)); // 0245A3664CF8 0x28 IsTargetAtionAll            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsLeaveAction                             = GetBool(new IntPtr(p + 0x029)); // 0245A3664D18 0x29 IsLeaveAction               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LeaveActionCount                          = GetInt32(new IntPtr(p + 0x02C)); // 0245A3664D38 0x2C LeaveActionCount            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LeaveActionLength                         = GetInt32(new IntPtr(p + 0x030)); // 0245A3664D58 0x30 LeaveActionLength           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.DefaultActionLength                       = GetInt32(new IntPtr(p + 0x034)); // 0245A3664D78 0x34 DefaultActionLength         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
