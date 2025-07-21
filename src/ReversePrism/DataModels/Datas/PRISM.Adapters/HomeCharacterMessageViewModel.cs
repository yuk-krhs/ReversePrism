using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CharaId                                  ModelPrimitiveType int int int Int32
    // 014 ActionIndex                              ModelPrimitiveType int int int Int32
    // 018 ActionIndexList                          ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 020 ActionViewModels                         ModelClassListType HomeCharacterActionViewModel[] HomeCharacterActionViewModel[] List<HomeCharacterActionViewModel> Pointer
    // 028 IsTargetAtionAll                         ModelPrimitiveType bool bool bool Bool
    // 029 IsLeaveAction                            ModelPrimitiveType bool bool bool Bool
    // 02C LeaveActionCount                         ModelPrimitiveType int int int Int32
    // 030 LeaveActionLength                        ModelPrimitiveType int int int Int32
    // 034 DefaultActionLength                      ModelPrimitiveType int int int Int32
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

            value.CharaId                                   = GetInt32(new IntPtr(p + 0x010)); // 0x10 CharaId                     ( ModelPrimitiveType int int int Int32 )
            value.ActionIndex                               = GetInt32(new IntPtr(p + 0x014)); // 0x14 ActionIndex                 ( ModelPrimitiveType int int int Int32 )
            value.ActionIndexList                           = GetInt32List(new IntPtr(p + 0x018)); // 0x18 ActionIndexList             ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.ActionViewModels                          = GetObjectList<HomeCharacterActionViewModel>(new IntPtr(p + 0x020), ReversePrism.DataModels.HomeCharacterActionViewModel.FromPointer); // 0x20 ActionViewModels            ( ModelClassListType HomeCharacterActionViewModel[] HomeCharacterActionViewModel[] List<HomeCharacterActionViewModel> Pointer )
            value.IsTargetAtionAll                          = GetBool(new IntPtr(p + 0x028)); // 0x28 IsTargetAtionAll            ( ModelPrimitiveType bool bool bool Bool )
            value.IsLeaveAction                             = GetBool(new IntPtr(p + 0x029)); // 0x29 IsLeaveAction               ( ModelPrimitiveType bool bool bool Bool )
            value.LeaveActionCount                          = GetInt32(new IntPtr(p + 0x02C)); // 0x2C LeaveActionCount            ( ModelPrimitiveType int int int Int32 )
            value.LeaveActionLength                         = GetInt32(new IntPtr(p + 0x030)); // 0x30 LeaveActionLength           ( ModelPrimitiveType int int int Int32 )
            value.DefaultActionLength                       = GetInt32(new IntPtr(p + 0x034)); // 0x34 DefaultActionLength         ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
