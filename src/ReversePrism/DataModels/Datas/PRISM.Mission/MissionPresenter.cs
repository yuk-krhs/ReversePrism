using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 View                                     00018662B3C0 ModelClassType MissionView MissionView MissionView Pointer
    // 068 MissionModel                             000186625F10 ModelClassType MissionModel MissionModel MissionModel Pointer
    // 070 CurrentTabMissionGroupId                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 078 Disposables                              0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer
    // 080 ResourceTagName                          000186671910 ModelPrimitiveType string string string String
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

            value.View                                      = GetObject<MissionView>(new IntPtr(p + 0x060), ReversePrism.DataModels.MissionView.FromPointer); // 0246655F5ED0 0x60 View                        ( 00018662B3C0 ModelClassType MissionView MissionView MissionView Pointer )
            value.MissionModel                              = GetObject<MissionModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.MissionModel.FromPointer); // 0246655F5EF0 0x68 MissionModel                ( 000186625F10 ModelClassType MissionModel MissionModel MissionModel Pointer )
            value.CurrentTabMissionGroupId                  = GetInt32(new IntPtr(p + 0x070)); // 0246655F5F10 0x70 CurrentTabMissionGroupId    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Disposables                               = GetObject<CompositeDisposable>(new IntPtr(p + 0x078), ReversePrism.DataModels.CompositeDisposable.FromPointer); // 0246655F5F30 0x78 Disposables                 ( 0001865F3230 ModelClassType CompositeDisposable CompositeDisposable CompositeDisposable Pointer )
            value.ResourceTagName                           = GetString(new IntPtr(p + 0x080)); // 0246655F5F50 0x80 ResourceTagName             ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
