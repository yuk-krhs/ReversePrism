using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NoticePrefab                             0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 000 <Instance>k__BackingField                MissionNoticeSystem IL2CPP_TYPE_CLASS
    // 028 NoticeViewList                           000185CF3C08 ModelClassListType List`1<MissionNoticePresenter> List`1<MissionNoticePresenter> List<MissionNoticePresenter> Pointer
    // 030 WaitMissionInfoList                      000185D26DF8 ModelClassListType List`1<MissionNoticeInfo> List`1<MissionNoticeInfo> List<MissionNoticeInfo> Pointer
    // 038 ViewNoticeMax                            0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class MissionNoticeSystem : DataModel
    {
        public GameObject?                              NoticePrefab                            { get; set; }
        public List<MissionNoticePresenter>?            NoticeViewList                          { get; set; }
        public List<MissionNoticeInfo>?                 WaitMissionInfoList                     { get; set; }
        public int                                      ViewNoticeMax                           { get; set; }

        public static MissionNoticeSystem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionNoticeSystem() { Pointer= p0 };

            value.NoticePrefab                              = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 024660A59A90 0x20 NoticePrefab                ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.NoticeViewList                            = GetObjectList<MissionNoticePresenter>(new IntPtr(p + 0x028), ReversePrism.DataModels.MissionNoticePresenter.FromPointer); // 024660A59AD0 0x28 NoticeViewList              ( 000185CF3C08 ModelClassListType List`1<MissionNoticePresenter> List`1<MissionNoticePresenter> List<MissionNoticePresenter> Pointer )
            value.WaitMissionInfoList                       = GetObjectList<MissionNoticeInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.MissionNoticeInfo.FromPointer); // 024660A59AF0 0x30 WaitMissionInfoList         ( 000185D26DF8 ModelClassListType List`1<MissionNoticeInfo> List`1<MissionNoticeInfo> List<MissionNoticeInfo> Pointer )
            value.ViewNoticeMax                             = GetInt32(new IntPtr(p + 0x038)); // 024660A59B10 0x38 ViewNoticeMax               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
