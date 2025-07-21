using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_NudgeJobs                              NativePagedList`1<NudgeJobData> IL2CPP_TYPE_GENERICINST
    // 018 m_ConvertMeshJobs                        NativePagedList`1<ConvertMeshJobData> IL2CPP_TYPE_GENERICINST
    // 020 m_CopyClosingMeshJobs                    NativePagedList`1<CopyClosingMeshJobData> IL2CPP_TYPE_GENERICINST
    // 028 M_JobMerger                              ModelClassType JobMerger JobMerger JobMerger Pointer
    // 030 Disposed                                 ModelPrimitiveType bool bool bool Bool
    public partial class JobManager : DataModel
    {
        public JobMerger?                               M_JobMerger                             { get; set; }
        public bool                                     Disposed                                { get; set; }

        public static JobManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JobManager() { Pointer= p0 };

            value.M_JobMerger                               = GetObject<JobMerger>(new IntPtr(p + 0x028), ReversePrism.DataModels.JobMerger.FromPointer); // 0x28 M_JobMerger                 ( ModelClassType JobMerger JobMerger JobMerger Pointer )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x030)); // 0x30 Disposed                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
