using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 View                                     ModelClassType MissionView MissionView MissionView Pointer
    // 068 MissionModel                             ModelClassType MissionModel MissionModel MissionModel Pointer
    // 070 CurrentTabMissionGroupId                 ModelPrimitiveType int int int Int32
    // 078 Disposables                              ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 080 ResourceTagName                          ModelPrimitiveType string string string String
    public partial class MissionPresenter : DataModel
    {
        public MissionView?                             View                                    { get; set; }
        public MissionModel?                            MissionModel                            { get; set; }
        public int                                      CurrentTabMissionGroupId                { get; set; }
        public CompositeDisposable?                     Disposables                             { get; set; }
        public string                                   ResourceTagName                         { get; set; }

        public static MissionPresenter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionPresenter() { Pointer= p0 };

            value.View                                      = GetObject<MissionView>(new IntPtr(p + 0x060), ReversePrism.DataModels.MissionView.FromPointer); // 0x60 View                        ( ModelClassType MissionView MissionView MissionView Pointer )
            value.MissionModel                              = GetObject<MissionModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.MissionModel.FromPointer); // 0x68 MissionModel                ( ModelClassType MissionModel MissionModel MissionModel Pointer )
            value.CurrentTabMissionGroupId                  = GetInt32(new IntPtr(p + 0x070)); // 0x70 CurrentTabMissionGroupId    ( ModelPrimitiveType int int int Int32 )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x078), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0x78 Disposables                 ( ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ResourceTagName                           = GetString(new IntPtr(p + 0x080)); // 0x80 ResourceTagName             ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
